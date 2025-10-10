using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceLayer.KioskApplication.Forms
{
    public partial class TripSchedulesForm : Form
    {
        public TripSchedulesForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }
        private void btnTripSched_Click(object sender, EventArgs e)
        {
            KioskBaseForm parent = new KioskBaseForm();
            parent.Show();

            parent.LoadFormInPanel(new TripSchedulesForm());

            this.Hide();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void pnlCheckRes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            LandingForm landing = new LandingForm();
            landing.Show();
            this.ParentForm?.Close();
        }
    }
}
