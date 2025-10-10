using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace UserInterfaceLayer.StaffApplication.Forms
{
    public class CustomProgressBar : ProgressBar
    {
        public CustomProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                         ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor |
                         ControlStyles.ResizeRedraw, true);
            this.BackColor = Color.Transparent;
            this.Style = ProgressBarStyle.Continuous;
        }
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            Rectangle rec = this.ClientRectangle;
            int cornerRadius = 8;

            using (GraphicsPath bgPath = GetRoundedRectangle(rec, cornerRadius))
            {
                using (LinearGradientBrush bgBrush = new LinearGradientBrush(
                    rec,
                    Color.FromArgb(245, 247, 250),
                    Color.FromArgb(235, 238, 242),
                    LinearGradientMode.Vertical))
                {
                    g.FillPath(bgBrush, bgPath);
                }
            }
            if (Value > 0)
            {
                int progressWidth = (int)(rec.Width * (Value / (float)Maximum));
                Rectangle progressRec = new Rectangle(0, 0, progressWidth, rec.Height);

                if (progressWidth > 0)
                {
                    using (GraphicsPath progressPath = GetRoundedRectangle(progressRec, cornerRadius))
                    {
                        using (LinearGradientBrush progressBrush = new LinearGradientBrush(
                            progressRec,
                            Color.FromArgb(255, 159, 67),  // Light orange
                            Color.FromArgb(255, 107, 53),  // Deep orange
                            LinearGradientMode.Horizontal))
                        {
                            ColorBlend blend = new ColorBlend();
                            blend.Colors = new Color[] {
                                Color.FromArgb(255, 183, 77),  // Soft orange
                                Color.FromArgb(255, 140, 56),  // Mid orange
                                Color.FromArgb(255, 118, 47)   // Rich orange
                            };
                            blend.Positions = new float[] { 0f, 0.5f, 1f };
                            progressBrush.InterpolationColors = blend;

                            g.FillPath(progressBrush, progressPath);
                        }

                        Rectangle glassRec = new Rectangle(progressRec.X, progressRec.Y,
                            progressRec.Width, progressRec.Height / 2);
                        using (GraphicsPath glassPath = GetRoundedRectangle(glassRec, cornerRadius, true))
                        {
                            using (LinearGradientBrush glassBrush = new LinearGradientBrush(
                                glassRec,
                                Color.FromArgb(80, 255, 255, 255),
                                Color.FromArgb(10, 255, 255, 255),
                                LinearGradientMode.Vertical))
                            {
                                g.FillPath(glassBrush, glassPath);
                            }
                        }

                        if (progressWidth > 20)
                        {
                            Rectangle shimmerRec = new Rectangle(
                                progressWidth - 60, 0, 60, rec.Height);
                            using (LinearGradientBrush shimmerBrush = new LinearGradientBrush(
                                shimmerRec,
                                Color.FromArgb(0, 255, 255, 255),
                                Color.FromArgb(60, 255, 255, 255),
                                LinearGradientMode.Horizontal))
                            {
                                ColorBlend shimmerBlend = new ColorBlend();
                                shimmerBlend.Colors = new Color[] {
                                    Color.FromArgb(0, 255, 255, 255),
                                    Color.FromArgb(60, 255, 255, 255),
                                    Color.FromArgb(0, 255, 255, 255)
                                };
                                shimmerBlend.Positions = new float[] { 0f, 0.5f, 1f };
                                shimmerBrush.InterpolationColors = shimmerBlend;

                                using (GraphicsPath shimmerPath = GetRoundedRectangle(progressRec, cornerRadius))
                                {
                                    g.SetClip(shimmerPath);
                                    g.FillRectangle(shimmerBrush, shimmerRec);
                                    g.ResetClip();
                                }
                            }
                        }
                    }
                }
            }

            int displayValue = (int)((Value / (float)Maximum) * 100);
            string text = displayValue.ToString() + "%";
            using (Font f = new Font("Segoe UI", 9, FontStyle.Bold))
            {
                SizeF textSize = g.MeasureString(text, f);
                float x = (Width - textSize.Width) / 2;
                float y = (Height - textSize.Height) / 2;

                using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(60, 0, 0, 0)))
                {
                    g.DrawString(text, f, shadowBrush, x + 1, y + 1);
                }

                using (SolidBrush textBrush = new SolidBrush(Color.White))
                {
                    g.DrawString(text, f, textBrush, x, y);
                }
            }
        }

        private GraphicsPath GetRoundedRectangle(Rectangle bounds, int radius, bool topOnly = false)
        {
            int diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();

            if (topOnly)
            {
                path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
                path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
                path.AddLine(bounds.Right, bounds.Bottom, bounds.X, bounds.Bottom);
            }
            else
            {
                path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
                path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
                path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
                path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            }

            path.CloseFigure();
            return path;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                
            }
            base.Dispose(disposing);
        }
    }
}
