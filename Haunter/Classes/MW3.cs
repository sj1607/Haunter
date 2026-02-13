using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haunter.Classes
{
    public class MW3
    {
        //The offset between each class structure (0x62) 
        private const uint CLASS_SIZE_OFFSET = 0x62U;


        // PUBILC CLASS STURCTURE :



        // Class 1 :  0x830A70F4
        private const uint CLASS1_STRUC = 0x830A70F4U;

        // Class 2 : 0x830A70F4 + 0x62 = 0x830A7156
        private const uint CLASS2_STRUC = CLASS1_STRUC + (1 * CLASS_SIZE_OFFSET);

        // Class 3 : 0x830A70F4 + 0xC4 = 0x830A71B8
        private const uint CLASS3_STRUC = CLASS1_STRUC + (2 * CLASS_SIZE_OFFSET);

        // Class 4 : 0x830A70F4 + 0x126 = 0x830A721A
        private const uint CLASS4_STRUC = CLASS1_STRUC + (3 * CLASS_SIZE_OFFSET);

        // Class 5 : 0x830A70F4 + 0x188 = 0x830A727C
        private const uint CLASS5_STRUC = CLASS1_STRUC + (4 * CLASS_SIZE_OFFSET);

        // Class 6 : 0x830A70F4 + 0x1EA = 0x830A72DE
        private const uint CLASS6_STRUC = CLASS1_STRUC + (5 * CLASS_SIZE_OFFSET);

        // Class 7 : 0x830A70F4 + 0x24C = 0x830A7340
        private const uint CLASS7_STRUC = CLASS1_STRUC + (6 * CLASS_SIZE_OFFSET);

        // Class 8 : 0x830A70F4 + 0x2AE = 0x830A73A2
        private const uint CLASS8_STRUC = CLASS1_STRUC + (7 * CLASS_SIZE_OFFSET);

        // Class 9 : 0x830A70F4 + 0x310 = 0x830A7404
        private const uint CLASS9_STRUC = CLASS1_STRUC + (8 * CLASS_SIZE_OFFSET);

        // Class 10 : 0x830A70F4 + 0x372 = 0x830A7466
        private const uint CLASS10_STRUC = CLASS1_STRUC + (9 * CLASS_SIZE_OFFSET);

        // Class 11 : 0x830A70F4 + 0x3D4 = 0x830A74C8
        private const uint CLASS11_STRUC = CLASS1_STRUC + (10 * CLASS_SIZE_OFFSET);

        // Class 12 : 0x830A70F4 + 0x436 = 0x830A752A
        private const uint CLASS12_STRUC = CLASS1_STRUC + (11 * CLASS_SIZE_OFFSET);

        // Class 13 : 0x830A70F4 + 0x498 = 0x830A758C
        private const uint CLASS13_STRUC = CLASS1_STRUC + (12 * CLASS_SIZE_OFFSET);

        // Class 14 : 0x830A70F4 + 0x4FA = 0x830A75EE
        private const uint CLASS14_STRUC = CLASS1_STRUC + (13 * CLASS_SIZE_OFFSET);

        // Class 15 : 0x830A70F4 + 0x55C = 0x830A7650
        private const uint CLASS15_STRUC = CLASS1_STRUC + (14 * CLASS_SIZE_OFFSET);


        // PUBLIC CLASS NAMES 


        // Class 1 Name : 0x830A70F4 + 0x28 = 0x830A711C
        private const uint CLASS1_NAME = 0x830A711CU;

        // Class 2 Name : 0x830A711C + 0x62 = 0x830A717E
        private const uint CLASS2_NAME = CLASS1_NAME + (1 * CLASS_SIZE_OFFSET);

        // Class 3 Name : 0x830A711C + 0xC4 = 0x830A71E0
        private const uint CLASS3_NAME = CLASS1_NAME + (2 * CLASS_SIZE_OFFSET);

        // Class 4 Name : 0x830A711C + 0x126 = 0x830A7242
        private const uint CLASS4_NAME = CLASS1_NAME + (3 * CLASS_SIZE_OFFSET);

        // Class 5 Name : 0x830A711C + 0x188 = 0x830A72A4
        private const uint CLASS5_NAME = CLASS1_NAME + (4 * CLASS_SIZE_OFFSET);

        // Class 6 Name : 0x830A711C + 0x1EA = 0x830A7306
        private const uint CLASS6_NAME = CLASS1_NAME + (5 * CLASS_SIZE_OFFSET);

        // Class 7 Name : 0x830A711C + 0x24C = 0x830A7368
        private const uint CLASS7_NAME = CLASS1_NAME + (6 * CLASS_SIZE_OFFSET);

        // Class 8 Name : 0x830A711C + 0x2AE = 0x830A73CA
        private const uint CLASS8_NAME = CLASS1_NAME + (7 * CLASS_SIZE_OFFSET);

        // Class 9 Name : 0x830A711C + 0x310 = 0x830A742C
        private const uint CLASS9_NAME = CLASS1_NAME + (8 * CLASS_SIZE_OFFSET);

        // Class 10 Name : 0x830A711C + 0x372 = 0x830A748E
        private const uint CLASS10_NAME = CLASS1_NAME + (9 * CLASS_SIZE_OFFSET);

        // Class 11 Name : 0x830A711C + 0x3D4 = 0x830A74F0
        private const uint CLASS11_NAME = CLASS1_NAME + (10 * CLASS_SIZE_OFFSET);

        // Class 12 Name : 0x830A711C + 0x436 = 0x830A7552
        private const uint CLASS12_NAME = CLASS1_NAME + (11 * CLASS_SIZE_OFFSET);

        // Class 13 Name : 0x830A711C + 0x498 = 0x830A75B4
        private const uint CLASS13_NAME = CLASS1_NAME + (12 * CLASS_SIZE_OFFSET);

        // Class 14 Name : 0x830A711C + 0x4FA = 0x830A7616
        private const uint CLASS14_NAME = CLASS1_NAME + (13 * CLASS_SIZE_OFFSET);

        // Class 15 Name : 0x830A711C + 0x55C = 0x830A7678
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


        // Class 1 : 0x830A76B2
        private const uint PRIVATE_CLASS1_STRUC = 0x830A76B2U;

        // Class 2  : 0x830A76B2 + 0x62 = 0x830A7714
        private const uint PRIVATE_CLASS2_STRUC = PRIVATE_CLASS1_STRUC + (1 * CLASS_SIZE_OFFSET);

        // Class 3  : 0x830A76B2 + 0xC4 = 0x830A7776
        private const uint PRIVATE_CLASS3_STRUC = PRIVATE_CLASS1_STRUC + (2 * CLASS_SIZE_OFFSET);

        // Class 4  : 0x830A76B2 + 0x126 = 0x830A77D8
        private const uint PRIVATE_CLASS4_STRUC = PRIVATE_CLASS1_STRUC + (3 * CLASS_SIZE_OFFSET);

        // Class 5  : 0x830A76B2 + 0x188 = 0x830A783A
        private const uint PRIVATE_CLASS5_STRUC = PRIVATE_CLASS1_STRUC + (4 * CLASS_SIZE_OFFSET);



        // PRIVATE CLASS NAMES 


        // Class 1 Name : 0x830A76DA
        private const uint PRIVATE_CLASS1_NAME = 0x830A76DAU;

        // Class 2 Name : 0x830A76DA + 0x62 = 0x830A773C
        private const uint PRIVATE_CLASS2_NAME = PRIVATE_CLASS1_NAME + (1 * CLASS_SIZE_OFFSET);

        // Class 3 Name : 0x830A76DA + 0xC4 = 0x830A779E
        private const uint PRIVATE_CLASS3_NAME = PRIVATE_CLASS1_NAME + (2 * CLASS_SIZE_OFFSET);

        // Class 4 Name : 0x830A76DA + 0x126 = 0x830A7800
        private const uint PRIVATE_CLASS4_NAME = PRIVATE_CLASS1_NAME + (3 * CLASS_SIZE_OFFSET);

        // Class 5 Name : 0x830A76DA + 0x188 = 0x830A7862
        private const uint PRIVATE_CLASS5_NAME = PRIVATE_CLASS1_NAME + (4 * CLASS_SIZE_OFFSET);

        public static uint PrivateClass1Struc => PRIVATE_CLASS1_STRUC;
        public static uint PrivateClass2Struc => PRIVATE_CLASS2_STRUC;
        public static uint PrivateClass3Struc => PRIVATE_CLASS3_STRUC;
        public static uint PrivateClass4Struc => PRIVATE_CLASS4_STRUC;
        public static uint PrivateClass5Struc => PRIVATE_CLASS5_STRUC;

        public static uint PrivateClass1Name => PRIVATE_CLASS1_NAME;
        public static uint PrivateClass2Name => PRIVATE_CLASS2_NAME;
        public static uint PrivateClass3Name => PRIVATE_CLASS3_NAME;
        public static uint PrivateClass4Name => PRIVATE_CLASS4_NAME;
        public static uint PrivateClass5Name => PRIVATE_CLASS5_NAME;



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

        public void SendProficiencyMainWeapon(uint address, int id)
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

        public void SendLethal(uint address, int id)
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
                Utils.WriteMem(address + 0x24U, id);
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
                Utils.WriteMem(address + 0x63U, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public static void GodMode(uint address)
        {
            try
            {
                byte[] godClass = new byte[]
                {
                    0x28, 0x00, 0x09, 0x00, 0x00, 0x00, 0x0D, 0x00, 0x86, 0x00, 0x00, 0x00,
                    0x0E, 0x00, 0x09, 0x00, 0x00, 0x00, 0x0D, 0x00, 0x86, 0x00, 0x00, 0x00,
                    0x6A, 0x00, 0x0F, 0x00, 0x11, 0x00, 0x08, 0x00, 0x00, 0x00, 0x61, 0x00,
                    0x83, 0x00, 0x00, 0x00, 0x54, 0x45, 0x53, 0x54, 0x00, 0x00, 0x00, 0x54,
                    0x20, 0x31, 0x00, 0x00, 0x76, 0x00, 0x20, 0x00, 0x20, 0x00, 0x20, 0x00,
                    0x13, 0x00, 0x14, 0x00, 0x19, 0x00, 0x2D, 0x00, 0x26, 0x00, 0x27, 0x00,
                    0x02, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x06, 0x00, 0x6B, 0x00,
                    0x00, 0x00, 0x00, 0x00
                };

                for(uint i = 0; i < godClass.Length; i++)
                    Utils.WriteMem(address + i, godClass[i]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


    }
}
