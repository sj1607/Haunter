using Haunter.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace Haunter.UserControls
{
    public partial class IW5 : UserControl
    {
        MW3 mw3 = new MW3();

        private Main parentForm;

        private uint[] addressesStructure = [MW3.Class1Struc, MW3.Class2Struc, MW3.Class3Struc, MW3.Class4Struc, MW3.Class5Struc, MW3.Class6Struc, MW3.Class7Struc, MW3.Class8Struc, MW3.Class9Struc, MW3.Class10Struc, MW3.Class11Struc, MW3.Class12Struc, MW3.Class13Struc, MW3.Class14Struc, MW3.Class15Struc];

        private uint[] addressesStructurePrivate = [MW3.PrivateClass1Struc, MW3.PrivateClass2Struc, MW3.PrivateClass3Struc, MW3.PrivateClass4Struc, MW3.PrivateClass5Struc];

        private uint[] addressesNames = [MW3.Class1Name, MW3.Class2Name, MW3.Class3Name, MW3.Class4Name, MW3.Class5Name, MW3.Class6Name, MW3.Class7Name, MW3.Class8Name, MW3.Class9Name, MW3.Class10Name, MW3.Class11Name, MW3.Class12Name, MW3.Class13Name, MW3.Class14Name, MW3.Class15Name];

        private uint[] addressesNamesPrivate = [MW3.PrivateClass1Name, MW3.PrivateClass2Name, MW3.PrivateClass3Name, MW3.PrivateClass4Name, MW3.PrivateClass5Name];

        private static readonly string[] weaponsNames = { "=== Pistols ===", "USP .45", "MP412", ".44 MAGNUM", "DESERT EAGLE", "P99", "FIVE SEVEN", "=== Assault Rifles ===", "ACR 6.8", "TYPE 95", "M4A1", "AK-47", "M16A4", "MK14", "G36C", "SCAR-L", "FAD", "CM901", "=== SMGs ===", "MP5", "PM-9", "P90", "PP90M1", "UMP45", "MP7", "=== Machine Pistols ===", "FMG9", "G18", "MP9", "SKORPION", "=== Shotguns ===", "SPAS-12", "AA-12", "STRIKER", "MODEL 1887", "USAS 12", "KSG 12", "=== LMGs ===", "M60E4", "MK46", "PKP PECHENEG", "L86 LSW", "MG36", "=== Sniper Rifles ===", "BARRETT .50CAL", "MSR", "RSASS", "DRAGUNOV", "AS50", "L118A", "=== Launchers & Special ===", "RPG-7", "JAVELIN", "STINGER", "SMAW", "M320 GLM", "RIOT SHIELD", "XM25" };

        private static readonly int[] weaponsIds = { -1, 1, 2, 3, 4, 5, 6, -1, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, -1, 17, 18, 19, 20, 21, 22, -1, 23, 24, 25, 26, -1, 28, 29, 30, 31, 32, 33, -1, 34, 35, 36, 37, 38, -1, 39, 40, 41, 42, 43, 44, -1, 46, 53, 54, 55, 56, 63, 66 };

        private static readonly string[] camoNames = { "NONE", "CLASSIC", "SNOW", "MULTICAM", "DIGITAL URBAN", "HEX", "CHOCO", "SNAKE", "BLUE", "RED", "AUTUMN", "GOLD" };

        private static readonly int[] camoIds = { 0, 1, 2, 3, 4, 5, 6, 8, 10, 11, 12, 13 };

        private static readonly string[] grenadesNames = { "=== Lethal ===", "FRAG", "SEMTEX", "THROWING KNIFE", "BOUNCING BETTY", "CLAYMORE", "C4", "=== Tacticals ===", "FLASH GRENADE", "CONCUSSION GRENADE", "SCRAMBLER", "EMP GRENADE", "SMOKE GRENADE", "TROPHY SYSTEM", "TACTICAL INSERTION", "PORTABLE RADAR" };

        private static readonly int[] grenadesIds = { -1, 108, 107, 106, 109, 102, 101, -1, 110, 112, 75, 117, 111, 114, 131, 76 };

        private static readonly string[] perkNames = { "=== Perk 1 ===", "RECON PRO", "SLEIGHT OF HAND PRO", "BLIND EYE PRO", "EXTREME CONDITIONING PRO", "SCAVENGER PRO", "=== Perk 2 ===", "QUICKDRAW PRO", "BLAST SHIELD PRO", "HARDLINE PRO", "ASSASSIN PRO", "OVERKILL PRO", "=== Perk 3 ===", "MARKSMAN PRO", "STALKER PRO", "SITREP PRO", "STEADY AIM PRO", "DEAD SILENCE PRO" };

        private static readonly int[] perkIds = { -1, 92, 15, 49, 9, 43, -1, 38, 78, 68, 48, 17, -1, 148, 74, 10, 12, 8 };

        private static readonly string[] othersNames = { "=== Death Streaks ===", "JUICED", "REVENGE", "FINAL STAND", "MARTYRDOM", "DEAD MAN'S HAND", "HOLLOW POINTS", "=== Glitches & Tools ===", "BROKEN SHADER (27)", "GRENADE LAUNCHER", "C4 (Other)", "CLAYMORE (Other)", "WEAPON SCRAMBLER", "BROKEN SHADER (51)", "WEAPON TROPHY", "FRAG (Other)", "BROKEN SHADER (58)" };

        private static readonly int[] othersIds = { -1, 118, 124, 120, 119, 125, 126, -1, 27, 45, 47, 49, 50, 51, 52, 57, 58 };

        public IW5(Main main)
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
                mw3TabControl.BackColor = Color.FromArgb(40, 40, 40);
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
                haunterTextBoxPriv1.BackColor = Color.FromArgb(40, 40, 40);
                haunterTextBoxPriv2.BackColor = Color.FromArgb(40, 40, 40);
                haunterTextBoxPriv3.BackColor = Color.FromArgb(40, 40, 40);
                haunterTextBoxPriv4.BackColor = Color.FromArgb(40, 40, 40);
                haunterTextBoxPriv5.BackColor = Color.FromArgb(40, 40, 40);
                haunterTextBoxResult.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxWeapons.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxStringColours.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxWeapons.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxStringColours.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxCamos.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxGrenades.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxPerks.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxPresetClassMW3.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxOthers.BackColor = Color.FromArgb(40, 40, 40);
                comboBox1.BackColor = Color.FromArgb(40, 40, 40);
                comboBox2.BackColor = Color.FromArgb(40, 40, 40);
                comboBox3.BackColor = Color.FromArgb(40, 40, 40);
                comboBox4.BackColor = Color.FromArgb(40, 40, 40);
                comboBox5.BackColor = Color.FromArgb(40, 40, 40);
                comboBox6.BackColor = Color.FromArgb(40, 40, 40);
                comboBox7.BackColor = Color.FromArgb(40, 40, 40);
                iconButton1.BackColor = Color.FromArgb(40, 40, 40);
                iconButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
                iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
                iconButton2.BackColor = Color.FromArgb(40, 40, 40);
                iconButton2.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
                iconButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
                tabPage2.BackColor = Color.FromArgb(40, 40, 40);
                tabPage3.BackColor = Color.FromArgb(40, 40, 40);
                tabPage4.BackColor = Color.FromArgb(40, 40, 40);
                tabPage5.BackColor = Color.FromArgb(40, 40, 40);
                numericUpDownClassIndex.BackColor = Color.FromArgb(40, 40, 40);
                numericUpDown1.BackColor = Color.FromArgb(40, 40, 40);



            }
            else
            {
                mw3TabControl.BackColor = Color.FromArgb(245, 245, 245);
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
                haunterTextBoxPriv1.BackColor = Color.FromArgb(245, 245, 245);
                haunterTextBoxPriv2.BackColor = Color.FromArgb(245, 245, 245);
                haunterTextBoxPriv3.BackColor = Color.FromArgb(245, 245, 245);
                haunterTextBoxPriv4.BackColor = Color.FromArgb(245, 245, 245);
                haunterTextBoxPriv5.BackColor = Color.FromArgb(245, 245, 245);
                haunterTextBoxResult.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxWeapons.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxStringColours.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxWeapons.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxStringColours.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxCamos.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxGrenades.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxPerks.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxPresetClassMW3.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxOthers.BackColor = Color.FromArgb(245, 245, 245);
                comboBox1.BackColor = Color.FromArgb(245, 245, 245);
                comboBox2.BackColor = Color.FromArgb(245, 245, 245);
                comboBox3.BackColor = Color.FromArgb(245, 245, 245);
                comboBox4.BackColor = Color.FromArgb(245, 245, 245);
                comboBox5.BackColor = Color.FromArgb(245, 245, 245);
                comboBox6.BackColor = Color.FromArgb(245, 245, 245);
                comboBox7.BackColor = Color.FromArgb(245, 245, 245);
                iconButton1.BackColor = Color.FromArgb(245, 245, 245);
                iconButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(245, 245, 245);
                iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 245, 245);
                iconButton2.BackColor = Color.FromArgb(245, 245, 245);
                iconButton2.FlatAppearance.MouseDownBackColor = Color.FromArgb(245, 245, 245);
                iconButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 245, 245);
                tabPage3.BackColor = Color.FromArgb(245, 245, 245);
                tabPage4.BackColor = Color.FromArgb(245, 245, 245);
                tabPage5.BackColor = Color.FromArgb(245, 245, 245);
                numericUpDownClassIndex.BackColor = Color.FromArgb(245, 245, 245);
                numericUpDown1.BackColor = Color.FromArgb(40, 40, 40);

            }
        }

        private uint GetSelectedClassStruct()
        {

            if (mw3TabControl.SelectedTab == tabPage2)
            {
                int index = (int)numericUpDownClassIndex.Value - 1;

                if (index < 0 || index >= addressesStructure.Length)
                    throw new Exception("Error");

                return addressesStructure[index];
            }
            else
            {
                int index = (int)numericUpDown1.Value - 1;

                if (index < 0 || index >= addressesStructurePrivate.Length)
                    throw new Exception("Error");

                return addressesStructurePrivate[index];
            }

        }

        bool SendItem(RadioButton rb, int radioIndex, int id)
        {
            if (!rb.Checked) return false;

            switch (radioIndex)
            {
                case 1:
                    mw3.SendMainWeapon(GetSelectedClassStruct(), id);
                    return true;

                case 2:
                    mw3.SendLethal(GetSelectedClassStruct(), id);
                    return true;

                case 3:
                    if (id > 7 || id == 5)
                        parentForm.NotifyToast("Haunter", "Warning for this secondary weapon item, the change is only visual.", ToolTipIcon.Warning);

                    mw3.SendSecondaryWeapon(GetSelectedClassStruct(), id);
                    return true;

                case 4:

                    return true;

                case 5:
                    mw3.SendPerk1(GetSelectedClassStruct(), id);
                    return true;

                case 6:
                    mw3.SendPerk2(GetSelectedClassStruct(), id);
                    return true;

                case 7:
                    mw3.SendPerk3(GetSelectedClassStruct(), id);
                    return true;

                case 8:
                    mw3.SendTactical(GetSelectedClassStruct(), id);
                    return true;

                case 9:
                    mw3.SendDeathStreak(GetSelectedClassStruct(), id);
                    return true;

                case 10:
                    mw3.SendCamo(GetSelectedClassStruct(), id);
                    return true;

                case 11:
                    MW3.GodMode(GetSelectedClassStruct());
                    return true;

                default:
                    return false;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

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

        private void SendClassNamesBtn_Click(object sender, EventArgs e)
        {
            var textBoxes = new[]
            {
                haunterTextBoxClassName1,
                haunterTextBoxClassName2,
                haunterTextBoxClassName3,
                haunterTextBoxClassName4,
                haunterTextBoxClassName5,
                haunterTextBoxClassName6,
                haunterTextBoxClassName7,
                haunterTextBoxClassName8,
                haunterTextBoxClassName9,
                haunterTextBoxClassName10,
                haunterTextBoxClassName11,
                haunterTextBoxClassName12,
                haunterTextBoxClassName13,
                haunterTextBoxClassName14,
                haunterTextBoxClassName15,
            };


            for (int s = 0; s < addressesNames.Length; s++)
            {
                if (!string.IsNullOrWhiteSpace(textBoxes[s].Text))
                {
                    try
                    {
                        Home.console.WriteString(addressesNames[s], textBoxes[s].Text);
                    }
                    catch (Exception ex)
                    {
                        parentForm.NotifyToast("Haunter", ex.Message, ToolTipIcon.Error);
                    }

                }
            }
            parentForm.NotifyToast("Haunter", "Class names sent!", ToolTipIcon.Info);
        }

        private void comboBoxPresetClassMW3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPreset = comboBoxPresetClassMW3.SelectedItem?.ToString() ?? comboBoxPresetClassMW3.Text;
            if (string.IsNullOrWhiteSpace(selectedPreset)) return;

            switch (selectedPreset)
            {
                case "Your Gamertag":
                    for (int i = 0; i < 15; i++)
                    {

                        int colorIndex = (i + 10) % 10;

                        Home.console.WriteString(addressesNames[i], $"#^{colorIndex}{Home.console.GetGamertag(false)}");
                    }

                    break;

                case "Number":
                    for (int i = 0; i < 15; i++)
                    {

                        int colorIndex = (i + 10) % 10;

                        Home.console.WriteString(addressesNames[i], $"#^{colorIndex}{i}");
                    }
                    break;

                case "Haunter":
                    for (int i = 0; i < 15; i++)
                    {

                        int colorIndex = (i + 10) % 10;

                        Home.console.WriteString(addressesNames[i], $"#^{colorIndex}Haunter");
                    }
                    break;

                case "Dash":
                    for (int i = 0; i < 15; i++)
                    {

                        Home.console.WriteString(addressesNames[i], "---------------");
                    }
                    break;

                case "Rainbow":
                    for (int i = 0; i < 15; i++)
                    {

                        Home.console.WriteString(addressesNames[i], "^1R^2a^3i^4n^5b");
                    }
                    break;


                //Thanks Smokey for the idea. (you can do this with almost any localized string, but if the string exceeds the limit, the class names will not be saved) 
                case "EndGame":
                    for (int i = 0; i < 15; i++)
                    {

                        Home.console.WriteString(addressesNames[i], "@MP_ENDED_GAME");
                    }
                    break;
            }

            parentForm.NotifyToast("Haunter", "Class names sent!", ToolTipIcon.Info);
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ButtonsForm buttonsForm = new ButtonsForm();
            buttonsForm.Show();
            buttonsForm.BringToFront();
            buttonsForm.SetTheme();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox5.SelectedIndex;
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
                itemSent |= SendItem(radioButton9, 1, id);
                itemSent |= SendItem(radioButton1, 2, id);
                itemSent |= SendItem(radioButton8, 3, id);
                itemSent |= SendItem(radioButton7, 5, id);
                itemSent |= SendItem(radioButton6, 6, id);
                itemSent |= SendItem(radioButton5, 7, id);
                itemSent |= SendItem(radioButton3, 8, id);
                itemSent |= SendItem(radioButton4, 9, id);
                if (itemSent)
                    parentForm.NotifyToast("Haunter", $"Set Item to {comboBox5.SelectedItem}", ToolTipIcon.Info);
                else
                    parentForm.NotifyToast("Haunter", "Item not sent, check that you have selected a radio button, the status of your console, or that the tool is connected.", ToolTipIcon.Error);

            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox4.SelectedIndex;
            if (index >= 0)
            {
                int id = camoIds[index];

                bool itemSent = false;

                itemSent |= SendItem(radioButton2, 10, id);

                if (itemSent)
                    parentForm.NotifyToast("Haunter", $"Set Item to {comboBox4.SelectedItem}", ToolTipIcon.Info);
                else
                    parentForm.NotifyToast("Haunter", "Item not sent, check that you have selected a radio button, the status of your console, or that the tool is connected.", ToolTipIcon.Error);

            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox3.SelectedIndex;
            if (index >= 0)
            {
                int id = perkIds[index];

                bool itemSent = false;
                itemSent |= SendItem(radioButton9, 1, id);
                itemSent |= SendItem(radioButton1, 2, id);
                itemSent |= SendItem(radioButton8, 3, id);
                itemSent |= SendItem(radioButton7, 5, id);
                itemSent |= SendItem(radioButton6, 6, id);
                itemSent |= SendItem(radioButton5, 7, id);
                itemSent |= SendItem(radioButton3, 8, id);
                itemSent |= SendItem(radioButton4, 9, id);

                if (itemSent)
                    parentForm.NotifyToast("Haunter", $"Set Item to {comboBox3.SelectedItem}", ToolTipIcon.Info);
                else
                    parentForm.NotifyToast("Haunter", "Item not sent, check that you have selected a radio button, the status of your console, or that the tool is connected.", ToolTipIcon.Error);

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox2.SelectedIndex;
            if (index >= 0)
            {
                int id = grenadesIds[index];

                bool itemSent = false;
                itemSent |= SendItem(radioButton9, 1, id);
                itemSent |= SendItem(radioButton1, 2, id);
                itemSent |= SendItem(radioButton8, 3, id);
                itemSent |= SendItem(radioButton7, 5, id);
                itemSent |= SendItem(radioButton6, 6, id);
                itemSent |= SendItem(radioButton5, 7, id);
                itemSent |= SendItem(radioButton3, 8, id);
                itemSent |= SendItem(radioButton4, 9, id);

                if (itemSent)
                    parentForm.NotifyToast("Haunter", $"Set Item to {comboBox2.SelectedItem}", ToolTipIcon.Info);
                else
                    parentForm.NotifyToast("Haunter", "Item not sent, check that you have selected a radio button, the status of your console, or that the tool is connected.", ToolTipIcon.Error);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            if (index >= 0)
            {
                int id = othersIds[index];

                bool itemSent = false;
                itemSent |= SendItem(radioButton9, 1, id);
                itemSent |= SendItem(radioButton1, 2, id);
                itemSent |= SendItem(radioButton8, 3, id);
                itemSent |= SendItem(radioButton7, 5, id);
                itemSent |= SendItem(radioButton6, 6, id);
                itemSent |= SendItem(radioButton5, 7, id);
                itemSent |= SendItem(radioButton3, 8, id);
                itemSent |= SendItem(radioButton4, 9, id);

                if (itemSent)
                    parentForm.NotifyToast("Haunter", $"Set Item to {comboBox1.SelectedItem}", ToolTipIcon.Info);
                else
                    parentForm.NotifyToast("Haunter", "Item not sent, check that you have selected a radio button, the status of your console, or that the tool is connected.", ToolTipIcon.Error);

            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPreset = comboBox7.SelectedItem?.ToString() ?? comboBox7.Text;
            if (string.IsNullOrWhiteSpace(selectedPreset)) return;

            switch (selectedPreset)
            {
                case "Your Gamertag":
                    for (int i = 0; i < 15; i++)
                    {

                        int colorIndex = (i + 10) % 10;

                        Home.console.WriteString(addressesNamesPrivate[i], $"#^{colorIndex}{Home.console.GetGamertag(false)}");
                    }

                    break;

                case "Number":
                    for (int i = 0; i < 15; i++)
                    {

                        int colorIndex = (i + 10) % 10;

                        Home.console.WriteString(addressesNamesPrivate[i], $"#^{colorIndex}{i}");
                    }
                    break;

                case "Haunter":
                    for (int i = 0; i < 15; i++)
                    {

                        int colorIndex = (i + 10) % 10;

                        Home.console.WriteString(addressesNamesPrivate[i], $"#^{colorIndex}Haunter");
                    }
                    break;

                case "Dash":
                    for (int i = 0; i < 15; i++)
                    {

                        Home.console.WriteString(addressesNamesPrivate[i], "---------------");
                    }
                    break;

                case "Rainbow":
                    for (int i = 0; i < 15; i++)
                    {

                        Home.console.WriteString(addressesNamesPrivate[i], "^1R^2a^3i^4n^5b");
                    }
                    break;


                //Thanks Smokey for the idea. (you can do this with almost any localized string, but if the string exceeds the limit, the class names will not be saved) 
                case "EndGame":
                    for (int i = 0; i < 15; i++)
                    {

                        Home.console.WriteString(addressesNamesPrivate[i], "@MP_ENDED_GAME");
                    }
                    break;
            }

            parentForm.NotifyToast("Haunter", "Class names sent!", ToolTipIcon.Info);
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPresetColours = comboBox6.SelectedItem?.ToString() ?? comboBox6.Text;
            if (string.IsNullOrWhiteSpace(selectedPresetColours)) return;

            switch (selectedPresetColours)
            {
                case "Red":
                    haunterTextBox6.Text = "^1";
                    break;

                case "Green":
                    haunterTextBox6.Text = "^2";
                    break;

                case "Yellow":
                    haunterTextBox6.Text = "^3";
                    break;

                case "Blue":
                    haunterTextBox6.Text = "^4";
                    break;

                case "Cyan":
                    haunterTextBox6.Text = "^5";
                    break;

                case "Pink":
                    haunterTextBox6.Text = "^6";
                    break;

                case "White":
                    haunterTextBox6.Text = "^7";
                    break;

                case "Black":
                    haunterTextBox6.Text = "^0";
                    break;
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ButtonsForm buttonsForm = new ButtonsForm();
            buttonsForm.Show();
            buttonsForm.BringToFront();
            buttonsForm.SetTheme();
        }

        private void IW5_Load(object sender, EventArgs e)
        {
            comboBoxWeapons.Items.AddRange(weaponsNames);
            comboBoxCamos.Items.AddRange(camoNames);
            comboBoxGrenades.Items.AddRange(grenadesNames);
            comboBoxPerks.Items.AddRange(perkNames);
            comboBoxOthers.Items.AddRange(othersNames);

            comboBox1.Items.AddRange(othersNames);
            comboBox2.Items.AddRange(grenadesNames);
            comboBox3.Items.AddRange(perkNames);
            comboBox4.Items.AddRange(camoNames);
            comboBox5.Items.AddRange(weaponsNames);
            GetGodModeClass();
        }

        private void GetGodModeClass()
        {
            try
            {
                uint classAddress = GetSelectedClassStruct();

                // On lit l'octet du glitch (le '76')
                // Dans ta séquence "TEST", il est à +0x34
                byte godByte = Home.console.ReadByte(classAddress + 0x34U);

                toggleButton1.CheckedChanged -= toggleButton1_CheckedChanged;

                toggleButton1.Checked = (godByte == 118);

                toggleButton1.CheckedChanged += toggleButton1_CheckedChanged;
            }
            catch { }
        }

        private void toggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                MW3.GodMode(GetSelectedClassStruct());
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            GetGodModeClass();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            var textBoxes = new[]
            {
               haunterTextBoxPriv1,
               haunterTextBoxPriv2,
               haunterTextBoxPriv3,
               haunterTextBoxPriv4,
               haunterTextBoxPriv5,

            };


            for (int s = 0; s < addressesNamesPrivate.Length; s++)
            {
                if (!string.IsNullOrWhiteSpace(textBoxes[s].Text))
                {
                    try
                    {
                        Home.console.WriteString(addressesNamesPrivate[s], textBoxes[s].Text);
                    }
                    catch (Exception ex)
                    {
                        parentForm.NotifyToast("Haunter", ex.Message, ToolTipIcon.Error);
                    }

                }
            }
            parentForm.NotifyToast("Haunter", "Class names sent!", ToolTipIcon.Info);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toggleButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                MW3.GodMode(GetSelectedClassStruct());
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
