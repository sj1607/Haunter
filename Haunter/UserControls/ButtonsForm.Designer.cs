namespace Haunter.UserControls
{
    partial class ButtonsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            exitFormBtn = new Button();
            comboBoxButtons = new ComboBox();
            copyBtn = new FontAwesome.Sharp.IconButton();
            noteLabel = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // exitFormBtn
            // 
            exitFormBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exitFormBtn.Cursor = Cursors.Hand;
            exitFormBtn.FlatAppearance.BorderSize = 0;
            exitFormBtn.FlatAppearance.MouseDownBackColor = Color.DimGray;
            exitFormBtn.FlatAppearance.MouseOverBackColor = Color.Gray;
            exitFormBtn.FlatStyle = FlatStyle.Flat;
            exitFormBtn.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitFormBtn.ForeColor = Color.FromArgb(114, 44, 133);
            exitFormBtn.Location = new Point(443, 12);
            exitFormBtn.Name = "exitFormBtn";
            exitFormBtn.Size = new Size(60, 45);
            exitFormBtn.TabIndex = 2;
            exitFormBtn.Text = "X";
            exitFormBtn.UseVisualStyleBackColor = true;
            exitFormBtn.Click += exitFormBtn_Click;
            // 
            // comboBoxButtons
            // 
            comboBoxButtons.BackColor = Color.FromArgb(40, 40, 40);
            comboBoxButtons.FlatStyle = FlatStyle.Flat;
            comboBoxButtons.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxButtons.ForeColor = Color.FromArgb(114, 44, 133);
            comboBoxButtons.FormattingEnabled = true;
            comboBoxButtons.Items.AddRange(new object[] { "A", "B", "X", "Y", "LB", "RB", "LT", "RT", "DPAD UP", "DPAD RIGHT", "DPAD DOWN", "DPAD LEFT", "SELECT", "START", "L", "R" });
            comboBoxButtons.Location = new Point(123, 182);
            comboBoxButtons.Name = "comboBoxButtons";
            comboBoxButtons.Size = new Size(253, 33);
            comboBoxButtons.TabIndex = 11;
            comboBoxButtons.Text = "Buttons";
            // 
            // copyBtn
            // 
            copyBtn.Cursor = Cursors.Hand;
            copyBtn.FlatAppearance.BorderSize = 0;
            copyBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            copyBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            copyBtn.FlatStyle = FlatStyle.Flat;
            copyBtn.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            copyBtn.ForeColor = Color.FromArgb(114, 44, 133);
            copyBtn.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            copyBtn.IconColor = Color.FromArgb(114, 44, 133);
            copyBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            copyBtn.IconSize = 45;
            copyBtn.ImageAlign = ContentAlignment.MiddleLeft;
            copyBtn.Location = new Point(123, 470);
            copyBtn.Name = "copyBtn";
            copyBtn.Size = new Size(253, 42);
            copyBtn.TabIndex = 12;
            copyBtn.Text = "Copy";
            copyBtn.UseVisualStyleBackColor = true;
            copyBtn.Click += copyBtn_Click;
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noteLabel.ForeColor = Color.FromArgb(114, 44, 133);
            noteLabel.Location = new Point(12, 559);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new Size(290, 20);
            noteLabel.TabIndex = 13;
            noteLabel.Text = "Note : The button may be invisible";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tarzan", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(114, 44, 133);
            label1.Location = new Point(84, 105);
            label1.Name = "label1";
            label1.Size = new Size(340, 20);
            label1.TabIndex = 14;
            label1.Text = "Note : Select a button and click on copy";
            // 
            // ButtonsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(515, 588);
            Controls.Add(label1);
            Controls.Add(noteLabel);
            Controls.Add(copyBtn);
            Controls.Add(comboBoxButtons);
            Controls.Add(exitFormBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ButtonsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ButtonsForm";
            Load += ButtonsForm_Load;
            MouseDown += Move_Form;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitFormBtn;
        private ComboBox comboBoxButtons;
        private FontAwesome.Sharp.IconButton copyBtn;
        private Label noteLabel;
        private Label label1;
    }
}