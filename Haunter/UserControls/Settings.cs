using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haunter.UserControls
{
    public partial class Settings : UserControl
    {
        public event EventHandler<bool> DarkModeChanged;
        public Settings()
        {
            InitializeComponent();

            startOnBootToggle.Checked = Properties.Settings.Default.setStartup;
            darkModeToggle.Checked = Properties.Settings.Default.darkMode;
            autoConnectToggle.Checked = Properties.Settings.Default.autoConnect;

        }

        private void startOnBootToggle_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.setStartup = startOnBootToggle.Checked;
            Properties.Settings.Default.Save();
            SetStartup(startOnBootToggle.Checked);
        }



        public void SetStartup(bool enable)
        {
            string appName = "Haunter";
            string appPath = Application.ExecutablePath;

            RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);

            if (enable)
                rk.SetValue(appName, appPath);
            else
                rk.DeleteValue(appName, false);

        }

        private void darkModeToggle_CheckedChanged(object sender, EventArgs e)
        {
            bool isDark = darkModeToggle.Checked;
            Properties.Settings.Default.darkMode = isDark;
            Properties.Settings.Default.Save();
            DarkModeChanged?.Invoke(this, isDark);
            if (isDark)
            {
                this.BackColor = Color.FromArgb(40, 40, 40);
            }
            else
            {
                this.BackColor = Color.FromArgb(245, 245, 245);
            }

        }

        private void Settings_Load(object sender, EventArgs e)
        {
            bool isDarkMode = Properties.Settings.Default.darkMode;
            if (isDarkMode)
            {
                this.BackColor = Color.FromArgb(40, 40, 40);
            }
            else
            {
                this.BackColor = Color.FromArgb(245, 245, 245);

            }
        }

        private void autoConnectToggle_CheckedChanged(object sender, EventArgs e)
        {
            bool isAutoConnect = autoConnectToggle.Checked;
            Properties.Settings.Default.autoConnect = isAutoConnect;
            Properties.Settings.Default.Save();

            

        }
    }
}
