using System;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using static Camera.CameraEasing;

namespace Camera
{
    public partial class CameraForm
    {
        public async Task MoveCameraAsync()
        {
            const float TargetFPS = 60.0f;
            const float TargetFrameTime = 1.0f / TargetFPS;

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

                float interpolatedFOV = Easing.CatmullRomFOV(keyPoints[p0Index].Item7, keyPoints[p1Index].Item7, keyPoints[p2Index].Item7, keyPoints[p3Index].Item7, tInSection);

                Console.WriteLine($"Progress {t}, Point = ({interpolatedPoint.X}, {interpolatedPoint.Y}, {interpolatedPoint.Z})");
                Console.WriteLine($"Progress {t}, View angle = ({interpolatedYaw}, {interpolatedPitch}, {interpolatedRoll}), Progress {t}, Fov = ({interpolatedFOV})");

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


        private async Task Data()
        {
            fovTextbox.Text = memory.ReadFloat(playerFov).ToString();
            fovVehiTextbox.Text = memory.ReadFloat(vehicleFov).ToString();
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
}
