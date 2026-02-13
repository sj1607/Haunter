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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;


namespace Haunter.UserControls
{

    public partial class IW4 : UserControl
    {
        private static readonly string[] weaponsNames = { "=== Sidearms ===", "M93 RAFFICA", "M9", "USP .45", "DESERT EAGLE", "GOLD DESERT EAGLE", ".44 MAGNUM", "G18", "=== Assault Rifles ===", "AK-47", "M16A4", "M4A1", "F2000", "FAMAS", "FAL", "SCAR-H", "TAR-21", "ACR", "=== SMGs ===", "MP5K", "MINI UZI", "P90", "VECTOR", "UMP45", "PP2000", "TMP", "=== Shotguns ===", "M1014", "RANGER", "STRIKER", "AA-12", "MODEL 1887", "SPAS-12", "=== LMGs ===", "RPD", "L86 LSW", "AUG HBAR", "MG4", "M240", "=== Sniper Rifles ===", "BARRET .50CAL", "INTERVENTION", "M21 EBR", "WA2000", "=== Equipment & Launchers ===", "GRENADE", "RPG-7 x2", "C4", "CLAYMORE", "JAVELIN", "STINGER", "AT4-HS", "THUMPER x2", "=== Lethal Grenades ===", "FRAG", "FLASH GRENADE", "SMOKE GRENADE", "STUN GRENADE", "=== Specialty & Other ===", "NOTHING", "RIOT SHIELD", "THROWING KNIFE", "ONE MAN ARMY" };

        private static readonly int[] weaponsIds = { -1, 1, 2, 3, 4, 5, 6, 7, -1, 8, 12, 13, 14, 15, 16, 17, 18, 19, -1, 20, 21, 22, 23, 24, 25, 26, -1, 27, 28, 29, 30, 31, 32, -1, 33, 34, 35, 36, 37, -1, 38, 39, 40, 41, -1, 42, 43, 44, 46, 47, 48, 49, 50, -1, 51, 53, 54, 55, -1, 52, 57, 58, 59 };


        private static readonly string[] attachmentNames = { "NONE", "GRENADE LAUNCHER", "RED DOT SIGHT", "SILENCER", "ACOG SCOPE", "GRIP", "AKIMBO", "THERMAL", "SHOTGUN", "HEARTBEAT SENSOR", "FMJ", "EXTENDED MAGS", "RAPID FIRE", "IDK", "HOLOGRAPHIC SIGHT", "TACTICAL KNIFE" };

        private static readonly int[] attachmentIds = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };


        private static readonly string[] camoNames = { "NONE", "DESERT", "WOODLAND", "DIGITAL", "RED TIGER", "BLUE TIGER", "ARTIC", "URBAN", "FALL" };

        private static readonly int[] camoIds = [0, 1, 2, 3, 4, 5, 8, 9, 10];


        private static readonly string[] grenadesNames = { "FRAG", "SEMTEX", "THROWING KNIFE", "TACTICAL INSERTION", "BLAST SHIELD", "CLAYMORE", "C4", "FLASH GRENADE x2", "STUN GRENADE x2", "SMOKE GRENADE x1" };

        private static readonly int[] grenadesIds = { 89, 88, 87, 58, 26, 83, 82, 53, 55, 54 };


        private static readonly string[] perkNames = new string[] { "MARATHON PRO", "SLEIGHT OF HAND PRO", "SCAVENGER PRO", "BLING PRO", "ONE MAN ARMY PRO", "STOPPING POWER PRO", "LIGHTWEIGHT PRO", "HARDLINE PRO", "COLD-BLOODED PRO", "DANGER CLOSE PRO", "COMMANDO PRO", "STEADY AIM PRO", "SCRAMBLER PRO", "NINJA PRO", "SITREP PRO", "LAST STAND PRO" };

        private static readonly int[] perkIds = new int[] { 55, 19, 49, 64, 61, 14, 40, 76, 54, 11, 63, 16, 35, 65, 10, 12 };


        private static readonly string[] deathStreakNames = new string[] { "COPYCAT", "PAINKILLER", "MARTYDOM", "FINAL STAND" };

        private static readonly int[] deathStreakIds = new int[] { 96, 77, 13, 41 };


        // Its in an array, so its easier to use.
        private uint[] addressesNames = [MW2.Class1Name, MW2.Class2Name, MW2.Class3Name, MW2.Class4Name, MW2.Class5Name, MW2.Class6Name, MW2.Class7Name, MW2.Class8Name, MW2.Class9Name, MW2.Class10Name];

        private uint[] addressesStructure = [MW2.Class1Struc, MW2.Class2Struc, MW2.Class3Struc, MW2.Class4Struc, MW2.Class5Struc, MW2.Class6Struc, MW2.Class7Struc, MW2.Class8Struc, MW2.Class9Struc, MW2.Class10Struc];

        MW2 mw2 = new MW2();
        private Main parentForm;

        public IW4(Main main)
        {
            InitializeComponent();
            parentForm = main;
            SetTheme();
        }


        private void IW4_Load(object sender, EventArgs e)
        {
            comboBoxWeapons.Items.AddRange(weaponsNames);
            comboBoxAttach.Items.AddRange(attachmentNames);
            comboBoxCamos.Items.AddRange(camoNames);
            comboBoxGrenades.Items.AddRange(grenadesNames);
            comboBoxPerks.Items.AddRange(perkNames);
            comboBoxDeathStreaks.Items.AddRange(deathStreakNames);
        }

        bool SendItem(RadioButton rb, int radioIndex, int id)
        {
            if (!rb.Checked) return false;

            switch (radioIndex)
            {
                case 1:
                    mw2.SendMainWeapon(GetSelectedClassStruct(), id);
                    return true;

                case 2:
                    mw2.SendAttachMainWeapon(GetSelectedClassStruct(), id);
                    return true;

                case 3:
                    if (id > 7 || id == 5)
                        parentForm.NotifyToast("Haunter", "Warning for this secondary weapon item, the change is only visual.", ToolTipIcon.Warning);

                    mw2.SendSecondaryWeapon(GetSelectedClassStruct(), id);
                    return true;

                case 4:
                    mw2.SendAttachSecondaryWeapon(GetSelectedClassStruct(), id);
                    return true;

                case 5:
                    mw2.SendPerk1(GetSelectedClassStruct(), id);
                    return true;

                case 6:
                    mw2.SendPerk2(GetSelectedClassStruct(), id);
                    return true;

                case 7:
                    mw2.SendPerk3(GetSelectedClassStruct(), id);
                    return true;

                case 8:
                    mw2.SendTactical(GetSelectedClassStruct(), id);
                    return true;

                case 9:
                    mw2.SendEquipement(GetSelectedClassStruct(), id);
                    return true;

                case 10:
                    mw2.SendCamo(GetSelectedClassStruct(), id);
                    return true;

                case 11:
                    mw2.SendDeathStreak(GetSelectedClassStruct(), id);
                    return true;

                default:
                    return false;
            }
        }


        private uint GetSelectedClassStruct()
        {
            int index = (int)numericUpDownClassIndex.Value - 1;

            if (index < 0 || index >= addressesStructure.Length)
                throw new Exception("Error");

            return addressesStructure[index];
        }

        private void comboBoxItems_SelectedIndexChanged(object sender, EventArgs e)
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
                itemSent |= SendItem(primaryAttachRadio, 2, id);
                itemSent |= SendItem(secondaryRadio, 3, id);
                itemSent |= SendItem(secondaryAttachRadio, 4, id);
                itemSent |= SendItem(perk1Radio, 5, id);
                itemSent |= SendItem(perk2Radio, 6, id);
                itemSent |= SendItem(perk3Radio, 7, id);
                itemSent |= SendItem(tacticalRadio, 8, id);
                itemSent |= SendItem(GrenadeRadio, 9, id);
                itemSent |= SendItem(CamoRadio, 10, id);
                itemSent |= SendItem(DeathStreakRadio, 11, id);
                if (itemSent)
                    parentForm.NotifyToast("Haunter", $"Set Item to {comboBoxWeapons.SelectedItem}", ToolTipIcon.Info);
                else
                    parentForm.NotifyToast("Haunter", "Item not sent, check that you have selected a radio button, the status of your console, or that the tool is connected.", ToolTipIcon.Error);

            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }



        private void comboBoxItems_SelectedIndexChanged_1(object sender, EventArgs e)
        {

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
                haunterTextBoxClassName10
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

        private void comboBoxPresetClassMW2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPreset = comboBoxPresetClassMW2.SelectedItem?.ToString() ?? comboBoxPresetClassMW2.Text;
            if (string.IsNullOrWhiteSpace(selectedPreset)) return;

            switch (selectedPreset)
            {
                case "Your Gamertag":
                    for (int i = 0; i < 10; i++)
                    {

                        int colorIndex = (i + 10) % 10;

                        Home.console.WriteString(addressesNames[i], $"#^{colorIndex}{Home.console.GetGamertag(false)}");
                    }

                    break;

                case "Number":
                    for (int i = 0; i < 10; i++)
                    {

                        int colorIndex = (i + 10) % 10;

                        Home.console.WriteString(addressesNames[i], $"#^{colorIndex}{i}");
                    }
                    break;

                case "Haunter":
                    for (int i = 0; i < 10; i++)
                    {

                        int colorIndex = (i + 10) % 10;

                        Home.console.WriteString(addressesNames[i], $"#^{colorIndex}Haunter");
                    }
                    break;

                case "Dash":
                    for (int i = 0; i < 10; i++)
                    {

                        Home.console.WriteString(addressesNames[i], "---------------");
                    }
                    break;

                case "Rainbow":
                    for (int i = 0; i < 10; i++)
                    {

                        Home.console.WriteString(addressesNames[i], "^1R^2a^3i^4n^5b");
                    }
                    break;


                //Thanks Smokey for the idea. (you can do this with almost any localized string, but if the string exceeds the limit, the class names will not be saved) 
                case "EndGame":
                    for (int i = 0; i < 10; i++)
                    {

                        Home.console.WriteString(addressesNames[i], "@MP_ENDED_GAME");
                    }
                    break;
            }

            parentForm.NotifyToast("Haunter", "Class names sent!", ToolTipIcon.Info);
        }

        private void comboBoxAttach_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxAttach.SelectedIndex;
            if (index >= 0)
            {
                int id = attachmentIds[index];

                bool itemSent = false;
                itemSent |= SendItem(primaryAttachRadio, 2, id);
                itemSent |= SendItem(secondaryAttachRadio, 4, id);

                if (itemSent)
                    parentForm.NotifyToast("Haunter", $"Set Item to {comboBoxAttach.SelectedItem}", ToolTipIcon.Info);
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
                itemSent |= SendItem(tacticalRadio, 8, id);
                itemSent |= SendItem(GrenadeRadio, 9, id);

                if (itemSent)
                    parentForm.NotifyToast("Haunter", $"Set Item to {comboBoxGrenades.SelectedItem}", ToolTipIcon.Info);
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

        private void comboBoxDeathStreaks_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxDeathStreaks.SelectedIndex;
            if (index >= 0)
            {
                int id = deathStreakIds[index];

                bool itemSent = false;
                itemSent |= SendItem(DeathStreakRadio, 11, id);
                if (itemSent)
                    parentForm.NotifyToast("Haunter", $"Set Item to {comboBoxDeathStreaks.SelectedItem}", ToolTipIcon.Info);
                else
                    parentForm.NotifyToast("Haunter", "Item not sent, check that you have selected a radio button, the status of your console, or that the tool is connected.", ToolTipIcon.Error);

            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ButtonsForm buttonsForm = new ButtonsForm();
            buttonsForm.Show();
            buttonsForm.BringToFront();
            buttonsForm.SetTheme();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        public void SetTheme()
        {
            bool isDarkMode = Properties.Settings.Default.darkMode;
            if (isDarkMode)
            {
                this.BackColor = Color.FromArgb(40, 40, 40);
                mw2TabControl.BackColor = Color.FromArgb(40, 40, 40);
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
                comboBoxAttach.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxCamos.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxGrenades.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxPerks.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxPresetClassMW2.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxDeathStreaks.BackColor = Color.FromArgb(40, 40, 40);
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
                mw2TabControl.BackColor = Color.FromArgb(245, 245, 245);
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
                comboBoxAttach.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxCamos.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxGrenades.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxPerks.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxPresetClassMW2.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxDeathStreaks.BackColor = Color.FromArgb(245, 245, 245);
                iconButton1.BackColor = Color.FromArgb(245, 245, 245);
                iconButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(245, 245, 245);
                iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 245, 245);
                tabPage1.BackColor = Color.FromArgb(245, 245, 245);
                numericUpDownClassIndex.BackColor = Color.FromArgb(245, 245, 245);

            }
        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void numericUpDownClassIndex_ValueChanged(object sender, EventArgs e)
        {

        }

        private void primaryRadio_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
