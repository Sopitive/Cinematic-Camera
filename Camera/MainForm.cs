using System;
using System.Windows.Forms;
using Memory;
using System.Diagnostics;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Camera
{
    public partial class CameraForm : Form
    {
        public Mem memory = new Mem();
        Process p;

        private Timer focusCheckTimer;

        public bool modulesUpdated = false;
        bool tagscurrentlyloaded;

        public string xPos;
        public string yPos;
        public string zPos;
        public string yawAng;
        public string pitchAng;
        public string rollAng;
        public string speedCamera;
        public string playerFov;
        public string vehicleFov;

        public string mccProcessSteam = "MCC-Win64-Shipping";
        public string mccProcessWinstore = "MCCWinStore-Win64-Shipping";
        private string selectedProcessName;

        public CameraForm()
        {
            Console.Title = "https://github.com/TermaciousTrickocity/Cinematic-Camera";

            InitializeComponent();
            LoadProcesses();
            TrySelectPredefinedProcess();
            InitializeDataGridView();
            InitializeTimeline();
            InitializeHotkeys();
            InitializeHotKeyTimer();

            try
            {
                string programDirectory = AppDomain.CurrentDomain.BaseDirectory;

                string subfolderName = "plugins";
                string subfolderPath = Path.Combine(programDirectory, subfolderName);

                DirectoryInfo d = new DirectoryInfo(@"plugins/");
                FileInfo[] Files = d.GetFiles("*.json");

                if (Directory.Exists(subfolderPath))
                {
                    string[] jsonFiles = Directory.GetFiles(subfolderPath, "*.json");

                    foreach (var file in Files)
                    {
                        string fileName = Path.GetFileName(file.ToString());
                        pluginAddressCombobox.Items.Add(fileName);
                    }
                }
                else
                {
                    Console.WriteLine("The 'plugins' folder does not exist.");
                    Directory.CreateDirectory(subfolderPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProcesses()
        {
            Process[] processes = Process.GetProcesses();

            foreach (Process process in processes)
            {
                processCombobox.Items.Add($"{process.ProcessName} (ID: {process.Id})");
            }
        }

        private void TrySelectPredefinedProcess()
        {
            foreach (var item in processCombobox.Items)
            {
                if (item.ToString().Contains(mccProcessSteam))
                {
                    processCombobox.SelectedItem = item;
                    selectedProcessName = mccProcessSteam;
                    Console.WriteLine($"Automatically found: {selectedProcessName}");
                    return;
                }
                if (item.ToString().Contains(mccProcessWinstore))
                {
                    processCombobox.SelectedItem = item;
                    selectedProcessName = mccProcessWinstore;
                    Console.WriteLine($"Automatically found: {selectedProcessName}");
                    return;
                }
            }
        }

        private void setFOV_Click(object sender, EventArgs e)
        {
            memory.WriteMemory(playerFov, "float", fovTextbox.Text);
        }

        private void setVehiFOV_Click(object sender, EventArgs e)
        {
            memory.WriteMemory(vehicleFov, "float", fovVehiTextbox.Text);
        }

        private void setRollAngle_Click(object sender, EventArgs e)
        {
            memory.WriteMemory(rollAng, "float", rollAngle.Text);
        }

        private void setCameraSpeed_Click(object sender, EventArgs e)
        {
            memory.WriteMemory(speedCamera, "float", quickAccessSpeed.Text);
        }

        private void createKeyframeButton_Click(object sender, EventArgs e)
        {
            createKeyframe();
        }

        private void deleteKeyframeButton_Click(object sender, EventArgs e)
        {
            RemoveSelectedKeypoint();
        }

        private void enablePathing_CheckedChanged(object sender, EventArgs e)
        {
            if (enablePathing.Checked == true)
            {
                MoveCameraAsync();
            }
        }

        public void updateModules_Click(object sender, EventArgs e)
        {
            if (processCombobox.SelectedIndex >= 0)
            {
                string selectedItem = processCombobox.SelectedItem.ToString();
                selectedProcessName = selectedItem.Split('(')[0].Trim();

                p = Process.GetProcessesByName(selectedProcessName)[0];
                memory.OpenProcess(p.Id);

                int PID = memory.GetProcIdFromName(selectedProcessName);
                if (PID == 0) return;

                UpdateModules();
            }
            else
            {
                MessageBox.Show("Please select a process.", "Process Selection");
            }
        }

        private void pluginAddressCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pluginAddressCombobox.Text == "None (Select one!)") return;

            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedItem != null)
            {
                string programDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string subfolderName = "plugins";

                string subfolderPath = Path.Combine(programDirectory, subfolderName);

                string selectedFilePath = Path.Combine(subfolderPath, comboBox.SelectedItem.ToString());
                GlobalData.LoadJSONFile(selectedFilePath);

                xPos = GlobalData.StringList[0];
                yPos = GlobalData.StringList[1];
                zPos = GlobalData.StringList[2];
                yawAng = GlobalData.StringList[3];
                pitchAng = GlobalData.StringList[4];
                rollAng = GlobalData.StringList[5];
                speedCamera = GlobalData.StringList[6];
                playerFov = GlobalData.StringList[7];
                vehicleFov = GlobalData.StringList[8];
            }
        }

        private void refreshProcess_Click(object sender, EventArgs e)
        {
            LoadProcesses();
        }

        private void updateDuration_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}