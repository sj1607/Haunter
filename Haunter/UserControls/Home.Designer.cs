namespace Haunter.UserControls
{
    partial class Home
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
            connectBtn = new FontAwesome.Sharp.IconButton();
            comboBoxConsole = new ComboBox();
            shutdownBtn = new FontAwesome.Sharp.IconButton();
            isConnectedLabel = new Label();
            responseLabel = new Label();
            haunterGroupBox1 = new Haunter.CustomGroupBox.HaunterGroupBox();
            haunterTextBoxGamertag = new Haunter.CustomTextBox.HaunterTextBox();
            gamertagLabel = new Label();
            haunterTextBoxTitleID = new Haunter.CustomTextBox.HaunterTextBox();
            titleIDLabel = new Label();
            haunterTextBoxCpuKey = new Haunter.CustomTextBox.HaunterTextBox();
            cpuKeyLabel = new Label();
            consoleIPLabel = new Label();
            haunterTextBoxIP = new Haunter.CustomTextBox.HaunterTextBox();
            reloadInfosBtn = new FontAwesome.Sharp.IconButton();
            haunterGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // connectBtn
            // 
            connectBtn.Cursor = Cursors.Hand;
            connectBtn.FlatAppearance.BorderSize = 0;
            connectBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
            connectBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 33, 33);
            connectBtn.FlatStyle = FlatStyle.Flat;
            connectBtn.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            connectBtn.ForeColor = Color.FromArgb(114, 44, 133);
            connectBtn.IconChar = FontAwesome.Sharp.IconChar.Plug;
            connectBtn.IconColor = Color.FromArgb(114, 44, 133);
            connectBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            connectBtn.IconSize = 40;
            connectBtn.ImageAlign = ContentAlignment.MiddleLeft;
            connectBtn.Location = new Point(29, 27);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(212, 49);
            connectBtn.TabIndex = 0;
            connectBtn.Text = "Connect";
            connectBtn.UseVisualStyleBackColor = true;
            connectBtn.Click += connectBtn_Click;
            // 
            // comboBoxConsole
            // 
            comboBoxConsole.BackColor = Color.FromArgb(40, 40, 40);
            comboBoxConsole.FlatStyle = FlatStyle.Flat;
            comboBoxConsole.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxConsole.ForeColor = Color.FromArgb(114, 44, 133);
            comboBoxConsole.FormattingEnabled = true;
            comboBoxConsole.Items.AddRange(new object[] { "Reboot Title", "Reboot Console" });
            comboBoxConsole.Location = new Point(569, 36);
            comboBoxConsole.Name = "comboBoxConsole";
            comboBoxConsole.Size = new Size(196, 33);
            comboBoxConsole.TabIndex = 1;
            comboBoxConsole.Text = "Reboot Mode";
            comboBoxConsole.SelectedIndexChanged += comboBoxConsole_SelectedIndexChanged;
            // 
            // shutdownBtn
            // 
            shutdownBtn.Cursor = Cursors.Hand;
            shutdownBtn.FlatAppearance.BorderSize = 0;
            shutdownBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            shutdownBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            shutdownBtn.FlatStyle = FlatStyle.Flat;
            shutdownBtn.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            shutdownBtn.ForeColor = Color.FromArgb(114, 44, 133);
            shutdownBtn.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            shutdownBtn.IconColor = Color.FromArgb(114, 44, 133);
            shutdownBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            shutdownBtn.IconSize = 40;
            shutdownBtn.ImageAlign = ContentAlignment.MiddleLeft;
            shutdownBtn.Location = new Point(291, 27);
            shutdownBtn.Name = "shutdownBtn";
            shutdownBtn.Size = new Size(212, 49);
            shutdownBtn.TabIndex = 2;
            shutdownBtn.Text = "Shutdown";
            shutdownBtn.UseVisualStyleBackColor = true;
            shutdownBtn.Click += shutdownBtn_Click;
            // 
            // isConnectedLabel
            // 
            isConnectedLabel.AutoSize = true;
            isConnectedLabel.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            isConnectedLabel.ForeColor = Color.FromArgb(114, 44, 133);
            isConnectedLabel.Location = new Point(26, 637);
            isConnectedLabel.Name = "isConnectedLabel";
            isConnectedLabel.Size = new Size(215, 25);
            isConnectedLabel.TabIndex = 3;
            isConnectedLabel.Text = "Connection Status : ";
            // 
            // responseLabel
            // 
            responseLabel.AutoSize = true;
            responseLabel.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            responseLabel.ForeColor = Color.Red;
            responseLabel.Location = new Point(247, 637);
            responseLabel.Name = "responseLabel";
            responseLabel.Size = new Size(152, 25);
            responseLabel.TabIndex = 4;
            responseLabel.Text = "Disconnected!";
            // 
            // haunterGroupBox1
            // 
            haunterGroupBox1.Controls.Add(haunterTextBoxGamertag);
            haunterGroupBox1.Controls.Add(gamertagLabel);
            haunterGroupBox1.Controls.Add(haunterTextBoxTitleID);
            haunterGroupBox1.Controls.Add(titleIDLabel);
            haunterGroupBox1.Controls.Add(haunterTextBoxCpuKey);
            haunterGroupBox1.Controls.Add(cpuKeyLabel);
            haunterGroupBox1.Controls.Add(consoleIPLabel);
            haunterGroupBox1.Controls.Add(haunterTextBoxIP);
            haunterGroupBox1.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            haunterGroupBox1.ForeColor = Color.FromArgb(114, 44, 133);
            haunterGroupBox1.Location = new Point(47, 195);
            haunterGroupBox1.Name = "haunterGroupBox1";
            haunterGroupBox1.Size = new Size(768, 373);
            haunterGroupBox1.TabIndex = 5;
            haunterGroupBox1.TabStop = false;
            haunterGroupBox1.Text = "Console Infos";
            // 
            // haunterTextBoxGamertag
            // 
            haunterTextBoxGamertag.BackColor = Color.FromArgb(40, 40, 40);
            haunterTextBoxGamertag.BorderStyle = BorderStyle.None;
            haunterTextBoxGamertag.ForeColor = Color.FromArgb(114, 44, 133);
            haunterTextBoxGamertag.Location = new Point(146, 269);
            haunterTextBoxGamertag.Name = "haunterTextBoxGamertag";
            haunterTextBoxGamertag.ReadOnly = true;
            haunterTextBoxGamertag.Size = new Size(310, 27);
            haunterTextBoxGamertag.TabIndex = 10;
            // 
            // gamertagLabel
            // 
            gamertagLabel.AutoSize = true;
            gamertagLabel.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gamertagLabel.ForeColor = Color.FromArgb(114, 44, 133);
            gamertagLabel.Location = new Point(6, 271);
            gamertagLabel.Name = "gamertagLabel";
            gamertagLabel.Size = new Size(125, 25);
            gamertagLabel.TabIndex = 9;
            gamertagLabel.Text = "Gamertag : ";
            // 
            // haunterTextBoxTitleID
            // 
            haunterTextBoxTitleID.BackColor = Color.FromArgb(40, 40, 40);
            haunterTextBoxTitleID.BorderStyle = BorderStyle.None;
            haunterTextBoxTitleID.ForeColor = Color.FromArgb(114, 44, 133);
            haunterTextBoxTitleID.Location = new Point(146, 207);
            haunterTextBoxTitleID.Name = "haunterTextBoxTitleID";
            haunterTextBoxTitleID.ReadOnly = true;
            haunterTextBoxTitleID.Size = new Size(287, 27);
            haunterTextBoxTitleID.TabIndex = 8;
            // 
            // titleIDLabel
            // 
            titleIDLabel.AutoSize = true;
            titleIDLabel.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleIDLabel.ForeColor = Color.FromArgb(114, 44, 133);
            titleIDLabel.Location = new Point(6, 209);
            titleIDLabel.Name = "titleIDLabel";
            titleIDLabel.Size = new Size(99, 25);
            titleIDLabel.TabIndex = 7;
            titleIDLabel.Text = "Title ID : ";
            // 
            // haunterTextBoxCpuKey
            // 
            haunterTextBoxCpuKey.BackColor = Color.FromArgb(40, 40, 40);
            haunterTextBoxCpuKey.BorderStyle = BorderStyle.None;
            haunterTextBoxCpuKey.ForeColor = Color.FromArgb(114, 44, 133);
            haunterTextBoxCpuKey.Location = new Point(146, 138);
            haunterTextBoxCpuKey.Name = "haunterTextBoxCpuKey";
            haunterTextBoxCpuKey.ReadOnly = true;
            haunterTextBoxCpuKey.Size = new Size(423, 27);
            haunterTextBoxCpuKey.TabIndex = 6;
            // 
            // cpuKeyLabel
            // 
            cpuKeyLabel.AutoSize = true;
            cpuKeyLabel.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cpuKeyLabel.ForeColor = Color.FromArgb(114, 44, 133);
            cpuKeyLabel.Location = new Point(6, 140);
            cpuKeyLabel.Name = "cpuKeyLabel";
            cpuKeyLabel.Size = new Size(114, 25);
            cpuKeyLabel.TabIndex = 5;
            cpuKeyLabel.Text = "CPU Key : ";
            // 
            // consoleIPLabel
            // 
            consoleIPLabel.AutoSize = true;
            consoleIPLabel.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            consoleIPLabel.ForeColor = Color.FromArgb(114, 44, 133);
            consoleIPLabel.Location = new Point(6, 69);
            consoleIPLabel.Name = "consoleIPLabel";
            consoleIPLabel.Size = new Size(136, 25);
            consoleIPLabel.TabIndex = 4;
            consoleIPLabel.Text = "Console IP : ";
            // 
            // haunterTextBoxIP
            // 
            haunterTextBoxIP.BackColor = Color.FromArgb(40, 40, 40);
            haunterTextBoxIP.BorderStyle = BorderStyle.None;
            haunterTextBoxIP.ForeColor = Color.FromArgb(114, 44, 133);
            haunterTextBoxIP.Location = new Point(146, 67);
            haunterTextBoxIP.Name = "haunterTextBoxIP";
            haunterTextBoxIP.ReadOnly = true;
            haunterTextBoxIP.Size = new Size(287, 27);
            haunterTextBoxIP.TabIndex = 0;
            haunterTextBoxIP.TextChanged += haunterTextBoxIP_TextChanged;
            // 
            // reloadInfosBtn
            // 
            reloadInfosBtn.Cursor = Cursors.Hand;
            reloadInfosBtn.FlatAppearance.BorderSize = 0;
            reloadInfosBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
            reloadInfosBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 33, 33);
            reloadInfosBtn.FlatStyle = FlatStyle.Flat;
            reloadInfosBtn.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reloadInfosBtn.ForeColor = Color.FromArgb(114, 44, 133);
            reloadInfosBtn.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            reloadInfosBtn.IconColor = Color.FromArgb(114, 44, 133);
            reloadInfosBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            reloadInfosBtn.IconSize = 40;
            reloadInfosBtn.ImageAlign = ContentAlignment.MiddleLeft;
            reloadInfosBtn.Location = new Point(569, 613);
            reloadInfosBtn.Name = "reloadInfosBtn";
            reloadInfosBtn.Size = new Size(212, 49);
            reloadInfosBtn.TabIndex = 6;
            reloadInfosBtn.Text = "Reload Infos";
            reloadInfosBtn.UseVisualStyleBackColor = true;
            reloadInfosBtn.Click += reloadInfosBtn_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            Controls.Add(reloadInfosBtn);
            Controls.Add(haunterGroupBox1);
            Controls.Add(responseLabel);
            Controls.Add(isConnectedLabel);
            Controls.Add(shutdownBtn);
            Controls.Add(comboBoxConsole);
            Controls.Add(connectBtn);
            Name = "Home";
            Size = new Size(924, 677);
            Load += Home_Load;
            haunterGroupBox1.ResumeLayout(false);
            haunterGroupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton connectBtn;
        private ComboBox comboBoxConsole;
        private FontAwesome.Sharp.IconButton shutdownBtn;
        private Label isConnectedLabel;
        private Label responseLabel;
        private CustomGroupBox.HaunterGroupBox haunterGroupBox1;
        private CustomTextBox.HaunterTextBox haunterTextBoxIP;
        private Label consoleIPLabel;
        private CustomTextBox.HaunterTextBox haunterTextBoxCpuKey;
        private Label cpuKeyLabel;
        private Label titleIDLabel;
        private CustomTextBox.HaunterTextBox haunterTextBoxTitleID;
        private CustomTextBox.HaunterTextBox haunterTextBoxGamertag;
        private Label gamertagLabel;
        private FontAwesome.Sharp.IconButton reloadInfosBtn;
    }
}
