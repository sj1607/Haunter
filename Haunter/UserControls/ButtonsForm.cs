using System.Configuration;
using System.Runtime.InteropServices;


namespace Haunter.UserControls
{
    public partial class ButtonsForm : Form
    {
        public ButtonsForm()
        {
            InitializeComponent();
        }

        private void exitFormBtn_Click(object sender, EventArgs e)
        {
            ButtonsForm.ActiveForm.Close();
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void Move_Form(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

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

        private void ButtonsForm_Load(object sender, EventArgs e)
        {

        }

        public void SetTheme()
        {
            bool isDarkMode = Properties.Settings.Default.darkMode;
            if (isDarkMode)
            {
                this.BackColor = Color.FromArgb(40, 40, 40);
                exitFormBtn.FlatAppearance.MouseDownBackColor = Color.DimGray;
                exitFormBtn.FlatAppearance.MouseOverBackColor = Color.Gray;
                comboBoxButtons.BackColor = Color.FromArgb(40, 40, 40);
                copyBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
                copyBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);

            }
            else
            {
                this.BackColor = Color.FromArgb(245, 245, 245);
                exitFormBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(245, 245, 245);
                exitFormBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 245, 245);
                comboBoxButtons.BackColor = Color.FromArgb(245, 245, 245);
                copyBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(245, 245, 245);
                copyBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 245, 245);

            }
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            string button = comboBoxButtons.SelectedItem?.ToString();

            switch(button)
            {
                case "A":
                    Clipboard.SetText("\u0001");
                    break;
                case "B":
                    Clipboard.SetText("\u0002");
                    break;
                case "X":
                    Clipboard.SetText("\u0003");
                    break;
                case "Y":
                    Clipboard.SetText("\u0004");
                    break;
                case "LB":
                    Clipboard.SetText("\u0005");
                    break;
                case "RB":
                    Clipboard.SetText("\u0006");
                    break;
                case "LT":
                    Clipboard.SetText("\u0012");
                    break;
                case "RT":
                    Clipboard.SetText("\u0013");
                    break;
                case "DPAD UP":
                    Clipboard.SetText("\u0014");
                    break;
                case "DPAD RIGHT":
                    Clipboard.SetText("\u0017");
                    break;
                case "DPAD DOWN":
                    Clipboard.SetText("\u0015");
                    break;
                case "DPAD LEFT":
                    Clipboard.SetText("\u0016");
                    break;
                case "SELECT":
                    Clipboard.SetText("\u000f");
                    break;
                case "START":
                    Clipboard.SetText("\u000e");
                    break;
                case "L":
                    Clipboard.SetText("\u0010");
                    break;
                case "R":
                    Clipboard.SetText("\u0011");
                    break;
                default:
                    MessageBox.Show("Please select a button from the dropdown menu.", "No Button Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
    }
}
