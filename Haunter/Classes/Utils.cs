using Haunter.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haunter.Classes
{
    public class Utils
    {
        public static void WriteMem(uint address, int value)
        {
            if (value > 65535)
            {
                Home.console.WriteUInt32(address, (uint)value);
            }
            else if (value > 255)
            {
                Home.console.WriteUInt16(address, (ushort)value);
            }
            else
            {
                Home.console.WriteByte(address, (byte)value);
                
            }

        }
    }
}
