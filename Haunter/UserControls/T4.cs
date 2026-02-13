using Haunter.Classes;
using System;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace Haunter.UserControls
{
    public partial class T4 : UserControl
    {
        // Instance of WAW class 
        WAW waw = new WAW();

        private Main parentForm;
        public T4(Main main)
        {
            InitializeComponent();
            parentForm = main;
        }

        private void T41_Load(object sender, EventArgs e)
        {
            comboBoxItems.Items.AddRange(WAW.Names.ToArray());
            comboBoxItemsClass2.Items.AddRange(WAW.Names.ToArray());
            comboBoxItemsClass3.Items.AddRange(WAW.Names.ToArray());
            comboBoxItemsClass4.Items.AddRange(WAW.Names.ToArray());
            comboBoxItemsClass5.Items.AddRange(WAW.Names.ToArray());
            comboBoxItemsClass6.Items.AddRange(WAW.Names.ToArray());
            comboBoxItemsClass7.Items.AddRange(WAW.Names.ToArray());
            comboBoxItemsClass8.Items.AddRange(WAW.Names.ToArray());
            comboBoxItemsClass9.Items.AddRange(WAW.Names.ToArray());
            comboBoxItemsClass10.Items.AddRange(WAW.Names.ToArray());

        }

        public void SetTheme()
        {
            bool isDarkMode = Properties.Settings.Default.darkMode;
            if (isDarkMode)
            {
                this.BackColor = Color.FromArgb(40, 40, 40);
                wawTabControl.BackColor = Color.FromArgb(40, 40, 40);
                tabPage1.BackColor = Color.FromArgb(40, 40, 40);
                tabPage2.BackColor = Color.FromArgb(40, 40, 40);
                tabPage3.BackColor = Color.FromArgb(40, 40, 40);
                tabPage4.BackColor = Color.FromArgb(40, 40, 40);
                tabPage5.BackColor = Color.FromArgb(40, 40, 40);
                tabPage6.BackColor = Color.FromArgb(40, 40, 40);
                tabPage7.BackColor = Color.FromArgb(40, 40, 40);
                tabPage8.BackColor = Color.FromArgb(40, 40, 40);
                tabPage9.BackColor = Color.FromArgb(40, 40, 40);
                tabPage10.BackColor = Color.FromArgb(40, 40, 40);
                tabPage11.BackColor = Color.FromArgb(40, 40, 40);
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
                buttonsText.BackColor = Color.FromArgb(40, 40, 40);
                buttonsText.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
                buttonsText.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
                SendClassNamesBtn.BackColor = Color.FromArgb(40, 40, 40);
                SendClassNamesBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
                SendClassNamesBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
                haunterTextBoxResult.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxPresetClassWAW.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxStringColours.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxItems.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxItemsClass2.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxItemsClass3.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxItemsClass4.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxItemsClass5.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxItemsClass6.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxItemsClass7.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxItemsClass8.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxItemsClass9.BackColor = Color.FromArgb(40, 40, 40);
                comboBoxItemsClass10.BackColor = Color.FromArgb(40, 40, 40);
            }
            else
            {
                this.BackColor = Color.FromArgb(245, 245, 245);
                wawTabControl.BackColor = Color.FromArgb(245, 245, 245);
                tabPage1.BackColor = Color.FromArgb(245, 245, 245);
                tabPage2.BackColor = Color.FromArgb(245, 245, 245);
                tabPage3.BackColor = Color.FromArgb(245, 245, 245);
                tabPage4.BackColor = Color.FromArgb(245, 245, 245);
                tabPage5.BackColor = Color.FromArgb(245, 245, 245);
                tabPage6.BackColor = Color.FromArgb(245, 245, 245);
                tabPage7.BackColor = Color.FromArgb(245, 245, 245);
                tabPage8.BackColor = Color.FromArgb(245, 245, 245);
                tabPage9.BackColor = Color.FromArgb(245, 245, 245);
                tabPage10.BackColor = Color.FromArgb(245, 245, 245);
                tabPage11.BackColor = Color.FromArgb(245, 245, 245);
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
                buttonsText.BackColor = Color.FromArgb(245, 245, 245);
                buttonsText.FlatAppearance.MouseDownBackColor = Color.FromArgb(245, 245, 245);
                buttonsText.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 245, 245);
                SendClassNamesBtn.BackColor = Color.FromArgb(245, 245, 245);
                SendClassNamesBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(245, 245, 245);
                SendClassNamesBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 245, 245);
                haunterTextBoxResult.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxPresetClassWAW.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxStringColours.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxItems.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxItemsClass2.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxItemsClass3.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxItemsClass4.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxItemsClass5.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxItemsClass6.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxItemsClass7.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxItemsClass8.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxItemsClass9.BackColor = Color.FromArgb(245, 245, 245);
                comboBoxItemsClass10.BackColor = Color.FromArgb(245, 245, 245);

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
                    waw.Cbuf_AddText(commandClassNames);
                }


                if (!string.IsNullOrWhiteSpace(textBoxesPrestige[i].Text))
                {
                    string commandPrestigeNames = $"prestigeclass{i + 1} {textBoxesPrestige[i].Text}";
                    waw.Cbuf_AddText(commandPrestigeNames);
                }
            }

            waw.Cbuf_AddText(";updategamerprofile;uploadstats;");
            parentForm.NotifyToast("Haunter", "Class names sent!", ToolTipIcon.Info);
        }

        private void comboBoxPresetClassWAW_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPreset = comboBoxPresetClassWAW.SelectedItem?.ToString() ?? comboBoxPresetClassWAW.Text;
            if (string.IsNullOrWhiteSpace(selectedPreset)) return;

            switch (selectedPreset)
            {
                case "Your Gamertag":
                    for (int i = 0; i < 5; i++)
                    {
                        waw.Cbuf_AddText($"customclass{i + 1} \"#^{i + 1} {Home.console.GetGamertag(false)}\";updategamerprofile;uploadstats;");
                        int colorIndex = (i + 6) % 10;

                        //loop offset for prestige class names
                        int classNumber = i + 6;
                        waw.Cbuf_AddText($"prestigeclass{i + 1} \"#^{colorIndex}{Home.console.GetGamertag(false)}\";updategamerprofile;uploadstats;");
                    }

                    break;

                case "Number":
                    for (int i = 0; i < 5; i++)
                    {

                        waw.Cbuf_AddText($"customclass{i + 1} \"#^{i + 1}{i + 1}\";updategamerprofile;uploadstats;");
                        int colorIndex = (i + 6) % 10;

                        //loop offset for prestige class names
                        int classNumber = i + 6;
                        waw.Cbuf_AddText($"prestigeclass{i + 1} \"#^{colorIndex}{classNumber}\";updategamerprofile;uploadstats;");
                    }
                    break;

                case "Haunter":
                    for (int i = 0; i < 5; i++)
                    {
                        waw.Cbuf_AddText($"customclass{i + 1} \"#^{i + 1}Haunter\";updategamerprofile;uploadstats;");
                        int colorIndex = (i + 6) % 10;
                        waw.Cbuf_AddText($"prestigeclass{i + 1} \"#^{colorIndex}Haunter\";updategamerprofile;uploadstats;");
                    }
                    break;

                case "Dash":
                    for (int i = 0; i < 5; i++)
                    {
                        waw.Cbuf_AddText($"customclass{i + 1} \"---------------\";updategamerprofile;uploadstats;");
                        waw.Cbuf_AddText($"prestigeclass{i + 1} \"---------------\";updategamerprofile;uploadstats;");
                    }
                    break;

                case "Rainbow":
                    for (int i = 0; i < 5; i++)
                    {
                        waw.Cbuf_AddText($"customclass{i + 1} \"^1R^2a^3i^4n^5b^6o^7w\";updategamerprofile;uploadstats;");
                        waw.Cbuf_AddText($"prestigeclass{i + 1} \"^1R^2a^3i^4n^5b^6o^7w\";updategamerprofile;uploadstats;");
                    }
                    break;

                case "Invisible":
                    for (int i = 0; i < 5; i++)
                    {
                        waw.Cbuf_AddText($"customclass{i + 1} \"@\";updategamerprofile;uploadstats;");
                        waw.Cbuf_AddText($"prestigeclass{i + 1} \"@\";updategamerprofile;uploadstats;");
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

        private void buttonsText_Click(object sender, EventArgs e)
        {
            ButtonsForm buttonsForm = new ButtonsForm();
            buttonsForm.Show();
            buttonsForm.BringToFront();
            buttonsForm.SetTheme();
        }

        private void comboBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxItems.SelectedIndex;
            if (index >= 0)
            {
                int id = WAW.Ids[index];
                if (id == -1)
                {
                    //ignore if separator   
                    comboBoxItems.SelectedIndex = -1;
                    return;
                }


                //if items is not a separator

                try
                {
                    //check radio buttons checked state and send item
                    waw.SendItem(primaryRadio, 201, id);
                    waw.SendItem(primaryAttachRadio, 202, id);
                    waw.SendItem(secondaryRadio, 203, id);
                    waw.SendItem(secondaryAttachRadio, 204, id);
                    waw.SendItem(perk1Radio, 205, id);
                    waw.SendItem(perk2Radio, 206, id);
                    waw.SendItem(perk3Radio, 207, id);
                    waw.SendItem(specialGrenadeRadio, 208, id);
                }
                catch
                {
                    parentForm.NotifyToast("Haunter", "An error occurred while trying to send the item to the game. Make sure the game is running and connected", ToolTipIcon.Error);
                    return;
                }


                parentForm.NotifyToast("Haunter", $"Set Item to {comboBoxItems.SelectedItem}", ToolTipIcon.Info);


            }
        }

        private void comboBoxItemsClass2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxItemsClass2.SelectedIndex;
            if (index >= 0)
            {
                int id = WAW.Ids[index];
                if (id == -1)
                {
                    //ignore if separator   
                    comboBoxItemsClass2.SelectedIndex = -1;
                    return;
                }


                //if items is not a separator

                try
                {
                    //check radio buttons checked state and send item
                    waw.SendItem(primaryClass2, 211, id);
                    waw.SendItem(primaryAttachClass2, 212, id);
                    waw.SendItem(secondaryClass2, 213, id);
                    waw.SendItem(secondaryAttachClass2, 214, id);
                    waw.SendItem(perk1Class2, 215, id);
                    waw.SendItem(perk2Class2, 216, id);
                    waw.SendItem(perk3Class2, 217, id);
                    waw.SendItem(specialGrenadeClass2, 218, id);
                }
                catch
                {
                    parentForm.NotifyToast("Haunter", "An error occurred while trying to send the item to the game. Make sure the game is running and connected", ToolTipIcon.Error);
                    return;
                }

                parentForm.NotifyToast("Haunter", $"Set Item to {comboBoxItemsClass2.SelectedItem}", ToolTipIcon.Info);


            }
        }

        private void comboBoxItemsClass3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxItemsClass3.SelectedIndex;
            if (index >= 0)
            {
                int id = WAW.Ids[index];
                if (id == -1)
                {
                    //ignore if separator   
                    comboBoxItemsClass3.SelectedIndex = -1;
                    return;
                }


                //if items is not a separator

                try
                {
                    //check radio buttons checked state and send item
                    waw.SendItem(primaryClass3, 221, id);
                    waw.SendItem(primaryAttachClass3, 222, id);
                    waw.SendItem(secondaryClass3, 223, id);
                    waw.SendItem(secondaryAttachClass3, 224, id);
                    waw.SendItem(perk1Class3, 225, id);
                    waw.SendItem(perk2Class3, 226, id);
                    waw.SendItem(perk3Class3, 227, id);
                    waw.SendItem(specialGrenadeClass3, 228, id);
                }
                catch
                {
                    parentForm.NotifyToast("Haunter", "An error occurred while trying to send the item to the game. Make sure the game is running and connected", ToolTipIcon.Error);
                    return;
                }

                parentForm.NotifyToast("Haunter", $"Set Item to {comboBoxItemsClass3.SelectedItem}", ToolTipIcon.Info);


            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxItemsClass4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxItemsClass4.SelectedIndex;
            if (index >= 0)
            {
                int id = WAW.Ids[index];
                if (id == -1)
                {
                    //ignore if separator   
                    comboBoxItemsClass4.SelectedIndex = -1;
                    return;
                }


                //if items is not a separator

                try
                {
                    //check radio buttons checked state and send item
                    waw.SendItem(primaryClass4, 231, id);
                    waw.SendItem(primaryAttachClass4, 232, id);
                    waw.SendItem(secondaryClass4, 233, id);
                    waw.SendItem(secondaryAttachClass4, 234, id);
                    waw.SendItem(perk1Class4, 235, id);
                    waw.SendItem(perk2Class4, 236, id);
                    waw.SendItem(perk3Class4, 237, id);
                    waw.SendItem(specialGrenadeClass4, 238, id);
                }
                catch
                {
                    parentForm.NotifyToast("Haunter", "An error occurred while trying to send the item to the game. Make sure the game is running and connected", ToolTipIcon.Error);
                    return;
                }

                parentForm.NotifyToast("Haunter", $"Set Item to {comboBoxItemsClass4.SelectedItem}", ToolTipIcon.Info);


            }
        }

        private void comboBoxItemsClass5_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxItemsClass5.SelectedIndex;
            if (index >= 0)
            {
                int id = WAW.Ids[index];
                if (id == -1)
                {
                    //ignore if separator   
                    comboBoxItemsClass5.SelectedIndex = -1;
                    return;
                }


                //if items is not a separator

                try
                {
                    //check radio buttons checked state and send item
                    waw.SendItem(primaryClass5, 241, id);
                    waw.SendItem(primaryAttachClass5, 242, id);
                    waw.SendItem(secondaryClass5, 243, id);
                    waw.SendItem(secondaryAttachClass5, 244, id);
                    waw.SendItem(perk1Class5, 245, id);
                    waw.SendItem(perk2Class5, 246, id);
                    waw.SendItem(perk3Class5, 247, id);
                    waw.SendItem(specialGrenadeClass5, 248, id);
                }
                catch
                {
                    parentForm.NotifyToast("Haunter", "An error occurred while trying to send the item to the game. Make sure the game is running and connected", ToolTipIcon.Error);
                    return;
                }

                parentForm.NotifyToast("Haunter", $"Set Item to {comboBoxItemsClass5.SelectedItem}", ToolTipIcon.Info);


            }
        }

        private void comboBoxItemsClass6_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxItemsClass6.SelectedIndex;
            if (index >= 0)
            {
                int id = WAW.Ids[index];
                if (id == -1)
                {
                    //ignore if separator   
                    comboBoxItemsClass6.SelectedIndex = -1;
                    return;
                }


                //if items is not a separator

                try
                {
                    //check radio buttons checked state and send item
                    waw.SendItem(primaryClass6, 1201, id);
                    waw.SendItem(primaryAttachClass6, 1202, id);
                    waw.SendItem(secondaryClass6, 1203, id);
                    waw.SendItem(secondaryAttachClass6, 1204, id);
                    waw.SendItem(perk1Class6, 1205, id);
                    waw.SendItem(perk2Class6, 1206, id);
                    waw.SendItem(perk3Class6, 1207, id);
                    waw.SendItem(specialGrenadeClass6, 1208, id);
                }
                catch
                {
                    parentForm.NotifyToast("Haunter", "An error occurred while trying to send the item to the game. Make sure the game is running and connected", ToolTipIcon.Error);
                    return;
                }

                parentForm.NotifyToast("Haunter", $"Set Item to {comboBoxItemsClass6.SelectedItem}", ToolTipIcon.Info);


            }
        }

        private void comboBoxItemsClass7_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxItemsClass7.SelectedIndex;
            if (index >= 0)
            {
                int id = WAW.Ids[index];
                if (id == -1)
                {
                    //ignore if separator   
                    comboBoxItemsClass7.SelectedIndex = -1;
                    return;
                }


                //if items is not a separator

                try
                {
                    //check radio buttons checked state and send item
                    waw.SendItem(primaryClass7, 1211, id);
                    waw.SendItem(primaryAttachClass7, 1212, id);
                    waw.SendItem(secondaryClass7, 1213, id);
                    waw.SendItem(secondaryAttachClass7, 1214, id);
                    waw.SendItem(perk1Class7, 1215, id);
                    waw.SendItem(perk2Class7, 1216, id);
                    waw.SendItem(perk3Class7, 1217, id);
                    waw.SendItem(specialGrenadeClass7, 1218, id);
                }
                catch
                {
                    parentForm.NotifyToast("Haunter", "An error occurred while trying to send the item to the game. Make sure the game is running and connected", ToolTipIcon.Error);
                    return;
                }

                parentForm.NotifyToast("Haunter", $"Set Item to {comboBoxItemsClass7.SelectedItem}", ToolTipIcon.Info);


            }
        }

        private void comboBoxItemsClass8_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxItemsClass8.SelectedIndex;
            if (index >= 0)
            {
                int id = WAW.Ids[index];
                if (id == -1)
                {
                    //ignore if separator   
                    comboBoxItemsClass8.SelectedIndex = -1;
                    return;
                }


                //if items is not a separator

                try
                {
                    //check radio buttons checked state and send item
                    waw.SendItem(primaryClass8, 1221, id);
                    waw.SendItem(primaryAttachClass8, 1222, id);
                    waw.SendItem(secondaryClass8, 1223, id);
                    waw.SendItem(secondaryAttachClass8, 1224, id);
                    waw.SendItem(perk1Class8, 1225, id);
                    waw.SendItem(perk2Class8, 1226, id);
                    waw.SendItem(perk3Class8, 1227, id);
                    waw.SendItem(specialGrenadeClass8, 1228, id);
                }
                catch
                {
                    parentForm.NotifyToast("Haunter", "An error occurred while trying to send the item to the game. Make sure the game is running and connected", ToolTipIcon.Error);
                    return;
                }

                parentForm.NotifyToast("Haunter", $"Set Item to {comboBoxItemsClass8.SelectedItem}", ToolTipIcon.Info);


            }
        }

        private void comboBoxItemsClass9_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxItemsClass9.SelectedIndex;
            if (index >= 0)
            {
                int id = WAW.Ids[index];
                if (id == -1)
                {
                    //ignore if separator   
                    comboBoxItemsClass9.SelectedIndex = -1;
                    return;
                }


                //if items is not a separator

                try
                {
                    //check radio buttons checked state and send item
                    waw.SendItem(primaryClass9, 1231, id);
                    waw.SendItem(primaryAttachClass9, 1232, id);
                    waw.SendItem(secondaryClass9, 1233, id);
                    waw.SendItem(secondaryAttachClass9, 1234, id);
                    waw.SendItem(perk1Class9, 1235, id);
                    waw.SendItem(perk2Class9, 1236, id);
                    waw.SendItem(perk3Class9, 1237, id);
                    waw.SendItem(specialGrenadeClass9, 1238, id);
                }
                catch
                {
                    parentForm.NotifyToast("Haunter", "An error occurred while trying to send the item to the game. Make sure the game is running and connected", ToolTipIcon.Error);
                    return;
                }

                parentForm.NotifyToast("Haunter", $"Set Item to {comboBoxItemsClass9.SelectedItem}", ToolTipIcon.Info);


            }
        }

        private void comboBoxItemsClass10_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxItemsClass10.SelectedIndex;
            if (index >= 0)
            {
                int id = WAW.Ids[index];
                if (id == -1)
                {
                    //ignore if separator   
                    comboBoxItemsClass10.SelectedIndex = -1;
                    return;
                }


                //if items is not a separator

                try
                {
                    //check radio buttons checked state and send item
                    waw.SendItem(primaryClass10, 1241, id);
                    waw.SendItem(primaryAttachClass10, 1242, id);
                    waw.SendItem(secondaryClass10, 1243, id);
                    waw.SendItem(secondaryAttachClass10, 1244, id);
                    waw.SendItem(perk1Class10, 1245, id);
                    waw.SendItem(perk2Class10, 1246, id);
                    waw.SendItem(perk3Class10, 1247, id);
                    waw.SendItem(specialGrenadeClass10, 1248, id);
                }
                catch
                {
                    parentForm.NotifyToast("Haunter", "An error occurred while trying to send the item to the game. Make sure the game is running and connected", ToolTipIcon.Error);
                    return;
                }

                parentForm.NotifyToast("Haunter", $"Set Item to {comboBoxItemsClass10.SelectedItem}", ToolTipIcon.Info);


            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
    

