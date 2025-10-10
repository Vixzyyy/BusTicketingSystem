using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UserInterfaceLayer
{
    public partial class ReceiptShapeControl : UserControl
    {
        public ReceiptShapeControl()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.DoubleBuffered = true; // smoother drawing

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int waveRadius = 6;   // curve size for bottom perforation
            int cornerRadius = 20; // corner roundness

            Color borderColor = Color.FromArgb(237, 164, 80);
            Color fillColor = Color.White;
            Color shadowColor = Color.FromArgb(255, 228, 200);

            using (Pen borderPen = new Pen(borderColor, 2))
            using (SolidBrush fillBrush = new SolidBrush(fillColor))
            using (SolidBrush shadowBrush = new SolidBrush(shadowColor))
            {
                // === Rounded rectangle path (excluding bottom wave) ===
                int rectHeight = this.Height - waveRadius * 2 - 1;
                int rectWidth = this.Width - 1;

                System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

                // top-left corner
                path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
                // top edge
                path.AddLine(cornerRadius, 0, rectWidth - cornerRadius, 0);
                // top-right corner
                path.AddArc(rectWidth - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
                // right edge
                path.AddLine(rectWidth, cornerRadius, rectWidth, rectHeight - cornerRadius);
                // bottom-right corner
                path.AddArc(rectWidth - cornerRadius, rectHeight - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                // bottom edge (stop before left corner)
                path.AddLine(rectWidth - cornerRadius, rectHeight, cornerRadius, rectHeight);
                // bottom-left corner
                path.AddArc(0, rectHeight - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                // close
                path.CloseFigure();

                // Fill + border
                e.Graphics.FillPath(fillBrush, path);
                e.Graphics.DrawPath(borderPen, path);

                // === Wavy bottom perforation ===
                for (int x = 0; x < this.Width; x += waveRadius * 2)
                {
                    e.Graphics.DrawArc(borderPen, x, rectHeight, waveRadius * 2, waveRadius * 2, 0, 180);
                }
            }
        }
    }
}
