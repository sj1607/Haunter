

using Haunter.UserControls;

namespace Haunter.Classes
{

    /// <summary>
    /// Class <c>AW</c> AW Offsets.
    /// </summary>
    public class AW
    {
        // I wrote directly in hex literals because I find it more readable than directly in decimal, and it will save you from having to convert if you are only there for the offsets.  

        //The offset between each class structure (0x80) 
        private const uint CLASS_SIZE_OFFSET = 0x80U;

        // PUBLIC CLASS STRUCTURE 

        // Class 1 : 0x83A70F0D
        private const uint CLASS1_STRUC = 0x83A70F0DU;

        // Class 2: 0x83A70F0D + 0x80 = 0x83A70F8D
        private const uint CLASS2_STRUC = CLASS1_STRUC + (1 * CLASS_SIZE_OFFSET);

        // Class 3: 0x83A70F0D + 0x100 = 0x83A7100D
        private const uint CLASS3_STRUC = CLASS1_STRUC + (2 * CLASS_SIZE_OFFSET);

        // Class 4: 0x83A70F0D + 0x180 = 0x83A7108D
        private const uint CLASS4_STRUC = CLASS1_STRUC + (3 * CLASS_SIZE_OFFSET);

        // Class 5: 0x83A70F0D + 0x200 = 0x83A7110D
        private const uint CLASS5_STRUC = CLASS1_STRUC + (4 * CLASS_SIZE_OFFSET);

        // Class 6: 0x83A70F0D + 0x280 = 0x83A7118D
        private const uint CLASS6_STRUC = CLASS1_STRUC + (5 * CLASS_SIZE_OFFSET);

        // Class 7: 0x83A70F0D + 0x300 = 0x83A7120D
        private const uint CLASS7_STRUC = CLASS1_STRUC + (6 * CLASS_SIZE_OFFSET);

        // Class 8: 0x83A70F0D + 0x380 = 0x83A7128D
        private const uint CLASS8_STRUC = CLASS1_STRUC + (7 * CLASS_SIZE_OFFSET);

        // Class 9: 0x83A70F0D + 0x400 = 0x83A7130D
        private const uint CLASS9_STRUC = CLASS1_STRUC + (8 * CLASS_SIZE_OFFSET);

        // Class 10: 0x83A70F0D + 0x480 = 0x83A7138D
        private const uint CLASS10_STRUC = CLASS1_STRUC + (9 * CLASS_SIZE_OFFSET);

        // Class 11: 0x83A70F0D + 0x500 = 0x83A7140D
        private const uint CLASS11_STRUC = CLASS1_STRUC + (10 * CLASS_SIZE_OFFSET);

        // Class 12: 0x83A70F0D + 0x580 = 0x83A7148D
        private const uint CLASS12_STRUC = CLASS1_STRUC + (11 * CLASS_SIZE_OFFSET);

        // Class 13: 0x83A70F0D + 0x600 = 0x83A7150D
        private const uint CLASS13_STRUC = CLASS1_STRUC + (12 * CLASS_SIZE_OFFSET);

        // Class 14: 0x83A70F0D + 0x680 = 0x83A7158D
        private const uint CLASS14_STRUC = CLASS1_STRUC + (13 * CLASS_SIZE_OFFSET);

        // Class 15: 0x83A70F0D + 0x700 = 0x83A7160D
        private const uint CLASS15_STRUC = CLASS1_STRUC + (14 * CLASS_SIZE_OFFSET);


        // PUBLIC CLASS NAMES 


        // Class 1 Name : 0x83A70F2D
        private const uint CLASS1_NAME = 0x83A70F2DU;

        // Class 2 Name : 0x83A70F2D + 0x80 = 0x83A70FAD
        private const uint CLASS2_NAME = CLASS1_NAME + (1 * CLASS_SIZE_OFFSET);

        // Class 3 Name : 0x83A70F2D + 0x100 = 0x83A7102D
        private const uint CLASS3_NAME = CLASS1_NAME + (2 * CLASS_SIZE_OFFSET);

        // Class 4 Name : 0x83A70F2D + 0x180 = 0x83A710AD
        private const uint CLASS4_NAME = CLASS1_NAME + (3 * CLASS_SIZE_OFFSET);

        // Class 5 Name : 0x83A70F2D + 0x200 = 0x83A7112D
        private const uint CLASS5_NAME = CLASS1_NAME + (4 * CLASS_SIZE_OFFSET);

        // Class 6 Name : 0x83A70F2D + 0x280 = 0x83A711AD
        private const uint CLASS6_NAME = CLASS1_NAME + (5 * CLASS_SIZE_OFFSET);

        // Class 7 Name : 0x83A70F2D + 0x300 = 0x83A7122D
        private const uint CLASS7_NAME = CLASS1_NAME + (6 * CLASS_SIZE_OFFSET);

        // Class 8 Name : 0x83A70F2D + 0x380 = 0x83A712AD
        private const uint CLASS8_NAME = CLASS1_NAME + (7 * CLASS_SIZE_OFFSET);

        // Class 9 Name : 0x83A70F2D + 0x400 = 0x83A7132D
        private const uint CLASS9_NAME = CLASS1_NAME + (8 * CLASS_SIZE_OFFSET);

        // Class 10 Name : 0x83A70F2D + 0x480 = 0x83A713AD
        private const uint CLASS10_NAME = CLASS1_NAME + (9 * CLASS_SIZE_OFFSET);

        // Class 11 Name : 0x83A70F2D + 0x500 = 0x83A7142D
        private const uint CLASS11_NAME = CLASS1_NAME + (10 * CLASS_SIZE_OFFSET);

        // Class 12 Name : 0x83A70F2D + 0x580 = 0x83A714AD
        private const uint CLASS12_NAME = CLASS1_NAME + (11 * CLASS_SIZE_OFFSET);

        // Class 13 Name : 0x83A70F2D + 0x600 = 0x83A7152D
        private const uint CLASS13_NAME = CLASS1_NAME + (12 * CLASS_SIZE_OFFSET);

        // Class 14 Name : 0x83A70F2D + 0x680 = 0x83A715AD
        private const uint CLASS14_NAME = CLASS1_NAME + (13 * CLASS_SIZE_OFFSET);

        // Class 15 Name : 0x83A70F2D + 0x700 = 0x83A7162D
        private const uint CLASS15_NAME = CLASS1_NAME + (14 * CLASS_SIZE_OFFSET);


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
        public static uint Class11Struc => CLASS11_STRUC;
        public static uint Class12Struc => CLASS12_STRUC;
        public static uint Class13Struc => CLASS13_STRUC;
        public static uint Class14Struc => CLASS14_STRUC;
        public static uint Class15Struc => CLASS15_STRUC;

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
        public static uint Class11Name => CLASS11_NAME;
        public static uint Class12Name => CLASS12_NAME;
        public static uint Class13Name => CLASS13_NAME;
        public static uint Class14Name => CLASS14_NAME;
        public static uint Class15Name => CLASS15_NAME;


        // PRIVATE CLASS STRUCTURE 


        // Class 1 : 0x83A730B1
        private const uint PRIVATE_CLASS1_STRUC = 0x83A730B1U;

        // Class 2: 0x83A730B1 + 0x80 = 0x83A73131
        private const uint PRIVATE_CLASS2_STRUC = PRIVATE_CLASS1_STRUC + (1 * CLASS_SIZE_OFFSET);

        // Class 3  : 0x83A730B1 + 0x100 = 0x83A731B1
        private const uint PRIVATE_CLASS3_STRUC = PRIVATE_CLASS1_STRUC + (2 * CLASS_SIZE_OFFSET);

        // Class 4  : 0x83A730B1 + 0x180 = 0x83A73231
        private const uint PRIVATE_CLASS4_STRUC = PRIVATE_CLASS1_STRUC + (3 * CLASS_SIZE_OFFSET);

        // Class 5  : 0x83A730B1 + 0x200 = 0x83A732B1
        private const uint PRIVATE_CLASS5_STRUC = PRIVATE_CLASS1_STRUC + (4 * CLASS_SIZE_OFFSET);

        // Class 6: 0x83A730B1 + 0x280 = 0x83A73331
        private const uint PRIVATE_CLASS6_STRUC = PRIVATE_CLASS1_STRUC + (5 * CLASS_SIZE_OFFSET);

        // Class 7: 0x83A730B1 + 0x300 = 0x83A733B1
        private const uint PRIVATE_CLASS7_STRUC = PRIVATE_CLASS1_STRUC + (6 * CLASS_SIZE_OFFSET);

        // Class 8: 0x83A730B1 + 0x380 = 0x83A73431
        private const uint PRIVATE_CLASS8_STRUC = PRIVATE_CLASS1_STRUC + (7 * CLASS_SIZE_OFFSET);

        // Class 9: 0x83A730B1 + 0x400 = 0x83A734B1
        private const uint PRIVATE_CLASS9_STRUC = PRIVATE_CLASS1_STRUC + (8 * CLASS_SIZE_OFFSET);

        // Class 10: 0x83A730B1 + 0x480 = 0x83A73531
        private const uint PRIVATE_CLASS10_STRUC = PRIVATE_CLASS1_STRUC + (9 * CLASS_SIZE_OFFSET);

        // Class 11: 0x83A730B1 + 0x500 = 0x83A735B1
        private const uint PRIVATE_CLASS11_STRUC = PRIVATE_CLASS1_STRUC + (10 * CLASS_SIZE_OFFSET);

        // Class 12: 0x83A730B1 + 0x580 = 0x83A73631
        private const uint PRIVATE_CLASS12_STRUC = PRIVATE_CLASS1_STRUC + (11 * CLASS_SIZE_OFFSET);

        // Class 13: 0x83A730B1 + 0x600 = 0x83A736B1
        private const uint PRIVATE_CLASS13_STRUC = PRIVATE_CLASS1_STRUC + (12 * CLASS_SIZE_OFFSET);

        // Class 14: 0x83A730B1 + 0x680 = 0x83A73731
        private const uint PRIVATE_CLASS14_STRUC = PRIVATE_CLASS1_STRUC + (13 * CLASS_SIZE_OFFSET);

        // Class 15: 0x83A730B1 + 0x700 = 0x83A737B1
        private const uint PRIVATE_CLASS15_STRUC = PRIVATE_CLASS1_STRUC + (14 * CLASS_SIZE_OFFSET);


        // PRIVATE CLASS NAMES 


        // Class 1 Name : 0x83A70F2D
        private const uint PRIVATE_CLASS1_NAME = 0x83A730D1U;

        // Class 2 Name : 0x83A730D1 + 0x80 = 0x83A73151
        private const uint PRIVATE_CLASS2_NAME = PRIVATE_CLASS1_NAME + (1 * CLASS_SIZE_OFFSET);

        // Class 3 Name : 0x83A730D1 + 0x100 = 0x83A731D1
        private const uint PRIVATE_CLASS3_NAME = PRIVATE_CLASS1_NAME + (2 * CLASS_SIZE_OFFSET);

        // Class 4 Name : 0x83A730D1 + 0x180 = 0x83A73251
        private const uint PRIVATE_CLASS4_NAME = PRIVATE_CLASS1_NAME + (3 * CLASS_SIZE_OFFSET);

        // Class 5 Name : 0x83A730D1 + 0x200 = 0x83A732D1
        private const uint PRIVATE_CLASS5_NAME = PRIVATE_CLASS1_NAME + (4 * CLASS_SIZE_OFFSET);

        // Class 6 Name : 0x83A730D1 + 0x280 = 0x83A73351
        private const uint PRIVATE_CLASS6_NAME = PRIVATE_CLASS1_NAME + (5 * CLASS_SIZE_OFFSET);

        // Class 7 Name : 0x83A730D1 + 0x300 = 0x83A733D1
        private const uint PRIVATE_CLASS7_NAME = PRIVATE_CLASS1_NAME + (6 * CLASS_SIZE_OFFSET);

        // Class 8 Name : 0x83A730D1 + 0x380 = 0x83A73451
        private const uint PRIVATE_CLASS8_NAME = PRIVATE_CLASS1_NAME + (7 * CLASS_SIZE_OFFSET);

        // Class 9 Name : 0x83A730D1 + 0x400 = 0x83A734D1
        private const uint PRIVATE_CLASS9_NAME = PRIVATE_CLASS1_NAME + (8 * CLASS_SIZE_OFFSET);

        // Class 10 Name : 0x83A730D1 + 0x480 = 0x83A73551
        private const uint PRIVATE_CLASS10_NAME = PRIVATE_CLASS1_NAME + (9 * CLASS_SIZE_OFFSET);

        // Class 11 Name : 0x83A730D1 + 0x500 = 0x83A735D1
        private const uint PRIVATE_CLASS11_NAME = PRIVATE_CLASS1_NAME + (10 * CLASS_SIZE_OFFSET);

        // Class 12 Name : 0x83A730D1 + 0x580 = 0x83A73651
        private const uint PRIVATE_CLASS12_NAME = PRIVATE_CLASS1_NAME + (11 * CLASS_SIZE_OFFSET);

        // Class 13 Name : 0x83A730D1 + 0x600 = 0x83A736D1
        private const uint PRIVATE_CLASS13_NAME = PRIVATE_CLASS1_NAME + (12 * CLASS_SIZE_OFFSET);

        // Class 14 Name : 0x83A730D1 + 0x680 = 0x83A73751
        private const uint PRIVATE_CLASS14_NAME = PRIVATE_CLASS1_NAME + (13 * CLASS_SIZE_OFFSET);

        // Class 15 Name : 0x83A730D1 + 0x700 = 0x83A737D1
        private const uint PRIVATE_CLASS15_NAME = PRIVATE_CLASS1_NAME + (14 * CLASS_SIZE_OFFSET);

        public static uint PrivateClass1Struc => PRIVATE_CLASS1_STRUC;
        public static uint PrivateClass2Struc => PRIVATE_CLASS2_STRUC;
        public static uint PrivateClass3Struc => PRIVATE_CLASS3_STRUC;
        public static uint PrivateClass4Struc => PRIVATE_CLASS4_STRUC;
        public static uint PrivateClass5Struc => PRIVATE_CLASS5_STRUC;
        public static uint PrivateClass6Struc => PRIVATE_CLASS6_STRUC;
        public static uint PrivateClass7Struc => PRIVATE_CLASS7_STRUC;
        public static uint PrivateClass8Struc => PRIVATE_CLASS8_STRUC;
        public static uint PrivateClass9Struc => PRIVATE_CLASS9_STRUC;
        public static uint PrivateClass10Struc => PRIVATE_CLASS10_STRUC;
        public static uint PrivateClass11Struc => PRIVATE_CLASS11_STRUC;
        public static uint PrivateClass12Struc => PRIVATE_CLASS12_STRUC;
        public static uint PrivateClass13Struc => PRIVATE_CLASS13_STRUC;
        public static uint PrivateClass14Struc => PRIVATE_CLASS14_STRUC;
        public static uint PrivateClass15Struc => PRIVATE_CLASS15_STRUC;

        public static uint PrivateClass1Name => PRIVATE_CLASS1_NAME;
        public static uint PrivateClass2Name => PRIVATE_CLASS2_NAME;
        public static uint PrivateClass3Name => PRIVATE_CLASS3_NAME;
        public static uint PrivateClass4Name => PRIVATE_CLASS4_NAME;
        public static uint PrivateClass5Name => PRIVATE_CLASS5_NAME;
        public static uint PrivateClass6Name => PRIVATE_CLASS6_NAME;
        public static uint PrivateClass7Name => PRIVATE_CLASS7_NAME;
        public static uint PrivateClass8Name => PRIVATE_CLASS8_NAME;
        public static uint PrivateClass9Name => PRIVATE_CLASS9_NAME;
        public static uint PrivateClass10Name => PRIVATE_CLASS10_NAME;
        public static uint PrivateClass11Name => PRIVATE_CLASS11_NAME;
        public static uint PrivateClass12Name => PRIVATE_CLASS12_NAME;
        public static uint PrivateClass13Name => PRIVATE_CLASS13_NAME;
        public static uint PrivateClass14Name => PRIVATE_CLASS14_NAME;
        public static uint PrivateClass15Name => PRIVATE_CLASS15_NAME;


        public void SendMainWeapon(uint address, int id)
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

        public void SendAttach2MainWeapon(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0x4U, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void SendAttach3MainWeapon(uint address, int id)
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

        public void SendCamo(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0x8U, id);
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

        public void SendAttach2SecondaryWeapon(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0x10U, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void SendCamoSecondary(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0x14U, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void SendExoLauncher(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0x19U, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void SendExoLauncher2(uint address , bool flag)
        {
            //This is a bool flag for having a second exo launcher, so only 0 or 1
            byte result =  flag ? (byte)1 : (byte)0; 

            try
            {
                Utils.WriteMem(address + 0x1BU, result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        public void SendExoAbility(uint address, int id)
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

        public void SendPerk1(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0x36U, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void SendPerk1_1(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0x38U, id);
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
                Utils.WriteMem(address + 0x3AU, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void SendPerk2_2(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0x3CU, id);
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
                Utils.WriteMem(address + 0x3EU, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void SendPerk3_3(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0x40U, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        public void SendWildCard(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0x3DU, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void SendWildCard2(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0x3FU, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void SendWildCard3(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0x41U, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void SendStreak(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0x74U, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void SendStreak2(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0x82U, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void SendStreak3(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0x90U, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void SendStreak4(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0x98U, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

    }



}
