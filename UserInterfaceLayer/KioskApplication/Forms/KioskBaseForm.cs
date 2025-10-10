using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterfaceLayer.KioskApplication.Forms;

namespace UserInterfaceLayer
{
    public partial class KioskBaseForm : Form
    {
        public KioskBaseForm(Form defaultChild = null)
        {
            InitializeComponent();

            if (defaultChild != null)
                LoadFormInPanel(defaultChild);

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("MMMM dd, yyyy    |    HH:mm:ss");
        }
        public void LoadFormInPanel(Form childForm)
        {
            panel4.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panel4.Controls.Add(childForm);
            childForm.Show();
        }

        private void KioskBaseForm_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            LandingForm landing = new LandingForm();
            landing.Show();

            this.Close();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }
    }
}
