namespace Haunter
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            hiddenPanel = new Panel();
            centerPanel = new Panel();
            topPanel = new Panel();
            giphPictureBox = new PictureBox();
            minimizeStateBtn = new Button();
            exitBtn = new Button();
            mainPanel = new Panel();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBoxWAW = new PictureBox();
            pictureBoxCod4 = new PictureBox();
            settingsBtn = new FontAwesome.Sharp.IconButton();
            awBtn = new FontAwesome.Sharp.IconButton();
            ghostsBtn = new FontAwesome.Sharp.IconButton();
            bo3Btn = new FontAwesome.Sharp.IconButton();
            bo2Btn = new FontAwesome.Sharp.IconButton();
            bo1Btn = new FontAwesome.Sharp.IconButton();
            mw3Btn = new FontAwesome.Sharp.IconButton();
            mw2Btn = new FontAwesome.Sharp.IconButton();
            wawBtn = new FontAwesome.Sharp.IconButton();
            cod4Btn = new FontAwesome.Sharp.IconButton();
            homeBtn = new FontAwesome.Sharp.IconButton();
            hamburgerBtn = new FontAwesome.Sharp.IconButton();
            hamburgerTimer = new System.Windows.Forms.Timer(components);
            hiddenPanel.SuspendLayout();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)giphPictureBox).BeginInit();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWAW).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCod4).BeginInit();
            SuspendLayout();
            // 
            // hiddenPanel
            // 
            hiddenPanel.BackColor = Color.FromArgb(40, 40, 40);
            hiddenPanel.Controls.Add(centerPanel);
            hiddenPanel.Controls.Add(topPanel);
            hiddenPanel.Controls.Add(mainPanel);
            hiddenPanel.Location = new Point(12, 12);
            hiddenPanel.Name = "hiddenPanel";
            hiddenPanel.Size = new Size(1204, 814);
            hiddenPanel.TabIndex = 0;
            hiddenPanel.Paint += hiddenPanel_Paint;
            hiddenPanel.MouseDown += Move_Form;
            // 
            // centerPanel
            // 
            centerPanel.Dock = DockStyle.Fill;
            centerPanel.Location = new Point(280, 137);
            centerPanel.Name = "centerPanel";
            centerPanel.Size = new Size(924, 677);
            centerPanel.TabIndex = 4;
            centerPanel.Paint += centerPanel_Paint;
            centerPanel.MouseDown += Move_Form;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(33, 33, 33);
            topPanel.Controls.Add(giphPictureBox);
            topPanel.Controls.Add(minimizeStateBtn);
            topPanel.Controls.Add(exitBtn);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(280, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(924, 137);
            topPanel.TabIndex = 3;
            topPanel.Paint += topPanel_Paint;
            topPanel.MouseDown += Move_Form;
            // 
            // giphPictureBox
            // 
            giphPictureBox.Anchor = AnchorStyles.Top;
            giphPictureBox.BackColor = Color.Transparent;
            giphPictureBox.Image = Properties.Resources.GiphDarkMode;
            giphPictureBox.Location = new Point(170, 0);
            giphPictureBox.Name = "giphPictureBox";
            giphPictureBox.Size = new Size(600, 138);
            giphPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            giphPictureBox.TabIndex = 3;
            giphPictureBox.TabStop = false;
            giphPictureBox.MouseDown += Move_Form;
            // 
            // minimizeStateBtn
            // 
            minimizeStateBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimizeStateBtn.Cursor = Cursors.Hand;
            minimizeStateBtn.FlatAppearance.BorderSize = 0;
            minimizeStateBtn.FlatAppearance.MouseDownBackColor = Color.DimGray;
            minimizeStateBtn.FlatAppearance.MouseOverBackColor = Color.Gray;
            minimizeStateBtn.FlatStyle = FlatStyle.Flat;
            minimizeStateBtn.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minimizeStateBtn.ForeColor = Color.FromArgb(114, 44, 133);
            minimizeStateBtn.Location = new Point(810, 0);
            minimizeStateBtn.Name = "minimizeStateBtn";
            minimizeStateBtn.Size = new Size(60, 45);
            minimizeStateBtn.TabIndex = 2;
            minimizeStateBtn.Text = "_";
            minimizeStateBtn.UseVisualStyleBackColor = true;
            minimizeStateBtn.Click += minimizeStateBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exitBtn.Cursor = Cursors.Hand;
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatAppearance.MouseDownBackColor = Color.DimGray;
            exitBtn.FlatAppearance.MouseOverBackColor = Color.Gray;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitBtn.ForeColor = Color.FromArgb(114, 44, 133);
            exitBtn.Location = new Point(864, 0);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(60, 45);
            exitBtn.TabIndex = 1;
            exitBtn.Text = "X";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(33, 33, 33);
            mainPanel.Controls.Add(pictureBox8);
            mainPanel.Controls.Add(pictureBox7);
            mainPanel.Controls.Add(pictureBox6);
            mainPanel.Controls.Add(pictureBox5);
            mainPanel.Controls.Add(pictureBox4);
            mainPanel.Controls.Add(pictureBox3);
            mainPanel.Controls.Add(pictureBox2);
            mainPanel.Controls.Add(pictureBoxWAW);
            mainPanel.Controls.Add(pictureBoxCod4);
            mainPanel.Controls.Add(settingsBtn);
            mainPanel.Controls.Add(awBtn);
            mainPanel.Controls.Add(ghostsBtn);
            mainPanel.Controls.Add(bo3Btn);
            mainPanel.Controls.Add(bo2Btn);
            mainPanel.Controls.Add(bo1Btn);
            mainPanel.Controls.Add(mw3Btn);
            mainPanel.Controls.Add(mw2Btn);
            mainPanel.Controls.Add(wawBtn);
            mainPanel.Controls.Add(cod4Btn);
            mainPanel.Controls.Add(homeBtn);
            mainPanel.Controls.Add(hamburgerBtn);
            mainPanel.Dock = DockStyle.Left;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(280, 814);
            mainPanel.TabIndex = 0;
            mainPanel.Paint += mainPanel_Paint;
            mainPanel.MouseDown += Move_Form;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.Cursor = Cursors.Hand;
            pictureBox8.Image = Properties.Resources.aw;
            pictureBox8.Location = new Point(13, 692);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(56, 39);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 19;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Cursor = Cursors.Hand;
            pictureBox7.Image = Properties.Resources.ghosts;
            pictureBox7.Location = new Point(13, 632);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(56, 39);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 18;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = Properties.Resources.bo3;
            pictureBox6.Location = new Point(13, 572);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(56, 39);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 17;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = Properties.Resources.bo2;
            pictureBox5.Location = new Point(13, 512);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(56, 39);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = Properties.Resources.bo1;
            pictureBox4.Location = new Point(13, 452);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(56, 39);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.mw3;
            pictureBox3.Location = new Point(13, 392);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.mw2;
            pictureBox2.Location = new Point(13, 332);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBoxWAW
            // 
            pictureBoxWAW.BackColor = Color.Transparent;
            pictureBoxWAW.Cursor = Cursors.Hand;
            pictureBoxWAW.Image = Properties.Resources.waw;
            pictureBoxWAW.Location = new Point(13, 272);
            pictureBoxWAW.Name = "pictureBoxWAW";
            pictureBoxWAW.Size = new Size(56, 39);
            pictureBoxWAW.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxWAW.TabIndex = 12;
            pictureBoxWAW.TabStop = false;
            pictureBoxWAW.Click += pictureBoxWAW_Click;
            // 
            // pictureBoxCod4
            // 
            pictureBoxCod4.BackColor = Color.Transparent;
            pictureBoxCod4.Cursor = Cursors.Hand;
            pictureBoxCod4.Image = Properties.Resources.cod4;
            pictureBoxCod4.Location = new Point(13, 212);
            pictureBoxCod4.Name = "pictureBoxCod4";
            pictureBoxCod4.Size = new Size(56, 39);
            pictureBoxCod4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCod4.TabIndex = 3;
            pictureBoxCod4.TabStop = false;
            pictureBoxCod4.Click += pictureBoxCod4_Click;
            // 
            // settingsBtn
            // 
            settingsBtn.Cursor = Cursors.Hand;
            settingsBtn.FlatAppearance.BorderSize = 0;
            settingsBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
            settingsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 33, 33);
            settingsBtn.FlatStyle = FlatStyle.Flat;
            settingsBtn.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            settingsBtn.ForeColor = Color.FromArgb(114, 44, 133);
            settingsBtn.IconChar = FontAwesome.Sharp.IconChar.Cog;
            settingsBtn.IconColor = Color.FromArgb(114, 44, 133);
            settingsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            settingsBtn.IconSize = 45;
            settingsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            settingsBtn.Location = new Point(9, 749);
            settingsBtn.Margin = new Padding(9);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(253, 42);
            settingsBtn.TabIndex = 11;
            settingsBtn.Text = "SETTINGS";
            settingsBtn.UseVisualStyleBackColor = true;
            settingsBtn.Click += settingsBtn_Click;
            // 
            // awBtn
            // 
            awBtn.Cursor = Cursors.Hand;
            awBtn.FlatAppearance.BorderSize = 0;
            awBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
            awBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 33, 33);
            awBtn.FlatStyle = FlatStyle.Flat;
            awBtn.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            awBtn.ForeColor = Color.FromArgb(114, 44, 133);
            awBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            awBtn.IconColor = Color.FromArgb(114, 44, 133);
            awBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            awBtn.IconSize = 45;
            awBtn.ImageAlign = ContentAlignment.MiddleLeft;
            awBtn.Location = new Point(9, 689);
            awBtn.Margin = new Padding(9);
            awBtn.Name = "awBtn";
            awBtn.Size = new Size(253, 42);
            awBtn.TabIndex = 10;
            awBtn.Text = "AW";
            awBtn.UseVisualStyleBackColor = true;
            awBtn.Click += awBtn_Click;
            // 
            // ghostsBtn
            // 
            ghostsBtn.Cursor = Cursors.Hand;
            ghostsBtn.FlatAppearance.BorderSize = 0;
            ghostsBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
            ghostsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 33, 33);
            ghostsBtn.FlatStyle = FlatStyle.Flat;
            ghostsBtn.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ghostsBtn.ForeColor = Color.FromArgb(114, 44, 133);
            ghostsBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            ghostsBtn.IconColor = Color.FromArgb(114, 44, 133);
            ghostsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ghostsBtn.IconSize = 45;
            ghostsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ghostsBtn.Location = new Point(9, 629);
            ghostsBtn.Margin = new Padding(9);
            ghostsBtn.Name = "ghostsBtn";
            ghostsBtn.Size = new Size(253, 42);
            ghostsBtn.TabIndex = 9;
            ghostsBtn.Text = "GHOSTS";
            ghostsBtn.UseVisualStyleBackColor = true;
            ghostsBtn.Click += ghostsBtn_Click;
            // 
            // bo3Btn
            // 
            bo3Btn.Cursor = Cursors.Hand;
            bo3Btn.FlatAppearance.BorderSize = 0;
            bo3Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
            bo3Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 33, 33);
            bo3Btn.FlatStyle = FlatStyle.Flat;
            bo3Btn.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bo3Btn.ForeColor = Color.FromArgb(114, 44, 133);
            bo3Btn.IconChar = FontAwesome.Sharp.IconChar.None;
            bo3Btn.IconColor = Color.FromArgb(114, 44, 133);
            bo3Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bo3Btn.IconSize = 45;
            bo3Btn.ImageAlign = ContentAlignment.MiddleLeft;
            bo3Btn.Location = new Point(9, 569);
            bo3Btn.Margin = new Padding(9);
            bo3Btn.Name = "bo3Btn";
            bo3Btn.Size = new Size(253, 42);
            bo3Btn.TabIndex = 8;
            bo3Btn.Text = "BO3";
            bo3Btn.UseVisualStyleBackColor = true;
            bo3Btn.Click += bo3Btn_Click;
            // 
            // bo2Btn
            // 
            bo2Btn.Cursor = Cursors.Hand;
            bo2Btn.FlatAppearance.BorderSize = 0;
            bo2Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
            bo2Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 33, 33);
            bo2Btn.FlatStyle = FlatStyle.Flat;
            bo2Btn.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bo2Btn.ForeColor = Color.FromArgb(114, 44, 133);
            bo2Btn.IconChar = FontAwesome.Sharp.IconChar.None;
            bo2Btn.IconColor = Color.FromArgb(114, 44, 133);
            bo2Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bo2Btn.IconSize = 45;
            bo2Btn.ImageAlign = ContentAlignment.MiddleLeft;
            bo2Btn.Location = new Point(13, 509);
            bo2Btn.Margin = new Padding(9);
            bo2Btn.Name = "bo2Btn";
            bo2Btn.Size = new Size(253, 42);
            bo2Btn.TabIndex = 7;
            bo2Btn.Text = "BO2";
            bo2Btn.UseVisualStyleBackColor = true;
            // 
            // bo1Btn
            // 
            bo1Btn.Cursor = Cursors.Hand;
            bo1Btn.FlatAppearance.BorderSize = 0;
            bo1Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
            bo1Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 33, 33);
            bo1Btn.FlatStyle = FlatStyle.Flat;
            bo1Btn.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bo1Btn.ForeColor = Color.FromArgb(114, 44, 133);
            bo1Btn.IconChar = FontAwesome.Sharp.IconChar.None;
            bo1Btn.IconColor = Color.FromArgb(114, 44, 133);
            bo1Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bo1Btn.IconSize = 45;
            bo1Btn.ImageAlign = ContentAlignment.MiddleLeft;
            bo1Btn.Location = new Point(13, 449);
            bo1Btn.Margin = new Padding(9);
            bo1Btn.Name = "bo1Btn";
            bo1Btn.Size = new Size(253, 42);
            bo1Btn.TabIndex = 6;
            bo1Btn.Text = "BO1";
            bo1Btn.UseVisualStyleBackColor = true;
            bo1Btn.Click += bo1Btn_Click;
            // 
            // mw3Btn
            // 
            mw3Btn.Cursor = Cursors.Hand;
            mw3Btn.FlatAppearance.BorderSize = 0;
            mw3Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
            mw3Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 33, 33);
            mw3Btn.FlatStyle = FlatStyle.Flat;
            mw3Btn.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mw3Btn.ForeColor = Color.FromArgb(114, 44, 133);
            mw3Btn.IconChar = FontAwesome.Sharp.IconChar.None;
            mw3Btn.IconColor = Color.FromArgb(114, 44, 133);
            mw3Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            mw3Btn.IconSize = 45;
            mw3Btn.ImageAlign = ContentAlignment.MiddleLeft;
            mw3Btn.Location = new Point(13, 389);
            mw3Btn.Margin = new Padding(9);
            mw3Btn.Name = "mw3Btn";
            mw3Btn.Size = new Size(253, 42);
            mw3Btn.TabIndex = 5;
            mw3Btn.Text = "MW3";
            mw3Btn.UseVisualStyleBackColor = true;
            mw3Btn.Click += mw3Btn_Click;
            // 
            // mw2Btn
            // 
            mw2Btn.Cursor = Cursors.Hand;
            mw2Btn.FlatAppearance.BorderSize = 0;
            mw2Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
            mw2Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 33, 33);
            mw2Btn.FlatStyle = FlatStyle.Flat;
            mw2Btn.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mw2Btn.ForeColor = Color.FromArgb(114, 44, 133);
            mw2Btn.IconChar = FontAwesome.Sharp.IconChar.None;
            mw2Btn.IconColor = Color.FromArgb(114, 44, 133);
            mw2Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            mw2Btn.IconSize = 45;
            mw2Btn.ImageAlign = ContentAlignment.MiddleLeft;
            mw2Btn.Location = new Point(13, 329);
            mw2Btn.Margin = new Padding(9);
            mw2Btn.Name = "mw2Btn";
            mw2Btn.Size = new Size(253, 42);
            mw2Btn.TabIndex = 4;
            mw2Btn.Text = "MW2";
            mw2Btn.UseVisualStyleBackColor = true;
            mw2Btn.Click += mw2Btn_Click;
            // 
            // wawBtn
            // 
            wawBtn.Cursor = Cursors.Hand;
            wawBtn.FlatAppearance.BorderSize = 0;
            wawBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
            wawBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 33, 33);
            wawBtn.FlatStyle = FlatStyle.Flat;
            wawBtn.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            wawBtn.ForeColor = Color.FromArgb(114, 44, 133);
            wawBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            wawBtn.IconColor = Color.FromArgb(114, 44, 133);
            wawBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            wawBtn.IconSize = 45;
            wawBtn.ImageAlign = ContentAlignment.MiddleLeft;
            wawBtn.Location = new Point(13, 269);
            wawBtn.Margin = new Padding(9);
            wawBtn.Name = "wawBtn";
            wawBtn.Size = new Size(253, 42);
            wawBtn.TabIndex = 3;
            wawBtn.Text = "WAW";
            wawBtn.UseVisualStyleBackColor = true;
            wawBtn.Click += wawBtn_Click;
            // 
            // cod4Btn
            // 
            cod4Btn.Cursor = Cursors.Hand;
            cod4Btn.FlatAppearance.BorderSize = 0;
            cod4Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
            cod4Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 33, 33);
            cod4Btn.FlatStyle = FlatStyle.Flat;
            cod4Btn.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cod4Btn.ForeColor = Color.FromArgb(114, 44, 133);
            cod4Btn.IconChar = FontAwesome.Sharp.IconChar.None;
            cod4Btn.IconColor = Color.FromArgb(114, 44, 133);
            cod4Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            cod4Btn.IconSize = 45;
            cod4Btn.ImageAlign = ContentAlignment.MiddleLeft;
            cod4Btn.Location = new Point(13, 209);
            cod4Btn.Margin = new Padding(9);
            cod4Btn.Name = "cod4Btn";
            cod4Btn.Size = new Size(253, 42);
            cod4Btn.TabIndex = 2;
            cod4Btn.Text = "COD 4";
            cod4Btn.UseVisualStyleBackColor = true;
            cod4Btn.Click += cod4Btn_Click;
            // 
            // homeBtn
            // 
            homeBtn.Cursor = Cursors.Hand;
            homeBtn.FlatAppearance.BorderSize = 0;
            homeBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
            homeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 33, 33);
            homeBtn.FlatStyle = FlatStyle.Flat;
            homeBtn.Font = new Font("Tarzan", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            homeBtn.ForeColor = Color.FromArgb(114, 44, 133);
            homeBtn.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            homeBtn.IconColor = Color.FromArgb(114, 44, 133);
            homeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            homeBtn.IconSize = 45;
            homeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            homeBtn.Location = new Point(13, 155);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(253, 42);
            homeBtn.TabIndex = 1;
            homeBtn.Text = "HOME";
            homeBtn.UseVisualStyleBackColor = true;
            homeBtn.Click += homeBtn_Click;
            // 
            // hamburgerBtn
            // 
            hamburgerBtn.Cursor = Cursors.Hand;
            hamburgerBtn.FlatAppearance.BorderSize = 0;
            hamburgerBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
            hamburgerBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 33, 33);
            hamburgerBtn.FlatStyle = FlatStyle.Flat;
            hamburgerBtn.IconChar = FontAwesome.Sharp.IconChar.Bars;
            hamburgerBtn.IconColor = Color.FromArgb(114, 44, 133);
            hamburgerBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            hamburgerBtn.IconSize = 45;
            hamburgerBtn.Location = new Point(13, 37);
            hamburgerBtn.Name = "hamburgerBtn";
            hamburgerBtn.Size = new Size(56, 56);
            hamburgerBtn.TabIndex = 0;
            hamburgerBtn.UseVisualStyleBackColor = true;
            hamburgerBtn.Click += hamburgerBtn_Click;
            // 
            // hamburgerTimer
            // 
            hamburgerTimer.Interval = 10;
            hamburgerTimer.Tick += hamburgerTimer_Tick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1228, 838);
            Controls.Add(hiddenPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Haunter";
            Load += Form1_Load;
            MouseDown += Move_Form;
            hiddenPanel.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)giphPictureBox).EndInit();
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWAW).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCod4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel hiddenPanel;
        private Panel mainPanel;
        private Button exitBtn;
        private Button minimizeStateBtn;
        private FontAwesome.Sharp.IconButton hamburgerBtn;
        private System.Windows.Forms.Timer hamburgerTimer;
        private FontAwesome.Sharp.IconButton homeBtn;
        private FontAwesome.Sharp.IconButton cod4Btn;
        private FontAwesome.Sharp.IconButton settingsBtn;
        private FontAwesome.Sharp.IconButton awBtn;
        private FontAwesome.Sharp.IconButton ghostsBtn;
        private FontAwesome.Sharp.IconButton bo3Btn;
        private FontAwesome.Sharp.IconButton bo2Btn;
        private FontAwesome.Sharp.IconButton bo1Btn;
        private FontAwesome.Sharp.IconButton mw3Btn;
        private FontAwesome.Sharp.IconButton mw2Btn;
        private FontAwesome.Sharp.IconButton wawBtn;
        private PictureBox pictureBoxCod4;
        private PictureBox pictureBoxWAW;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Panel topPanel;
        private PictureBox giphPictureBox;
        private Panel centerPanel;
    }
}
