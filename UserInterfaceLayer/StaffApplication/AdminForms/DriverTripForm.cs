using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceLayer.StaffApplication.Forms
{
    public partial class DriverTripForm : Form
    {
        private string tripId;
        private string currentDriver;

        public DriverTripForm(string tripId, string currentDriver)
        {
            InitializeComponent();
            this.tripId = tripId;
            this.currentDriver = currentDriver;
        }

        private void DriverTripForm_Load(object sender, EventArgs e)
        {
            lblTripID.Text = "Trip ID: " + tripId;
            lblCurrentDriver.Text = "Current Driver: " + currentDriver;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TripsForm parent = (TripsForm)this.ParentForm;
            parent.ReloadTripsList();
        }
    }
}
