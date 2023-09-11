using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camera
{
    public partial class CameraForm
    {
        private void InitializeDataGridView()
        {
            // Set DataGridView properties
            keyframeDataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            keyframeDataGridView.AllowUserToResizeColumns = false; // Disable column resizing
            keyframeDataGridView.AllowUserToResizeRows = false;    // Disable row resizing
            keyframeDataGridView.AllowUserToOrderColumns = false; // Disable column sorting

            // Add columns to the DataGridView
            keyframeDataGridView.Columns.Add("X", "X");
            keyframeDataGridView.Columns.Add("Y", "Y");
            keyframeDataGridView.Columns.Add("Z", "Z");
            keyframeDataGridView.Columns.Add("Yaw", "Yaw");
            keyframeDataGridView.Columns.Add("Pitch", "Pitch");
            keyframeDataGridView.Columns.Add("Roll", "Roll");
            keyframeDataGridView.Columns.Add("FOV", "FOV"); // Add FOV column

            // Subscribe to the CellEndEdit event
            keyframeDataGridView.CellEndEdit += keyframeDataGridView_CellEndEdit;

            foreach (var keypoint in keyPoints)
            {
                keyframeDataGridView.Rows.Add(keypoint.Item1, keypoint.Item2, keypoint.Item3, keypoint.Item4, keypoint.Item5, keypoint.Item6, keypoint.Item7);
            }
        }

        private void RemoveSelectedKeypoint()
        {
            if (keyframeDataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = keyframeDataGridView.SelectedRows[0].Index;
                keyPoints.RemoveAt(selectedIndex);
                UpdateDataGridView();
            }
        }

        private void UpdateDataGridView()
        {
            keyframeDataGridView.Rows.Clear();
            foreach (var keypoint in keyPoints)
            {
                keyframeDataGridView.Rows.Add(keypoint.Item1, keypoint.Item2, keypoint.Item3, keypoint.Item4, keypoint.Item5, keypoint.Item6, keypoint.Item7);
            }
        }

        private void keyframeDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var editedValue = keyframeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (editedValue != null && float.TryParse(editedValue.ToString(), out float newValue))
                {
                    var editedKeyPoint = keyPoints[e.RowIndex];
                    switch (e.ColumnIndex)
                    {
                        case 0: editedKeyPoint.Item1 = newValue; break; // X
                        case 1: editedKeyPoint.Item2 = newValue; break; // Y
                        case 2: editedKeyPoint.Item3 = newValue; break; // Z
                        case 3: editedKeyPoint.Item4 = newValue; break; // Yaw
                        case 4: editedKeyPoint.Item5 = newValue; break; // Pitch
                        case 5: editedKeyPoint.Item6 = newValue; break; // Roll
                        case 6: editedKeyPoint.Item7 = newValue; break; // FOV
                    }

                    keyPoints[e.RowIndex] = editedKeyPoint;
                }
            }
        }

        private void keyframeDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                RemoveSelectedKeypoint();
            }
        }

        private void dupeStartToEnd_Click(object sender, EventArgs e)
        {
            if (keyPoints.Count > 0)
            {
                keyPoints.Add(keyPoints[0]);
                UpdateDataGridView();
            }
        }
    }
}
