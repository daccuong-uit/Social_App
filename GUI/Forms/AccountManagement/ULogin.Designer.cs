namespace GUI.Forms.AccountManagement
{
    partial class ULogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.lblUsename = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pblPassword = new System.Windows.Forms.Panel();
            this.picEye = new System.Windows.Forms.PictureBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblFacebookIntro = new System.Windows.Forms.Label();
            this.lblFacebook = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.llblForgotPassword = new System.Windows.Forms.LinkLabel();
            this.line_ControlBar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbtnDarkmode = new System.Windows.Forms.CheckBox();
            this.flpLanguae = new System.Windows.Forms.FlowLayoutPanel();
            this.llblEnglish = new System.Windows.Forms.LinkLabel();
            this.llblVietnamese = new System.Windows.Forms.LinkLabel();
            this.llblFrance = new System.Windows.Forms.LinkLabel();
            this.llblSpain = new System.Windows.Forms.LinkLabel();
            this.llblChinese = new System.Windows.Forms.LinkLabel();
            this.btnSignUp = new GUI.Components.CustomButton();
            this.btnLogin = new GUI.Components.CustomButton();
            this.borPassword = new GUI.UserControls.DesignControls.BorderCustome();
            this.borUserName = new GUI.UserControls.DesignControls.BorderCustome();
            this.borPanel = new GUI.UserControls.DesignControls.BorderCustome();
            this.pnlUsername.SuspendLayout();
            this.pblPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEye)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.line_ControlBar)).BeginInit();
            this.panel2.SuspendLayout();
            this.flpLanguae.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUsername
            // 
            this.pnlUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlUsername.Controls.Add(this.lblUsename);
            this.pnlUsername.Controls.Add(this.borUserName);
            this.pnlUsername.Controls.Add(this.txtUsername);
            this.pnlUsername.Location = new System.Drawing.Point(760, 97);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(300, 50);
            this.pnlUsername.TabIndex = 1;
            // 
            // lblUsename
            // 
            this.lblUsename.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsename.AutoSize = true;
            this.lblUsename.BackColor = System.Drawing.Color.White;
            this.lblUsename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsename.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsename.ForeColor = System.Drawing.Color.DimGray;
            this.lblUsename.Location = new System.Drawing.Point(15, 15);
            this.lblUsename.Name = "lblUsename";
            this.lblUsename.Size = new System.Drawing.Size(263, 23);
            this.lblUsename.TabIndex = 1;
            this.lblUsename.Text = "Enter your email or username";
            this.lblUsename.Click += new System.EventHandler(this.lblUsename_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(18, 16);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(259, 22);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // pblPassword
            // 
            this.pblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pblPassword.BackColor = System.Drawing.Color.Transparent;
            this.pblPassword.Controls.Add(this.picEye);
            this.pblPassword.Controls.Add(this.lblPassword);
            this.pblPassword.Controls.Add(this.borPassword);
            this.pblPassword.Controls.Add(this.txtPassword);
            this.pblPassword.Location = new System.Drawing.Point(760, 157);
            this.pblPassword.Name = "pblPassword";
            this.pblPassword.Size = new System.Drawing.Size(300, 50);
            this.pblPassword.TabIndex = 1;
            // 
            // picEye
            // 
            this.picEye.Image = global::GUI.Properties.Resources.eye_24_black;
            this.picEye.Location = new System.Drawing.Point(270, 12);
            this.picEye.Name = "picEye";
            this.picEye.Size = new System.Drawing.Size(24, 24);
            this.picEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEye.TabIndex = 8;
            this.picEye.TabStop = false;
            this.picEye.Tag = "1";
            this.picEye.Visible = false;
            this.picEye.Click += new System.EventHandler(this.picEye_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPassword.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.DimGray;
            this.lblPassword.Location = new System.Drawing.Point(15, 13);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 23);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(16, 13);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(248, 22);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnSignUp);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.line_ControlBar);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.pblPassword);
            this.panel1.Controls.Add(this.pnlUsername);
            this.panel1.Controls.Add(this.borPanel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 620);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.lblFacebookIntro);
            this.panel4.Controls.Add(this.lblFacebook);
            this.panel4.Location = new System.Drawing.Point(207, 141);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(443, 216);
            this.panel4.TabIndex = 7;
            // 
            // lblFacebookIntro
            // 
            this.lblFacebookIntro.AllowDrop = true;
            this.lblFacebookIntro.AutoSize = true;
            this.lblFacebookIntro.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacebookIntro.Location = new System.Drawing.Point(10, 80);
            this.lblFacebookIntro.Name = "lblFacebookIntro";
            this.lblFacebookIntro.Size = new System.Drawing.Size(427, 58);
            this.lblFacebookIntro.TabIndex = 7;
            this.lblFacebookIntro.Text = "Facebook helps you connect and share \r\nwith the people in your life.";
            // 
            // lblFacebook
            // 
            this.lblFacebook.AutoSize = true;
            this.lblFacebook.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacebook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.lblFacebook.Location = new System.Drawing.Point(0, 0);
            this.lblFacebook.Name = "lblFacebook";
            this.lblFacebook.Size = new System.Drawing.Size(345, 72);
            this.lblFacebook.TabIndex = 6;
            this.lblFacebook.Text = "Facebook";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.llblForgotPassword);
            this.panel3.Location = new System.Drawing.Point(760, 267);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 40);
            this.panel3.TabIndex = 1;
            // 
            // llblForgotPassword
            // 
            this.llblForgotPassword.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.llblForgotPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llblForgotPassword.AutoSize = true;
            this.llblForgotPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.llblForgotPassword.Location = new System.Drawing.Point(102, 11);
            this.llblForgotPassword.Name = "llblForgotPassword";
            this.llblForgotPassword.Size = new System.Drawing.Size(111, 16);
            this.llblForgotPassword.TabIndex = 0;
            this.llblForgotPassword.TabStop = true;
            this.llblForgotPassword.Text = "Forgot password";
            this.llblForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblForgotPassword_LinkClicked);
            // 
            // line_ControlBar
            // 
            this.line_ControlBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.line_ControlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            this.line_ControlBar.Location = new System.Drawing.Point(760, 327);
            this.line_ControlBar.Name = "line_ControlBar";
            this.line_ControlBar.Size = new System.Drawing.Size(300, 1);
            this.line_ControlBar.TabIndex = 4;
            this.line_ControlBar.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cbtnDarkmode);
            this.panel2.Controls.Add(this.flpLanguae);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 623);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1263, 150);
            this.panel2.TabIndex = 3;
            // 
            // cbtnDarkmode
            // 
            this.cbtnDarkmode.AutoSize = true;
            this.cbtnDarkmode.BackColor = System.Drawing.Color.Transparent;
            this.cbtnDarkmode.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbtnDarkmode.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtnDarkmode.ForeColor = System.Drawing.Color.Gray;
            this.cbtnDarkmode.Location = new System.Drawing.Point(32, 79);
            this.cbtnDarkmode.Name = "cbtnDarkmode";
            this.cbtnDarkmode.Size = new System.Drawing.Size(118, 27);
            this.cbtnDarkmode.TabIndex = 4;
            this.cbtnDarkmode.Text = "Darkmode";
            this.cbtnDarkmode.UseVisualStyleBackColor = false;
            this.cbtnDarkmode.CheckedChanged += new System.EventHandler(this.cbtnDarkmode_CheckedChanged);
            // 
            // flpLanguae
            // 
            this.flpLanguae.BackColor = System.Drawing.Color.Transparent;
            this.flpLanguae.Controls.Add(this.llblEnglish);
            this.flpLanguae.Controls.Add(this.llblVietnamese);
            this.flpLanguae.Controls.Add(this.llblFrance);
            this.flpLanguae.Controls.Add(this.llblSpain);
            this.flpLanguae.Controls.Add(this.llblChinese);
            this.flpLanguae.Location = new System.Drawing.Point(32, 23);
            this.flpLanguae.Name = "flpLanguae";
            this.flpLanguae.Size = new System.Drawing.Size(446, 37);
            this.flpLanguae.TabIndex = 0;
            // 
            // llblEnglish
            // 
            this.llblEnglish.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.llblEnglish.AutoSize = true;
            this.llblEnglish.BackColor = System.Drawing.Color.Transparent;
            this.llblEnglish.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblEnglish.LinkColor = System.Drawing.Color.Gray;
            this.llblEnglish.Location = new System.Drawing.Point(3, 0);
            this.llblEnglish.Name = "llblEnglish";
            this.llblEnglish.Size = new System.Drawing.Size(73, 23);
            this.llblEnglish.TabIndex = 1;
            this.llblEnglish.TabStop = true;
            this.llblEnglish.Text = "English";
            // 
            // llblVietnamese
            // 
            this.llblVietnamese.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.llblVietnamese.AutoSize = true;
            this.llblVietnamese.BackColor = System.Drawing.Color.Transparent;
            this.llblVietnamese.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblVietnamese.LinkColor = System.Drawing.Color.Gray;
            this.llblVietnamese.Location = new System.Drawing.Point(82, 0);
            this.llblVietnamese.Name = "llblVietnamese";
            this.llblVietnamese.Size = new System.Drawing.Size(109, 23);
            this.llblVietnamese.TabIndex = 1;
            this.llblVietnamese.TabStop = true;
            this.llblVietnamese.Text = "Vietnamese";
            // 
            // llblFrance
            // 
            this.llblFrance.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.llblFrance.AutoSize = true;
            this.llblFrance.BackColor = System.Drawing.Color.Transparent;
            this.llblFrance.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblFrance.LinkColor = System.Drawing.Color.Gray;
            this.llblFrance.Location = new System.Drawing.Point(197, 0);
            this.llblFrance.Name = "llblFrance";
            this.llblFrance.Size = new System.Drawing.Size(69, 23);
            this.llblFrance.TabIndex = 1;
            this.llblFrance.TabStop = true;
            this.llblFrance.Text = "French";
            // 
            // llblSpain
            // 
            this.llblSpain.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.llblSpain.AutoSize = true;
            this.llblSpain.BackColor = System.Drawing.Color.Transparent;
            this.llblSpain.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblSpain.LinkColor = System.Drawing.Color.Gray;
            this.llblSpain.Location = new System.Drawing.Point(272, 0);
            this.llblSpain.Name = "llblSpain";
            this.llblSpain.Size = new System.Drawing.Size(84, 23);
            this.llblSpain.TabIndex = 1;
            this.llblSpain.TabStop = true;
            this.llblSpain.Text = "Spainish";
            // 
            // llblChinese
            // 
            this.llblChinese.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.llblChinese.AutoSize = true;
            this.llblChinese.BackColor = System.Drawing.Color.Transparent;
            this.llblChinese.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblChinese.LinkColor = System.Drawing.Color.Gray;
            this.llblChinese.Location = new System.Drawing.Point(362, 0);
            this.llblChinese.Name = "llblChinese";
            this.llblChinese.Size = new System.Drawing.Size(76, 23);
            this.llblChinese.TabIndex = 1;
            this.llblChinese.TabStop = true;
            this.llblChinese.Text = "Chinese";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSignUp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSignUp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSignUp.BorderRadius = 12;
            this.btnSignUp.BorderSize = 0;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(810, 352);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(200, 50);
            this.btnSignUp.TabIndex = 5;
            this.btnSignUp.Text = "Create new account";
            this.btnSignUp.TextColor = System.Drawing.Color.White;
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnLogin.BorderRadius = 12;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(760, 217);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(300, 50);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // borPassword
            // 
            this.borPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borPassword.BackColor = System.Drawing.Color.White;
            this.borPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            this.borPassword.BorderRadius = 10;
            this.borPassword.BorderSize = 1;
            this.borPassword.FillColor = System.Drawing.Color.White;
            this.borPassword.Location = new System.Drawing.Point(0, 0);
            this.borPassword.Name = "borPassword";
            this.borPassword.Size = new System.Drawing.Size(300, 50);
            this.borPassword.TabIndex = 0;
            this.borPassword.Text = "borderCustome2";
            this.borPassword.Click += new System.EventHandler(this.borderCustome2_Click);
            // 
            // borUserName
            // 
            this.borUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borUserName.BackColor = System.Drawing.Color.White;
            this.borUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            this.borUserName.BorderRadius = 10;
            this.borUserName.BorderSize = 1;
            this.borUserName.FillColor = System.Drawing.Color.White;
            this.borUserName.Location = new System.Drawing.Point(0, 0);
            this.borUserName.Name = "borUserName";
            this.borUserName.Size = new System.Drawing.Size(300, 50);
            this.borUserName.TabIndex = 0;
            this.borUserName.Text = "borderCustome2";
            this.borUserName.Click += new System.EventHandler(this.borUserName_Click);
            // 
            // borPanel
            // 
            this.borPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.borPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            this.borPanel.BorderRadius = 10;
            this.borPanel.BorderSize = 2;
            this.borPanel.FillColor = System.Drawing.Color.White;
            this.borPanel.Location = new System.Drawing.Point(740, 80);
            this.borPanel.Name = "borPanel";
            this.borPanel.Size = new System.Drawing.Size(340, 348);
            this.borPanel.TabIndex = 0;
            this.borPanel.Text = "borderCustome1";
            // 
            // ULogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ULogin";
            this.Size = new System.Drawing.Size(1263, 773);
            this.pnlUsername.ResumeLayout(false);
            this.pnlUsername.PerformLayout();
            this.pblPassword.ResumeLayout(false);
            this.pblPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEye)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.line_ControlBar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flpLanguae.ResumeLayout(false);
            this.flpLanguae.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.DesignControls.BorderCustome borPanel;
        private System.Windows.Forms.Panel pnlUsername;
        private UserControls.DesignControls.BorderCustome borUserName;
        private System.Windows.Forms.Panel pblPassword;
        private UserControls.DesignControls.BorderCustome borPassword;
        private System.Windows.Forms.Label lblUsename;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel1;
        private Components.CustomButton btnLogin;
        private System.Windows.Forms.PictureBox line_ControlBar;
        private System.Windows.Forms.LinkLabel llblForgotPassword;
        private System.Windows.Forms.Panel panel3;
        private Components.CustomButton btnSignUp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFacebook;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblFacebookIntro;
        private System.Windows.Forms.PictureBox picEye;
        private System.Windows.Forms.FlowLayoutPanel flpLanguae;
        private System.Windows.Forms.LinkLabel llblEnglish;
        private System.Windows.Forms.LinkLabel llblVietnamese;
        private System.Windows.Forms.LinkLabel llblFrance;
        private System.Windows.Forms.LinkLabel llblSpain;
        private System.Windows.Forms.LinkLabel llblChinese;
        private System.Windows.Forms.CheckBox cbtnDarkmode;
    }
}
