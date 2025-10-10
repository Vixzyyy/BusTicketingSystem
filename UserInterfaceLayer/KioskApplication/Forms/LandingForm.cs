using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterfaceLayer.StaffApplication.Forms;


namespace UserInterfaceLayer.KioskApplication.Forms
{
    public partial class LandingForm : Form
    {
        public LandingForm()
        {
            InitializeComponent();
        }

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {
            KioskBaseForm kiosk = new KioskBaseForm(new SelectTripForm());
            kiosk.Show();

            this.Hide();
        }

        private void btnCheckID_Click(object sender, EventArgs e)
        {
            KioskBaseForm kiosk = new KioskBaseForm(new InputResIDForm());
            kiosk.Show();

            this.Hide();
        }

        private void btnTripSched_Click(object sender, EventArgs e)
        {
            KioskBaseForm kiosk = new KioskBaseForm(new TripSchedulesForm());
            kiosk.Show();

            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("MMMM dd, yyyy    |    HH:mm:ss");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            LoadForm loadform = new LoadForm();
            loadform.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

    }
}

