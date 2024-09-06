namespace GUI.Forms.AccountManagement
{
    partial class LoginForm
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
            this.pnlThemeScroll = new System.Windows.Forms.Panel();
            this.uLogin1 = new GUI.Forms.AccountManagement.ULogin();
            this.pnlThemeScroll.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlThemeScroll
            // 
            this.pnlThemeScroll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlThemeScroll.AutoScroll = true;
            this.pnlThemeScroll.BackColor = System.Drawing.Color.Transparent;
            this.pnlThemeScroll.Controls.Add(this.uLogin1);
            this.pnlThemeScroll.Location = new System.Drawing.Point(0, 33);
            this.pnlThemeScroll.Name = "pnlThemeScroll";
            this.pnlThemeScroll.Size = new System.Drawing.Size(1280, 690);
            this.pnlThemeScroll.TabIndex = 1;
            // 
            // uLogin1
            // 
            this.uLogin1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uLogin1.AutoSize = true;
            this.uLogin1.BackColor = System.Drawing.Color.Transparent;
            this.uLogin1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uLogin1.Location = new System.Drawing.Point(0, 0);
            this.uLogin1.Margin = new System.Windows.Forms.Padding(4);
            this.uLogin1.Name = "uLogin1";
            this.uLogin1.Size = new System.Drawing.Size(1263, 873);
            this.uLogin1.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlThemeScroll);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LoginForm";
            this.Text = "Account";
            this.Controls.SetChildIndex(this.controlBar, 0);
            this.Controls.SetChildIndex(this.pnlThemeScroll, 0);
            this.pnlThemeScroll.ResumeLayout(false);
            this.pnlThemeScroll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlThemeScroll;
        private ULogin uLogin1;
    }
}