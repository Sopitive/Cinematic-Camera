using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Camera.CameraEasing;

namespace Camera
{
    public partial class CameraForm
    {
        private float LerpAngle(float a, float b, float t)
        {
            float delta = Math.Abs(b - a);
            if (delta > Math.PI)
            {
                if (b > a)
                    a += 2 * (float)Math.PI;
                else
                    b += 2 * (float)Math.PI;
            }
            return a + (b - a) * t;
        }

        private float lastYaw = 0.0f;
        private float lastPitch = 0.0f;
        private float smoothingFactor = 0.5f;

        private Vector3 targetPosition;

        public async Task MoveCameraAsync()
        {
            float UserTargetFPS;
            float TargetFPS;
            string inputText = targetFPS.Text;

            // Try to parse the input text to a float using float.TryParse.
            if (float.TryParse(inputText, out UserTargetFPS))
            {
                Console.WriteLine("Target FPS: " + UserTargetFPS);
            }
            else
            {
                UserTargetFPS = 60.0f;
                targetFPS.Text = "60";
                enablePathing.Checked = false;
                return;
            }

            TargetFPS = UserTargetFPS;
            float TargetFrameTime = 1.0f / TargetFPS;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            float t = 0.0f;
            float keyPointTime = float.Parse(pathDuration.Text);

            int numKeyPoints = keyPoints.Count;

            while (t < 1.0f) // Exit the loop when t reaches 1.0
            {
                if (enablePathing.Checked == false) return;

                float deltaTime = (float)stopwatch.Elapsed.TotalSeconds;
                stopwatch.Restart();

                // Calculate movement speed based on keyPointTime
                float movementSpeed = 1.0f / keyPointTime;

                t += deltaTime * movementSpeed;

                if (t > 1.0f)
                {
                    if (keyFrameListLoop.Checked == true)
                    {
                        t = t - (int)t;
                    }
                }

                int startIndex = (int)Math.Floor(t * (numKeyPoints - 1));
                float tInSection = (t * (numKeyPoints - 1)) - startIndex;

                int p0Index = Math.Max(startIndex - 1, 0);
                int p1Index = startIndex;
                int p2Index = Math.Min(startIndex + 1, numKeyPoints - 1);
                int p3Index = Math.Min(startIndex + 2, numKeyPoints - 1);

                Vector3 p0 = new Vector3(keyPoints[p0Index].Item1, keyPoints[p0Index].Item2, keyPoints[p0Index].Item3);
                Vector3 p1 = new Vector3(keyPoints[p1Index].Item1, keyPoints[p1Index].Item2, keyPoints[p1Index].Item3);
                Vector3 p2 = new Vector3(keyPoints[p2Index].Item1, keyPoints[p2Index].Item2, keyPoints[p2Index].Item3);
                Vector3 p3 = new Vector3(keyPoints[p3Index].Item1, keyPoints[p3Index].Item2, keyPoints[p3Index].Item3);

                Vector3 interpolatedPoint = Easing.CatmullRom(p0, p1, p2, p3, tInSection);

                memory.WriteMemory(xPos, "float", $"{interpolatedPoint.X}");
                memory.WriteMemory(yPos, "float", $"{interpolatedPoint.Y}");
                memory.WriteMemory(zPos, "float", $"{interpolatedPoint.Z}");

                if (enableLookTarget.Checked == true)
                {
                    // Read the current camera position from memory
                    float cameraPosX = memory.ReadFloat(xPos);
                    float cameraPosY = memory.ReadFloat(yPos);
                    float cameraPosZ = memory.ReadFloat(zPos);

                    // Assuming targetPosition is correctly set when setTarget is clicked
                    Vector3 cameraPosition = new Vector3(cameraPosX, cameraPosY, cameraPosZ);

                    // Calculate the direction vector from the camera position to the target position
                    Vector3 direction = targetPosition - cameraPosition;

                    // Calculate the yaw angle
                    float currentYaw = (float)Math.Atan2(direction.Y, direction.X);
                    float interpolatedYaw = LerpAngle(lastYaw, currentYaw, smoothingFactor); // Adjust smoothingFactor as needed
                    lastYaw = interpolatedYaw;

                    // Calculate the pitch angle
                    float currentPitch = (float)Math.Atan2(direction.Z, direction.Length());
                    float interpolatedPitch = LerpAngle(lastPitch, currentPitch, smoothingFactor); // Adjust smoothingFactor as needed
                    lastPitch = interpolatedPitch;

                    // Does roll just because
                    float interpolatedRoll = Easing.CatmullRomAngle(keyPoints[p0Index].Item6, keyPoints[p1Index].Item6, keyPoints[p2Index].Item6, keyPoints[p3Index].Item6, tInSection);

                    // Ensure angle values are within the appropriate range (0 to 2π)
                    interpolatedYaw %= 2 * (float)Math.PI;
                    interpolatedPitch %= 2 * (float)Math.PI;
                    interpolatedRoll %= 2 * (float)Math.PI;

                    // Write the calculated yaw and pitch angles to memory with increased precision
                    memory.WriteMemory(yawAng, "float", interpolatedYaw.ToString("0.00000")); // Adjust the number of decimal places as needed
                    memory.WriteMemory(pitchAng, "float", interpolatedPitch.ToString("0.00000")); // Adjust the number of decimal places as needed
                    memory.WriteMemory(rollAng, "float", interpolatedRoll.ToString("0.00000")); // Adjust the number of decimal places as needed

                }
                else if (enableLookTarget.Checked == false)
                {
                    // Calculate the look angles using your existing code
                    float interpolatedYaw = Easing.CatmullRomAngle(keyPoints[p0Index].Item4, keyPoints[p1Index].Item4, keyPoints[p2Index].Item4, keyPoints[p3Index].Item4, tInSection);
                    float interpolatedPitch = Easing.CatmullRomAngle(keyPoints[p0Index].Item5, keyPoints[p1Index].Item5, keyPoints[p2Index].Item5, keyPoints[p3Index].Item5, tInSection);
                    float interpolatedRoll = Easing.CatmullRomAngle(keyPoints[p0Index].Item6, keyPoints[p1Index].Item6, keyPoints[p2Index].Item6, keyPoints[p3Index].Item6, tInSection);

                    // Ensure angle values are within the appropriate range (0 to 2π)
                    interpolatedYaw %= 2 * (float)Math.PI;
                    interpolatedPitch %= 2 * (float)Math.PI;
                    interpolatedRoll %= 2 * (float)Math.PI;

                    // Write interpolated angles to memory
                    memory.WriteMemory(yawAng, "float", $"{interpolatedYaw}");
                    memory.WriteMemory(pitchAng, "float", $"{interpolatedPitch}");
                    memory.WriteMemory(rollAng, "float", $"{interpolatedRoll}");
                }

                float interpolatedFOV = Easing.CatmullRomFOV(keyPoints[p0Index].Item7, keyPoints[p1Index].Item7, keyPoints[p2Index].Item7, keyPoints[p3Index].Item7, tInSection);

                Console.WriteLine($"Progress {t}");
                string result = (t * 100).ToString("F2") + "%";
                keyProgress.Text = result.ToString();

                memory.WriteMemory(playerFov, "float", $"{interpolatedFOV}"); // Write FOV value

                int delayMilliseconds = (int)((TargetFrameTime - deltaTime) * 1000);
                if (delayMilliseconds > 0)
                {
                    await Task.Delay(delayMilliseconds);
                }
            }

            if (keyFrameListLoop.Checked == false)
            {
                enablePathing.Checked = false;
                keyProgress.Text = "0.00%";
            }
        }

        private void setTarget_Click(object sender, EventArgs e)
        {
            // Read the current camera position from memory
            float cameraPosX = memory.ReadFloat(xPos);
            float cameraPosY = memory.ReadFloat(yPos);
            float cameraPosZ = memory.ReadFloat(zPos);

            // Set targetPosition using the obtained values
            targetPosition = new Vector3(cameraPosX, cameraPosY, cameraPosZ);

            targetTextbox.Text = targetPosition.ToString();
            Console.WriteLine(targetPosition.ToString());
        }

        private void GotoSelectedKeypoint()
        {
            if (keyframeDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = keyframeDataGridView.SelectedRows[0];
                int rowIndex = selectedRow.Index;

                if (rowIndex >= 0 && rowIndex < keyPoints.Count) // Ensure the selected row index is valid
                {
                    var selectedKeypoint = keyPoints[rowIndex]; // Get the keypoint corresponding to the selected row

                    // Write the selected keypoint's values to memory
                    memory.WriteMemory(xPos, "float", $"{selectedKeypoint.Item1}");
                    memory.WriteMemory(yPos, "float", $"{selectedKeypoint.Item2}");
                    memory.WriteMemory(zPos, "float", $"{selectedKeypoint.Item3}");
                    memory.WriteMemory(yawAng, "float", $"{selectedKeypoint.Item4}");
                    memory.WriteMemory(pitchAng, "float", $"{selectedKeypoint.Item5}");
                    memory.WriteMemory(rollAng, "float", $"{selectedKeypoint.Item6}");
                    memory.WriteMemory(playerFov, "float", $"{selectedKeypoint.Item7}");

                    Console.WriteLine($"Teleported to keypoint: {selectedKeypoint.Item1}, {selectedKeypoint.Item2}, {selectedKeypoint.Item3}, {selectedKeypoint.Item4}, {selectedKeypoint.Item5}, {selectedKeypoint.Item6}, {selectedKeypoint.Item7} ");
                }
            }
        }

        private async Task Data()
        {
            fovTextbox.Text = memory.ReadFloat(playerFov).ToString();
            rollAngle.Text = memory.ReadFloat(rollAng).ToString();
            quickAccessSpeed.Text = memory.ReadFloat(speedCamera).ToString();

            for (; ; )
            {
                cameraX.Text = memory.ReadFloat(xPos).ToString();
                cameraY.Text = memory.ReadFloat(yPos).ToString();
                cameraZ.Text = memory.ReadFloat(zPos).ToString();

                cameraYaw.Text = memory.ReadFloat(yawAng).ToString();
                cameraPitch.Text = memory.ReadFloat(pitchAng).ToString();
                cameraRoll.Text = memory.ReadFloat(rollAng).ToString();

                cameraSpeed.Text = memory.ReadFloat(speedCamera).ToString();

                fovStatus.Text = memory.ReadFloat(playerFov).ToString();

                await Task.Delay(1);
            }
        }

        private void increaseRoll()
        {
            float initalFloat = memory.ReadFloat(rollAng);
            float decFloat = initalFloat + 0.1f;

            memory.WriteMemory(rollAng, "float", decFloat.ToString());
        }

        private void decreaseRoll()
        {
            float initalFloat = memory.ReadFloat(rollAng);
            float decFloat = initalFloat - 0.1f;

            memory.WriteMemory(rollAng, "float", decFloat.ToString());
        }

        private void increaseFOV()
        {
            float initalFloat = memory.ReadFloat(playerFov);
            float decFloat = initalFloat + 0.1f;

            if (decFloat >= 150.0f) return;

            memory.WriteMemory(playerFov, "float", decFloat.ToString());
        }

        private void decreaseFOV()
        {
            float initalFloat = memory.ReadFloat(playerFov);
            float decFloat = initalFloat - 0.1f;

            if (decFloat <= 1.0f) return;

            memory.WriteMemory(playerFov, "float", decFloat.ToString());
        }
    }

    public class Keypoint
    {
        public float XPos { get; set; }
        public float YPos { get; set; }
        public float ZPos { get; set; }
        public float YawAng { get; set; }
        public float PitchAng { get; set; }
        public float RollAng { get; set; }
        public float PlayerFov { get; set; }
    }
}