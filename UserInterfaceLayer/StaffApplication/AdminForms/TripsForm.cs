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
    public partial class TripsForm : Form
    {

        private string tripId;
        private string currentDriver;
        public TripsForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void LoadFormInPanel(Form frm)
        {
            panel2.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panel2.Controls.Add(frm);
            frm.Show();
        }

        private void TripsForm_Load(object sender, EventArgs e)
        {
            dgvTrips.Dock = DockStyle.Fill;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dgvTrips.SelectedRows.Count > 0)
            {
                string tripId = dgvTrips.SelectedRows[0].Cells["TripID"].Value.ToString();
                string status = dgvTrips.SelectedRows[0].Cells["TripStatus"].Value.ToString();

                if (status == "Scheduled")
                {
                    DialogResult result = MessageBox.Show($"Mark Trip #{tripId} as Departed?",
                                                          "Confirm Departure",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("Trip marked as Departed.");
                        ReloadTripsList();
                    }
                }
                else if (status == "Departed")
                {
                    MessageBox.Show("This trip is already marked as Departed.");
                }
                else if (status == "Completed")
                {
                    MessageBox.Show("This trip is already Completed. No further updates allowed.");
                }
                else if (status == "Cancelled")
                {
                    MessageBox.Show("This trip is Cancelled. Cannot mark as Departed.");
                }
            }
            else
            {
                MessageBox.Show("Please select a trip first.",
                                "No Trip Selected",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btEdit_Click(object sender, EventArgs e)
        {

        }

        private void btUpd_Click(object sender, EventArgs e)
        {
            if (dgvTrips.SelectedRows.Count > 0)
            {
                //string tripId = dgvTodaysTrip.SelectedRows[0].Cells["TripID"].Value.ToString();
                //string currentDriver = dgvTodaysTrip.SelectedRows[0].Cells["DriverName"].Value.ToString();

                LoadFormInPanel(new DriverTripForm(tripId, currentDriver));
            }
            else
            {
                MessageBox.Show("Please select a trip first before assigning a driver.", "No Trip Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dgvTrips.SelectedRows.Count > 0)
            {
                string tripId = dgvTrips.SelectedRows[0].Cells["TripID"].Value.ToString();
                string status = dgvTrips.SelectedRows[0].Cells["TripStatus"].Value.ToString();

                if (status == "Departed")
                {
                    DialogResult result = MessageBox.Show($"Mark Trip #{tripId} as Completed?",
                                                          "Confirm Completion",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("Trip marked as Completed.");
                        ReloadTripsList();
                    }
                }
                else if (status == "Scheduled")
                {
                    MessageBox.Show("This trip has not Departed yet. You cannot mark it as Completed.");
                }
                else if (status == "Completed")
                {
                    MessageBox.Show("This trip is already Completed. No further updates allowed.");
                }
                else if (status == "Cancelled")
                {
                    MessageBox.Show("This trip is Cancelled. Cannot mark as Completed.");
                }
            }
            else
            {
                MessageBox.Show("Please select a trip first.",
                                "No Trip Selected",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void dgvTodaysTrip_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void ReloadTripsList()
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(dgvTrips);
            dgvTrips.Dock = DockStyle.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new AddTripForm());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTrips.SelectedRows.Count > 0)
            {
                //string tripId = dgvTodaysTrip.SelectedRows[0].Cells["TripID"].Value.ToString();

                LoadFormInPanel(new EditTripForm());
            }
            else
            {
                MessageBox.Show("Please select a trip first before editing.", "No Trip Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new CancelTripForm());
        }

        private void btnDeparted_Click(object sender, EventArgs e)
        {

        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {

        }
    }
}
