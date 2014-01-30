namespace ScpServer
{
    partial class BetterDS4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxControllers = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pgbBattery = new System.Windows.Forms.ProgressBar();
            this.chkAutoSleep = new System.Windows.Forms.CheckBox();
            this.nudSleepTimer = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxProfile = new System.Windows.Forms.ComboBox();
            this.btnNewProfile = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnDeleteProfile = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnApplyProfile = new System.Windows.Forms.Button();
            this.btnSleep = new System.Windows.Forms.Button();
            this.btnControlPanel = new System.Windows.Forms.Button();
            this.gbxController = new System.Windows.Forms.GroupBox();
            this.chkTouchPad = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkBatteryFlash = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.chkBatteryIndicator = new System.Windows.Forms.CheckBox();
            this.btnLEDColor = new System.Windows.Forms.Button();
            this.tbrSensitivity = new System.Windows.Forms.TrackBar();
            this.tbrRumble = new System.Windows.Forms.TrackBar();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cldLEDColor = new System.Windows.Forms.ColorDialog();
            this.rootHub = new ScpControl.BusDevice(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepTimer)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gbxController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSensitivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrRumble)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connected DS4 Controllers:";
            // 
            // lbxControllers
            // 
            this.lbxControllers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxControllers.FormattingEnabled = true;
            this.lbxControllers.Location = new System.Drawing.Point(12, 50);
            this.lbxControllers.Name = "lbxControllers";
            this.lbxControllers.Size = new System.Drawing.Size(169, 212);
            this.lbxControllers.TabIndex = 1;
            this.lbxControllers.SelectedIndexChanged += new System.EventHandler(this.lbxControllers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Battery:";
            // 
            // pgbBattery
            // 
            this.pgbBattery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgbBattery.Location = new System.Drawing.Point(190, 50);
            this.pgbBattery.Name = "pgbBattery";
            this.pgbBattery.Size = new System.Drawing.Size(346, 23);
            this.pgbBattery.TabIndex = 3;
            // 
            // chkAutoSleep
            // 
            this.chkAutoSleep.AutoSize = true;
            this.chkAutoSleep.Enabled = false;
            this.chkAutoSleep.Location = new System.Drawing.Point(190, 79);
            this.chkAutoSleep.Name = "chkAutoSleep";
            this.chkAutoSleep.Size = new System.Drawing.Size(248, 17);
            this.chkAutoSleep.TabIndex = 4;
            this.chkAutoSleep.Text = "Power off Bluetooth connected controllers after";
            this.chkAutoSleep.UseVisualStyleBackColor = true;
            // 
            // nudSleepTimer
            // 
            this.nudSleepTimer.Enabled = false;
            this.nudSleepTimer.Location = new System.Drawing.Point(436, 78);
            this.nudSleepTimer.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.nudSleepTimer.Name = "nudSleepTimer";
            this.nudSleepTimer.Size = new System.Drawing.Size(40, 20);
            this.nudSleepTimer.TabIndex = 5;
            this.nudSleepTimer.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "minutes.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Selected Profile:";
            // 
            // cbxProfile
            // 
            this.cbxProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxProfile.Enabled = false;
            this.cbxProfile.FormattingEnabled = true;
            this.cbxProfile.Location = new System.Drawing.Point(190, 123);
            this.cbxProfile.Name = "cbxProfile";
            this.cbxProfile.Size = new System.Drawing.Size(172, 21);
            this.cbxProfile.TabIndex = 8;
            // 
            // btnNewProfile
            // 
            this.btnNewProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewProfile.Enabled = false;
            this.btnNewProfile.Location = new System.Drawing.Point(368, 121);
            this.btnNewProfile.Name = "btnNewProfile";
            this.btnNewProfile.Size = new System.Drawing.Size(52, 23);
            this.btnNewProfile.TabIndex = 9;
            this.btnNewProfile.Text = "New";
            this.btnNewProfile.UseVisualStyleBackColor = true;
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditProfile.Enabled = false;
            this.btnEditProfile.Location = new System.Drawing.Point(426, 121);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(52, 23);
            this.btnEditProfile.TabIndex = 10;
            this.btnEditProfile.Text = "Edit";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProfile
            // 
            this.btnDeleteProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteProfile.Enabled = false;
            this.btnDeleteProfile.Location = new System.Drawing.Point(484, 121);
            this.btnDeleteProfile.Name = "btnDeleteProfile";
            this.btnDeleteProfile.Size = new System.Drawing.Size(52, 23);
            this.btnDeleteProfile.TabIndex = 11;
            this.btnDeleteProfile.Text = "Delete";
            this.btnDeleteProfile.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(548, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Enabled = false;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnApplyProfile
            // 
            this.btnApplyProfile.Enabled = false;
            this.btnApplyProfile.Location = new System.Drawing.Point(190, 150);
            this.btnApplyProfile.Name = "btnApplyProfile";
            this.btnApplyProfile.Size = new System.Drawing.Size(75, 23);
            this.btnApplyProfile.TabIndex = 13;
            this.btnApplyProfile.Text = "Apply";
            this.btnApplyProfile.UseVisualStyleBackColor = true;
            // 
            // btnSleep
            // 
            this.btnSleep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSleep.Enabled = false;
            this.btnSleep.Location = new System.Drawing.Point(190, 266);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(75, 23);
            this.btnSleep.TabIndex = 14;
            this.btnSleep.Text = "Power Off";
            this.btnSleep.UseVisualStyleBackColor = true;
            // 
            // btnControlPanel
            // 
            this.btnControlPanel.Location = new System.Drawing.Point(190, 179);
            this.btnControlPanel.Name = "btnControlPanel";
            this.btnControlPanel.Size = new System.Drawing.Size(75, 43);
            this.btnControlPanel.TabIndex = 15;
            this.btnControlPanel.Text = "Control\r\nPanel";
            this.btnControlPanel.UseVisualStyleBackColor = true;
            this.btnControlPanel.Click += new System.EventHandler(this.btnControlPanel_Click);
            // 
            // gbxController
            // 
            this.gbxController.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxController.Controls.Add(this.chkTouchPad);
            this.gbxController.Controls.Add(this.label6);
            this.gbxController.Controls.Add(this.label5);
            this.gbxController.Controls.Add(this.chkBatteryFlash);
            this.gbxController.Controls.Add(this.numericUpDown1);
            this.gbxController.Controls.Add(this.chkBatteryIndicator);
            this.gbxController.Controls.Add(this.btnLEDColor);
            this.gbxController.Controls.Add(this.tbrSensitivity);
            this.gbxController.Controls.Add(this.tbrRumble);
            this.gbxController.Location = new System.Drawing.Point(271, 150);
            this.gbxController.Name = "gbxController";
            this.gbxController.Size = new System.Drawing.Size(265, 138);
            this.gbxController.TabIndex = 16;
            this.gbxController.TabStop = false;
            this.gbxController.Text = "Controller Properties";
            // 
            // chkTouchPad
            // 
            this.chkTouchPad.AutoSize = true;
            this.chkTouchPad.Enabled = false;
            this.chkTouchPad.Location = new System.Drawing.Point(6, 56);
            this.chkTouchPad.Name = "chkTouchPad";
            this.chkTouchPad.Size = new System.Drawing.Size(79, 17);
            this.chkTouchPad.TabIndex = 21;
            this.chkTouchPad.Text = "Touch Pad";
            this.chkTouchPad.UseVisualStyleBackColor = true;
            this.chkTouchPad.CheckedChanged += new System.EventHandler(this.chkTouchPad_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Rumble Boost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "%";
            // 
            // chkBatteryFlash
            // 
            this.chkBatteryFlash.AutoSize = true;
            this.chkBatteryFlash.Enabled = false;
            this.chkBatteryFlash.Location = new System.Drawing.Point(6, 115);
            this.chkBatteryFlash.Name = "chkBatteryFlash";
            this.chkBatteryFlash.Size = new System.Drawing.Size(196, 17);
            this.chkBatteryFlash.TabIndex = 2;
            this.chkBatteryFlash.Text = "Flash LED when power drops below";
            this.chkBatteryFlash.UseVisualStyleBackColor = true;
            this.chkBatteryFlash.CheckedChanged += new System.EventHandler(this.chkBatteryFlash_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(202, 114);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // chkBatteryIndicator
            // 
            this.chkBatteryIndicator.AutoSize = true;
            this.chkBatteryIndicator.Enabled = false;
            this.chkBatteryIndicator.Location = new System.Drawing.Point(6, 92);
            this.chkBatteryIndicator.Name = "chkBatteryIndicator";
            this.chkBatteryIndicator.Size = new System.Drawing.Size(170, 17);
            this.chkBatteryIndicator.TabIndex = 1;
            this.chkBatteryIndicator.Text = "Use LED as a battery indicator";
            this.chkBatteryIndicator.UseVisualStyleBackColor = true;
            this.chkBatteryIndicator.CheckedChanged += new System.EventHandler(this.chkBatteryIndicator_CheckedChanged);
            // 
            // btnLEDColor
            // 
            this.btnLEDColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLEDColor.Enabled = false;
            this.btnLEDColor.Location = new System.Drawing.Point(184, 88);
            this.btnLEDColor.Name = "btnLEDColor";
            this.btnLEDColor.Size = new System.Drawing.Size(75, 23);
            this.btnLEDColor.TabIndex = 0;
            this.btnLEDColor.Text = "Set Color";
            this.btnLEDColor.UseVisualStyleBackColor = true;
            this.btnLEDColor.Click += new System.EventHandler(this.btnLEDColor_Click);
            // 
            // tbrSensitivity
            // 
            this.tbrSensitivity.Enabled = false;
            this.tbrSensitivity.LargeChange = 50;
            this.tbrSensitivity.Location = new System.Drawing.Point(85, 55);
            this.tbrSensitivity.Maximum = 100;
            this.tbrSensitivity.Name = "tbrSensitivity";
            this.tbrSensitivity.Size = new System.Drawing.Size(174, 45);
            this.tbrSensitivity.TabIndex = 22;
            this.tbrSensitivity.TickFrequency = 10;
            this.tbrSensitivity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbrSensitivity.Value = 100;
            this.tbrSensitivity.Scroll += new System.EventHandler(this.tbrSensitivity_Scroll);
            // 
            // tbrRumble
            // 
            this.tbrRumble.Enabled = false;
            this.tbrRumble.LargeChange = 50;
            this.tbrRumble.Location = new System.Drawing.Point(85, 19);
            this.tbrRumble.Maximum = 200;
            this.tbrRumble.Name = "tbrRumble";
            this.tbrRumble.Size = new System.Drawing.Size(174, 45);
            this.tbrRumble.TabIndex = 19;
            this.tbrRumble.TickFrequency = 10;
            this.tbrRumble.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbrRumble.Value = 100;
            this.tbrRumble.Scroll += new System.EventHandler(this.tbrRumble_Scroll);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Location = new System.Drawing.Point(12, 266);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(169, 23);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // BetterDS4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 301);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.gbxController);
            this.Controls.Add(this.btnControlPanel);
            this.Controls.Add(this.btnSleep);
            this.Controls.Add(this.btnApplyProfile);
            this.Controls.Add(this.btnDeleteProfile);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.btnNewProfile);
            this.Controls.Add(this.cbxProfile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudSleepTimer);
            this.Controls.Add(this.chkAutoSleep);
            this.Controls.Add(this.pgbBattery);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxControllers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BetterDS4";
            this.Text = "Better DS4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BetterDS4_Close);
            this.Load += new System.EventHandler(this.BetterDS4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepTimer)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxController.ResumeLayout(false);
            this.gbxController.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSensitivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrRumble)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxControllers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pgbBattery;
        private System.Windows.Forms.CheckBox chkAutoSleep;
        private System.Windows.Forms.NumericUpDown nudSleepTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxProfile;
        private System.Windows.Forms.Button btnNewProfile;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnDeleteProfile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnApplyProfile;
        private System.Windows.Forms.Button btnSleep;
        private System.Windows.Forms.Button btnControlPanel;
        private System.Windows.Forms.GroupBox gbxController;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkBatteryFlash;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox chkBatteryIndicator;
        private System.Windows.Forms.Button btnLEDColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar tbrRumble;
        private ScpControl.BusDevice rootHub;
        private System.Windows.Forms.CheckBox chkTouchPad;
        private System.Windows.Forms.TrackBar tbrSensitivity;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ColorDialog cldLEDColor;

    }
}