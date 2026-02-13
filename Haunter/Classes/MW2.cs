using Haunter.UserControls;


namespace Haunter.Classes
{
    /// <summary>
    /// Class <c>MW2</c> MW2 Offsets.
    /// </summary>
    public class MW2
    {
        // I wrote directly in hex literals because I find it more readable than directly in decimal, and it will save you from having to convert if you are only there for the offsets.  

        //The offset between each class structure (0x40) 
        private const uint CLASS_SIZE_OFFSET = 0x40U;

        // Class 1 : 0x831A1180
        private const uint CLASS1_STRUC = 0x831A1180U;

        // Class 2: 0x831A1180 + 0x40 = 0x831A11C0
        private const uint CLASS2_STRUC = CLASS1_STRUC + (1 * CLASS_SIZE_OFFSET);

        // Class 3: 0x831A1180 + 0x80 = 0x831A1200
        private const uint CLASS3_STRUC = CLASS1_STRUC + (2 * CLASS_SIZE_OFFSET);

        // Class 4: 0x831A1180 + 0xC0 = 0x831A1240
        private const uint CLASS4_STRUC = CLASS1_STRUC + (3 * CLASS_SIZE_OFFSET);

        // Class 5: 0x831A1180 + 0x100 = 0x831A1280
        private const uint CLASS5_STRUC = CLASS1_STRUC + (4 * CLASS_SIZE_OFFSET);

        // Class 6: 0x831A1180 + 0x140 = 0x831A12C0
        private const uint CLASS6_STRUC = CLASS1_STRUC + (5 * CLASS_SIZE_OFFSET);

        // Class 7: 0x831A1180 + 0x180 = 0x831A1300
        private const uint CLASS7_STRUC = CLASS1_STRUC + (6 * CLASS_SIZE_OFFSET);

        // Class 8: 0x831A1180 + 0x1C0 = 0x831A1340
        private const uint CLASS8_STRUC = CLASS1_STRUC + (7 * CLASS_SIZE_OFFSET);

        // Class 9: 0x831A1180 + 0x200 = 0x831A1380
        private const uint CLASS9_STRUC = CLASS1_STRUC + (8 * CLASS_SIZE_OFFSET);

        // Class 10: 0x831A1180 + 0x240 = 0x831A13C0
        private const uint CLASS10_STRUC = CLASS1_STRUC + (9 * CLASS_SIZE_OFFSET);


        // CLASS NAMES


        // Class 1 Name : 0x831A11A4
        private const uint CLASS1_NAME = 0x831A11A4U;

        // Class 2 Name : 0x831A11A4 + 0x40 = 0x831A11E4
        private const uint CLASS2_NAME  = CLASS1_NAME + (1 * CLASS_SIZE_OFFSET);

        // Class 3 Name : 0x831A11A4 + 0x80 = 0x831A1224
        private const uint CLASS3_NAME = CLASS1_NAME + (2 * CLASS_SIZE_OFFSET);

        // Class 4 Name : 0x831A11A4 + 0xC0 = 0x831A1264
        private const uint CLASS4_NAME = CLASS1_NAME + (3 * CLASS_SIZE_OFFSET);

        // Class 5 Name : 0x831A11A4 + 0x100 = 0x831A12A4
        private const uint CLASS5_NAME = CLASS1_NAME + (4 * CLASS_SIZE_OFFSET);

        // Class 6 Name : 0x831A11A4 + 0x140 = 0x831A12E4
        private const uint CLASS6_NAME = CLASS1_NAME + (5 * CLASS_SIZE_OFFSET);

        // Class 7 Name : 0x831A11A4 + 0x180 = 0x831A1324
        private const uint CLASS7_NAME = CLASS1_NAME + (6 * CLASS_SIZE_OFFSET);

        // Class 8 Name : 0x831A11A4 + 0x1C0 = 0x831A1364
        private const uint CLASS8_NAME = CLASS1_NAME + (7 * CLASS_SIZE_OFFSET);

        // Class 9 Name : 0x831A11A4 + 0x200 = 0x831A13A4
        private const uint CLASS9_NAME = CLASS1_NAME + (8 * CLASS_SIZE_OFFSET);

        // Class 10 Name : 0x831A11A4 + 0x200 = 0x831A13E4
        private const uint CLASS10_NAME = CLASS1_NAME + (9 * CLASS_SIZE_OFFSET);


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

        public static uint Class1Name => CLASS1_NAME;
        public static uint Class2Name => CLASS2_NAME;
        public static uint Class3Name => CLASS3_NAME;
        public static uint Class4Name => CLASS4_NAME;
        public static uint Class5Name => CLASS5_NAME;
        public static uint Class6Name => CLASS6_NAME;
        public static uint Class7Name => CLASS7_NAME;
        public static uint Class8Name => CLASS8_NAME;
        public static uint Class9Name => CLASS9_NAME;
        public static uint Class10Name => CLASS10_NAME;


        public void SendMainWeapon(uint address ,int id)
        {
            try
            {
                Utils.WriteMem(address, id);
            }
            catch(Exception ex) 
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void SendAttachMainWeapon(uint address, int id)
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

        public void SendCamo(uint address, int id)
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

        public void SendSecondaryWeapon(uint address, int id)
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

        public void SendAttachSecondaryWeapon(uint address, int id)
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
                Utils.WriteMem(address + 0x18U, id);
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
                Utils.WriteMem(address + 0x22U, id);
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
                Utils.WriteMem(address + 0x1AU, id);
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
                Utils.WriteMem(address + 0x1CU, id);
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
                Utils.WriteMem(address + 0x1EU, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void SendDeathStreak(uint address, int id)
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

    }
}
