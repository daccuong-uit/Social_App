﻿using GUI.Resources.Styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControls.ControlBar
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            InitializeForm();
        }


        void InitializeForm()
        {
            this.BackColor = ColorPalette.LightColor1;
            this.ForeColor = ColorPalette.DarkColor1; 
            this.Font = new Font("Georgia", 10, FontStyle.Regular);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Height = 720;
            this.Width = 1280;

            // Khởi tạo UControlBar
            UControlBar controlBar = new UControlBar();

            // Đăng ký các sự kiện
            controlBar.btnCloseClicked += ControlBar_btnCloseClicked;
            controlBar.btnMaximizeClicked += ControlBar_btnMaximizeClicked;
            controlBar.btnMinimizeClicked += ControlBar_btnMinimizeClicked;

            // Thêm UControlBar vào form
            this.Controls.Add(controlBar);
            controlBar.Dock = DockStyle.Top;

            // Thiết lập giao diện
            controlBar.DesignA();
        }

        private void ControlBar_btnCloseClicked(object sender, EventArgs e)
        {
            this.Close(); // Đóng form
        }

        private void ControlBar_btnMaximizeClicked(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized; // Tối đa hóa
            }
            else
            {
                this.WindowState = FormWindowState.Normal; // Khôi phục
            }
        }

        private void ControlBar_btnMinimizeClicked(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Giảm thiểu
        }
    }
}