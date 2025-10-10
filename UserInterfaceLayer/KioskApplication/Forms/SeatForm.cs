using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using Application.DTOs;

namespace UserInterfaceLayer.KioskApplication.Forms
{
   
    public partial class SeatForm : Form
    {
        private SelectTripForm parentTripForm;
       
        public SeatForm(
            string origin, string destination, string busType, string busClass,
            string departureTime, string arrivalTime, decimal fare,
            SelectTripForm parentTripForm,
            List<TripDetailsDTO> tripList)
        {
            InitializeComponent();
            this.parentTripForm = parentTripForm;
            

            InitializeTripSummary(origin, destination, busType, busClass, departureTime, arrivalTime, fare);
        }

        private void InitializeTripSummary(string origin, string destination, string busType,
            string busClass, string departureTime, string arrivalTime, decimal fare)
        {
            lblOrigin.Text = origin;
            lblDestination.Text = destination;
            lblBusType.Text = busType;
            lblBusClass.Text = busClass;
            lblDeparture.Text = departureTime;
            lblArrival.Text = arrivalTime;
            lblFareSeat.Text = $"₱{fare:N2}";

            lblSelectedSeats.AutoSize = false;
            int maxWidth = pnlBookingSummary.Width - lblSelectedSeats.Location.X - 10;
            lblSelectedSeats.Size = new Size(maxWidth, lblSelectedSeats.Height);
            lblSelectedSeats.AutoEllipsis = true;
            lblSelectedSeats.TextAlign = ContentAlignment.MiddleLeft;
        }

        public void LoadSeatLayout(string busType, decimal fare)
        {
            UserControl? seatLayout = null;

            if (busType == "Regular Mini Bus")
                seatLayout = new RegularMiniBus();
            else if (busType == "Regular Coach")
                seatLayout = new RegularCoachBus();
            else if (busType == "Deluxe Coach")
                seatLayout = new DeluxeCoachBus();
            else if (busType == "Regular Tour Bus")
                seatLayout = new RegularTourBus();
            else if (busType == "Deluxe Tour Bus")
                seatLayout = new DeluxeTourBus();

            if (seatLayout != null)
            {
                seatLayout.Dock = DockStyle.Fill;
                pnlSeatLayout.Controls.Clear();
                pnlSeatLayout.Controls.Add(seatLayout);

                if (seatLayout is SeatLayoutBase layoutBase)
                {
                    layoutBase.SetSummaryLabels(lblSelectedSeats, lblTotalAmount, lblFareSeat, fare);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (parentTripForm != null)
            {
                parentTripForm.ShowTripSelection();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string seats = lblSelectedSeats.Text;

            if (string.IsNullOrWhiteSpace(seats))
            {
                MessageBox.Show("Please select at least one seat.", "No Seats Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string busType = lblBusType.Text;
            string busClass = lblBusClass.Text;
            string origin = lblOrigin.Text;
            string destination = lblDestination.Text;
            string tripDateTime = $"{lblDeparture.Text} - {lblArrival.Text}";

            decimal farePerSeat = 0;
            decimal.TryParse(lblFareSeat.Text.Replace("₱", "").Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out farePerSeat);

            decimal totalAmount = 0;
            decimal.TryParse(lblTotalAmount.Text.Replace("₱", "").Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out totalAmount);

            PassengerDetailsForm passengerForm = new PassengerDetailsForm(
                seats, busType, busClass,
                origin, destination, tripDateTime,
                farePerSeat, totalAmount,
                parentTripForm,
                this
            );

            parentTripForm.LoadFormInMainPanel(passengerForm);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (parentTripForm != null)
            {
                parentTripForm.ShowTripSelection();
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            btnNext_Click(sender, e);
        }

        private void pnlSelectTrip_Paint(object sender, PaintEventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
    }
}