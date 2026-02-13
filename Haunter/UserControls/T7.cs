using Haunter.Classes;
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
    
    public partial class T7 : UserControl
    {
        BO3 bo3 = new BO3();
        public T7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bo3.Cbuf_AddText(haunterTextBox1.Text);
            for(int k =0; k < 100; k++)
            {
                Home.console.WriteUInt32(0x83C662CFU, 0xD);
                Thread.Sleep(10);
            }
        }
    }
}
