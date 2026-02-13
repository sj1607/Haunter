using Haunter.Classes;
using Haunter.UserControls;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Haunter
{
    public partial class Main : Form
    {

        private bool isOpened = true;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        #region UserControls
        private Home home;
        #endregion

        private void Move_Form(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public Main()
        {
            InitializeComponent();
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);

            SetTheme();
            //load the home user control by default
            Home home = new Home(this);
            addUserControls(home);

        }

        //override the OnPaint method to draw a border around the form
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int borderWidth = 3;
            Color borderColor = Color.FromArgb(114, 44, 133);

            using (Pen pen = new Pen(borderColor, borderWidth))
            {

                e.Graphics.DrawRectangle(pen, new Rectangle(borderWidth / 2, borderWidth / 2, this.ClientSize.Width - borderWidth, this.ClientSize.Height - borderWidth));
            }
        }

        private void minimizeStateBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void hamburgerTimer_Tick(object sender, EventArgs e)
        {


            if (isOpened)
            {
                //close
                mainPanel.Width -= 20;
                if (mainPanel.Width <= 90)
                {
                    hamburgerTimer.Stop();
                    isOpened = false;

                }
            }
            else
            {
                //open
                mainPanel.Width += 20;
                if (mainPanel.Width >= 280)
                {
                    hamburgerTimer.Stop();
                    isOpened = true;
                }
            }
        }

        private void hamburgerBtn_Click(object sender, EventArgs e)
        {
            hamburgerTimer.Start();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cod4Btn_Click(object sender, EventArgs e)
        {
            COD4 mw1 = new COD4(this);
            if (!centerPanel.Controls.Contains(mw1))
            {
                addUserControls(mw1);
            }

            mw1.SetTheme();
        }

        private void centerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addUserControls(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;
            centerPanel.Controls.Clear();
            centerPanel.Controls.Add(userControl);
            userControl.BringToFront();

        }

        public void NotifyToast(string title, string message, ToolTipIcon icon)
        {
            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Icon = SystemIcons.Information;
            notifyIcon.Visible = true;
            notifyIcon.BalloonTipTitle = title;
            notifyIcon.BalloonTipText = message;
            notifyIcon.BalloonTipIcon = icon;
            notifyIcon.ShowBalloonTip(3000);
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            addUserControls(settings);
            settings.DarkModeChanged += (s, isDark) =>
            {
                SetTheme();
            };
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {

            if (home == null)
            {
                home = new Home(this);
            }

            if (!centerPanel.Controls.Contains(home))
            {
                addUserControls(home);
            }

            home.SetTheme();// Ensure the theme is updated when switching back to Home
        }

        public void SetTheme()
        {
            bool isDarkMode = Properties.Settings.Default.darkMode;
            if (isDarkMode)
            {
                this.BackColor = Color.FromArgb(40, 40, 40);
                hiddenPanel.BackColor = Color.FromArgb(40, 40, 40);
                giphPictureBox.BackColor = Color.FromArgb(33, 33, 33);
                topPanel.BackColor = Color.FromArgb(33, 33, 33);
                mainPanel.BackColor = Color.FromArgb(33, 33, 33);
                centerPanel.BackColor = Color.FromArgb(40, 40, 40);
                giphPictureBox.Image = Properties.Resources.GiphDarkMode;
                hamburgerBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
                hamburgerBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 33, 33);
                cod4Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
                cod4Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 33, 33);
                homeBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
                homeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 33, 33);
                wawBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
                wawBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 33, 33);
                mw2Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
                mw2Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 33, 33);
                mw3Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
                mw3Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 33, 33);
                bo1Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
                bo1Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 33, 33);
                bo2Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
                bo2Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 33, 33);
                bo3Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
                bo3Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 33, 33);
                ghostsBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
                ghostsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 33, 33);
                awBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
                awBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 33, 33);
                settingsBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
                settingsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 33, 33);




            }
            else
            {

                this.BackColor = Color.FromArgb(245, 245, 245);
                hiddenPanel.BackColor = Color.FromArgb(245, 245, 245);
                giphPictureBox.BackColor = Color.FromArgb(210, 210, 210);
                topPanel.BackColor = Color.FromArgb(210, 210, 210);
                mainPanel.BackColor = Color.FromArgb(210, 210, 210);
                centerPanel.BackColor = Color.FromArgb(245, 245, 245);
                giphPictureBox.Image = Properties.Resources.GiphWhiteMode;
                hamburgerBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 210, 210);
                hamburgerBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 210, 210);
                cod4Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 210, 210);
                cod4Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 210, 210);
                homeBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 210, 210);
                homeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 210, 210);
                wawBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 210, 210);
                wawBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 210, 210);
                mw2Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 210, 210);
                mw2Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 210, 210);
                mw3Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 210, 210);
                mw3Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 210, 210);
                bo1Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 210, 210);
                bo1Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 210, 210);
                bo2Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 210, 210);
                bo2Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 210, 210);
                bo3Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 210, 210);
                bo3Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 210, 210);
                ghostsBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 210, 210);
                ghostsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 210, 210);
                awBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 210, 210);
                awBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 210, 210);
                settingsBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 210, 210);
                settingsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 210, 210);
            }

        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void wawBtn_Click(object sender, EventArgs e)
        {
            T4 waw = new T4(this);
            if (!centerPanel.Controls.Contains(waw))
            {
                addUserControls(waw);
            }
            waw.SetTheme();
        }

        private void hiddenPanel_Paint(object sender, PaintEventArgs e)
        {
            //added an hidden panel to create spacing between Main and panels.
        }

        private void pictureBoxCod4_Click(object sender, EventArgs e)
        {
            COD4 mw1 = new COD4(this);
            if (!centerPanel.Controls.Contains(mw1))
            {
                addUserControls(mw1);
            }

            mw1.SetTheme();
        }

        private void pictureBoxWAW_Click(object sender, EventArgs e)
        {
            T4 waw = new T4(this);
            if (!centerPanel.Controls.Contains(waw))
            {
                addUserControls(waw);
            }
            waw.SetTheme();
        }

        private void mw2Btn_Click(object sender, EventArgs e)
        {
            IW4 mw2 = new IW4(this);
            if (!centerPanel.Controls.Contains(mw2))
            {
                addUserControls(mw2);
            }
        }

        private void bo3Btn_Click(object sender, EventArgs e)
        {

            MessageBox.Show("The servers have shut down in the meantime, and the addresses are dynamic, so it's pointless. I'm not going to bother with such a mediocre game on an old gen, but if anyone is interested, I am making the IDs available.");
            //T7 bo3 = new T7();
            //if (!centerPanel.Controls.Contains(bo3))
            //{
            //    addUserControls(bo3);
            //}

        }

        private void bo1Btn_Click(object sender, EventArgs e)
        {
            T5 bo1 = new T5(this);
            if (!centerPanel.Controls.Contains(bo1))
            {
                addUserControls(bo1);
            }
        }

        private void mw3Btn_Click(object sender, EventArgs e)
        {
            IW5 mw3 = new IW5(this);
            if (!centerPanel.Controls.Contains(mw3))
            {
                addUserControls(mw3);
            }
        }

        private void ghostsBtn_Click(object sender, EventArgs e)
        {

        }

        private void awBtn_Click(object sender, EventArgs e)
        {
            S1 aw = new S1(this);
            if (!centerPanel.Controls.Contains(aw))
            {
                addUserControls(aw);
            }
        }
    }
}
