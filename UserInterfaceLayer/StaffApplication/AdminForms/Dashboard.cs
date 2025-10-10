using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceLayer.StaffApplication.Forms
{
    public partial class Dashboard : Form
    {
        private Button selectedButton = null;
        private Color defaultBackColor;
        private Color defaultForeColor;
        public Dashboard()
        {
            InitializeComponent();
            LoadFormInPanel(new DashboardForm());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                StaffLoginForm userlogin = new StaffLoginForm();
                userlogin.Show();

                this.Hide();
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
        public void LoadFormInPanel(Form form)
        {
            if (panel6 == null)
                return;

            panel6.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel6.Controls.Add(form);
            form.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy | hh:mm");
        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {

        }
    }
}
