using Haunter.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haunter.Classes
{
    public class BO1
    {

        //The offset between each class structure (0x23) 
        private const uint CLASS_SIZE_OFFSET = 0x23U;

        // Class 1 : 0x84085A11
        private const uint CLASS1_STRUC = 0x84085A11U;

        /// Class 2: 0x84085A11 + 0x23 = 0x84085A34
        private const uint CLASS2_STRUC = CLASS1_STRUC + (1 * CLASS_SIZE_OFFSET);

        // Class 3: 0x84085A11 + 0x46 = 0x84085A57
        private const uint CLASS3_STRUC = CLASS1_STRUC + (2 * CLASS_SIZE_OFFSET);

        // Class 4: 0x84085A11 + 0x69 = 0x84085A7A
        private const uint CLASS4_STRUC = CLASS1_STRUC + (3 * CLASS_SIZE_OFFSET);

        // Class 5: 0x84085A11 + 0x8C = 0x84085A9D
        private const uint CLASS5_STRUC = CLASS1_STRUC + (4 * CLASS_SIZE_OFFSET);

        // Class 6: 0x84085A11 + 0xAF = 0x84085AC0
        private const uint CLASS6_STRUC = CLASS1_STRUC + (5 * CLASS_SIZE_OFFSET);

        // Class 7: 0x84085A11 + 0xD2 = 0x84085AE3
        private const uint CLASS7_STRUC = CLASS1_STRUC + (6 * CLASS_SIZE_OFFSET);

        // Class 8: 0x84085A11 + 0xF5 = 0x84085B06
        private const uint CLASS8_STRUC = CLASS1_STRUC + (7 * CLASS_SIZE_OFFSET);

        // Class 9: 0x84085A11 + 0x118 = 0x84085B29
        private const uint CLASS9_STRUC = CLASS1_STRUC + (8 * CLASS_SIZE_OFFSET);

        // Class 10: 0x84085A11 + 0x13B = 0x84085B4C
        private const uint CLASS10_STRUC = CLASS1_STRUC + (9 * CLASS_SIZE_OFFSET);


        public static uint Class1Struc => CLASS1_STRUC;
        public static uint Class2Struc => CLASS2_STRUC;
        public static uint Class3Struc => CLASS3_STRUC;
        public static uint Class4Struc => CLASS4_STRUC;
        public static uint Class5Struc => CLASS5_STRUC;
        public static uint Class6Struc => CLASS6_STRUC;
        public static uint Class7Struc => CLASS7_STRUC;
        public static uint Class8Struc => CLASS8_STRUC;
        public static uint Class9Struc => CLASS9_STRUC;
        public static uint Class10Struc => CLASS10_STRUC;


        //Since changing the class names caused the game to crash with a write, I'm using Cbuf
        public void Cbuf_AddText(string cmd)
        {
            try
            {
                Home.console.CallVoid(0x8233E8D8U, new object[] { 0, cmd });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        // to off godmode class write 0x20 (32 base 10)
        public static void GodMode(uint address , int id = 0)
        {
            try
            {
                Utils.WriteMem(address, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void SendMainWeapon(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0x6U, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        //No attachments for this game, it's too weird. Some have a 0x8 offset, others 0x9, and still others 0xA. I don't feel like checking where each one has which offset.  
        public void SendAttachMainWeapon(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0xAU, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void SendCamo(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0xCU, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

       
        public void SendSecondaryWeapon(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0x13U, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //same 
        public void SendAttachSecondaryWeapon(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0x18U, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void SendLethal(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0xEU, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void SendEquipement(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0x2U, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        public void SendTactical(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0x1FU, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void SendPerk1(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0x20U, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void SendPerk2(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0x21U, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void SendPerk3(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0x22U, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }



    }
}
