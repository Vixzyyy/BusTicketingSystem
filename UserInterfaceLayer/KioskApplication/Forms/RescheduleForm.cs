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
    public partial class RescheduleForm : Form
    {
        private ReservationDetailsForm previousForm;
        public RescheduleForm(ReservationDetailsForm previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
        }

        private void guna2ShadowPanel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guna2ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        /*private void btnUpdSeats_Click(object sender, EventArgs e)
        {
            pnlSeatPopup.Controls.Clear();

            UserControl seatLayout = null;

            if (lblBusType.Text == "Coach" && lblBusClass.Text == "Regular")
                seatLayout = new RegularCoachBus();
            else if (lblBusType.Text == "Coach" && lblBusClass.Text == "Deluxe")
                seatLayout = new DeluxeCoachBus();
            else if (lblBusType.Text == "Mini Bus" && lblBusClass.Text == "Regular")
                seatLayout = new RegularMiniBus();
            else if (lblBusType.Text == "Tour Bus" && lblBusClass.Text == "Regular")
                seatLayout = new RegularTourBus();
            else if (lblBusType.Text == "Tour Bus" && lblBusClass.Text == "Deluxe")
                seatLayout = new DeluxeTourBus();

            if (seatLayout != null)
            {
                seatLayout.Dock = DockStyle.Fill;
                pnlSeatPopup.Controls.Add(seatLayout);

                if (seatLayout is SeatLayoutBase layoutBase)
                {
                    layoutBase.SetSummaryLabels(
                        lblNewSeats,
                        lblNewNoSeats,
                        lblFareSeat,
                        decimal.Parse(lblFareSeat.Text.Replace("₱", ""))
                    );
                }
            }

            pnlSeatPopup.Visible = true;
            pnlSeatPopup.BringToFront();

            // Force button above popup
            btnConfirm.Parent = this;  // make sure it's on the form, not inside another panel
            btnConfirm.Visible = true;
            btnConfirm.BringToFront();


        }*/

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblNewSeats.Text))
            {
                MessageBox.Show("Please select at least one seat.");
                return;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void RescheduleForm_Load(object sender, EventArgs e)
        {
            //pnlSeatPopup.Visible = false;
        }

        protected KioskBaseForm GetKioskBaseForm()
        {
            Control current = this;
            while (current != null)
            {
                if (current is KioskBaseForm)
                    return (KioskBaseForm)current;
                current = current.Parent;
            }
            return null;
        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Reschedule confirmed! Reschedule issued.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            LandingForm landing = new LandingForm();
            landing.Show();

            (this.ParentForm as KioskBaseForm)?.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            KioskBaseForm parent = GetKioskBaseForm();
            if (parent != null && previousForm != null)
            {
                parent.LoadFormInPanel(previousForm);
            }
            else
            {
                MessageBox.Show("Parent KioskBaseForm not found!");
            }
        }

        private void btnSelectSeats_Click(object sender, EventArgs e)
        {

        }
    }
}
