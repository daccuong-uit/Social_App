using GUI.Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;
using ColorPalette = GUI.Resources.Styles.ColorPalette;

namespace GUI.UserControls.ControlBar
{
    public partial class UControlBar : UserControl
    {
        public event EventHandler btnCloseClicked;
        public event EventHandler btnMaximizeClicked;
        public event EventHandler btnMinimizeClicked;

        public UControlBar()
        {
            InitializeComponent();
        }

        public void DesignA()
        {
            if (AppSettings.IsDarkMode)
            {
                // Thiết lập giao diện cho chế độ tối
                picClose.Image = Properties.Resources.x_24_white;
                picMaximize.Image = Properties.Resources.square_20_white;
                picMinimize.Image = Properties.Resources.line_24_white;

                line_ControlBar.BackColor = ColorPalette.LightColor1;
            }
            else
            {
                // Thiết lập giao diện cho chế độ sáng
                picClose.Image = Properties.Resources.x_24_black;
                picMaximize.Image = Properties.Resources.square_20_black;
                picMinimize.Image = Properties.Resources.line_24_black;

                line_ControlBar.BackColor = ColorPalette.DarkColor1;
            }
        }

        #region Event Handlers
        // Minimize
        private void picMinimize_Click(object sender, EventArgs e)
        {
            btnMinimizeClicked?.Invoke(this, EventArgs.Empty);
        }

        private void picMinimize_MouseEnter(object sender, EventArgs e)
        {
            picMinimize.BackColor = Color.FromArgb(200, 200, 200); // Thay đổi màu nền khi chuột vào
        }

        private void picMinimize_MouseLeave(object sender, EventArgs e)
        {
            picMinimize.BackColor = Color.Transparent; // Trở về màu nền ban đầu
        }

        // Maximize
        private void picMaximize_Click(object sender, EventArgs e)
        {
            btnMaximizeClicked?.Invoke(this, EventArgs.Empty);
        }

        private void picMaximize_MouseEnter(object sender, EventArgs e)
        {
            picMaximize.BackColor = Color.FromArgb(200, 200, 200); // Thay đổi màu nền khi chuột vào
        }

        private void picMaximize_MouseLeave(object sender, EventArgs e)
        {
            picMaximize.BackColor = Color.Transparent; // Trở về màu nền ban đầu
        }

        // Close
        private void picClose_Click(object sender, EventArgs e)
        {
            btnCloseClicked?.Invoke(this, EventArgs.Empty);
        }

        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            picClose.BackColor = Color.FromArgb(255, 100, 100); // Thay đổi màu nền khi chuột vào
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.BackColor = Color.Transparent; // Trở về màu nền ban đầu
        }
        #endregion
    }
}