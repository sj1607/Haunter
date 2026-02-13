namespace Haunter.UserControls
{
    partial class COD4
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            cod4TabControl = new TabControl();
            cod4MainPage = new TabPage();
            buttonsText = new FontAwesome.Sharp.IconButton();
            haunterTextBoxResult = new Haunter.CustomTextBox.HaunterTextBox();
            comboBoxStringColours = new ComboBox();
            comboBoxPresetClassCOD4 = new ComboBox();
            noteLabel = new Label();
            SendClassNamesBtn = new FontAwesome.Sharp.IconButton();
            haunterTextBoxClassName5 = new Haunter.CustomTextBox.HaunterTextBox();
            haunterTextBoxClassName4 = new Haunter.CustomTextBox.HaunterTextBox();
            haunterTextBoxClassName3 = new Haunter.CustomTextBox.HaunterTextBox();
            haunterTextBoxClassName2 = new Haunter.CustomTextBox.HaunterTextBox();
            haunterTextBoxClassName1 = new Haunter.CustomTextBox.HaunterTextBox();
            tabPage2 = new TabPage();
            camoRadio = new RadioButton();
            specialGrenadeRadio = new RadioButton();
            perk3Radio = new RadioButton();
            perk2Radio = new RadioButton();
            perk1Radio = new RadioButton();
            secondaryAttachRadio = new RadioButton();
            secondaryRadio = new RadioButton();
            primaryAttachRadio = new RadioButton();
            primaryRadio = new RadioButton();
            itemsLabel = new Label();
            comboBoxItems = new ComboBox();
            tabPage1 = new TabPage();
            camoClass2Radio = new RadioButton();
            specialGrenadeClass2Radio = new RadioButton();
            perk3Class2Radio = new RadioButton();
            perk2Class2Radio = new RadioButton();
            perk1Class2Radio = new RadioButton();
            secondaryAttachClass2Radio = new RadioButton();
            secondaryClass2Radio = new RadioButton();
            primaryWeaponAttachClass2Radio = new RadioButton();
            primaryWeaponClass2Radio = new RadioButton();
            label1 = new Label();
            comboBoxItemsClass2 = new ComboBox();
            tabPage3 = new TabPage();
            camoClass3 = new RadioButton();
            specialGrenadeClass3 = new RadioButton();
            perk3Class3 = new RadioButton();
            perk2Class3 = new RadioButton();
            perk1Class3 = new RadioButton();
            secondaryAttachClass3Radio = new RadioButton();
            secondaryClass3 = new RadioButton();
            primaryAttachClass3Radio = new RadioButton();
            primaryClass3Radio = new RadioButton();
            label2 = new Label();
            comboBoxItemsClass3 = new ComboBox();
            tabPage4 = new TabPage();
            camoClass4 = new RadioButton();
            specialGrenadeClass4 = new RadioButton();
            perk3Class4 = new RadioButton();
            perk2Class4 = new RadioButton();
            perk1Class4 = new RadioButton();
            secondaryAttachClass4 = new RadioButton();
            secondaryClass4 = new RadioButton();
            primaryAttachClass4 = new RadioButton();
            primaryClass4 = new RadioButton();
            label3 = new Label();
            comboBoxItemsClass4 = new ComboBox();
            tabPage5 = new TabPage();
            camoClass5 = new RadioButton();
            specialGrenadeClass5 = new RadioButton();
            perk3Class5 = new RadioButton();
            perk2Class5 = new RadioButton();
            perk1Class5 = new RadioButton();
            secondaryAttachClass5 = new RadioButton();
            secondaryClass5 = new RadioButton();
            primaryAttachClass5 = new RadioButton();
            primaryClass5 = new RadioButton();
            label4 = new Label();
            comboBoxItemsClass5 = new ComboBox();
            cod4TabControl.SuspendLayout();
            cod4MainPage.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // cod4TabControl
            // 
            cod4TabControl.Controls.Add(cod4MainPage);
            cod4TabControl.Controls.Add(tabPage2);
            cod4TabControl.Controls.Add(tabPage1);
            cod4TabControl.Controls.Add(tabPage3);
            cod4TabControl.Controls.Add(tabPage4);
            cod4TabControl.Controls.Add(tabPage5);
            cod4TabControl.Dock = DockStyle.Fill;
            cod4TabControl.Font = new Font("Tarzan", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cod4TabControl.Location = new Point(0, 0);
            cod4TabControl.Name = "cod4TabControl";
            cod4TabControl.SelectedIndex = 0;
            cod4TabControl.Size = new Size(924, 677);
            cod4TabControl.TabIndex = 2;
            // 
            // cod4MainPage
            // 
            cod4MainPage.BackColor = Color.FromArgb(40, 40, 40);
            cod4MainPage.Controls.Add(buttonsText);
            cod4MainPage.Controls.Add(haunterTextBoxResult);
            cod4MainPage.Controls.Add(comboBoxStringColours);
            cod4MainPage.Controls.Add(comboBoxPresetClassCOD4);
            cod4MainPage.Controls.Add(noteLabel);
            cod4MainPage.Controls.Add(SendClassNamesBtn);
            cod4MainPage.Controls.Add(haunterTextBoxClassName5);
            cod4MainPage.Controls.Add(haunterTextBoxClassName4);
            cod4MainPage.Controls.Add(haunterTextBoxClassName3);
            cod4MainPage.Controls.Add(haunterTextBoxClassName2);
            cod4MainPage.Controls.Add(haunterTextBoxClassName1);
            cod4MainPage.Location = new Point(4, 24);
            cod4MainPage.Name = "cod4MainPage";
            cod4MainPage.Padding = new Padding(3);
            cod4MainPage.Size = new Size(916, 649);
            cod4MainPage.TabIndex = 0;
            cod4MainPage.Text = "Main";
            cod4MainPage.Click += cod4MainPage_Click;
            // 
            // buttonsText
            // 
            buttonsText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonsText.Cursor = Cursors.Hand;
            buttonsText.FlatAppearance.BorderSize = 0;
            buttonsText.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            buttonsText.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonsText.FlatStyle = FlatStyle.Flat;
            buttonsText.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonsText.ForeColor = Color.FromArgb(114, 44, 133);
            buttonsText.IconChar = FontAwesome.Sharp.IconChar.None;
            buttonsText.IconColor = Color.FromArgb(114, 44, 133);
            buttonsText.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonsText.IconSize = 40;
            buttonsText.ImageAlign = ContentAlignment.MiddleLeft;
            buttonsText.Location = new Point(774, 50);
            buttonsText.Name = "buttonsText";
            buttonsText.Size = new Size(136, 53);
            buttonsText.TabIndex = 12;
            buttonsText.Text = "Buttons Text";
            buttonsText.UseVisualStyleBackColor = true;
            buttonsText.Click += buttonsText_Click;
            // 
            // haunterTextBoxResult
            // 
            haunterTextBoxResult.BackColor = Color.FromArgb(40, 40, 40);
            haunterTextBoxResult.BorderStyle = BorderStyle.None;
            haunterTextBoxResult.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            haunterTextBoxResult.ForeColor = Color.FromArgb(114, 44, 133);
            haunterTextBoxResult.Location = new Point(288, 322);
            haunterTextBoxResult.Multiline = true;
            haunterTextBoxResult.Name = "haunterTextBoxResult";
            haunterTextBoxResult.PlaceholderText = "String Colours Result";
            haunterTextBoxResult.Size = new Size(224, 24);
            haunterTextBoxResult.TabIndex = 11;
            // 
            // comboBoxStringColours
            // 
            comboBoxStringColours.BackColor = Color.FromArgb(40, 40, 40);
            comboBoxStringColours.FlatStyle = FlatStyle.Flat;
            comboBoxStringColours.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxStringColours.ForeColor = Color.FromArgb(114, 44, 133);
            comboBoxStringColours.FormattingEnabled = true;
            comboBoxStringColours.Items.AddRange(new object[] { "Red", "Green", "Yellow", "Blue", "Cyan", "Pink", "Grey", "White", "Black" });
            comboBoxStringColours.Location = new Point(288, 60);
            comboBoxStringColours.Name = "comboBoxStringColours";
            comboBoxStringColours.Size = new Size(224, 33);
            comboBoxStringColours.TabIndex = 10;
            comboBoxStringColours.Text = "String Colours";
            comboBoxStringColours.SelectedIndexChanged += comboBoxStringColours_SelectedIndexChanged;
            // 
            // comboBoxPresetClassCOD4
            // 
            comboBoxPresetClassCOD4.BackColor = Color.FromArgb(40, 40, 40);
            comboBoxPresetClassCOD4.FlatStyle = FlatStyle.Flat;
            comboBoxPresetClassCOD4.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxPresetClassCOD4.ForeColor = Color.FromArgb(114, 44, 133);
            comboBoxPresetClassCOD4.FormattingEnabled = true;
            comboBoxPresetClassCOD4.Items.AddRange(new object[] { "Your Gamertag", "Number", "Haunter", "Dash", "Rainbow", "Unlocalized" });
            comboBoxPresetClassCOD4.Location = new Point(544, 60);
            comboBoxPresetClassCOD4.Name = "comboBoxPresetClassCOD4";
            comboBoxPresetClassCOD4.Size = new Size(224, 33);
            comboBoxPresetClassCOD4.TabIndex = 9;
            comboBoxPresetClassCOD4.Text = "Preset Class Names";
            comboBoxPresetClassCOD4.SelectedIndexChanged += comboBoxPresetClassCOD4_SelectedIndexChanged;
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noteLabel.ForeColor = Color.FromArgb(114, 44, 133);
            noteLabel.Location = new Point(29, 608);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new Size(715, 20);
            noteLabel.TabIndex = 8;
            noteLabel.Text = "Note : Empty textboxes will be ignored when you click the 'Send Class Names' button.";
            // 
            // SendClassNamesBtn
            // 
            SendClassNamesBtn.Cursor = Cursors.Hand;
            SendClassNamesBtn.FlatAppearance.BorderSize = 0;
            SendClassNamesBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            SendClassNamesBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            SendClassNamesBtn.FlatStyle = FlatStyle.Flat;
            SendClassNamesBtn.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SendClassNamesBtn.ForeColor = Color.FromArgb(114, 44, 133);
            SendClassNamesBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            SendClassNamesBtn.IconColor = Color.FromArgb(114, 44, 133);
            SendClassNamesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SendClassNamesBtn.IconSize = 40;
            SendClassNamesBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SendClassNamesBtn.Location = new Point(27, 519);
            SendClassNamesBtn.Name = "SendClassNamesBtn";
            SendClassNamesBtn.Size = new Size(253, 59);
            SendClassNamesBtn.TabIndex = 7;
            SendClassNamesBtn.Text = "Send Class Names";
            SendClassNamesBtn.UseVisualStyleBackColor = true;
            SendClassNamesBtn.Click += SendClassNamesBtn_Click;
            // 
            // haunterTextBoxClassName5
            // 
            haunterTextBoxClassName5.BackColor = Color.FromArgb(40, 40, 40);
            haunterTextBoxClassName5.BorderStyle = BorderStyle.None;
            haunterTextBoxClassName5.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            haunterTextBoxClassName5.ForeColor = Color.FromArgb(114, 44, 133);
            haunterTextBoxClassName5.Location = new Point(27, 410);
            haunterTextBoxClassName5.Multiline = true;
            haunterTextBoxClassName5.Name = "haunterTextBoxClassName5";
            haunterTextBoxClassName5.PlaceholderText = "Class Name 5";
            haunterTextBoxClassName5.Size = new Size(224, 24);
            haunterTextBoxClassName5.TabIndex = 6;
            haunterTextBoxClassName5.TextChanged += haunterTextBoxClassName5_TextChanged;
            // 
            // haunterTextBoxClassName4
            // 
            haunterTextBoxClassName4.BackColor = Color.FromArgb(40, 40, 40);
            haunterTextBoxClassName4.BorderStyle = BorderStyle.None;
            haunterTextBoxClassName4.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            haunterTextBoxClassName4.ForeColor = Color.FromArgb(114, 44, 133);
            haunterTextBoxClassName4.Location = new Point(29, 312);
            haunterTextBoxClassName4.Multiline = true;
            haunterTextBoxClassName4.Name = "haunterTextBoxClassName4";
            haunterTextBoxClassName4.PlaceholderText = "Class Name 4";
            haunterTextBoxClassName4.Size = new Size(224, 24);
            haunterTextBoxClassName4.TabIndex = 5;
            // 
            // haunterTextBoxClassName3
            // 
            haunterTextBoxClassName3.BackColor = Color.FromArgb(40, 40, 40);
            haunterTextBoxClassName3.BorderStyle = BorderStyle.None;
            haunterTextBoxClassName3.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            haunterTextBoxClassName3.ForeColor = Color.FromArgb(114, 44, 133);
            haunterTextBoxClassName3.Location = new Point(29, 222);
            haunterTextBoxClassName3.Multiline = true;
            haunterTextBoxClassName3.Name = "haunterTextBoxClassName3";
            haunterTextBoxClassName3.PlaceholderText = "Class Name 3";
            haunterTextBoxClassName3.Size = new Size(224, 24);
            haunterTextBoxClassName3.TabIndex = 4;
            // 
            // haunterTextBoxClassName2
            // 
            haunterTextBoxClassName2.BackColor = Color.FromArgb(40, 40, 40);
            haunterTextBoxClassName2.BorderStyle = BorderStyle.None;
            haunterTextBoxClassName2.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            haunterTextBoxClassName2.ForeColor = Color.FromArgb(114, 44, 133);
            haunterTextBoxClassName2.Location = new Point(28, 136);
            haunterTextBoxClassName2.Multiline = true;
            haunterTextBoxClassName2.Name = "haunterTextBoxClassName2";
            haunterTextBoxClassName2.PlaceholderText = "Class Name 2";
            haunterTextBoxClassName2.Size = new Size(224, 24);
            haunterTextBoxClassName2.TabIndex = 3;
            // 
            // haunterTextBoxClassName1
            // 
            haunterTextBoxClassName1.BackColor = Color.FromArgb(40, 40, 40);
            haunterTextBoxClassName1.BorderStyle = BorderStyle.None;
            haunterTextBoxClassName1.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            haunterTextBoxClassName1.ForeColor = Color.FromArgb(114, 44, 133);
            haunterTextBoxClassName1.Location = new Point(29, 60);
            haunterTextBoxClassName1.Multiline = true;
            haunterTextBoxClassName1.Name = "haunterTextBoxClassName1";
            haunterTextBoxClassName1.PlaceholderText = "Class Name 1";
            haunterTextBoxClassName1.Size = new Size(224, 24);
            haunterTextBoxClassName1.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(40, 40, 40);
            tabPage2.Controls.Add(camoRadio);
            tabPage2.Controls.Add(specialGrenadeRadio);
            tabPage2.Controls.Add(perk3Radio);
            tabPage2.Controls.Add(perk2Radio);
            tabPage2.Controls.Add(perk1Radio);
            tabPage2.Controls.Add(secondaryAttachRadio);
            tabPage2.Controls.Add(secondaryRadio);
            tabPage2.Controls.Add(primaryAttachRadio);
            tabPage2.Controls.Add(primaryRadio);
            tabPage2.Controls.Add(itemsLabel);
            tabPage2.Controls.Add(comboBoxItems);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(916, 649);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Class 1";
            tabPage2.Click += tabPage2_Click;
            // 
            // camoRadio
            // 
            camoRadio.AutoSize = true;
            camoRadio.Cursor = Cursors.Hand;
            camoRadio.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            camoRadio.ForeColor = Color.FromArgb(114, 44, 133);
            camoRadio.Location = new Point(32, 484);
            camoRadio.Name = "camoRadio";
            camoRadio.Size = new Size(74, 24);
            camoRadio.TabIndex = 21;
            camoRadio.TabStop = true;
            camoRadio.Text = "Camo";
            camoRadio.UseVisualStyleBackColor = true;
            // 
            // specialGrenadeRadio
            // 
            specialGrenadeRadio.AutoSize = true;
            specialGrenadeRadio.Cursor = Cursors.Hand;
            specialGrenadeRadio.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            specialGrenadeRadio.ForeColor = Color.FromArgb(114, 44, 133);
            specialGrenadeRadio.Location = new Point(32, 433);
            specialGrenadeRadio.Name = "specialGrenadeRadio";
            specialGrenadeRadio.Size = new Size(158, 24);
            specialGrenadeRadio.TabIndex = 20;
            specialGrenadeRadio.TabStop = true;
            specialGrenadeRadio.Text = "Special Grenade";
            specialGrenadeRadio.UseVisualStyleBackColor = true;
            // 
            // perk3Radio
            // 
            perk3Radio.AutoSize = true;
            perk3Radio.Cursor = Cursors.Hand;
            perk3Radio.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            perk3Radio.ForeColor = Color.FromArgb(114, 44, 133);
            perk3Radio.Location = new Point(32, 382);
            perk3Radio.Name = "perk3Radio";
            perk3Radio.Size = new Size(81, 24);
            perk3Radio.TabIndex = 19;
            perk3Radio.TabStop = true;
            perk3Radio.Text = "Perk 3";
            perk3Radio.UseVisualStyleBackColor = true;
            // 
            // perk2Radio
            // 
            perk2Radio.AutoSize = true;
            perk2Radio.Cursor = Cursors.Hand;
            perk2Radio.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            perk2Radio.ForeColor = Color.FromArgb(114, 44, 133);
            perk2Radio.Location = new Point(32, 332);
            perk2Radio.Name = "perk2Radio";
            perk2Radio.Size = new Size(81, 24);
            perk2Radio.TabIndex = 18;
            perk2Radio.TabStop = true;
            perk2Radio.Text = "Perk 2";
            perk2Radio.UseVisualStyleBackColor = true;
            // 
            // perk1Radio
            // 
            perk1Radio.AutoSize = true;
            perk1Radio.Cursor = Cursors.Hand;
            perk1Radio.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            perk1Radio.ForeColor = Color.FromArgb(114, 44, 133);
            perk1Radio.Location = new Point(32, 279);
            perk1Radio.Name = "perk1Radio";
            perk1Radio.Size = new Size(81, 24);
            perk1Radio.TabIndex = 17;
            perk1Radio.TabStop = true;
            perk1Radio.Text = "Perk 1";
            perk1Radio.UseVisualStyleBackColor = true;
            // 
            // secondaryAttachRadio
            // 
            secondaryAttachRadio.AutoSize = true;
            secondaryAttachRadio.Cursor = Cursors.Hand;
            secondaryAttachRadio.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secondaryAttachRadio.ForeColor = Color.FromArgb(114, 44, 133);
            secondaryAttachRadio.Location = new Point(32, 229);
            secondaryAttachRadio.Name = "secondaryAttachRadio";
            secondaryAttachRadio.Size = new Size(288, 24);
            secondaryAttachRadio.TabIndex = 16;
            secondaryAttachRadio.TabStop = true;
            secondaryAttachRadio.Text = "Secondary Weapon Attachment";
            secondaryAttachRadio.UseVisualStyleBackColor = true;
            // 
            // secondaryRadio
            // 
            secondaryRadio.AutoSize = true;
            secondaryRadio.Cursor = Cursors.Hand;
            secondaryRadio.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secondaryRadio.ForeColor = Color.FromArgb(114, 44, 133);
            secondaryRadio.Location = new Point(32, 177);
            secondaryRadio.Name = "secondaryRadio";
            secondaryRadio.Size = new Size(186, 24);
            secondaryRadio.TabIndex = 15;
            secondaryRadio.TabStop = true;
            secondaryRadio.Text = "Secondary Weapon";
            secondaryRadio.UseVisualStyleBackColor = true;
            // 
            // primaryAttachRadio
            // 
            primaryAttachRadio.AutoSize = true;
            primaryAttachRadio.Cursor = Cursors.Hand;
            primaryAttachRadio.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            primaryAttachRadio.ForeColor = Color.FromArgb(114, 44, 133);
            primaryAttachRadio.Location = new Point(32, 124);
            primaryAttachRadio.Name = "primaryAttachRadio";
            primaryAttachRadio.Size = new Size(264, 24);
            primaryAttachRadio.TabIndex = 14;
            primaryAttachRadio.TabStop = true;
            primaryAttachRadio.Text = "Primary Weapon Attachment";
            primaryAttachRadio.UseVisualStyleBackColor = true;
            // 
            // primaryRadio
            // 
            primaryRadio.AutoSize = true;
            primaryRadio.Cursor = Cursors.Hand;
            primaryRadio.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            primaryRadio.ForeColor = Color.FromArgb(114, 44, 133);
            primaryRadio.Location = new Point(32, 70);
            primaryRadio.Name = "primaryRadio";
            primaryRadio.Size = new Size(162, 24);
            primaryRadio.TabIndex = 13;
            primaryRadio.TabStop = true;
            primaryRadio.Text = "Primary Weapon";
            primaryRadio.UseVisualStyleBackColor = true;
            primaryRadio.CheckedChanged += primaryRadio_CheckedChanged;
            // 
            // itemsLabel
            // 
            itemsLabel.AutoSize = true;
            itemsLabel.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            itemsLabel.ForeColor = Color.FromArgb(114, 44, 133);
            itemsLabel.Location = new Point(545, 77);
            itemsLabel.Name = "itemsLabel";
            itemsLabel.Size = new Size(64, 20);
            itemsLabel.TabIndex = 12;
            itemsLabel.Text = "Items :";
            // 
            // comboBoxItems
            // 
            comboBoxItems.BackColor = Color.FromArgb(40, 40, 40);
            comboBoxItems.FlatStyle = FlatStyle.Flat;
            comboBoxItems.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxItems.ForeColor = Color.FromArgb(114, 44, 133);
            comboBoxItems.FormattingEnabled = true;
            comboBoxItems.Location = new Point(624, 70);
            comboBoxItems.Name = "comboBoxItems";
            comboBoxItems.Size = new Size(224, 33);
            comboBoxItems.TabIndex = 11;
            comboBoxItems.SelectedIndexChanged += comboBoxItems_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(40, 40, 40);
            tabPage1.Controls.Add(camoClass2Radio);
            tabPage1.Controls.Add(specialGrenadeClass2Radio);
            tabPage1.Controls.Add(perk3Class2Radio);
            tabPage1.Controls.Add(perk2Class2Radio);
            tabPage1.Controls.Add(perk1Class2Radio);
            tabPage1.Controls.Add(secondaryAttachClass2Radio);
            tabPage1.Controls.Add(secondaryClass2Radio);
            tabPage1.Controls.Add(primaryWeaponAttachClass2Radio);
            tabPage1.Controls.Add(primaryWeaponClass2Radio);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(comboBoxItemsClass2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(916, 649);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Class 2";
            // 
            // camoClass2Radio
            // 
            camoClass2Radio.AutoSize = true;
            camoClass2Radio.Cursor = Cursors.Hand;
            camoClass2Radio.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            camoClass2Radio.ForeColor = Color.FromArgb(114, 44, 133);
            camoClass2Radio.Location = new Point(39, 483);
            camoClass2Radio.Name = "camoClass2Radio";
            camoClass2Radio.Size = new Size(74, 24);
            camoClass2Radio.TabIndex = 32;
            camoClass2Radio.TabStop = true;
            camoClass2Radio.Text = "Camo";
            camoClass2Radio.UseVisualStyleBackColor = true;
            // 
            // specialGrenadeClass2Radio
            // 
            specialGrenadeClass2Radio.AutoSize = true;
            specialGrenadeClass2Radio.Cursor = Cursors.Hand;
            specialGrenadeClass2Radio.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            specialGrenadeClass2Radio.ForeColor = Color.FromArgb(114, 44, 133);
            specialGrenadeClass2Radio.Location = new Point(39, 432);
            specialGrenadeClass2Radio.Name = "specialGrenadeClass2Radio";
            specialGrenadeClass2Radio.Size = new Size(158, 24);
            specialGrenadeClass2Radio.TabIndex = 31;
            specialGrenadeClass2Radio.TabStop = true;
            specialGrenadeClass2Radio.Text = "Special Grenade";
            specialGrenadeClass2Radio.UseVisualStyleBackColor = true;
            // 
            // perk3Class2Radio
            // 
            perk3Class2Radio.AutoSize = true;
            perk3Class2Radio.Cursor = Cursors.Hand;
            perk3Class2Radio.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            perk3Class2Radio.ForeColor = Color.FromArgb(114, 44, 133);
            perk3Class2Radio.Location = new Point(39, 381);
            perk3Class2Radio.Name = "perk3Class2Radio";
            perk3Class2Radio.Size = new Size(81, 24);
            perk3Class2Radio.TabIndex = 30;
            perk3Class2Radio.TabStop = true;
            perk3Class2Radio.Text = "Perk 3";
            perk3Class2Radio.UseVisualStyleBackColor = true;
            // 
            // perk2Class2Radio
            // 
            perk2Class2Radio.AutoSize = true;
            perk2Class2Radio.Cursor = Cursors.Hand;
            perk2Class2Radio.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            perk2Class2Radio.ForeColor = Color.FromArgb(114, 44, 133);
            perk2Class2Radio.Location = new Point(39, 331);
            perk2Class2Radio.Name = "perk2Class2Radio";
            perk2Class2Radio.Size = new Size(81, 24);
            perk2Class2Radio.TabIndex = 29;
            perk2Class2Radio.TabStop = true;
            perk2Class2Radio.Text = "Perk 2";
            perk2Class2Radio.UseVisualStyleBackColor = true;
            // 
            // perk1Class2Radio
            // 
            perk1Class2Radio.AutoSize = true;
            perk1Class2Radio.Cursor = Cursors.Hand;
            perk1Class2Radio.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            perk1Class2Radio.ForeColor = Color.FromArgb(114, 44, 133);
            perk1Class2Radio.Location = new Point(39, 278);
            perk1Class2Radio.Name = "perk1Class2Radio";
            perk1Class2Radio.Size = new Size(81, 24);
            perk1Class2Radio.TabIndex = 28;
            perk1Class2Radio.TabStop = true;
            perk1Class2Radio.Text = "Perk 1";
            perk1Class2Radio.UseVisualStyleBackColor = true;
            // 
            // secondaryAttachClass2Radio
            // 
            secondaryAttachClass2Radio.AutoSize = true;
            secondaryAttachClass2Radio.Cursor = Cursors.Hand;
            secondaryAttachClass2Radio.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secondaryAttachClass2Radio.ForeColor = Color.FromArgb(114, 44, 133);
            secondaryAttachClass2Radio.Location = new Point(39, 228);
            secondaryAttachClass2Radio.Name = "secondaryAttachClass2Radio";
            secondaryAttachClass2Radio.Size = new Size(288, 24);
            secondaryAttachClass2Radio.TabIndex = 27;
            secondaryAttachClass2Radio.TabStop = true;
            secondaryAttachClass2Radio.Text = "Secondary Weapon Attachment";
            secondaryAttachClass2Radio.UseVisualStyleBackColor = true;
            // 
            // secondaryClass2Radio
            // 
            secondaryClass2Radio.AutoSize = true;
            secondaryClass2Radio.Cursor = Cursors.Hand;
            secondaryClass2Radio.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secondaryClass2Radio.ForeColor = Color.FromArgb(114, 44, 133);
            secondaryClass2Radio.Location = new Point(39, 176);
            secondaryClass2Radio.Name = "secondaryClass2Radio";
            secondaryClass2Radio.Size = new Size(186, 24);
            secondaryClass2Radio.TabIndex = 26;
            secondaryClass2Radio.TabStop = true;
            secondaryClass2Radio.Text = "Secondary Weapon";
            secondaryClass2Radio.UseVisualStyleBackColor = true;
            // 
            // primaryWeaponAttachClass2Radio
            // 
            primaryWeaponAttachClass2Radio.AutoSize = true;
            primaryWeaponAttachClass2Radio.Cursor = Cursors.Hand;
            primaryWeaponAttachClass2Radio.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            primaryWeaponAttachClass2Radio.ForeColor = Color.FromArgb(114, 44, 133);
            primaryWeaponAttachClass2Radio.Location = new Point(39, 123);
            primaryWeaponAttachClass2Radio.Name = "primaryWeaponAttachClass2Radio";
            primaryWeaponAttachClass2Radio.Size = new Size(264, 24);
            primaryWeaponAttachClass2Radio.TabIndex = 25;
            primaryWeaponAttachClass2Radio.TabStop = true;
            primaryWeaponAttachClass2Radio.Text = "Primary Weapon Attachment";
            primaryWeaponAttachClass2Radio.UseVisualStyleBackColor = true;
            // 
            // primaryWeaponClass2Radio
            // 
            primaryWeaponClass2Radio.AutoSize = true;
            primaryWeaponClass2Radio.Cursor = Cursors.Hand;
            primaryWeaponClass2Radio.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            primaryWeaponClass2Radio.ForeColor = Color.FromArgb(114, 44, 133);
            primaryWeaponClass2Radio.Location = new Point(39, 69);
            primaryWeaponClass2Radio.Name = "primaryWeaponClass2Radio";
            primaryWeaponClass2Radio.Size = new Size(162, 24);
            primaryWeaponClass2Radio.TabIndex = 24;
            primaryWeaponClass2Radio.TabStop = true;
            primaryWeaponClass2Radio.Text = "Primary Weapon";
            primaryWeaponClass2Radio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(114, 44, 133);
            label1.Location = new Point(552, 76);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 23;
            label1.Text = "Items :";
            // 
            // comboBoxItemsClass2
            // 
            comboBoxItemsClass2.BackColor = Color.FromArgb(40, 40, 40);
            comboBoxItemsClass2.FlatStyle = FlatStyle.Flat;
            comboBoxItemsClass2.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxItemsClass2.ForeColor = Color.FromArgb(114, 44, 133);
            comboBoxItemsClass2.FormattingEnabled = true;
            comboBoxItemsClass2.Location = new Point(631, 69);
            comboBoxItemsClass2.Name = "comboBoxItemsClass2";
            comboBoxItemsClass2.Size = new Size(224, 33);
            comboBoxItemsClass2.TabIndex = 22;
            comboBoxItemsClass2.SelectedIndexChanged += comboBoxItemsClass2_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(40, 40, 40);
            tabPage3.Controls.Add(camoClass3);
            tabPage3.Controls.Add(specialGrenadeClass3);
            tabPage3.Controls.Add(perk3Class3);
            tabPage3.Controls.Add(perk2Class3);
            tabPage3.Controls.Add(perk1Class3);
            tabPage3.Controls.Add(secondaryAttachClass3Radio);
            tabPage3.Controls.Add(secondaryClass3);
            tabPage3.Controls.Add(primaryAttachClass3Radio);
            tabPage3.Controls.Add(primaryClass3Radio);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(comboBoxItemsClass3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(916, 649);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "Class 3";
            // 
            // camoClass3
            // 
            camoClass3.AutoSize = true;
            camoClass3.Cursor = Cursors.Hand;
            camoClass3.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            camoClass3.ForeColor = Color.FromArgb(114, 44, 133);
            camoClass3.Location = new Point(39, 493);
            camoClass3.Name = "camoClass3";
            camoClass3.Size = new Size(74, 24);
            camoClass3.TabIndex = 43;
            camoClass3.TabStop = true;
            camoClass3.Text = "Camo";
            camoClass3.UseVisualStyleBackColor = true;
            // 
            // specialGrenadeClass3
            // 
            specialGrenadeClass3.AutoSize = true;
            specialGrenadeClass3.Cursor = Cursors.Hand;
            specialGrenadeClass3.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            specialGrenadeClass3.ForeColor = Color.FromArgb(114, 44, 133);
            specialGrenadeClass3.Location = new Point(39, 442);
            specialGrenadeClass3.Name = "specialGrenadeClass3";
            specialGrenadeClass3.Size = new Size(158, 24);
            specialGrenadeClass3.TabIndex = 42;
            specialGrenadeClass3.TabStop = true;
            specialGrenadeClass3.Text = "Special Grenade";
            specialGrenadeClass3.UseVisualStyleBackColor = true;
            // 
            // perk3Class3
            // 
            perk3Class3.AutoSize = true;
            perk3Class3.Cursor = Cursors.Hand;
            perk3Class3.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            perk3Class3.ForeColor = Color.FromArgb(114, 44, 133);
            perk3Class3.Location = new Point(39, 391);
            perk3Class3.Name = "perk3Class3";
            perk3Class3.Size = new Size(81, 24);
            perk3Class3.TabIndex = 41;
            perk3Class3.TabStop = true;
            perk3Class3.Text = "Perk 3";
            perk3Class3.UseVisualStyleBackColor = true;
            // 
            // perk2Class3
            // 
            perk2Class3.AutoSize = true;
            perk2Class3.Cursor = Cursors.Hand;
            perk2Class3.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            perk2Class3.ForeColor = Color.FromArgb(114, 44, 133);
            perk2Class3.Location = new Point(39, 341);
            perk2Class3.Name = "perk2Class3";
            perk2Class3.Size = new Size(81, 24);
            perk2Class3.TabIndex = 40;
            perk2Class3.TabStop = true;
            perk2Class3.Text = "Perk 2";
            perk2Class3.UseVisualStyleBackColor = true;
            // 
            // perk1Class3
            // 
            perk1Class3.AutoSize = true;
            perk1Class3.Cursor = Cursors.Hand;
            perk1Class3.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            perk1Class3.ForeColor = Color.FromArgb(114, 44, 133);
            perk1Class3.Location = new Point(39, 288);
            perk1Class3.Name = "perk1Class3";
            perk1Class3.Size = new Size(81, 24);
            perk1Class3.TabIndex = 39;
            perk1Class3.TabStop = true;
            perk1Class3.Text = "Perk 1";
            perk1Class3.UseVisualStyleBackColor = true;
            // 
            // secondaryAttachClass3Radio
            // 
            secondaryAttachClass3Radio.AutoSize = true;
            secondaryAttachClass3Radio.Cursor = Cursors.Hand;
            secondaryAttachClass3Radio.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secondaryAttachClass3Radio.ForeColor = Color.FromArgb(114, 44, 133);
            secondaryAttachClass3Radio.Location = new Point(39, 238);
            secondaryAttachClass3Radio.Name = "secondaryAttachClass3Radio";
            secondaryAttachClass3Radio.Size = new Size(288, 24);
            secondaryAttachClass3Radio.TabIndex = 38;
            secondaryAttachClass3Radio.TabStop = true;
            secondaryAttachClass3Radio.Text = "Secondary Weapon Attachment";
            secondaryAttachClass3Radio.UseVisualStyleBackColor = true;
            // 
            // secondaryClass3
            // 
            secondaryClass3.AutoSize = true;
            secondaryClass3.Cursor = Cursors.Hand;
            secondaryClass3.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secondaryClass3.ForeColor = Color.FromArgb(114, 44, 133);
            secondaryClass3.Location = new Point(39, 186);
            secondaryClass3.Name = "secondaryClass3";
            secondaryClass3.Size = new Size(186, 24);
            secondaryClass3.TabIndex = 37;
            secondaryClass3.TabStop = true;
            secondaryClass3.Text = "Secondary Weapon";
            secondaryClass3.UseVisualStyleBackColor = true;
            // 
            // primaryAttachClass3Radio
            // 
            primaryAttachClass3Radio.AutoSize = true;
            primaryAttachClass3Radio.Cursor = Cursors.Hand;
            primaryAttachClass3Radio.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            primaryAttachClass3Radio.ForeColor = Color.FromArgb(114, 44, 133);
            primaryAttachClass3Radio.Location = new Point(39, 133);
            primaryAttachClass3Radio.Name = "primaryAttachClass3Radio";
            primaryAttachClass3Radio.Size = new Size(264, 24);
            primaryAttachClass3Radio.TabIndex = 36;
            primaryAttachClass3Radio.TabStop = true;
            primaryAttachClass3Radio.Text = "Primary Weapon Attachment";
            primaryAttachClass3Radio.UseVisualStyleBackColor = true;
            // 
            // primaryClass3Radio
            // 
            primaryClass3Radio.AutoSize = true;
            primaryClass3Radio.Cursor = Cursors.Hand;
            primaryClass3Radio.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            primaryClass3Radio.ForeColor = Color.FromArgb(114, 44, 133);
            primaryClass3Radio.Location = new Point(39, 79);
            primaryClass3Radio.Name = "primaryClass3Radio";
            primaryClass3Radio.Size = new Size(162, 24);
            primaryClass3Radio.TabIndex = 35;
            primaryClass3Radio.TabStop = true;
            primaryClass3Radio.Text = "Primary Weapon";
            primaryClass3Radio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(114, 44, 133);
            label2.Location = new Point(552, 86);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 34;
            label2.Text = "Items :";
            // 
            // comboBoxItemsClass3
            // 
            comboBoxItemsClass3.BackColor = Color.FromArgb(40, 40, 40);
            comboBoxItemsClass3.FlatStyle = FlatStyle.Flat;
            comboBoxItemsClass3.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxItemsClass3.ForeColor = Color.FromArgb(114, 44, 133);
            comboBoxItemsClass3.FormattingEnabled = true;
            comboBoxItemsClass3.Location = new Point(631, 79);
            comboBoxItemsClass3.Name = "comboBoxItemsClass3";
            comboBoxItemsClass3.Size = new Size(224, 33);
            comboBoxItemsClass3.TabIndex = 33;
            comboBoxItemsClass3.SelectedIndexChanged += comboBoxItemsClass3_SelectedIndexChanged;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(40, 40, 40);
            tabPage4.Controls.Add(camoClass4);
            tabPage4.Controls.Add(specialGrenadeClass4);
            tabPage4.Controls.Add(perk3Class4);
            tabPage4.Controls.Add(perk2Class4);
            tabPage4.Controls.Add(perk1Class4);
            tabPage4.Controls.Add(secondaryAttachClass4);
            tabPage4.Controls.Add(secondaryClass4);
            tabPage4.Controls.Add(primaryAttachClass4);
            tabPage4.Controls.Add(primaryClass4);
            tabPage4.Controls.Add(label3);
            tabPage4.Controls.Add(comboBoxItemsClass4);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(916, 649);
            tabPage4.TabIndex = 4;
            tabPage4.Text = "Class 4";
            // 
            // camoClass4
            // 
            camoClass4.AutoSize = true;
            camoClass4.Cursor = Cursors.Hand;
            camoClass4.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            camoClass4.ForeColor = Color.FromArgb(114, 44, 133);
            camoClass4.Location = new Point(49, 490);
            camoClass4.Name = "camoClass4";
            camoClass4.Size = new Size(74, 24);
            camoClass4.TabIndex = 54;
            camoClass4.TabStop = true;
            camoClass4.Text = "Camo";
            camoClass4.UseVisualStyleBackColor = true;
            // 
            // specialGrenadeClass4
            // 
            specialGrenadeClass4.AutoSize = true;
            specialGrenadeClass4.Cursor = Cursors.Hand;
            specialGrenadeClass4.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            specialGrenadeClass4.ForeColor = Color.FromArgb(114, 44, 133);
            specialGrenadeClass4.Location = new Point(49, 439);
            specialGrenadeClass4.Name = "specialGrenadeClass4";
            specialGrenadeClass4.Size = new Size(158, 24);
            specialGrenadeClass4.TabIndex = 53;
            specialGrenadeClass4.TabStop = true;
            specialGrenadeClass4.Text = "Special Grenade";
            specialGrenadeClass4.UseVisualStyleBackColor = true;
            // 
            // perk3Class4
            // 
            perk3Class4.AutoSize = true;
            perk3Class4.Cursor = Cursors.Hand;
            perk3Class4.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            perk3Class4.ForeColor = Color.FromArgb(114, 44, 133);
            perk3Class4.Location = new Point(49, 388);
            perk3Class4.Name = "perk3Class4";
            perk3Class4.Size = new Size(81, 24);
            perk3Class4.TabIndex = 52;
            perk3Class4.TabStop = true;
            perk3Class4.Text = "Perk 3";
            perk3Class4.UseVisualStyleBackColor = true;
            // 
            // perk2Class4
            // 
            perk2Class4.AutoSize = true;
            perk2Class4.Cursor = Cursors.Hand;
            perk2Class4.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            perk2Class4.ForeColor = Color.FromArgb(114, 44, 133);
            perk2Class4.Location = new Point(49, 338);
            perk2Class4.Name = "perk2Class4";
            perk2Class4.Size = new Size(81, 24);
            perk2Class4.TabIndex = 51;
            perk2Class4.TabStop = true;
            perk2Class4.Text = "Perk 2";
            perk2Class4.UseVisualStyleBackColor = true;
            // 
            // perk1Class4
            // 
            perk1Class4.AutoSize = true;
            perk1Class4.Cursor = Cursors.Hand;
            perk1Class4.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            perk1Class4.ForeColor = Color.FromArgb(114, 44, 133);
            perk1Class4.Location = new Point(49, 285);
            perk1Class4.Name = "perk1Class4";
            perk1Class4.Size = new Size(81, 24);
            perk1Class4.TabIndex = 50;
            perk1Class4.TabStop = true;
            perk1Class4.Text = "Perk 1";
            perk1Class4.UseVisualStyleBackColor = true;
            // 
            // secondaryAttachClass4
            // 
            secondaryAttachClass4.AutoSize = true;
            secondaryAttachClass4.Cursor = Cursors.Hand;
            secondaryAttachClass4.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secondaryAttachClass4.ForeColor = Color.FromArgb(114, 44, 133);
            secondaryAttachClass4.Location = new Point(49, 235);
            secondaryAttachClass4.Name = "secondaryAttachClass4";
            secondaryAttachClass4.Size = new Size(288, 24);
            secondaryAttachClass4.TabIndex = 49;
            secondaryAttachClass4.TabStop = true;
            secondaryAttachClass4.Text = "Secondary Weapon Attachment";
            secondaryAttachClass4.UseVisualStyleBackColor = true;
            // 
            // secondaryClass4
            // 
            secondaryClass4.AutoSize = true;
            secondaryClass4.Cursor = Cursors.Hand;
            secondaryClass4.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secondaryClass4.ForeColor = Color.FromArgb(114, 44, 133);
            secondaryClass4.Location = new Point(49, 183);
            secondaryClass4.Name = "secondaryClass4";
            secondaryClass4.Size = new Size(186, 24);
            secondaryClass4.TabIndex = 48;
            secondaryClass4.TabStop = true;
            secondaryClass4.Text = "Secondary Weapon";
            secondaryClass4.UseVisualStyleBackColor = true;
            // 
            // primaryAttachClass4
            // 
            primaryAttachClass4.AutoSize = true;
            primaryAttachClass4.Cursor = Cursors.Hand;
            primaryAttachClass4.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            primaryAttachClass4.ForeColor = Color.FromArgb(114, 44, 133);
            primaryAttachClass4.Location = new Point(49, 130);
            primaryAttachClass4.Name = "primaryAttachClass4";
            primaryAttachClass4.Size = new Size(264, 24);
            primaryAttachClass4.TabIndex = 47;
            primaryAttachClass4.TabStop = true;
            primaryAttachClass4.Text = "Primary Weapon Attachment";
            primaryAttachClass4.UseVisualStyleBackColor = true;
            // 
            // primaryClass4
            // 
            primaryClass4.AutoSize = true;
            primaryClass4.Cursor = Cursors.Hand;
            primaryClass4.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            primaryClass4.ForeColor = Color.FromArgb(114, 44, 133);
            primaryClass4.Location = new Point(49, 76);
            primaryClass4.Name = "primaryClass4";
            primaryClass4.Size = new Size(162, 24);
            primaryClass4.TabIndex = 46;
            primaryClass4.TabStop = true;
            primaryClass4.Text = "Primary Weapon";
            primaryClass4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(114, 44, 133);
            label3.Location = new Point(562, 83);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 45;
            label3.Text = "Items :";
            // 
            // comboBoxItemsClass4
            // 
            comboBoxItemsClass4.BackColor = Color.FromArgb(40, 40, 40);
            comboBoxItemsClass4.FlatStyle = FlatStyle.Flat;
            comboBoxItemsClass4.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxItemsClass4.ForeColor = Color.FromArgb(114, 44, 133);
            comboBoxItemsClass4.FormattingEnabled = true;
            comboBoxItemsClass4.Location = new Point(641, 76);
            comboBoxItemsClass4.Name = "comboBoxItemsClass4";
            comboBoxItemsClass4.Size = new Size(224, 33);
            comboBoxItemsClass4.TabIndex = 44;
            comboBoxItemsClass4.SelectedIndexChanged += comboBoxItemsClass4_SelectedIndexChanged;
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.FromArgb(40, 40, 40);
            tabPage5.Controls.Add(camoClass5);
            tabPage5.Controls.Add(specialGrenadeClass5);
            tabPage5.Controls.Add(perk3Class5);
            tabPage5.Controls.Add(perk2Class5);
            tabPage5.Controls.Add(perk1Class5);
            tabPage5.Controls.Add(secondaryAttachClass5);
            tabPage5.Controls.Add(secondaryClass5);
            tabPage5.Controls.Add(primaryAttachClass5);
            tabPage5.Controls.Add(primaryClass5);
            tabPage5.Controls.Add(label4);
            tabPage5.Controls.Add(comboBoxItemsClass5);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(916, 649);
            tabPage5.TabIndex = 5;
            tabPage5.Text = "Class 5";
            tabPage5.Click += tabPage5_Click;
            // 
            // camoClass5
            // 
            camoClass5.AutoSize = true;
            camoClass5.Cursor = Cursors.Hand;
            camoClass5.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            camoClass5.ForeColor = Color.FromArgb(114, 44, 133);
            camoClass5.Location = new Point(44, 482);
            camoClass5.Name = "camoClass5";
            camoClass5.Size = new Size(74, 24);
            camoClass5.TabIndex = 65;
            camoClass5.TabStop = true;
            camoClass5.Text = "Camo";
            camoClass5.UseVisualStyleBackColor = true;
            // 
            // specialGrenadeClass5
            // 
            specialGrenadeClass5.AutoSize = true;
            specialGrenadeClass5.Cursor = Cursors.Hand;
            specialGrenadeClass5.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            specialGrenadeClass5.ForeColor = Color.FromArgb(114, 44, 133);
            specialGrenadeClass5.Location = new Point(44, 431);
            specialGrenadeClass5.Name = "specialGrenadeClass5";
            specialGrenadeClass5.Size = new Size(158, 24);
            specialGrenadeClass5.TabIndex = 64;
            specialGrenadeClass5.TabStop = true;
            specialGrenadeClass5.Text = "Special Grenade";
            specialGrenadeClass5.UseVisualStyleBackColor = true;
            // 
            // perk3Class5
            // 
            perk3Class5.AutoSize = true;
            perk3Class5.Cursor = Cursors.Hand;
            perk3Class5.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            perk3Class5.ForeColor = Color.FromArgb(114, 44, 133);
            perk3Class5.Location = new Point(44, 380);
            perk3Class5.Name = "perk3Class5";
            perk3Class5.Size = new Size(81, 24);
            perk3Class5.TabIndex = 63;
            perk3Class5.TabStop = true;
            perk3Class5.Text = "Perk 3";
            perk3Class5.UseVisualStyleBackColor = true;
            // 
            // perk2Class5
            // 
            perk2Class5.AutoSize = true;
            perk2Class5.Cursor = Cursors.Hand;
            perk2Class5.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            perk2Class5.ForeColor = Color.FromArgb(114, 44, 133);
            perk2Class5.Location = new Point(44, 330);
            perk2Class5.Name = "perk2Class5";
            perk2Class5.Size = new Size(81, 24);
            perk2Class5.TabIndex = 62;
            perk2Class5.TabStop = true;
            perk2Class5.Text = "Perk 2";
            perk2Class5.UseVisualStyleBackColor = true;
            // 
            // perk1Class5
            // 
            perk1Class5.AutoSize = true;
            perk1Class5.Cursor = Cursors.Hand;
            perk1Class5.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            perk1Class5.ForeColor = Color.FromArgb(114, 44, 133);
            perk1Class5.Location = new Point(44, 277);
            perk1Class5.Name = "perk1Class5";
            perk1Class5.Size = new Size(81, 24);
            perk1Class5.TabIndex = 61;
            perk1Class5.TabStop = true;
            perk1Class5.Text = "Perk 1";
            perk1Class5.UseVisualStyleBackColor = true;
            // 
            // secondaryAttachClass5
            // 
            secondaryAttachClass5.AutoSize = true;
            secondaryAttachClass5.Cursor = Cursors.Hand;
            secondaryAttachClass5.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secondaryAttachClass5.ForeColor = Color.FromArgb(114, 44, 133);
            secondaryAttachClass5.Location = new Point(44, 227);
            secondaryAttachClass5.Name = "secondaryAttachClass5";
            secondaryAttachClass5.Size = new Size(288, 24);
            secondaryAttachClass5.TabIndex = 60;
            secondaryAttachClass5.TabStop = true;
            secondaryAttachClass5.Text = "Secondary Weapon Attachment";
            secondaryAttachClass5.UseVisualStyleBackColor = true;
            // 
            // secondaryClass5
            // 
            secondaryClass5.AutoSize = true;
            secondaryClass5.Cursor = Cursors.Hand;
            secondaryClass5.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secondaryClass5.ForeColor = Color.FromArgb(114, 44, 133);
            secondaryClass5.Location = new Point(44, 175);
            secondaryClass5.Name = "secondaryClass5";
            secondaryClass5.Size = new Size(186, 24);
            secondaryClass5.TabIndex = 59;
            secondaryClass5.TabStop = true;
            secondaryClass5.Text = "Secondary Weapon";
            secondaryClass5.UseVisualStyleBackColor = true;
            // 
            // primaryAttachClass5
            // 
            primaryAttachClass5.AutoSize = true;
            primaryAttachClass5.Cursor = Cursors.Hand;
            primaryAttachClass5.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            primaryAttachClass5.ForeColor = Color.FromArgb(114, 44, 133);
            primaryAttachClass5.Location = new Point(44, 122);
            primaryAttachClass5.Name = "primaryAttachClass5";
            primaryAttachClass5.Size = new Size(264, 24);
            primaryAttachClass5.TabIndex = 58;
            primaryAttachClass5.TabStop = true;
            primaryAttachClass5.Text = "Primary Weapon Attachment";
            primaryAttachClass5.UseVisualStyleBackColor = true;
            // 
            // primaryClass5
            // 
            primaryClass5.AutoSize = true;
            primaryClass5.Cursor = Cursors.Hand;
            primaryClass5.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            primaryClass5.ForeColor = Color.FromArgb(114, 44, 133);
            primaryClass5.Location = new Point(44, 68);
            primaryClass5.Name = "primaryClass5";
            primaryClass5.Size = new Size(162, 24);
            primaryClass5.TabIndex = 57;
            primaryClass5.TabStop = true;
            primaryClass5.Text = "Primary Weapon";
            primaryClass5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(114, 44, 133);
            label4.Location = new Point(557, 75);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 56;
            label4.Text = "Items :";
            // 
            // comboBoxItemsClass5
            // 
            comboBoxItemsClass5.BackColor = Color.FromArgb(40, 40, 40);
            comboBoxItemsClass5.FlatStyle = FlatStyle.Flat;
            comboBoxItemsClass5.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxItemsClass5.ForeColor = Color.FromArgb(114, 44, 133);
            comboBoxItemsClass5.FormattingEnabled = true;
            comboBoxItemsClass5.Location = new Point(636, 68);
            comboBoxItemsClass5.Name = "comboBoxItemsClass5";
            comboBoxItemsClass5.Size = new Size(224, 33);
            comboBoxItemsClass5.TabIndex = 55;
            comboBoxItemsClass5.SelectedIndexChanged += comboBoxItemsClass5_SelectedIndexChanged;
            // 
            // COD4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            Controls.Add(cod4TabControl);
            Name = "COD4";
            Size = new Size(924, 677);
            Load += COD4_Load;
            cod4TabControl.ResumeLayout(false);
            cod4MainPage.ResumeLayout(false);
            cod4MainPage.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl cod4TabControl;
        private TabPage tabPage2;
        private TabPage cod4MainPage;
        private Label noteLabel;
        private FontAwesome.Sharp.IconButton SendClassNamesBtn;
        private CustomTextBox.HaunterTextBox haunterTextBoxClassName5;
        private CustomTextBox.HaunterTextBox haunterTextBoxClassName4;
        private CustomTextBox.HaunterTextBox haunterTextBoxClassName3;
        private CustomTextBox.HaunterTextBox haunterTextBoxClassName2;
        private CustomTextBox.HaunterTextBox haunterTextBoxClassName1;
        private ComboBox comboBoxPresetClassCOD4;
        private CustomTextBox.HaunterTextBox haunterTextBoxResult;
        private ComboBox comboBoxStringColours;
        private Label itemsLabel;
        private ComboBox comboBoxItems;
        private RadioButton primaryRadio;
        private RadioButton secondaryAttachRadio;
        private RadioButton secondaryRadio;
        private RadioButton primaryAttachRadio;
        private RadioButton camoRadio;
        private RadioButton specialGrenadeRadio;
        private RadioButton perk3Radio;
        private RadioButton perk2Radio;
        private RadioButton perk1Radio;
        private FontAwesome.Sharp.IconButton buttonsText;
        private TabPage tabPage1;
        private RadioButton camoClass2Radio;
        private RadioButton specialGrenadeClass2Radio;
        private RadioButton perk3Class2Radio;
        private RadioButton perk2Class2Radio;
        private RadioButton perk1Class2Radio;
        private RadioButton secondaryAttachClass2Radio;
        private RadioButton secondaryClass2Radio;
        private RadioButton primaryWeaponAttachClass2Radio;
        private RadioButton primaryWeaponClass2Radio;
        private Label label1;
        private ComboBox comboBoxItemsClass2;
        private TabPage tabPage3;
        private RadioButton camoClass3;
        private RadioButton specialGrenadeClass3;
        private RadioButton perk3Class3;
        private RadioButton perk2Class3;
        private RadioButton perk1Class3;
        private RadioButton secondaryAttachClass3Radio;
        private RadioButton secondaryClass3;
        private RadioButton primaryAttachClass3Radio;
        private RadioButton primaryClass3Radio;
        private Label label2;
        private ComboBox comboBoxItemsClass3;
        private TabPage tabPage4;
        private RadioButton camoClass4;
        private RadioButton specialGrenadeClass4;
        private RadioButton perk3Class4;
        private RadioButton perk2Class4;
        private RadioButton perk1Class4;
        private RadioButton secondaryAttachClass4;
        private RadioButton secondaryClass4;
        private RadioButton primaryAttachClass4;
        private RadioButton primaryClass4;
        private Label label3;
        private ComboBox comboBoxItemsClass4;
        private TabPage tabPage5;
        private RadioButton camoClass5;
        private RadioButton specialGrenadeClass5;
        private RadioButton perk3Class5;
        private RadioButton perk2Class5;
        private RadioButton perk1Class5;
        private RadioButton secondaryAttachClass5;
        private RadioButton secondaryClass5;
        private RadioButton primaryAttachClass5;
        private RadioButton primaryClass5;
        private Label label4;
        private ComboBox comboBoxItemsClass5;
    }
}
