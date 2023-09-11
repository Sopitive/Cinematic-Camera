using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camera
{
    public partial class CameraForm
    {
        private List<(float, float, float, float, float, float, float)> keyPoints = new List<(float, float, float, float, float, float, float)> { };

        public void createKeyframe()
        {
            try
            {
                // Retrieve the current XYZ position from memory
                float x = memory.ReadFloat(xPos);
                float y = memory.ReadFloat(yPos);
                float z = memory.ReadFloat(zPos);

                // Retrieve the current yaw, pitch, and roll angles from memory
                float yaw = memory.ReadFloat(yawAng);
                float pitch = memory.ReadFloat(pitchAng);
                float roll = memory.ReadFloat(rollAng);

                // Retrieve the current FOV from memory
                float fov = memory.ReadFloat(playerFov);

                keyPoints.Add((x, y, z, yaw, pitch, roll, fov));

                keyframeDataGridView.Rows.Add(x, y, z, yaw, pitch, roll, fov);

                Console.WriteLine($"Created a keyframe at: {x}, {y}, {z}, {yaw}, {pitch}, {roll}, {fov}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving keypoint: " + ex.Message);
            }
        }

        private void ImportKeyPoints(string filePath)
        {
            try
            {
                string json = File.ReadAllText(filePath);
                List<(float, float, float, float, float, float, float)> importedKeyPoints = JsonConvert.DeserializeObject<List<(float, float, float, float, float, float, float)>>(json);

                // Clear existing keyPoints and add the imported keyPoints
                keyPoints.Clear();
                keyPoints.AddRange(importedKeyPoints);

                UpdateDataGridView(); // Refresh DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error importing key points: " + ex.Message);
            }
        }

        private void ExportKeyPoints(string filePath)
        {
            try
            {
                string json = JsonConvert.SerializeObject(keyPoints, Formatting.Indented);
                File.WriteAllText(filePath, json);

                MessageBox.Show("Key points exported successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting key points: " + ex.Message);
            }
        }

        private void importPathButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ImportKeyPoints(openFileDialog.FileName);
                }
            }
        }

        private void exportPathButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportKeyPoints(saveFileDialog.FileName);
                }
            }
        }
    }

    public class Keyframe
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float Yaw { get; set; }
        public float Pitch { get; set; }
        public float Roll { get; set; }
        public float FOV { get; set; }
    }
}
