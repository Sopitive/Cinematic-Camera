namespace Camera
{
    partial class CameraForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraForm));
            mainGroupBox = new System.Windows.Forms.GroupBox();
            refreshProcess = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            processCombobox = new System.Windows.Forms.ComboBox();
            updateModules = new System.Windows.Forms.Button();
            label13 = new System.Windows.Forms.Label();
            pluginAddressCombobox = new System.Windows.Forms.ComboBox();
            groupBox9 = new System.Windows.Forms.GroupBox();
            label20 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            textBox8 = new System.Windows.Forms.TextBox();
            textBox9 = new System.Windows.Forms.TextBox();
            textBox10 = new System.Windows.Forms.TextBox();
            textBox11 = new System.Windows.Forms.TextBox();
            textBox12 = new System.Windows.Forms.TextBox();
            textBox13 = new System.Windows.Forms.TextBox();
            textBox14 = new System.Windows.Forms.TextBox();
            label18 = new System.Windows.Forms.Label();
            textBox7 = new System.Windows.Forms.TextBox();
            textBox6 = new System.Windows.Forms.TextBox();
            textBox5 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox1 = new System.Windows.Forms.TextBox();
            label17 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            groupBox8 = new System.Windows.Forms.GroupBox();
            setFOV = new System.Windows.Forms.Button();
            quickAccessSpeed = new System.Windows.Forms.TextBox();
            fovTextbox = new System.Windows.Forms.TextBox();
            setCameraSpeed = new System.Windows.Forms.Button();
            setVehiFOV = new System.Windows.Forms.Button();
            rollAngle = new System.Windows.Forms.TextBox();
            fovVehiTextbox = new System.Windows.Forms.TextBox();
            setRollAngle = new System.Windows.Forms.Button();
            cameraGroupbox = new System.Windows.Forms.GroupBox();
            label22 = new System.Windows.Forms.Label();
            fovStatus = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            cameraX = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            cameraY = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            cameraZ = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            cameraYaw = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            cameraPitch = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            cameraRoll = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            cameraSpeed = new System.Windows.Forms.TextBox();
            openPlugin = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            dupeStartToEnd = new System.Windows.Forms.Button();
            enablePathing = new System.Windows.Forms.CheckBox();
            exportPathButton = new System.Windows.Forms.Button();
            importPathButton = new System.Windows.Forms.Button();
            deleteKeyframeButton = new System.Windows.Forms.Button();
            createKeyframeButton = new System.Windows.Forms.Button();
            checkBox1 = new System.Windows.Forms.CheckBox();
            keyFrameListLoop = new System.Windows.Forms.CheckBox();
            keyframeDataGridView = new System.Windows.Forms.DataGridView();
            label12 = new System.Windows.Forms.Label();
            pathDuration = new System.Windows.Forms.TextBox();
            groupBox7 = new System.Windows.Forms.GroupBox();
            label21 = new System.Windows.Forms.Label();
            keyProgress = new System.Windows.Forms.TextBox();
            updateDuration = new System.Windows.Forms.Button();
            timelinePanel = new System.Windows.Forms.Panel();
            mainGroupBox.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox8.SuspendLayout();
            cameraGroupbox.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)keyframeDataGridView).BeginInit();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // mainGroupBox
            // 
            mainGroupBox.Controls.Add(refreshProcess);
            mainGroupBox.Controls.Add(label8);
            mainGroupBox.Controls.Add(processCombobox);
            mainGroupBox.Controls.Add(updateModules);
            mainGroupBox.Controls.Add(label13);
            mainGroupBox.Controls.Add(pluginAddressCombobox);
            mainGroupBox.Controls.Add(groupBox9);
            mainGroupBox.Controls.Add(groupBox8);
            mainGroupBox.Controls.Add(cameraGroupbox);
            mainGroupBox.Location = new System.Drawing.Point(12, 12);
            mainGroupBox.Name = "mainGroupBox";
            mainGroupBox.Size = new System.Drawing.Size(398, 679);
            mainGroupBox.TabIndex = 0;
            mainGroupBox.TabStop = false;
            mainGroupBox.Text = "Memory";
            // 
            // refreshProcess
            // 
            refreshProcess.Location = new System.Drawing.Point(302, 18);
            refreshProcess.Name = "refreshProcess";
            refreshProcess.Size = new System.Drawing.Size(80, 24);
            refreshProcess.TabIndex = 32;
            refreshProcess.Text = "Refresh";
            refreshProcess.UseVisualStyleBackColor = true;
            refreshProcess.Click += refreshProcess_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(12, 23);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(47, 15);
            label8.TabIndex = 31;
            label8.Text = "Process";
            // 
            // processCombobox
            // 
            processCombobox.FormattingEnabled = true;
            processCombobox.Location = new System.Drawing.Point(65, 20);
            processCombobox.Name = "processCombobox";
            processCombobox.Size = new System.Drawing.Size(231, 23);
            processCombobox.TabIndex = 30;
            processCombobox.Text = "MCC not found (Is it running?)";
            // 
            // updateModules
            // 
            updateModules.Location = new System.Drawing.Point(302, 48);
            updateModules.Name = "updateModules";
            updateModules.Size = new System.Drawing.Size(80, 24);
            updateModules.TabIndex = 29;
            updateModules.Text = "Update";
            updateModules.UseVisualStyleBackColor = true;
            updateModules.Click += updateModules_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(12, 52);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(41, 15);
            label13.TabIndex = 20;
            label13.Text = "Plugin";
            // 
            // pluginAddressCombobox
            // 
            pluginAddressCombobox.FormattingEnabled = true;
            pluginAddressCombobox.Location = new System.Drawing.Point(65, 49);
            pluginAddressCombobox.Name = "pluginAddressCombobox";
            pluginAddressCombobox.Size = new System.Drawing.Size(231, 23);
            pluginAddressCombobox.TabIndex = 26;
            pluginAddressCombobox.Text = "None (Select one!)";
            pluginAddressCombobox.SelectedIndexChanged += pluginAddressCombobox_SelectedIndexChanged;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(label20);
            groupBox9.Controls.Add(label19);
            groupBox9.Controls.Add(textBox8);
            groupBox9.Controls.Add(textBox9);
            groupBox9.Controls.Add(textBox10);
            groupBox9.Controls.Add(textBox11);
            groupBox9.Controls.Add(textBox12);
            groupBox9.Controls.Add(textBox13);
            groupBox9.Controls.Add(textBox14);
            groupBox9.Controls.Add(label18);
            groupBox9.Controls.Add(textBox7);
            groupBox9.Controls.Add(textBox6);
            groupBox9.Controls.Add(textBox5);
            groupBox9.Controls.Add(textBox4);
            groupBox9.Controls.Add(textBox3);
            groupBox9.Controls.Add(textBox2);
            groupBox9.Controls.Add(textBox1);
            groupBox9.Controls.Add(label17);
            groupBox9.Controls.Add(label16);
            groupBox9.Controls.Add(label15);
            groupBox9.Controls.Add(label14);
            groupBox9.Controls.Add(label11);
            groupBox9.Controls.Add(label10);
            groupBox9.Controls.Add(label9);
            groupBox9.Location = new System.Drawing.Point(6, 343);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new System.Drawing.Size(382, 330);
            groupBox9.TabIndex = 25;
            groupBox9.TabStop = false;
            groupBox9.Text = "Hotkeys";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(174, 262);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(127, 15);
            label20.TabIndex = 42;
            label20.Text = "(Not customizable yet)";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(250, 44);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(60, 15);
            label19.TabIndex = 41;
            label19.Text = "Controller";
            // 
            // textBox8
            // 
            textBox8.Location = new System.Drawing.Point(251, 236);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new System.Drawing.Size(57, 23);
            textBox8.TabIndex = 40;
            textBox8.Text = "(None)";
            // 
            // textBox9
            // 
            textBox9.Location = new System.Drawing.Point(251, 207);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new System.Drawing.Size(57, 23);
            textBox9.TabIndex = 39;
            textBox9.Text = "(None)";
            // 
            // textBox10
            // 
            textBox10.Location = new System.Drawing.Point(251, 178);
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new System.Drawing.Size(57, 23);
            textBox10.TabIndex = 38;
            textBox10.Text = "(None)";
            // 
            // textBox11
            // 
            textBox11.Location = new System.Drawing.Point(251, 149);
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new System.Drawing.Size(57, 23);
            textBox11.TabIndex = 37;
            textBox11.Text = "(None)";
            // 
            // textBox12
            // 
            textBox12.Location = new System.Drawing.Point(251, 120);
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new System.Drawing.Size(57, 23);
            textBox12.TabIndex = 36;
            textBox12.Text = "(None)";
            // 
            // textBox13
            // 
            textBox13.Location = new System.Drawing.Point(251, 91);
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new System.Drawing.Size(57, 23);
            textBox13.TabIndex = 35;
            textBox13.Text = "(None)";
            // 
            // textBox14
            // 
            textBox14.Location = new System.Drawing.Point(251, 62);
            textBox14.Name = "textBox14";
            textBox14.ReadOnly = true;
            textBox14.Size = new System.Drawing.Size(57, 23);
            textBox14.TabIndex = 34;
            textBox14.Text = "(None)";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(170, 44);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(57, 15);
            label18.TabIndex = 33;
            label18.Text = "Keyboard";
            // 
            // textBox7
            // 
            textBox7.Location = new System.Drawing.Point(170, 236);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new System.Drawing.Size(57, 23);
            textBox7.TabIndex = 32;
            textBox7.Text = "Y";
            // 
            // textBox6
            // 
            textBox6.Location = new System.Drawing.Point(170, 207);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new System.Drawing.Size(57, 23);
            textBox6.TabIndex = 31;
            textBox6.Text = "U";
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(170, 178);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new System.Drawing.Size(57, 23);
            textBox5.TabIndex = 30;
            textBox5.Text = "I";
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(170, 149);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new System.Drawing.Size(57, 23);
            textBox4.TabIndex = 29;
            textBox4.Text = "P";
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(170, 120);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new System.Drawing.Size(57, 23);
            textBox3.TabIndex = 28;
            textBox3.Text = "K";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(170, 91);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new System.Drawing.Size(57, 23);
            textBox2.TabIndex = 27;
            textBox2.Text = "N";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(170, 62);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new System.Drawing.Size(57, 23);
            textBox1.TabIndex = 24;
            textBox1.Text = "M";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(59, 239);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(74, 15);
            label17.TabIndex = 26;
            label17.Text = "Decrease fov";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(59, 210);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(70, 15);
            label16.TabIndex = 25;
            label16.Text = "Increase fov";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(59, 181);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(106, 15);
            label15.TabIndex = 24;
            label15.Text = "Decrease roll angle";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(59, 152);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(102, 15);
            label14.TabIndex = 23;
            label14.Text = "Increase roll angle";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(59, 123);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(60, 15);
            label11.TabIndex = 22;
            label11.Text = "Add point";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(59, 94);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(75, 15);
            label10.TabIndex = 21;
            label10.Text = "Stop pathing";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(59, 65);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(75, 15);
            label9.TabIndex = 20;
            label9.Text = "Start pathing";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(setFOV);
            groupBox8.Controls.Add(quickAccessSpeed);
            groupBox8.Controls.Add(fovTextbox);
            groupBox8.Controls.Add(setCameraSpeed);
            groupBox8.Controls.Add(setVehiFOV);
            groupBox8.Controls.Add(rollAngle);
            groupBox8.Controls.Add(fovVehiTextbox);
            groupBox8.Controls.Add(setRollAngle);
            groupBox8.Location = new System.Drawing.Point(6, 226);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new System.Drawing.Size(382, 111);
            groupBox8.TabIndex = 24;
            groupBox8.TabStop = false;
            groupBox8.Text = "Modifiers";
            // 
            // setFOV
            // 
            setFOV.Location = new System.Drawing.Point(6, 21);
            setFOV.Name = "setFOV";
            setFOV.Size = new System.Drawing.Size(105, 38);
            setFOV.TabIndex = 0;
            setFOV.Text = "FOV";
            setFOV.UseVisualStyleBackColor = true;
            setFOV.Click += setFOV_Click;
            // 
            // quickAccessSpeed
            // 
            quickAccessSpeed.Location = new System.Drawing.Point(319, 71);
            quickAccessSpeed.Name = "quickAccessSpeed";
            quickAccessSpeed.Size = new System.Drawing.Size(57, 23);
            quickAccessSpeed.TabIndex = 23;
            // 
            // fovTextbox
            // 
            fovTextbox.Location = new System.Drawing.Point(117, 30);
            fovTextbox.Name = "fovTextbox";
            fovTextbox.Size = new System.Drawing.Size(57, 23);
            fovTextbox.TabIndex = 1;
            // 
            // setCameraSpeed
            // 
            setCameraSpeed.Location = new System.Drawing.Point(208, 62);
            setCameraSpeed.Name = "setCameraSpeed";
            setCameraSpeed.Size = new System.Drawing.Size(105, 38);
            setCameraSpeed.TabIndex = 22;
            setCameraSpeed.Text = "Camera speed";
            setCameraSpeed.UseVisualStyleBackColor = true;
            setCameraSpeed.Click += setCameraSpeed_Click;
            // 
            // setVehiFOV
            // 
            setVehiFOV.Location = new System.Drawing.Point(208, 22);
            setVehiFOV.Name = "setVehiFOV";
            setVehiFOV.Size = new System.Drawing.Size(105, 38);
            setVehiFOV.TabIndex = 2;
            setVehiFOV.Text = "Vehicle FOV";
            setVehiFOV.UseVisualStyleBackColor = true;
            setVehiFOV.Click += setVehiFOV_Click;
            // 
            // rollAngle
            // 
            rollAngle.Location = new System.Drawing.Point(117, 71);
            rollAngle.Name = "rollAngle";
            rollAngle.Size = new System.Drawing.Size(57, 23);
            rollAngle.TabIndex = 21;
            // 
            // fovVehiTextbox
            // 
            fovVehiTextbox.Location = new System.Drawing.Point(319, 30);
            fovVehiTextbox.Name = "fovVehiTextbox";
            fovVehiTextbox.Size = new System.Drawing.Size(57, 23);
            fovVehiTextbox.TabIndex = 3;
            // 
            // setRollAngle
            // 
            setRollAngle.Location = new System.Drawing.Point(6, 62);
            setRollAngle.Name = "setRollAngle";
            setRollAngle.Size = new System.Drawing.Size(105, 38);
            setRollAngle.TabIndex = 20;
            setRollAngle.Text = "Roll angle";
            setRollAngle.UseVisualStyleBackColor = true;
            setRollAngle.Click += setRollAngle_Click;
            // 
            // cameraGroupbox
            // 
            cameraGroupbox.Controls.Add(label22);
            cameraGroupbox.Controls.Add(fovStatus);
            cameraGroupbox.Controls.Add(label1);
            cameraGroupbox.Controls.Add(cameraX);
            cameraGroupbox.Controls.Add(label7);
            cameraGroupbox.Controls.Add(cameraY);
            cameraGroupbox.Controls.Add(label6);
            cameraGroupbox.Controls.Add(cameraZ);
            cameraGroupbox.Controls.Add(label5);
            cameraGroupbox.Controls.Add(cameraYaw);
            cameraGroupbox.Controls.Add(label4);
            cameraGroupbox.Controls.Add(cameraPitch);
            cameraGroupbox.Controls.Add(label3);
            cameraGroupbox.Controls.Add(cameraRoll);
            cameraGroupbox.Controls.Add(label2);
            cameraGroupbox.Controls.Add(cameraSpeed);
            cameraGroupbox.Location = new System.Drawing.Point(6, 78);
            cameraGroupbox.Name = "cameraGroupbox";
            cameraGroupbox.Size = new System.Drawing.Size(382, 142);
            cameraGroupbox.TabIndex = 19;
            cameraGroupbox.TabStop = false;
            cameraGroupbox.Text = "Camera status:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new System.Drawing.Point(6, 111);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(70, 15);
            label22.TabIndex = 19;
            label22.Text = "Camera Fov";
            // 
            // fovStatus
            // 
            fovStatus.Location = new System.Drawing.Point(80, 108);
            fovStatus.Name = "fovStatus";
            fovStatus.ReadOnly = true;
            fovStatus.Size = new System.Drawing.Size(76, 23);
            fovStatus.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 15);
            label1.TabIndex = 11;
            label1.Text = "Camera X";
            // 
            // cameraX
            // 
            cameraX.Location = new System.Drawing.Point(80, 21);
            cameraX.Name = "cameraX";
            cameraX.ReadOnly = true;
            cameraX.Size = new System.Drawing.Size(76, 23);
            cameraX.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(207, 82);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(71, 15);
            label7.TabIndex = 17;
            label7.Text = "Camera Roll";
            // 
            // cameraY
            // 
            cameraY.Location = new System.Drawing.Point(80, 50);
            cameraY.Name = "cameraY";
            cameraY.ReadOnly = true;
            cameraY.Size = new System.Drawing.Size(76, 23);
            cameraY.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(207, 111);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(83, 15);
            label6.TabIndex = 16;
            label6.Text = "Camera Speed";
            // 
            // cameraZ
            // 
            cameraZ.Location = new System.Drawing.Point(80, 79);
            cameraZ.Name = "cameraZ";
            cameraZ.ReadOnly = true;
            cameraZ.Size = new System.Drawing.Size(76, 23);
            cameraZ.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(207, 53);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(78, 15);
            label5.TabIndex = 15;
            label5.Text = "Camera Pitch";
            // 
            // cameraYaw
            // 
            cameraYaw.Location = new System.Drawing.Point(296, 21);
            cameraYaw.Name = "cameraYaw";
            cameraYaw.ReadOnly = true;
            cameraYaw.Size = new System.Drawing.Size(76, 23);
            cameraYaw.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(207, 24);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(72, 15);
            label4.TabIndex = 14;
            label4.Text = "Camera Yaw";
            // 
            // cameraPitch
            // 
            cameraPitch.Location = new System.Drawing.Point(296, 50);
            cameraPitch.Name = "cameraPitch";
            cameraPitch.ReadOnly = true;
            cameraPitch.Size = new System.Drawing.Size(76, 23);
            cameraPitch.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 82);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(58, 15);
            label3.TabIndex = 13;
            label3.Text = "Camera Z";
            // 
            // cameraRoll
            // 
            cameraRoll.Location = new System.Drawing.Point(296, 79);
            cameraRoll.Name = "cameraRoll";
            cameraRoll.ReadOnly = true;
            cameraRoll.Size = new System.Drawing.Size(76, 23);
            cameraRoll.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 53);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(58, 15);
            label2.TabIndex = 12;
            label2.Text = "Camera Y";
            // 
            // cameraSpeed
            // 
            cameraSpeed.Location = new System.Drawing.Point(296, 108);
            cameraSpeed.Name = "cameraSpeed";
            cameraSpeed.ReadOnly = true;
            cameraSpeed.Size = new System.Drawing.Size(76, 23);
            cameraSpeed.TabIndex = 10;
            // 
            // openPlugin
            // 
            openPlugin.Location = new System.Drawing.Point(1311, 32);
            openPlugin.Name = "openPlugin";
            openPlugin.Size = new System.Drawing.Size(75, 23);
            openPlugin.TabIndex = 0;
            openPlugin.Text = "openPlugin";
            openPlugin.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dupeStartToEnd);
            groupBox2.Controls.Add(enablePathing);
            groupBox2.Controls.Add(exportPathButton);
            groupBox2.Controls.Add(importPathButton);
            groupBox2.Controls.Add(deleteKeyframeButton);
            groupBox2.Controls.Add(createKeyframeButton);
            groupBox2.Location = new System.Drawing.Point(416, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(756, 69);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pathing";
            // 
            // dupeStartToEnd
            // 
            dupeStartToEnd.Location = new System.Drawing.Point(339, 19);
            dupeStartToEnd.Name = "dupeStartToEnd";
            dupeStartToEnd.Size = new System.Drawing.Size(105, 38);
            dupeStartToEnd.TabIndex = 29;
            dupeStartToEnd.Text = "Add start point to end";
            dupeStartToEnd.UseVisualStyleBackColor = true;
            dupeStartToEnd.Click += dupeStartToEnd_Click;
            // 
            // enablePathing
            // 
            enablePathing.AutoSize = true;
            enablePathing.Location = new System.Drawing.Point(228, 29);
            enablePathing.Name = "enablePathing";
            enablePathing.Size = new System.Drawing.Size(105, 19);
            enablePathing.TabIndex = 22;
            enablePathing.Text = "Enable pathing";
            enablePathing.UseVisualStyleBackColor = true;
            enablePathing.CheckedChanged += enablePathing_CheckedChanged;
            // 
            // exportPathButton
            // 
            exportPathButton.Location = new System.Drawing.Point(645, 19);
            exportPathButton.Name = "exportPathButton";
            exportPathButton.Size = new System.Drawing.Size(105, 38);
            exportPathButton.TabIndex = 28;
            exportPathButton.Text = "Export Path";
            exportPathButton.UseVisualStyleBackColor = true;
            exportPathButton.Click += exportPathButton_Click;
            // 
            // importPathButton
            // 
            importPathButton.Location = new System.Drawing.Point(534, 18);
            importPathButton.Name = "importPathButton";
            importPathButton.Size = new System.Drawing.Size(105, 38);
            importPathButton.TabIndex = 27;
            importPathButton.Text = "Import path";
            importPathButton.UseVisualStyleBackColor = true;
            importPathButton.Click += importPathButton_Click;
            // 
            // deleteKeyframeButton
            // 
            deleteKeyframeButton.Location = new System.Drawing.Point(117, 18);
            deleteKeyframeButton.Name = "deleteKeyframeButton";
            deleteKeyframeButton.Size = new System.Drawing.Size(105, 38);
            deleteKeyframeButton.TabIndex = 21;
            deleteKeyframeButton.Text = "Delete keyframe";
            deleteKeyframeButton.UseVisualStyleBackColor = true;
            deleteKeyframeButton.Click += deleteKeyframeButton_Click;
            // 
            // createKeyframeButton
            // 
            createKeyframeButton.Location = new System.Drawing.Point(6, 19);
            createKeyframeButton.Name = "createKeyframeButton";
            createKeyframeButton.Size = new System.Drawing.Size(105, 38);
            createKeyframeButton.TabIndex = 20;
            createKeyframeButton.Text = "Create keyframe";
            createKeyframeButton.UseVisualStyleBackColor = true;
            createKeyframeButton.Click += createKeyframeButton_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(272, 18);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(133, 19);
            checkBox1.TabIndex = 24;
            checkBox1.Text = "Loop back and forth";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // keyFrameListLoop
            // 
            keyFrameListLoop.AutoSize = true;
            keyFrameListLoop.Location = new System.Drawing.Point(411, 19);
            keyFrameListLoop.Name = "keyFrameListLoop";
            keyFrameListLoop.Size = new System.Drawing.Size(123, 19);
            keyFrameListLoop.TabIndex = 23;
            keyFrameListLoop.Text = "Loop keyframe list";
            keyFrameListLoop.UseVisualStyleBackColor = true;
            // 
            // keyframeDataGridView
            // 
            keyframeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            keyframeDataGridView.Location = new System.Drawing.Point(416, 87);
            keyframeDataGridView.Name = "keyframeDataGridView";
            keyframeDataGridView.RowTemplate.Height = 25;
            keyframeDataGridView.Size = new System.Drawing.Size(756, 604);
            keyframeDataGridView.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(12, 19);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(107, 15);
            label12.TabIndex = 31;
            label12.Text = "Duration (seconds)";
            // 
            // pathDuration
            // 
            pathDuration.Location = new System.Drawing.Point(125, 16);
            pathDuration.Name = "pathDuration";
            pathDuration.Size = new System.Drawing.Size(55, 23);
            pathDuration.TabIndex = 32;
            pathDuration.Text = "10";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(label21);
            groupBox7.Controls.Add(keyProgress);
            groupBox7.Controls.Add(updateDuration);
            groupBox7.Controls.Add(keyFrameListLoop);
            groupBox7.Controls.Add(checkBox1);
            groupBox7.Controls.Add(timelinePanel);
            groupBox7.Controls.Add(label12);
            groupBox7.Controls.Add(pathDuration);
            groupBox7.Location = new System.Drawing.Point(12, 697);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new System.Drawing.Size(1160, 134);
            groupBox7.TabIndex = 33;
            groupBox7.TabStop = false;
            groupBox7.Text = "Timeline";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new System.Drawing.Point(1023, 19);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(52, 15);
            label21.TabIndex = 35;
            label21.Text = "Progress";
            // 
            // keyProgress
            // 
            keyProgress.Location = new System.Drawing.Point(1081, 14);
            keyProgress.Name = "keyProgress";
            keyProgress.ReadOnly = true;
            keyProgress.Size = new System.Drawing.Size(73, 23);
            keyProgress.TabIndex = 34;
            keyProgress.Text = "0.00%";
            // 
            // updateDuration
            // 
            updateDuration.Location = new System.Drawing.Point(186, 15);
            updateDuration.Name = "updateDuration";
            updateDuration.Size = new System.Drawing.Size(80, 24);
            updateDuration.TabIndex = 33;
            updateDuration.Text = "Update";
            updateDuration.UseVisualStyleBackColor = true;
            updateDuration.Click += updateDuration_Click;
            // 
            // timelinePanel
            // 
            timelinePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            timelinePanel.Location = new System.Drawing.Point(6, 45);
            timelinePanel.Name = "timelinePanel";
            timelinePanel.Size = new System.Drawing.Size(1148, 83);
            timelinePanel.TabIndex = 33;
            // 
            // CameraForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1186, 841);
            Controls.Add(openPlugin);
            Controls.Add(keyframeDataGridView);
            Controls.Add(groupBox7);
            Controls.Add(mainGroupBox);
            Controls.Add(groupBox2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(1202, 880);
            MinimumSize = new System.Drawing.Size(1202, 880);
            Name = "CameraForm";
            Text = "Cinematic Tools";
            mainGroupBox.ResumeLayout(false);
            mainGroupBox.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            cameraGroupbox.ResumeLayout(false);
            cameraGroupbox.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)keyframeDataGridView).EndInit();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.Button setFOV;
        private System.Windows.Forms.TextBox fovTextbox;
        private System.Windows.Forms.TextBox fovVehiTextbox;
        private System.Windows.Forms.Button setVehiFOV;
        private System.Windows.Forms.TextBox cameraY;
        private System.Windows.Forms.TextBox cameraX;
        private System.Windows.Forms.TextBox cameraSpeed;
        private System.Windows.Forms.TextBox cameraRoll;
        private System.Windows.Forms.TextBox cameraPitch;
        private System.Windows.Forms.TextBox cameraYaw;
        private System.Windows.Forms.TextBox cameraZ;
        private System.Windows.Forms.GroupBox cameraGroupbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cameraSway;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button createKeyframeButton;
        private System.Windows.Forms.DataGridView keyframeDataGridView;
        private System.Windows.Forms.Button deleteKeyframeButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox keyFrameListLoop;
        private System.Windows.Forms.CheckBox enablePathing;
        private System.Windows.Forms.Button exportPathButton;
        private System.Windows.Forms.Button importPathButton;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox fovStatus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox pathDuration;
        private System.Windows.Forms.TextBox quickAccessSpeed;
        private System.Windows.Forms.Button setCameraSpeed;
        private System.Windows.Forms.TextBox rollAngle;
        private System.Windows.Forms.Button setRollAngle;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Panel timelinePanel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox pluginAddressCombobox;
        private System.Windows.Forms.Button updateModules;
        private System.Windows.Forms.Button dupeStartToEnd;
        private System.Windows.Forms.Button openPlugin;
        private System.Windows.Forms.ComboBox processCombobox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button refreshProcess;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button updateDuration;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox keyProgress;
    }
}
