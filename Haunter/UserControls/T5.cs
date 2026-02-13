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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Haunter.UserControls
{
    public partial class T5 : UserControl
    {
        // Instance of bo1 class 
        BO1 bo1 = new BO1();

        private Main parentForm;

        private static readonly string[] weaponsNames = { "=== Pistols ===", "ASP", "CZ75", "M1911", "MAKAROV", "PYTHON", "ASP DUAL WIELD", "CZ75 DUAL WIELD", "M1911 DUAL WIELD", "MAKAROV DUAL WIELD", "PYTHON DUAL WIELD", "=== SMGs ===", "AK74U", "KIPARIS", "MAC11", "MP5K", "MPL", "PM63", "SPECTRE", "UZI", "SKORPION", "KIPARIS DUAL WIELD", "MAC11 DUAL WIELD", "PM63 DUAL WIELD", "SKORPION DUAL WIELD", "=== Assault Rifles ===", "G11", "GALIL", "M14", "M16", "AK-47", "AUG", "COMMANDO", "ENFIELD", "FAMAS", "FN FAL", "=== Shotguns ===", "STAKEOUT", "OLYMPIA", "SPAS-12", "HS10", "HS10 DUAL WIELD", "=== Sniper Rifles ===", "DRAGUNOV", "L96A1", "PSG1", "WA2000", "=== LMGs ===", "HK21", "M60", "RPK", "STONER63", "=== Special & Launchers ===", "M72 LAW", "RPG", "STRELA-3", "CROSSBOW", "BALLISTIC KNIFE" };

        private static readonly int[] weaponsIds = { -1, 16, 32, 48, 64, 80, 96, 112, 128, 144, 160, -1, 192, 208, 224, 240, 257, 4097, 12289, 16385, 8193, 20481, 24577, 28673, 32769, -1, 258, 4098, 8194, 12290, 40961, 45057, 49153, 53249, 57345, 61441, -1, 259, 4099, 8195, 61442, 12291, -1, 40962, 45058, 49154, 53250, -1, 20482, 24578, 28674, 32770, -1, 20483, 24579, 28675, 32771, 57347 };

        private static readonly string[] camoNames = { "NONE", "DUSTY", "ICE", "RED", "OLIVE", "NEVEDA", "SAHARA", "ERDL", "TIGER", "BERLIN", "WARSAW", "SIBERIA", "YUKON", "WOODLAND", "FLORA", "GOLD" };

        private static readonly int[] camoIds = { 0, 16, 32, 48, 64, 80, 96, 112, 128, 144, 160, 176, 192, 208, 224, 240 };

        private static readonly string[] grenadesNames = { "=== Lethal ===", "FRAG", "SEMTEX", "TOMAHAWK", "=== Tacticals ===", "WILLY PETE", "NOVA GAS", "FLASHBANG", "CONCUSSION", "DECOY", "=== Equipment ===", "CAMERA SPIKE", "C4", "TACTICAL INSERTION", "JAMMER", "MOTION SENSOR", "CLAYMORE" };

        private static readonly int[] grenadesIds = { -1, 61443, 4, 4100, -1, 48, 64, 80, 96, 112, -1, 56324, 44036, 52228, 48132, 60420, 39940 };

        private static readonly string[] perkNames = new string[] { "LIGHTWEIGHT", "SCAVENGER", "GHOST", "FLAK JACKET", "HARDLINE", "HARDENED", "SCOUT", "STEADY AIM", "SLEIGHT OF HAND", "WARLORD", "TACTICAL MASK", "MARATHON", "NINJA", "SECOND CHANCE", "HACKER" };

        private static readonly int[] perkIds = new int[] { 100, 132, 164, 196, 228, 73, 41, 9, 105, 137, 10795, 43562, 51754, 59946, 2603 };

        private static readonly string[] othersNames = new string[] { "STEADY AIM", "SEMTEX", "GRAY", "MILITIA", "LION", "STEADY AIM_2", "HACKER", "BROKEN SHADER", "GUNSHIP", "PLAYER EMBLEM", "CHALLENGES FOR KILLSTREAKS", "TOMAHAWK", "DEMON", "STEADY AIM PRO", "SPIDER", "SCOUT", "MASTERKEY", "SCOUT PRO", "GRENADE LAUNCHER", "HARDENED", "FLAMETHROWER", "HARDENED PRO", "LIGHTWEIGHT", "LIGHTWEIGHT PRO", "SCAVENGER", "SCAVENGER PRO", "GHOST", "GHOST PRO", "FLAK JACKET", "FLAK JACKET PRO", "HARDLINE", "HARDLINE PRO", "KNIFE", "SPY PLANE", "CARE PACKAGE", "RC-XD", "SENTRY GUN PARA", "SENTRY GUN", "SAM TURRET", "SAM TURRET 2", "MORTAR TEAM", "NAPALM STRIKE", "BLACKBIRD", "ATTACK HELICOPTER", "CHOPPER GUNNER", "COUNTER-SPY PLANE", "ROLLING THUNDER", "ATTACK DOGS", "DEATH MACHINE", "VALKYRIE ROCKET PARA", "VALKYRIE ROCKET", "GRIM REAPER", "THE PRESTIGE LEADERBOARD", "CREATE A CLASS" };

        private static readonly int[] othersIds = new int[] { 10, 260, 262, 263, 264, 266, 267, 268, 269, 270, 271, 4100, 4104, 4106, 8200, 8202, 12296, 12298, 16392, 16394, 20488, 20490, 24585, 28681, 32777, 36873, 40969, 45065, 49161, 53257, 57353, 61449, 57355, 4108, 8204, 12300, 16396, 20492, 24588, 28684, 32780, 36876, 40972, 45068, 53260, 57356, 61452, 4109, 8205, 12301, 16397, 20493, 28686, 12302 };

        private uint[] addressesStructure = [BO1.Class1Struc, BO1.Class2Struc, BO1.Class3Struc, BO1.Class4Struc, BO1.Class5Struc, BO1.Class6Struc, BO1.Class7Struc, BO1.Class8Struc, BO1.Class9Struc, BO1.Class10Struc];

        public T5(Main main)
        {
            InitializeComponent();
            parentForm = main;
            SetTheme();
        }



        public void SetTheme()
        {
            bool isDarkMode = Properties.Settings.Default.darkMode;
            if (isDarkMode)
            {
                this.BackColor = Color.FromArgb(40, 40, 40);
                bo1TabControl.BackColor = Color.FromArgb(40, 40, 40);
                tabPage2.BackColor = Color.FromArgb(40, 40, 40);
                haunterTextBoxClassName1.BackColor = Color.FromArgb(40, 40, 40);
                haunterTextBoxClassName2.BackColor = Color.FromArgb(40, 40, 40);
                haunterTextBoxClassName3.BackColor = Color.FromArgb(40, 40, 40);
                haunterTextBoxClassName4.BackColor = Color.FromArgb(40, 40, 40);
                haunterTextBoxClassName5.BackColor = Color.FromArgb(40, 40, 40);
                haunterTextBoxClassName6.BackColor = Color.FromArgb(40, 40, 40);
                haunterTextBoxClassName7.BackColor = Color.FromArgb(40, 40, 40);
                haunterTextBoxClassName8.BackColor = Color.FromArgb(40, 40, 40);
                haunterTextBoxClassName9.BackColor = Color.FromArgb(40, 40, 40);
                haunterTextBoxClassName10.BackColor = Color.FromArgb(40, 40, 40);
                haunterTextBoxResult.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxWeapons.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxStringColours.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxWeapons.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxStringColours.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxCamos.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxGrenades.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxPerks.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxPresetClassBO1.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxOthers.BackColor = Color.FromArgb(40, 40, 40);
                iconButton1.BackColor = Color.FromArgb(40, 40, 40);
                iconButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
                iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
                tabPage1.BackColor = Color.FromArgb(40, 40, 40);
                tabPage2.BackColor = Color.FromArgb(40, 40, 40);
                numericUpDownClassIndex.BackColor = Color.FromArgb(40, 40, 40);



            }
            else
            {
                this.BackColor = Color.FromArgb(245, 245, 245);
                bo1TabControl.BackColor = Color.FromArgb(245, 245, 245);
                tabPage2.BackColor = Color.FromArgb(245, 245, 245);
                haunterTextBoxClassName1.BackColor = Color.FromArgb(245, 245, 245);
                haunterTextBoxClassName2.BackColor = Color.FromArgb(245, 245, 245);
                haunterTextBoxClassName3.BackColor = Color.FromArgb(245, 245, 245);
                haunterTextBoxClassName4.BackColor = Color.FromArgb(245, 245, 245);
                haunterTextBoxClassName5.BackColor = Color.FromArgb(245, 245, 245);
                haunterTextBoxClassName6.BackColor = Color.FromArgb(245, 245, 245);
                haunterTextBoxClassName7.BackColor = Color.FromArgb(245, 245, 245);
                haunterTextBoxClassName8.BackColor = Color.FromArgb(245, 245, 245);
                haunterTextBoxClassName9.BackColor = Color.FromArgb(245, 245, 245);
                haunterTextBoxClassName10.BackColor = Color.FromArgb(245, 245, 245);
                haunterTextBoxResult.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxWeapons.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxStringColours.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxWeapons.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxStringColours.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxCamos.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxGrenades.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxPerks.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxPresetClassBO1.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxOthers.BackColor = Color.FromArgb(245, 245, 245);
                iconButton1.BackColor = Color.FromArgb(245, 245, 245);
                iconButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(245, 245, 245);
                iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 245, 245);
                tabPage1.BackColor = Color.FromArgb(245, 245, 245);
                numericUpDownClassIndex.BackColor = Color.FromArgb(245, 245, 245);

            }
        }

        private uint GetSelectedClassStruct()
        {
            int index = (int)numericUpDownClassIndex.Value - 1;

            if (index < 0 || index >= addressesStructure.Length)
                throw new Exception("Error");

            return addressesStructure[index];
        }

        bool SendItem(RadioButton rb, int radioIndex, int id)
        {
            if (!rb.Checked) return false;

            switch (radioIndex)
            {
                case 1:
                    bo1.SendMainWeapon(GetSelectedClassStruct(), id);
                    return true;

                case 2:
                    bo1.SendLethal(GetSelectedClassStruct(), id);
                    return true;

                case 3:
                    if (id > 7 || id == 5)
                        parentForm.NotifyToast("Haunter", "Warning for this secondary weapon item, the change is only visual.", ToolTipIcon.Warning);

                    bo1.SendSecondaryWeapon(GetSelectedClassStruct(), id);
                    return true;

                case 4:

                    return true;

                case 5:
                    bo1.SendPerk1(GetSelectedClassStruct(), id);
                    return true;

                case 6:
                    bo1.SendPerk2(GetSelectedClassStruct(), id);
                    return true;

                case 7:
                    bo1.SendPerk3(GetSelectedClassStruct(), id);
                    return true;

                case 8:
                    bo1.SendTactical(GetSelectedClassStruct(), id);
                    return true;

                case 9:
                    bo1.SendEquipement(GetSelectedClassStruct(), id);
                    return true;

                case 10:
                    bo1.SendCamo(GetSelectedClassStruct(), id);
                    return true;

                case 11:
                    BO1.GodMode(GetSelectedClassStruct());
                    return true;

                default:
                    return false;
            }
        }

        private void SendClassNamesBtn_Click(object sender, EventArgs e)
        {
            var textBoxes = new[]
            {
                haunterTextBoxClassName1,
                haunterTextBoxClassName2,
                haunterTextBoxClassName3,
                haunterTextBoxClassName4,
                haunterTextBoxClassName5,

            };

            var textBoxesPrestige = new[]
            {
                haunterTextBoxClassName6,
                haunterTextBoxClassName7,
                haunterTextBoxClassName8,
                haunterTextBoxClassName9,
                haunterTextBoxClassName10
            };

            for (int i = 0; i < 5; i++)
            {

                if (!string.IsNullOrWhiteSpace(textBoxes[i].Text))
                {
                    string commandClassNames = $"customclass{i + 1} {textBoxes[i].Text}";
                    bo1.Cbuf_AddText(commandClassNames);
                }


                if (!string.IsNullOrWhiteSpace(textBoxesPrestige[i].Text))
                {
                    string commandPrestigeNames = $"prestigeclass{i + 1} {textBoxesPrestige[i].Text}";
                    bo1.Cbuf_AddText(commandPrestigeNames);
                }
            }

            bo1.Cbuf_AddText(";updategamerprofile;uploadstats;");
            parentForm.NotifyToast("Haunter", "Class names sent!", ToolTipIcon.Info);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPresetClassBO1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPreset = comboBoxPresetClassBO1.SelectedItem?.ToString() ?? comboBoxPresetClassBO1.Text;
            if (string.IsNullOrWhiteSpace(selectedPreset)) return;

            switch (selectedPreset)
            {
                case "Your Gamertag":
                    for (int i = 0; i < 5; i++)
                    {
                        bo1.Cbuf_AddText($"customclass{i + 1} \"#^{i + 1} {Home.console.GetGamertag(false)}\";updategamerprofile;uploadstats;");
                        int colorIndex = (i + 6) % 10;

                        //loop offset for prestige class names
                        int classNumber = i + 6;
                        bo1.Cbuf_AddText($"prestigeclass{i + 1} \"#^{colorIndex}{Home.console.GetGamertag(false)}\";updategamerprofile;uploadstats;");
                    }

                    break;

                case "Number":
                    for (int i = 0; i < 5; i++)
                    {

                        bo1.Cbuf_AddText($"customclass{i + 1} \"#^{i + 1}{i + 1}\";updategamerprofile;uploadstats;");
                        int colorIndex = (i + 6) % 10;

                        //loop offset for prestige class names
                        int classNumber = i + 6;
                        bo1.Cbuf_AddText($"prestigeclass{i + 1} \"#^{colorIndex}{classNumber}\";updategamerprofile;uploadstats;");
                    }
                    break;

                case "Haunter":
                    for (int i = 0; i < 5; i++)
                    {
                        bo1.Cbuf_AddText($"customclass{i + 1} \"#^{i + 1}Haunter\";updategamerprofile;uploadstats;");
                        int colorIndex = (i + 6) % 10;
                        bo1.Cbuf_AddText($"prestigeclass{i + 1} \"#^{colorIndex}Haunter\";updategamerprofile;uploadstats;");
                    }
                    break;

                case "Dash":
                    for (int i = 0; i < 5; i++)
                    {
                        bo1.Cbuf_AddText($"customclass{i + 1} \"---------------\";updategamerprofile;uploadstats;");
                        bo1.Cbuf_AddText($"prestigeclass{i + 1} \"---------------\";updategamerprofile;uploadstats;");
                    }
                    break;

                case "Rainbow":
                    for (int i = 0; i < 5; i++)
                    {
                        bo1.Cbuf_AddText($"customclass{i + 1} \"^1R^2a^3i^4n^5b^6o^7w\";updategamerprofile;uploadstats;");
                        bo1.Cbuf_AddText($"prestigeclass{i + 1} \"^1R^2a^3i^4n^5b^6o^7w\";updategamerprofile;uploadstats;");
                    }
                    break;


                //Thanks Smokey for the idea. (you can do this with almost any localized string, but if the string exceeds the limit, the class names will not be saved) 
                case "EndGame":
                    for (int i = 0; i < 5; i++)
                    {
                        bo1.Cbuf_AddText($"customclass{i + 1} \"@MP_ENDED_GAME\";updategamerprofile;uploadstats;");
                        bo1.Cbuf_AddText($"prestigeclass{i + 1} \"@MP_ENDED_GAME\";updategamerprofile;uploadstats;");
                    }
                    break;
            }
        }

        private void comboBoxStringColours_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPresetColours = comboBoxStringColours.SelectedItem?.ToString() ?? comboBoxStringColours.Text;
            if (string.IsNullOrWhiteSpace(selectedPresetColours)) return;

            switch (selectedPresetColours)
            {
                case "Red":
                    haunterTextBoxResult.Text = "^1";
                    break;

                case "Green":
                    haunterTextBoxResult.Text = "^2";
                    break;

                case "Yellow":
                    haunterTextBoxResult.Text = "^3";
                    break;

                case "Blue":
                    haunterTextBoxResult.Text = "^4";
                    break;

                case "Cyan":
                    haunterTextBoxResult.Text = "^5";
                    break;

                case "Pink":
                    haunterTextBoxResult.Text = "^6";
                    break;

                case "White":
                    haunterTextBoxResult.Text = "^7";
                    break;

                case "Black":
                    haunterTextBoxResult.Text = "^0";
                    break;
            }
        }

        private void buttonsText_Click(object sender, EventArgs e)
        {
            ButtonsForm buttonsForm = new ButtonsForm();
            buttonsForm.Show();
            buttonsForm.BringToFront();
            buttonsForm.SetTheme();
        }

        private void GetGodModeClass()
        {
            try
            {
                uint classAddress = GetSelectedClassStruct();

                byte godByte = Home.console.ReadByte(classAddress);


                toggleButton1.CheckedChanged -= toggleButton1_CheckedChanged;
                toggleButton1.Checked = (godByte < 32);
                toggleButton1.CheckedChanged += toggleButton1_CheckedChanged;
            }
            catch
            {
            }
        }

        private void numericUpDownClassIndex_ValueChanged(object sender, EventArgs e)
        {
            GetGodModeClass();
        }

        private void comboBoxWeapons_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxWeapons.SelectedIndex;
            if (index >= 0)
            {
                int id = weaponsIds[index];
                if (id == -1)
                {
                    //ignore if separator   
                    //comboBoxItems.SelectedIndex = -1;
                    return;
                }

                bool itemSent = false;
                //if items is not a separator
                //check radio buttons checked state and send item
                itemSent |= SendItem(primaryRadio, 1, id);
                itemSent |= SendItem(lethalRadio, 2, id);
                itemSent |= SendItem(secondaryRadio, 3, id);
                itemSent |= SendItem(perk1Radio, 5, id);
                itemSent |= SendItem(perk2Radio, 6, id);
                itemSent |= SendItem(perk3Radio, 7, id);
                itemSent |= SendItem(tacticalRadio, 8, id);
                itemSent |= SendItem(GrenadeRadio, 9, id);
                itemSent |= SendItem(CamoRadio, 10, id);
                if (itemSent)
                    parentForm.NotifyToast("Haunter", $"Set Item to {comboBoxWeapons.SelectedItem}", ToolTipIcon.Info);
                else
                    parentForm.NotifyToast("Haunter", "Item not sent, check that you have selected a radio button, the status of your console, or that the tool is connected.", ToolTipIcon.Error);

            }
        }

        private void comboBoxCamos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxCamos.SelectedIndex;
            if (index >= 0)
            {
                int id = camoIds[index];

                bool itemSent = false;

                itemSent |= SendItem(CamoRadio, 10, id);

                if (itemSent)
                    parentForm.NotifyToast("Haunter", $"Set Item to {comboBoxCamos.SelectedItem}", ToolTipIcon.Info);
                else
                    parentForm.NotifyToast("Haunter", "Item not sent, check that you have selected a radio button, the status of your console, or that the tool is connected.", ToolTipIcon.Error);

            }
        }

        private void comboBoxGrenades_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxGrenades.SelectedIndex;
            if (index >= 0)
            {
                int id = grenadesIds[index];

                bool itemSent = false;
                itemSent |= SendItem(primaryRadio, 1, id);
                itemSent |= SendItem(lethalRadio, 2, id);
                itemSent |= SendItem(secondaryRadio, 3, id);
                itemSent |= SendItem(perk1Radio, 5, id);
                itemSent |= SendItem(perk2Radio, 6, id);
                itemSent |= SendItem(perk3Radio, 7, id);
                itemSent |= SendItem(tacticalRadio, 8, id);
                itemSent |= SendItem(GrenadeRadio, 9, id);
                itemSent |= SendItem(CamoRadio, 10, id);

                if (itemSent)
                    parentForm.NotifyToast("Haunter", $"Set Item to {comboBoxGrenades.SelectedItem}", ToolTipIcon.Info);
                else
                    parentForm.NotifyToast("Haunter", "Item not sent, check that you have selected a radio button, the status of your console, or that the tool is connected.", ToolTipIcon.Error);

            }
        }

        private void comboBoxOthers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxOthers.SelectedIndex;
            if (index >= 0)
            {
                int id = othersIds[index];

                bool itemSent = false;
                itemSent |= SendItem(primaryRadio, 1, id);
                itemSent |= SendItem(lethalRadio, 2, id);
                itemSent |= SendItem(secondaryRadio, 3, id);
                itemSent |= SendItem(perk1Radio, 5, id);
                itemSent |= SendItem(perk2Radio, 6, id);
                itemSent |= SendItem(perk3Radio, 7, id);
                itemSent |= SendItem(tacticalRadio, 8, id);
                itemSent |= SendItem(GrenadeRadio, 9, id);

                if (itemSent)
                    parentForm.NotifyToast("Haunter", $"Set Item to {comboBoxOthers.SelectedItem}", ToolTipIcon.Info);
                else
                    parentForm.NotifyToast("Haunter", "Item not sent, check that you have selected a radio button, the status of your console, or that the tool is connected.", ToolTipIcon.Error);

            }
        }

        private void T5_Load(object sender, EventArgs e)
        {
            comboBoxWeapons.Items.AddRange(weaponsNames);
            comboBoxCamos.Items.AddRange(camoNames);
            comboBoxGrenades.Items.AddRange(grenadesNames);
            comboBoxPerks.Items.AddRange(perkNames);
            comboBoxOthers.Items.AddRange(othersNames);
            GetGodModeClass();
        }

        private void GodModeRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxPerks_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxPerks.SelectedIndex;
            if (index >= 0)
            {
                int id = perkIds[index];

                bool itemSent = false;
                itemSent |= SendItem(primaryRadio, 1, id);
                itemSent |= SendItem(lethalRadio, 2, id);
                itemSent |= SendItem(secondaryRadio, 3, id);
                itemSent |= SendItem(perk1Radio, 5, id);
                itemSent |= SendItem(perk2Radio, 6, id);
                itemSent |= SendItem(perk3Radio, 7, id);
                itemSent |= SendItem(tacticalRadio, 8, id);
                itemSent |= SendItem(GrenadeRadio, 9, id);

                if (itemSent)
                    parentForm.NotifyToast("Haunter", $"Set Item to {comboBoxPerks.SelectedItem}", ToolTipIcon.Info);
                else
                    parentForm.NotifyToast("Haunter", "Item not sent, check that you have selected a radio button, the status of your console, or that the tool is connected.", ToolTipIcon.Error);

            }
        }

        private void toggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                uint classAddress = GetSelectedClassStruct();

                byte valueToWrite = toggleButton1.Checked ? (byte)0 : (byte)32;

                Home.console.WriteByte(classAddress, valueToWrite);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
