

namespace Haunter.CustomGroupBox
{
    public class HaunterGroupBox : GroupBox
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);

            int borderWidth = 2;
            Color borderColor = Color.FromArgb(114, 44, 133);

            SizeF textSize = e.Graphics.MeasureString(this.Text, this.Font);
            Rectangle rect = new Rectangle(borderWidth / 2,(int)(textSize.Height / 2),this.ClientSize.Width - borderWidth,this.ClientSize.Height - (int)(textSize.Height / 2) - borderWidth);

            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                // left line
                e.Graphics.DrawLine(pen, rect.Left, rect.Top, rect.Left, rect.Bottom);

                // right line
                e.Graphics.DrawLine(pen, rect.Right, rect.Top, rect.Right, rect.Bottom);

                // down line
                e.Graphics.DrawLine(pen, rect.Left, rect.Bottom, rect.Right, rect.Bottom);

               
                int textStart = 10; 
                int textWidth = (int)textSize.Width + 6;

                
                e.Graphics.DrawLine(pen, rect.Left, rect.Top, rect.Left + textStart, rect.Top);

                //Up line
                e.Graphics.DrawLine(pen, rect.Left + textStart + textWidth, rect.Top, rect.Right, rect.Top);
            }

          
            using (SolidBrush brush = new SolidBrush(this.ForeColor))
            {
                e.Graphics.DrawString(this.Text, this.Font, brush, rect.Left + 10, 0);
            }
        }
    }
}
