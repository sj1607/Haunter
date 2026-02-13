namespace Haunter.UserControls
{
    partial class T7
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
            button1 = new Button();
            haunterTextBox1 = new Haunter.CustomTextBox.HaunterTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(338, 284);
            button1.Name = "button1";
            button1.Size = new Size(251, 90);
            button1.TabIndex = 0;
            button1.Text = "Command Buffer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // haunterTextBox1
            // 
            haunterTextBox1.BackColor = Color.White;
            haunterTextBox1.BorderStyle = BorderStyle.None;
            haunterTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            haunterTextBox1.ForeColor = Color.Black;
            haunterTextBox1.Location = new Point(338, 198);
            haunterTextBox1.Name = "haunterTextBox1";
            haunterTextBox1.Size = new Size(251, 22);
            haunterTextBox1.TabIndex = 1;
            // 
            // T7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            Controls.Add(haunterTextBox1);
            Controls.Add(button1);
            Name = "T7";
            Size = new Size(924, 677);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CustomTextBox.HaunterTextBox haunterTextBox1;
    }
}
