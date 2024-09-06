namespace GUI.UserControls.ControlBar
{
    partial class UControlBar
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
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picMaximize = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.line_ControlBar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line_ControlBar)).BeginInit();
            this.SuspendLayout();
            // 
            // picMinimize
            // 
            this.picMinimize.BackColor = System.Drawing.Color.Transparent;
            this.picMinimize.Image = global::GUI.Properties.Resources.line_24_black;
            this.picMinimize.Location = new System.Drawing.Point(1158, 0);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(40, 32);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picMinimize.TabIndex = 1;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            this.picMinimize.MouseEnter += new System.EventHandler(this.picMinimize_MouseEnter);
            this.picMinimize.MouseLeave += new System.EventHandler(this.picMinimize_MouseLeave);
            // 
            // picMaximize
            // 
            this.picMaximize.BackColor = System.Drawing.Color.Transparent;
            this.picMaximize.Image = global::GUI.Properties.Resources.square_20_black;
            this.picMaximize.Location = new System.Drawing.Point(1199, 0);
            this.picMaximize.Name = "picMaximize";
            this.picMaximize.Size = new System.Drawing.Size(40, 32);
            this.picMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picMaximize.TabIndex = 1;
            this.picMaximize.TabStop = false;
            this.picMaximize.Click += new System.EventHandler(this.picMaximize_Click);
            this.picMaximize.MouseEnter += new System.EventHandler(this.picMaximize_MouseEnter);
            this.picMaximize.MouseLeave += new System.EventHandler(this.picMaximize_MouseLeave);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.Image = global::GUI.Properties.Resources.x_24_black;
            this.picClose.Location = new System.Drawing.Point(1240, 0);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(40, 32);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picClose.TabIndex = 1;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseEnter += new System.EventHandler(this.picClose_MouseEnter);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            // 
            // line_ControlBar
            // 
            this.line_ControlBar.BackColor = System.Drawing.Color.Black;
            this.line_ControlBar.Location = new System.Drawing.Point(0, 39);
            this.line_ControlBar.Name = "line_ControlBar";
            this.line_ControlBar.Size = new System.Drawing.Size(1280, 1);
            this.line_ControlBar.TabIndex = 3;
            this.line_ControlBar.TabStop = false;
            // 
            // UControlBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.line_ControlBar);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.picMaximize);
            this.Controls.Add(this.picMinimize);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UControlBar";
            this.Size = new System.Drawing.Size(1280, 40);
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line_ControlBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox picMaximize;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox line_ControlBar;
    }
}
