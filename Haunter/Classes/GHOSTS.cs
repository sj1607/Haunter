using Haunter.UserControls;


/// <summary>
/// Class <c>GHOSTS</c> GOSTS Offsets.
/// </summary>
namespace Haunter.Classes
{
    public class GHOSTS
    {
        // I wrote directly in hex literals because I find it more readable than directly in decimal, and it will save you from having to convert if you are only there for the offsets.  

        //Sorry, but for this game, I only do the first squad, because there are literally 60 default classes and 100 classes if you have the DLCs, that's way too many lol, it bores me.  

        //The offset between each class structure (0x80) 
        private const uint CLASS_SIZE_OFFSET = 0x80U;

        private const uint SQUAD_NAME_OFFSET = 0x83584891U;

        // PUBLIC CLASS STRUCTURE 

        // Class 1 : 0x835845A8
        private const uint CLASS1_STRUC = 0x835845A8U;

        // Class 2: 0x835845A8 + 0x80 = 0x83584628
        private const uint CLASS2_STRUC = CLASS1_STRUC + (1 * CLASS_SIZE_OFFSET);

        // Class 3: 0x835845A8 + 0x100 = 0x835846A8
        private const uint CLASS3_STRUC = CLASS1_STRUC + (2 * CLASS_SIZE_OFFSET);

        // Class 4: 0x835845A8 + 0x180 = 0x83584728
        private const uint CLASS4_STRUC = CLASS1_STRUC + (3 * CLASS_SIZE_OFFSET);

        // Class 5: 0x835845A8 + 0x200 = 0x835847A8
        private const uint CLASS5_STRUC = CLASS1_STRUC + (4 * CLASS_SIZE_OFFSET);

        // Class 6: 0x835845A8 + 0x280 = 0x83584828
        private const uint CLASS6_STRUC = CLASS1_STRUC + (5 * CLASS_SIZE_OFFSET);

        // Class 7: 0x835845A8 + 0x300 = 0x835848A8
        private const uint CLASS7_STRUC = CLASS1_STRUC + (6 * CLASS_SIZE_OFFSET);

        // Class 8: 0x835845A8 + 0x380 = 0x83584928
        private const uint CLASS8_STRUC = CLASS1_STRUC + (7 * CLASS_SIZE_OFFSET);

        // Class 9: 0x835845A8 + 0x400 = 0x835849A8
        private const uint CLASS9_STRUC = CLASS1_STRUC + (8 * CLASS_SIZE_OFFSET);

        // Class 10: 0x835845A8 + 0x480 = 0x83584A28
        private const uint CLASS10_STRUC = CLASS1_STRUC + (9 * CLASS_SIZE_OFFSET);


        // PUBLIC CLASS NAMES 


        // Class 1 Name : 0x83584593
        private const uint CLASS1_NAME = 0x83584593U;

        // Class 2 Name : 0x83584593 + 0x80 = 0x83584613
        private const uint CLASS2_NAME = CLASS1_NAME + (1 * CLASS_SIZE_OFFSET);

        // Class 3 Name : 0x83584593 + 0x100 = 0x83584693
        private const uint CLASS3_NAME = CLASS1_NAME + (2 * CLASS_SIZE_OFFSET);

        // Class 4 Name : 0x83584593 + 0x180 = 0x83584713
        private const uint CLASS4_NAME = CLASS1_NAME + (3 * CLASS_SIZE_OFFSET);

        // Class 5 Name : 0x83584593 + 0x200 = 0x83584793
        private const uint CLASS5_NAME = CLASS1_NAME + (4 * CLASS_SIZE_OFFSET);

        // Class 6 Name : 0x83584593 + 0x280 = 0x83584813
        private const uint CLASS6_NAME = CLASS1_NAME + (5 * CLASS_SIZE_OFFSET);

        // Class 7 Name : 0x83584593 + 0x300 = 0x83584893
        private const uint CLASS7_NAME = CLASS1_NAME + (6 * CLASS_SIZE_OFFSET);

        // Class 8 Name : 0x83584593 + 0x380 = 0x83584913
        private const uint CLASS8_NAME = CLASS1_NAME + (7 * CLASS_SIZE_OFFSET);

        // Class 9 Name : 0x83584593 + 0x400 = 0x83584993
        private const uint CLASS9_NAME = CLASS1_NAME + (8 * CLASS_SIZE_OFFSET);

        // Class 10 Name : 0x83584593 + 0x480 = 0x83584A13
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


        // PRIVATE CLASS STRUCTURE 


        // Class 1 : 0x83588B40
        private const uint PRIVATE_CLASS1_STRUC = 0x83588B40U;

        // Class 2: 0x83588B40 + 0x80 = 0x83588BC0
        private const uint PRIVATE_CLASS2_STRUC = PRIVATE_CLASS1_STRUC + (1 * CLASS_SIZE_OFFSET);

        // Class 3  : 0x83588B40 + 0x100 = 0x83588C40
        private const uint PRIVATE_CLASS3_STRUC = PRIVATE_CLASS1_STRUC + (2 * CLASS_SIZE_OFFSET);

        // Class 4  : 0x83588B40 + 0x180 = 0x83588CC0
        private const uint PRIVATE_CLASS4_STRUC = PRIVATE_CLASS1_STRUC + (3 * CLASS_SIZE_OFFSET);

        // Class 5  : 0x83588B40 + 0x200 = 0x83588D40
        private const uint PRIVATE_CLASS5_STRUC = PRIVATE_CLASS1_STRUC + (4 * CLASS_SIZE_OFFSET);

        // Class 6: 0x83588B40 + 0x280 = 0x83588DC0
        private const uint PRIVATE_CLASS6_STRUC = PRIVATE_CLASS1_STRUC + (5 * CLASS_SIZE_OFFSET);


        // PRIVATE CLASS NAMES 


        // Class 1 Name : 0x83588B2B
        private const uint PRIVATE_CLASS1_NAME = 0x83588B2BU;

        // Class 2 Name : 0x83588B2B + 0x80 = 0x83588BAB
        private const uint PRIVATE_CLASS2_NAME = PRIVATE_CLASS1_NAME + (1 * CLASS_SIZE_OFFSET);

        // Class 3 Name : 0x83588B2B + 0x100 = 0x83588C2B
        private const uint PRIVATE_CLASS3_NAME = PRIVATE_CLASS1_NAME + (2 * CLASS_SIZE_OFFSET);

        // Class 4 Name : 0x83588B2B + 0x180 = 0x83588CAB
        private const uint PRIVATE_CLASS4_NAME = PRIVATE_CLASS1_NAME + (3 * CLASS_SIZE_OFFSET);

        // Class 5 Name : 0x83588B2B + 0x200 = 0x83588D2B
        private const uint PRIVATE_CLASS5_NAME = PRIVATE_CLASS1_NAME + (4 * CLASS_SIZE_OFFSET);

        // Class 6 Name : 0x83588B2B + 0x280 = 0x83588DAB
        private const uint PRIVATE_CLASS6_NAME = PRIVATE_CLASS1_NAME + (5 * CLASS_SIZE_OFFSET);

        public static uint PrivateClass1Struc => PRIVATE_CLASS1_STRUC;
        public static uint PrivateClass2Struc => PRIVATE_CLASS2_STRUC;
        public static uint PrivateClass3Struc => PRIVATE_CLASS3_STRUC;
        public static uint PrivateClass4Struc => PRIVATE_CLASS4_STRUC;
        public static uint PrivateClass5Struc => PRIVATE_CLASS5_STRUC;
        public static uint PrivateClass6Struc => PRIVATE_CLASS6_STRUC;


        public static uint PrivateClass1Name => PRIVATE_CLASS1_NAME;
        public static uint PrivateClass2Name => PRIVATE_CLASS2_NAME;
        public static uint PrivateClass3Name => PRIVATE_CLASS3_NAME;
        public static uint PrivateClass4Name => PRIVATE_CLASS4_NAME;
        public static uint PrivateClass5Name => PRIVATE_CLASS5_NAME;
        public static uint PrivateClass6Name => PRIVATE_CLASS6_NAME;


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

        public void SendAttachMainWeapon(uint address, int id)
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

        public void SendAttach2MainWeapon(uint address, int id)
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

        public void SendAttach3MainWeapon(uint address, int id)
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

        public void SendCamo(uint address, int id)
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

        public void SendSecondaryWeapon(uint address, int id)
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

        public void SendAttachSecondaryWeapon(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0x16U, id);
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
                Utils.WriteMem(address + 0x1CU, id);
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
                Utils.WriteMem(address + 0x1EU, id);
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
                Utils.WriteMem(address + 0x5EU, id);
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
                Utils.WriteMem(address + 0x5FU, id);
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
                Utils.WriteMem(address + 0x60U, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void SendPerk4(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0x61U, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void SendPerk5(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0x62U, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void SendPerk6(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0x63U, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void SendPerk7(uint address, int id)
        {
            try
            {
                Utils.WriteMem(address + 0x64U, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void SendPerk8(uint address, int id)
        {
            //for some reason, if you want one eighth perk write 0x3 to address + 0x5FU because it is the same offset as the second perk.
            try
            {
                Utils.WriteMem(address + 0x5FU, id);
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
                Utils.WriteMem(address + 0x32U, id);
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
                Utils.WriteMem(address + 0x34U, id);
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
                Utils.WriteMem(address + 0x36U, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
