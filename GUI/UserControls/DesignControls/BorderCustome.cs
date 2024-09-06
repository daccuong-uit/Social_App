using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using GUI.Resources.Styles;

namespace GUI.UserControls.DesignControls
{
    [DesignerCategory("Code")]
    [ToolboxItem(true)]
    public class BorderCustome : Control
    {
        private Color borderColor = ColorPalette.LightColor2; // Màu đường viền
        private int borderSize = 1; // Kích thước đường viền
        private int borderRadius = 10; // Bán kính góc
        private Color fillColor = Color.White; // Màu bên trong

        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); } // Vẽ lại control khi thay đổi màu
        }

        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = Math.Max(1, value); Invalidate(); } // Đảm bảo kích thước đường viền không nhỏ hơn 1
        }

        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = Math.Max(0, value); Invalidate(); } // Đảm bảo bán kính không âm
        }

        public Color FillColor
        {
            get { return fillColor; }
            set { fillColor = value; Invalidate(); } // Vẽ lại control khi thay đổi màu fill
        }

        public BorderCustome()
        {
            this.DoubleBuffered = true; // Giảm nháy hình
            this.Size = new Size(100, 100); // Kích thước mặc định
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Tính toán hình chữ nhật cho border
            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);

            // Đặt chế độ làm mịn
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Vẽ màu bên trong
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, borderRadius * 2, borderRadius * 2, 180, 90);
                path.AddArc(rect.X + rect.Width - borderRadius * 2, rect.Y, borderRadius * 2, borderRadius * 2, 270, 90);
                path.AddArc(rect.X + rect.Width - borderRadius * 2, rect.Y + rect.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90);
                path.AddArc(rect.X, rect.Y + rect.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90);
                path.CloseFigure();

                // Vẽ màu bên trong
                using (Brush fillBrush = new SolidBrush(fillColor))
                {
                    e.Graphics.FillPath(fillBrush, path);
                }

                // Vẽ đường viền
                using (Pen borderPen = new Pen(borderColor, borderSize))
                {
                    e.Graphics.DrawPath(borderPen, path);
                }
            }
        }
    }
}