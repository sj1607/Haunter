using Haunter.Classes;
using System.Windows.Forms;
using XDevkit;

namespace Haunter.UserControls
{
    public partial class Home : UserControl
    {
        private Main parentForm;

        #region ConnectionVariables
        public static IXboxConsole console;
        public static bool activeConnection;
        public static bool isConnected;
        #endregion

        #region Connection
        private bool Connect()
        {
            try
            {
                IXboxConsole newConnection = console;
                if (newConnection.Connect(out newConnection))
                {
                    activeConnection = true;
                    console = newConnection;
                }
                else
                {
                    activeConnection = false;
                }
                return activeConnection;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                activeConnection = false;
                return false;
            }
        }

        #endregion

        public Home(Main mainForm)
        {
            InitializeComponent();
            parentForm = mainForm;
            try
            {
                if (isConnected)
                {
                    connectBtn.IconColor = Color.Green;
                    connectBtn.IconChar = FontAwesome.Sharp.IconChar.PlugCircleCheck;
                    responseLabel.ForeColor = Color.Lime;
                    responseLabel.Text = "Connected!";
                    reloadInfos();
                    return;
                }

                autoConnect();
            }
            catch 
            {
                parentForm.NotifyToast("Haunter not Connected", "Make sure your console is turned on or hasn't frozen , check that your console is linked to neighborhood or reboot it.", ToolTipIcon.Error);
            }

        }

        private void autoConnect()
        {

            if (Properties.Settings.Default.autoConnect)
            {

                isConnected = Connect();
                if (isConnected)
                {
                    connectBtn.IconColor = Color.Green;
                    connectBtn.IconChar = FontAwesome.Sharp.IconChar.PlugCircleCheck;
                    console.XNotify("Haunter Connected - Made By Littof", 4);
                    parentForm.NotifyToast("Haunter Connected", "Made By Littof", ToolTipIcon.Info);
                    responseLabel.ForeColor = Color.Lime;
                    responseLabel.Text = "Connected!";
                    reloadInfos();
                }
                else
                {
                    parentForm.NotifyToast("Haunter not Connected", "Make sure your console is turned on or hasn't frozen , check that your console is linked to neighborhood or reboot it.", ToolTipIcon.Error);
                    connectBtn.IconColor = Color.Red;
                    connectBtn.IconChar = FontAwesome.Sharp.IconChar.PlugCircleXmark;
                    responseLabel.ForeColor = Color.Red;
                    responseLabel.Text = "Disconnected!";
                }
            }
        }

        public void SetTheme()
        {
            bool isDarkMode = Properties.Settings.Default.darkMode;

            if (isDarkMode)
            {
                this.BackColor = Color.FromArgb(40, 40, 40);
                connectBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
                connectBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
                comboBoxConsole.BackColor = Color.FromArgb(40, 40, 40);
                shutdownBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
                shutdownBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
                haunterTextBoxIP.BackColor = Color.FromArgb(40, 40, 40);
                haunterTextBoxCpuKey.BackColor = Color.FromArgb(40, 40, 40);
                haunterTextBoxTitleID.BackColor = Color.FromArgb(40, 40, 40);
                haunterTextBoxGamertag.BackColor = Color.FromArgb(40, 40, 40);
                reloadInfosBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
                reloadInfosBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            }
            else
            {
                this.BackColor = Color.FromArgb(245, 245, 245);
                connectBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(245, 245, 245);
                connectBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 245, 245);
                comboBoxConsole.BackColor = Color.FromArgb(245, 245, 245);
                shutdownBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(245, 245, 245);
                shutdownBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 245, 245);
                haunterTextBoxIP.BackColor = Color.FromArgb(245, 245, 245);
                haunterTextBoxCpuKey.BackColor = Color.FromArgb(245, 245, 245);
                haunterTextBoxTitleID.BackColor = Color.FromArgb(245, 245, 245);
                haunterTextBoxGamertag.BackColor = Color.FromArgb(245, 245, 245);
                reloadInfosBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(245, 245, 245);
                reloadInfosBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 245, 245);

            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            SetTheme();
        }


        private void connectBtn_Click(object sender, EventArgs e)
        {
            if (isConnected) // if is already connected it leave the function.
                return;

            isConnected = Connect();

            if (isConnected)
            {
                connectBtn.IconColor = Color.Green;
                connectBtn.IconChar = FontAwesome.Sharp.IconChar.PlugCircleCheck;
                console.XNotify("Haunter Connected - Made By Littof", 4);
                parentForm.NotifyToast("Haunter Connected", "Made By Littof", ToolTipIcon.Info);
                responseLabel.ForeColor = Color.Lime;
                responseLabel.Text = "Connected!";
                reloadInfos();
            }
            else
            {
                parentForm.NotifyToast("Haunter not Connected", "Make sure your console is turned on or hasn't frozen , check that your console is linked to neighborhood or reboot it.", ToolTipIcon.Error);
                connectBtn.IconColor = Color.Red;
                connectBtn.IconChar = FontAwesome.Sharp.IconChar.PlugCircleXmark;
                responseLabel.ForeColor = Color.Red;
                responseLabel.Text = "Disconnected!";
            }
        }

        private void shutdownBtn_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                parentForm.NotifyToast("Haunter not Connected", "Make sure your console is turned on or hasn't frozen , check that your console is linked to neighborhood or reboot it.", ToolTipIcon.Error);
                return;
            }

            console.ShutDownConsole();


        }

        private void comboBoxConsole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxConsole.SelectedItem.ToString() == "Reboot Title")
            {
                console.Reboot(null, null, null, XboxRebootFlags.Title);
            }
            else if (comboBoxConsole.SelectedItem.ToString() == "Reboot Console")
            {
                console.Reboot(null, null, null, XboxRebootFlags.Cold);
            }
        }

        private void reloadInfos()
        {
            try
            {
                string ip = console.XboxIP().ToString();
                haunterTextBoxIP.Text = ip;

                string cpukey = console.GetCPUKey().ToString();
                haunterTextBoxCpuKey.Text = cpukey;

                string titleID = console.XamGetCurrentTitleId().ToString("X2");
                haunterTextBoxTitleID.Text = titleID;

                string gt = console.GetGamertag(false);
                if (String.IsNullOrEmpty(gt))
                {
                    gt = "Not Signed!";
                }
                haunterTextBoxGamertag.Text = gt;
            }
            catch (Exception ex)
            {
                parentForm.NotifyToast("Haunter", ex.Message, ToolTipIcon.Error);
            }
        }

        private void reloadInfosBtn_Click(object sender, EventArgs e)
        {
            reloadInfos();
        }

        private void haunterTextBoxIP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
