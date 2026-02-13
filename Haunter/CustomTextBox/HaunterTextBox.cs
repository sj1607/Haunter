using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haunter.CustomTextBox
{
    public class HaunterTextBox : TextBox
    {
        private Color borderColor = Color.FromArgb(114, 44, 133); // purple
        private int borderHeight = 4;

        public HaunterTextBox()
        {
            this.BorderStyle = BorderStyle.None; //Create own border
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;

            
            this.GotFocus += (s, e) => this.Invalidate();
            this.LostFocus += (s, e) => this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Padding = new Padding(0, 0, 0, borderHeight); 
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            const int WM_PAINT = 0x000F;
            if (m.Msg == WM_PAINT)
            {
                using (Graphics g = this.CreateGraphics())
                {
                    int y = this.Height - borderHeight;
                    Color color = this.Focused ? borderColor : Color.Gray;//default border color
                    using (Pen pen = new Pen(color, borderHeight))
                    {
                        g.DrawLine(pen, 0, y+2, this.Width, y+2);
                    }
                }
            }
        }
    }
}
