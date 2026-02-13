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
    public partial class COD4 : UserControl
    {
        private Main parentForm;

        string[] names = new string[] { "=== Side Arm ===", "M19911 .45", "USP .45", "Desert Eagle", "Gold Desert Eagle", "=== SMG ===", "MP5", "Skorpion", "Mini-Uzi", "AK-74u", "P90", "=== Assault Rifles ===", "AK-47", "M14", "MP44", "G3", "G36C", "M16A4", "M4 Carbine", "=== Snipers ===", "Dragunov", "M40A3", "Barrett .50cal", "R700", "M21", "=== Shotguns ===", "M1014", "W1200", "=== LMGs ===", "RPD", "M240 SAW", "M60E4", "=== Explosives & Grenades ===", "Grenade Launcher", "RPG-7", "C4", "Claymore", "Frag", "Flash Grenade", "Smoke Grenade", "Stun Grenade", "=== Perks ===", "Eavesdrop", "UAV Jammer", "Iron Lungs", "Dead Silence", "Extreme Condition", "Bomb Squad", "Sonic Boom", "Last Stand", "Martyrdom", "Stopping Power", "Deep Impact", "Steady Aim", "Double Tap", "Sleight of Hand", "Bandolier", "Overkill", "Juggernaut", "Frag x3", "Special Grenade", "C4 x2", "Claymore x2", "RPG x2", "=== Attachments ===", "Grenade Launcher", "Grip", "Attachments", "=== Camos ===", "None", "Desert", "Woodland", "Digital", "Red Tiger", "Blue Tiger", "Gold", "=== Others ===", "None", "Demolition", "Sniper", "Create a Class", "Challenges", "Hardcore", "OldSchool", "Clan Tag" };

        // -1 is the separator 
        int[] ids = new int[] { -1, 1, 2, 3, 4, -1, 10, 11, 12, 13, 14, -1, 20, 21, 22, 23, 24, 25, 26, -1, 60, 61, 62, 64, 65, -1, 70, 71, -1, 80, 81, 82, -1, 50, 55, 90, 91, 100, 101, 102, 103, -1, 150, 151, 152, 153, 154, 155, 156, 157, 158, 160, 161, 162, 163, 164, 165, 166, 167, 173, 176, 184, 185, 186, -1, 191, 192, 193, -1, 0, 1, 2, 3, 4, 5, 6, -1, 190, 195, 196, 197, 198, 199, 200, 201 };



        public COD4(Main main)
        {
            InitializeComponent();
            parentForm = main;
        }

        private void Cbuf_AddText(string text)
        {
            if (!Home.isConnected)
            {
                parentForm.NotifyToast("Haunter not Connected", "Make sure your console is turned on or hasn't frozen. Check that your console is linked to Neighborhood or reboot it.", ToolTipIcon.Error);
                return;
            }

            try
            {
                Home.console.CallVoid(2183372752U, new object[] { 0, text });
            }
            catch (Exception ex)
            {
                parentForm.NotifyToast("Haunter", $"Error: {ex.Message}", ToolTipIcon.Error);
            }
        }

        private void COD4_Load(object sender, EventArgs e)
        {
            comboBoxItems.Items.AddRange(names);
            comboBoxItemsClass2.Items.AddRange(names);
            comboBoxItemsClass3.Items.AddRange(names);
            comboBoxItemsClass4.Items.AddRange(names);
            comboBoxItemsClass5.Items.AddRange(names);
        }

        public void SetTheme()
        {
            bool isDarkMode = Properties.Settings.Default.darkMode;
            if (isDarkMode)
            {
                this.BackColor = Color.FromArgb(40, 40, 40);
                cod4TabControl.BackColor = Color.FromArgb(40, 40, 40);
                cod4MainPage.BackColor = Color.FromArgb(40, 40, 40);
                tabPage2.BackColor = Color.FromArgb(40, 40, 40);
                haunterTextBoxClassName1.BackColor = Color.FromArgb(40, 40, 40);
                haunterTextBoxClassName2.BackColor = Color.FromArgb(40, 40, 40);
                haunterTextBoxClassName3.BackColor = Color.FromArgb(40, 40, 40);
                haunterTextBoxClassName4.BackColor = Color.FromArgb(40, 40, 40);
                haunterTextBoxClassName5.BackColor = Color.FromArgb(40, 40, 40);
                haunterTextBoxResult.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxPresetClassCOD4.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxStringColours.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxItems.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxItemsClass2.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxItemsClass3.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxItemsClass4.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxItemsClass5.BackColor = Color.FromArgb(40, 40, 40);
                buttonsText.BackColor = Color.FromArgb(40, 40, 40);
                buttonsText.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
                buttonsText.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
                tabPage1.BackColor = Color.FromArgb(40, 40, 40);
                tabPage3.BackColor = Color.FromArgb(40, 40, 40);
                tabPage4.BackColor = Color.FromArgb(40, 40, 40);
                tabPage5.BackColor = Color.FromArgb(40, 40, 40);



            }
            else
            {
                this.BackColor = Color.FromArgb(245, 245, 245);
                cod4TabControl.BackColor = Color.FromArgb(245, 245, 245);
                cod4MainPage.BackColor = Color.FromArgb(245, 245, 245);
                tabPage2.BackColor = Color.FromArgb(245, 245, 245);
                haunterTextBoxClassName1.BackColor = Color.FromArgb(245, 245, 245);
                haunterTextBoxClassName2.BackColor = Color.FromArgb(245, 245, 245);
                haunterTextBoxClassName3.BackColor = Color.FromArgb(245, 245, 245);
                haunterTextBoxClassName4.BackColor = Color.FromArgb(245, 245, 245);
                haunterTextBoxClassName5.BackColor = Color.FromArgb(245, 245, 245);
                haunterTextBoxResult.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxPresetClassCOD4.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxStringColours.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxItems.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxItemsClass2.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxItemsClass3.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxItemsClass4.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxItemsClass5.BackColor = Color.FromArgb(245, 245, 245);
                buttonsText.BackColor = Color.FromArgb(245, 245, 245);
                buttonsText.FlatAppearance.MouseDownBackColor = Color.FromArgb(245, 245, 245);
                buttonsText.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 245, 245);
                tabPage1.BackColor = Color.FromArgb(245, 245, 245);
                tabPage3.BackColor = Color.FromArgb(245, 245, 245);
                tabPage4.BackColor = Color.FromArgb(245, 245, 245);
                tabPage5.BackColor = Color.FromArgb(245, 245, 245);

            }
        }

        private void cod4MainPage_Click(object sender, EventArgs e)
        {

        }

        private void haunterTextBoxClassName5_TextChanged(object sender, EventArgs e)
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
                haunterTextBoxClassName5
            };



            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(textBoxes[i].Text))
                {
                    string commandClassNames = $"customclass{i + 1} {textBoxes[i].Text}";
                    Cbuf_AddText(commandClassNames);
                }
            }
            Cbuf_AddText(";updategamerprofile;uploadstats;");
            parentForm.NotifyToast("Haunter", "Class names sent!", ToolTipIcon.Info);

        }

        private void comboBoxPresetClassCOD4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPreset = comboBoxPresetClassCOD4.SelectedItem?.ToString() ?? comboBoxPresetClassCOD4.Text;
            if (string.IsNullOrWhiteSpace(selectedPreset)) return;

            switch (selectedPreset)
            {
                case "Your Gamertag":
                    for (int i = 0; i < 5; i++)
                    {
                        Cbuf_AddText($"customclass{i + 1} \"#^{i + 1} {Home.console.GetGamertag(false)}\";updategamerprofile;uploadstats;");
                    }

                    break;

                case "Number":
                    for (int i = 0; i < 5; i++)
                    {
                        Cbuf_AddText($"customclass{i + 1} \"#^{i + 1}{i}\";updategamerprofile;uploadstats;");
                    }
                    break;

                case "Haunter":
                    for (int i = 0; i < 5; i++)
                    {
                        Cbuf_AddText($"customclass{i + 1} \"#^{i + 1}Haunter\";updategamerprofile;uploadstats;");
                    }
                    break;

                case "Dash":
                    for (int i = 0; i < 5; i++)
                    {
                        Cbuf_AddText($"customclass{i + 1} \"---------------\";updategamerprofile;uploadstats;");
                    }
                    break;

                case "Rainbow":
                    for (int i = 0; i < 5; i++)
                    {
                        Cbuf_AddText($"customclass{i + 1} \"^1R^2a^3i^4n^5b^6o^7w\";updategamerprofile;uploadstats;");
                    }
                    break;

                case "Unlocalized":
                    for (int i = 0; i < 5; i++)
                    {
                        Cbuf_AddText($"customclass{i + 1} \"@\";updategamerprofile;uploadstats;");
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


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        void SendItem(RadioButton rb, int statId, int id)
        {
            if (rb.Checked)
                Cbuf_AddText($"statSet {statId} {id}");
        }

        private void comboBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxItems.SelectedIndex;
            if (index >= 0)
            {
                int id = ids[index];
                if (id == -1)
                {
                    //ignore if separator   
                    comboBoxItems.SelectedIndex = -1;
                    return;
                }


                //if items is not a separator
                // get the selected class index via the tab control
                int classindex = cod4TabControl.SelectedIndex;
                switch (classindex)
                {
                    case 1:
                        //check radio buttons checked state and send item
                        SendItem(primaryRadio, 201, id);
                        SendItem(primaryAttachRadio, 202, id);
                        SendItem(secondaryRadio, 203, id);
                        SendItem(secondaryAttachRadio, 204, id);
                        SendItem(perk1Radio, 205, id);
                        SendItem(perk2Radio, 206, id);
                        SendItem(perk3Radio, 207, id);
                        SendItem(specialGrenadeRadio, 208, id);
                        SendItem(camoRadio, 209, id);

                        parentForm.NotifyToast("Haunter", $"Set Item to {comboBoxItems.SelectedItem}", ToolTipIcon.Info);
                        break;
                }
            }
        }

        private void buttonsText_Click(object sender, EventArgs e)
        {
            ButtonsForm buttonsForm = new ButtonsForm();
            buttonsForm.Show();
            buttonsForm.BringToFront();
            buttonsForm.SetTheme();

        }

        private void comboBoxItemsClass2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxItemsClass2.SelectedIndex;
            if (index >= 0)
            {
                int id = ids[index];
                if (id == -1)
                {
                    //ignore if separator   
                    comboBoxItemsClass2.SelectedIndex = -1;
                    return;
                }


                //if items is not a separator
                // get the selected class index via the tab control
                int classindex = cod4TabControl.SelectedIndex;
                switch (classindex)
                {
                    case 2:
                        //check radio buttons checked state and send item
                        SendItem(primaryWeaponClass2Radio, 211, id);
                        SendItem(primaryWeaponAttachClass2Radio, 212, id);
                        SendItem(secondaryClass2Radio, 213, id);
                        SendItem(secondaryClass2Radio, 214, id);
                        SendItem(perk1Class2Radio, 215, id);
                        SendItem(perk2Class2Radio, 216, id);
                        SendItem(perk3Class2Radio, 217, id);
                        SendItem(specialGrenadeClass2Radio, 218, id);
                        SendItem(camoClass2Radio, 219, id);

                        parentForm.NotifyToast("Haunter", $"Set Item to {comboBoxItems.SelectedItem}", ToolTipIcon.Info);
                        break;
                }
            }
        }

        private void comboBoxItemsClass3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxItemsClass3.SelectedIndex;
            if (index >= 0)
            {
                int id = ids[index];
                if (id == -1)
                {
                    //ignore if separator   
                    comboBoxItemsClass3.SelectedIndex = -1;
                    return;
                }


                //if items is not a separator
                // get the selected class index via the tab control
                int classindex = cod4TabControl.SelectedIndex;
                switch (classindex)
                {
                    case 3:
                        //check radio buttons checked state and send item
                        SendItem(primaryClass3Radio, 221, id);
                        SendItem(primaryAttachClass3Radio, 222, id);
                        SendItem(secondaryClass3, 223, id);
                        SendItem(secondaryAttachClass3Radio, 224, id);
                        SendItem(perk1Class3, 225, id);
                        SendItem(perk2Class3, 226, id);
                        SendItem(perk3Class3, 227, id);
                        SendItem(specialGrenadeClass3, 228, id);
                        SendItem(camoClass3, 229, id);

                        parentForm.NotifyToast("Haunter", $"Set Item to {comboBoxItems.SelectedItem}", ToolTipIcon.Info);
                        break;
                }
            }
        }

        private void comboBoxItemsClass4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxItemsClass4.SelectedIndex;
            if (index >= 0)
            {
                int id = ids[index];
                if (id == -1)
                {
                    //ignore if separator   
                    comboBoxItemsClass4.SelectedIndex = -1;
                    return;
                }


                //if items is not a separator
                // get the selected class index via the tab control
                int classindex = cod4TabControl.SelectedIndex;
                switch (classindex)
                {
                    case 4:
                        //check radio buttons checked state and send item
                        SendItem(primaryClass4, 231, id);
                        SendItem(primaryAttachClass4, 232, id);
                        SendItem(secondaryClass4, 233, id);
                        SendItem(secondaryAttachClass4, 234, id);
                        SendItem(perk1Class4, 235, id);
                        SendItem(perk2Class4, 236, id);
                        SendItem(perk3Class4, 237, id);
                        SendItem(specialGrenadeClass4, 238, id);
                        SendItem(camoClass4, 239, id);

                        parentForm.NotifyToast("Haunter", $"Set Item to {comboBoxItems.SelectedItem}", ToolTipIcon.Info);
                        break;
                }
            }
        }

        private void comboBoxItemsClass5_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxItemsClass5.SelectedIndex;
            if (index >= 0)
            {
                int id = ids[index];
                if (id == -1)
                {
                    //ignore if separator   
                    comboBoxItemsClass5.SelectedIndex = -1;
                    return;
                }


                //if items is not a separator
                // get the selected class index via the tab control
                int classindex = cod4TabControl.SelectedIndex;
                switch (classindex)
                {
                    case 5:
                        //check radio buttons checked state and send item
                        SendItem(primaryClass5, 241, id);
                        SendItem(primaryAttachClass5, 242, id);
                        SendItem(secondaryClass5, 243, id);
                        SendItem(secondaryAttachClass5, 244, id);
                        SendItem(perk1Class5, 245, id);
                        SendItem(perk2Class5, 246, id);
                        SendItem(perk3Class5, 247, id);
                        SendItem(specialGrenadeClass5, 248, id);
                        SendItem(camoClass5, 249, id);

                        parentForm.NotifyToast("Haunter", $"Set Item to {comboBoxItems.SelectedItem}", ToolTipIcon.Info);
                        break;
                }
            }
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void primaryRadio_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}
