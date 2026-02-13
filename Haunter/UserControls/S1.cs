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
    public partial class S1 : UserControl
    {
        AW aw = new AW();

        private Main parentForm;

        private uint[] addressesStructure = [AW.Class1Struc, AW.Class2Struc, AW.Class3Struc, AW.Class4Struc, AW.Class5Struc, AW.Class6Struc, AW.Class7Struc, AW.Class8Struc, AW.Class9Struc, AW.Class10Struc, AW.Class11Struc, AW.Class12Struc, AW.Class13Struc, AW.Class14Struc, AW.Class15Struc];

        private uint[] addressesStructurePrivate = [AW.PrivateClass1Struc, AW.PrivateClass2Struc, AW.PrivateClass3Struc, AW.PrivateClass4Struc, AW.PrivateClass5Struc , AW.PrivateClass6Struc , AW.PrivateClass7Struc , AW.PrivateClass8Struc , AW.PrivateClass9Struc , AW.PrivateClass10Struc , AW.PrivateClass11Struc , AW.PrivateClass12Struc , AW.PrivateClass13Struc , AW.PrivateClass14Struc , AW.PrivateClass15Struc];

        private uint[] addressesNames = [AW.Class1Name, AW.Class2Name, AW.Class3Name, AW.Class4Name, AW.Class5Name, AW.Class6Name, AW.Class7Name, AW.Class8Name, AW.Class9Name, AW.Class10Name, AW.Class11Name, AW.Class12Name, AW.Class13Name, AW.Class14Name, AW.Class15Name];

        private uint[] addressesNamesPrivate = [AW.PrivateClass1Name, AW.PrivateClass2Name, AW.PrivateClass3Name, AW.PrivateClass4Name, AW.PrivateClass5Name , AW.PrivateClass6Name , AW.PrivateClass7Name , AW.PrivateClass8Name , AW.PrivateClass9Name , AW.PrivateClass10Name , AW.PrivateClass11Name , AW.PrivateClass12Name , AW.PrivateClass13Name , AW.PrivateClass14Name , AW.PrivateClass15Name];


        public S1(Main main)
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
                awTabControl.BackColor = Color.FromArgb(40, 40, 40);
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
                comboBoxPresetClassAW.BackColor = Color.FromArgb(40, 40, 40);
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
                awTabControl.BackColor = Color.FromArgb(245, 245, 245);
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
                comboBoxPresetClassAW.BackColor = Color.FromArgb(245, 245, 245);
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

            if (awTabControl.SelectedTab == tabPage2)
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
                    aw.SendMainWeapon(GetSelectedClassStruct(), id);
                    return true;

                case 2:
                    aw.SendExoLauncher(GetSelectedClassStruct(), id);
                    return true;

                case 3:
                    if (id > 7 || id == 5)
                        parentForm.NotifyToast("Haunter", "Warning for this secondary weapon item, the change is only visual.", ToolTipIcon.Warning);

                    aw.SendSecondaryWeapon(GetSelectedClassStruct(), id);
                    return true;

                case 4:

                    return true;

                case 5:
                    aw.SendPerk1(GetSelectedClassStruct(), id);
                    return true;

                case 6:
                    aw.SendPerk2(GetSelectedClassStruct(), id);
                    return true;

                case 7:
                    aw.SendPerk3(GetSelectedClassStruct(), id);
                    return true;

                case 8:
                    aw.SendExoLauncher2(GetSelectedClassStruct(), true);
                    return true;

                case 9:
                    aw.SendExoAbility(GetSelectedClassStruct(), id);
                    return true;

                case 10:
                    aw.SendCamo(GetSelectedClassStruct(), id);
                    return true;

                default:
                    return false;
            }
        }

        private void numericUpDownClassIndex_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxWeapons_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
