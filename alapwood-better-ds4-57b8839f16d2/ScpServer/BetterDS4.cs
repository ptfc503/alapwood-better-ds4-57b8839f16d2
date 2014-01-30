using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ScpControl;

namespace ScpServer
{
    public partial class BetterDS4 : Form
    {
        int device = -1;    //Keeps track of which device is currently selected

        public void RestartServer() {
            //Restart the server
            rootHub.Stop();
            
            rootHub.Open();
            rootHub.Start();

            RefreshControllers();
        }

        public void RefreshControllers() {
            //Clear the controllers listbox
            lbxControllers.SelectedIndex = -1;
            lbxControllers.Items.Clear();

            //Populate the controllers listbox
            for (int i = 0; i < 4; i++) {
                string s = rootHub.getControllerInfo(i);

                //If there is a controller connected to device i ...
                if (s != null) {
                    //... give it a name with values pulled from the rootHub
                    lbxControllers.Items.Add("DS4 Controller " + (i + 1) + (rootHub.PDS4Controllers[i].IsUSB ? " (USB)" : " (Bluetooth)"));
                }
            }
        }

        public void LoadForm(int d) {
            //Enable controls
            pgbBattery.Value = rootHub.PDS4Controllers[device].Charge;
            tbrRumble.Enabled = true;
            chkTouchPad.Enabled = true;
            chkBatteryIndicator.Enabled = true;
            btnLEDColor.Enabled = !chkBatteryIndicator.Checked;
            chkBatteryFlash.Enabled = true;
            tbrSensitivity.Enabled = chkTouchPad.Checked;

            //Load the current settings for this device
            ledColor color = Global.loadColor(d);
            tbrRumble.Value = ScpControl.Global.loadRumbleBoost(d);
            chkBatteryIndicator.Checked = ScpControl.Global.getLedAsBatteryIndicator(d);
            chkBatteryFlash.Checked = ScpControl.Global.getFlashWhenLowBattery(d);
            chkTouchPad.Checked = Global.getTouchEnabled(d);
            tbrSensitivity.Value = Global.getTouchSensitivity(d);
        }

        public void DisableForm() {
            //Disable controls
            chkAutoSleep.Enabled = false;
            cbxProfile.Enabled = false;
            btnNewProfile.Enabled = false;
            btnEditProfile.Enabled = false;
            btnApplyProfile.Enabled = false;
            btnSleep.Enabled = false;
            tbrRumble.Enabled = false;
            chkTouchPad.Enabled = false;
            tbrSensitivity.Enabled = false;
            chkBatteryIndicator.Enabled = false;
            btnLEDColor.Enabled = false;
            chkBatteryFlash.Enabled = false;
            nudSleepTimer.Enabled = false;

            //Reset values to defaults
            pgbBattery.Value = 0;
            tbrRumble.Value = 100;
            tbrSensitivity.Value = 100;
            nudSleepTimer.Value = 20;

            //Clear the profile combo box
            cbxProfile.Items.Clear();

            //Uncheck checkboxes
            chkAutoSleep.Checked = false;
            chkTouchPad.Checked = false;
            chkBatteryIndicator.Checked = false;
            chkBatteryIndicator.Enabled = false;
            chkBatteryFlash.Checked = false;

        }

        

        public BetterDS4() {
            InitializeComponent();
        }

        private void BetterDS4_Load(object sender, EventArgs e) {
            Icon = Properties.Resources.Scp_All;
            Global.Load();
            Global.setDeviceSharingModeIsExclusive(true);
            
            //Start the server
            rootHub.Open();
            rootHub.Start();

            RefreshControllers();
        }

        private void BetterDS4_Close(object sender, FormClosingEventArgs e) {
            //Stop the server
            //rootHub.Stop();   //Stop logs the server shutdown
            rootHub.Close();    //Close does not
        }


        private void btnControlPanel_Click(object sender, EventArgs e) {
            //Open the "Game Controllers" panel in control panel
            System.Diagnostics.Process.Start("control.exe", "joy.cpl");
        }

        private void lbxControllers_SelectedIndexChanged(object sender, EventArgs e) {
            //Update the selected device variable
            device = lbxControllers.SelectedIndex;

            //Set the state of the form
            if (device == -1) {
                DisableForm();
            } else {
                LoadForm(device);
            }

        }

        private void chkTouchPad_CheckedChanged(object sender, EventArgs e) {
            if (chkTouchPad.Enabled) {
                //Enable the sensitivity trackbar
                Global.setTouchEnabled(device, chkTouchPad.Checked);
                rootHub.PDS4Controllers[device].isTouchEnabled = chkTouchPad.Checked;
                tbrSensitivity.Enabled = chkTouchPad.Checked;
            }
        }

        private void chkBatteryIndicator_CheckedChanged(object sender, EventArgs e) {
            if (chkBatteryIndicator.Enabled) {
                btnLEDColor.Enabled = !chkBatteryIndicator.Checked;
                Global.setLedAsBatteryIndicator(device, chkBatteryIndicator.Checked);
            }
        }

        private void chkBatteryFlash_CheckedChanged(object sender, EventArgs e) {
            if (chkBatteryFlash.Enabled) {
                Global.setFlashWhenLowBattery(device, chkBatteryFlash.Checked);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            RestartServer();
        }

        private void btnLEDColor_Click(object sender, EventArgs e) {
            ColorDialog cd = new ColorDialog();
            ledColor ledc = Global.loadColor(device);

            cd.Color = Color.FromArgb(ledc.red, ledc.green, ledc.blue);

            if (cd.ShowDialog() == DialogResult.OK) {
                Color c = cd.Color;

                Global.saveColor(device, c.R, c.G, c.B);
            }
        }

        private void tbrRumble_Scroll(object sender, EventArgs e) {
            if (tbrRumble.Enabled) {
                rootHub.setRumble(device, (byte)tbrRumble.Value, 0, 0);
            }
        }

        private void tbrSensitivity_Scroll(object sender, EventArgs e) {
            if (tbrSensitivity.Enabled) {
                Global.setTouchSensitivity(device, (byte)tbrSensitivity.Value);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            AboutBetterDS4 frmAbout = new AboutBetterDS4();
            frmAbout.Show();
        }
    }
}
