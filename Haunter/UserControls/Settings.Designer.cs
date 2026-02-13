namespace Haunter.UserControls
{
    partial class Settings
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
            startOnBootToggle = new Haunter.ToggleButton.ToggleButton();
            startupLabel = new Label();
            darkModeLabel = new Label();
            darkModeToggle = new Haunter.ToggleButton.ToggleButton();
            autoConnectLabel = new Label();
            autoConnectToggle = new Haunter.ToggleButton.ToggleButton();
            SuspendLayout();
            // 
            // startOnBootToggle
            // 
            startOnBootToggle.AutoSize = true;
            startOnBootToggle.Location = new Point(145, 126);
            startOnBootToggle.MinimumSize = new Size(45, 22);
            startOnBootToggle.Name = "startOnBootToggle";
            startOnBootToggle.OffBackColor = Color.Gray;
            startOnBootToggle.OffToggleColor = Color.Gainsboro;
            startOnBootToggle.OnBackColor = Color.FromArgb(114, 44, 133);
            startOnBootToggle.OnToggleColor = Color.WhiteSmoke;
            startOnBootToggle.Size = new Size(45, 22);
            startOnBootToggle.TabIndex = 0;
            startOnBootToggle.UseVisualStyleBackColor = true;
            startOnBootToggle.CheckedChanged += startOnBootToggle_CheckedChanged;
            // 
            // startupLabel
            // 
            startupLabel.AutoSize = true;
            startupLabel.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startupLabel.ForeColor = Color.FromArgb(114, 44, 133);
            startupLabel.Location = new Point(15, 123);
            startupLabel.Name = "startupLabel";
            startupLabel.Size = new Size(124, 25);
            startupLabel.TabIndex = 1;
            startupLabel.Text = "Set Startup";
            // 
            // darkModeLabel
            // 
            darkModeLabel.AutoSize = true;
            darkModeLabel.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            darkModeLabel.ForeColor = Color.FromArgb(114, 44, 133);
            darkModeLabel.Location = new Point(15, 76);
            darkModeLabel.Name = "darkModeLabel";
            darkModeLabel.Size = new Size(119, 25);
            darkModeLabel.TabIndex = 2;
            darkModeLabel.Text = "Dark Mode";
            // 
            // darkModeToggle
            // 
            darkModeToggle.AutoSize = true;
            darkModeToggle.Location = new Point(145, 79);
            darkModeToggle.MinimumSize = new Size(45, 22);
            darkModeToggle.Name = "darkModeToggle";
            darkModeToggle.OffBackColor = Color.Gray;
            darkModeToggle.OffToggleColor = Color.Gainsboro;
            darkModeToggle.OnBackColor = Color.FromArgb(114, 44, 133);
            darkModeToggle.OnToggleColor = Color.WhiteSmoke;
            darkModeToggle.Size = new Size(45, 22);
            darkModeToggle.TabIndex = 3;
            darkModeToggle.UseVisualStyleBackColor = true;
            darkModeToggle.CheckedChanged += darkModeToggle_CheckedChanged;
            // 
            // autoConnectLabel
            // 
            autoConnectLabel.AutoSize = true;
            autoConnectLabel.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoConnectLabel.ForeColor = Color.FromArgb(114, 44, 133);
            autoConnectLabel.Location = new Point(15, 30);
            autoConnectLabel.Name = "autoConnectLabel";
            autoConnectLabel.Size = new Size(150, 25);
            autoConnectLabel.TabIndex = 4;
            autoConnectLabel.Text = "Auto Connect";
            // 
            // autoConnectToggle
            // 
            autoConnectToggle.AutoSize = true;
            autoConnectToggle.Location = new Point(171, 35);
            autoConnectToggle.MinimumSize = new Size(45, 22);
            autoConnectToggle.Name = "autoConnectToggle";
            autoConnectToggle.OffBackColor = Color.Gray;
            autoConnectToggle.OffToggleColor = Color.Gainsboro;
            autoConnectToggle.OnBackColor = Color.FromArgb(114, 44, 133);
            autoConnectToggle.OnToggleColor = Color.WhiteSmoke;
            autoConnectToggle.Size = new Size(45, 22);
            autoConnectToggle.TabIndex = 5;
            autoConnectToggle.UseVisualStyleBackColor = true;
            autoConnectToggle.CheckedChanged += autoConnectToggle_CheckedChanged;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            Controls.Add(autoConnectToggle);
            Controls.Add(autoConnectLabel);
            Controls.Add(darkModeToggle);
            Controls.Add(darkModeLabel);
            Controls.Add(startupLabel);
            Controls.Add(startOnBootToggle);
            Name = "Settings";
            Size = new Size(924, 677);
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToggleButton.ToggleButton startOnBootToggle;
        private Label startupLabel;
        private Label darkModeLabel;
        private ToggleButton.ToggleButton darkModeToggle;
        private Label autoConnectLabel;
        private ToggleButton.ToggleButton autoConnectToggle;
    }
}
