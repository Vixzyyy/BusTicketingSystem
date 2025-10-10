using System;
using System.Drawing;
using System.Windows.Forms;

namespace UserInterfaceLayer.StaffApplication.Forms
{
    public partial class SplashScreen : Form
    {
        private CustomProgressBar customProgressBar1;

        public SplashScreen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            customProgressBar1 = new CustomProgressBar();
            customProgressBar1.Location = new Point(141, 398);
            customProgressBar1.Size = new Size(512, 22);
            customProgressBar1.Maximum = 100;
            customProgressBar1.Value = 0;
            guna2ShadowPanel1.Controls.Add(customProgressBar1);

            customProgressBar1.Value = 0;
            timer1.Interval = 5;
            timer1.Enabled = true;
            timer1.Start();
        }
        private void SplashScreen_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (customProgressBar1.Value < customProgressBar1.Maximum)
            {
                customProgressBar1.Value += 5;
                customProgressBar1.Invalidate(true);
                this.Refresh();
            }
            else
            {
                timer1.Stop();
                BaseDashboardForm db = new BaseDashboardForm();
                db.Show();
                this.Hide();
            }
        }

        private void customProgressBar1_Click(object sender, EventArgs e)
        {
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void customProgressBar1_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}