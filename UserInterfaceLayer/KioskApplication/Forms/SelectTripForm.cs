using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Application.Services;

using UserInterfaceLayer.UserControls;
using Application.DTOs;



namespace UserInterfaceLayer.KioskApplication.Forms
{
    public partial class SelectTripForm : Form
    {
        private List<TripDetailsDTO> currentTrips;
        private int currentStep = 0;
        private const int STEP_SELECT_TRIP = 0;
        private const int STEP_SELECT_SEATS = 1;
        private const int STEP_PASSENGER_DETAILS = 2;
        private const int STEP_CONFIRM_PAYMENT = 3;

        private SeatForm currentSeatForm;
        private PassengerDetailsForm currentPassengerForm;
        private ConfirmPaymentForm currentConfirmForm;

        public SelectTripForm()
        {
            this.SuspendLayout();
            InitializeComponent();

            typeof(FlowLayoutPanel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, flowLayoutPanelTrips, new object[] { true });

            ClearForm();
            AttachNavigationHandlers();
            this.ResumeLayout(false);
        }

        private void AttachNavigationHandlers()
        {
            cbMini.CheckedChanged += (s, ev) => ApplyFilters();
            cbCoach.CheckedChanged += (s, ev) => ApplyFilters();
            cbTour.CheckedChanged += (s, ev) => ApplyFilters();
            cbRegular.CheckedChanged += (s, ev) => ApplyFilters();
            cbDeluxe.CheckedChanged += (s, ev) => ApplyFilters();

            btnSelectTrip.Click += BtnSelectTrip_Click;
            btnSelectSeats.Click += BtnSelectSeats_Click;
            btnPassengerDetails.Click += BtnPassengerDetails_Click;
            btnConfirmPayment.Click += BtnConfirmPayment_Click;
        }

        private void BtnSelectTrip_Click(object sender, EventArgs e)
        {
            if (currentStep > STEP_SELECT_TRIP)
            {
                var result = MessageBox.Show(
                    "Are you sure you want to go back? Your current progress will be lost.",
                    "Confirm Navigation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    currentSeatForm = null;
                    currentPassengerForm = null;
                    currentConfirmForm = null;
                    ShowTripSelection();
                }
            }
        }

        private void BtnSelectSeats_Click(object sender, EventArgs e)
        {
            if (currentStep < STEP_SELECT_SEATS)
            {
                MessageBox.Show("Please select a trip first.", "Navigation Blocked",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (currentStep > STEP_SELECT_SEATS)
            {
                var result = MessageBox.Show(
                    "Are you sure you want to go back? Your current progress will be lost.",
                    "Confirm Navigation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No) return;

                currentPassengerForm = null;
                currentConfirmForm = null;
            }

            if (currentSeatForm != null)
            {
                LoadFormInMainPanel(currentSeatForm);
            }
        }

        private void BtnPassengerDetails_Click(object sender, EventArgs e)
        {
            if (currentStep < STEP_PASSENGER_DETAILS)
            {
                MessageBox.Show("Please complete seat selection first.", "Navigation Blocked",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (currentStep > STEP_PASSENGER_DETAILS)
            {
                var result = MessageBox.Show(
                    "Are you sure you want to go back? Your current progress will be lost.",
                    "Confirm Navigation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No) return;
                currentConfirmForm = null;
            }

            if (currentPassengerForm != null)
            {
                LoadFormInMainPanel(currentPassengerForm);
            }
        }

        private void BtnConfirmPayment_Click(object sender, EventArgs e)
        {
            if (currentStep < STEP_CONFIRM_PAYMENT)
            {
                MessageBox.Show("Please complete passenger details first.", "Navigation Blocked",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (currentConfirmForm != null)
            {
                LoadFormInMainPanel(currentConfirmForm);
            }
        }

        public void LoadFormInMainPanel(Form childForm)
        {
            mainPanel.SuspendLayout();

            guna2Panel1.Visible = false;

            mainPanel.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(childForm);
            childForm.Show();

            if (childForm is SeatForm seatForm)
            {
                currentStep = STEP_SELECT_SEATS;
                currentSeatForm = seatForm;
            }
            else if (childForm is PassengerDetailsForm passengerForm)
            {
                currentStep = STEP_PASSENGER_DETAILS;
                currentPassengerForm = passengerForm;
            }
            else if (childForm is ConfirmPaymentForm confirmForm)
            {
                currentStep = STEP_CONFIRM_PAYMENT;
                currentConfirmForm = confirmForm;
            }

            mainPanel.ResumeLayout(true);
            UpdateNavigationButtons();
        }

        public void ShowTripSelection()
        {
            mainPanel.SuspendLayout();
            mainPanel.Controls.Clear();

            guna2Panel1.Visible = true;
            guna2Panel1.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(guna2Panel1);

            currentStep = STEP_SELECT_TRIP;

            if (currentTrips != null && currentTrips.Any())
            {
                LoadTripCards(currentTrips);
            }

            mainPanel.ResumeLayout(true);
            UpdateNavigationButtons();
        }

        private void UpdateNavigationButtons()
        {
            btnSelectTrip.Enabled = true;
            btnSelectSeats.Enabled = currentStep >= STEP_SELECT_SEATS;
            btnPassengerDetails.Enabled = currentStep >= STEP_PASSENGER_DETAILS;
            btnConfirmPayment.Enabled = currentStep >= STEP_CONFIRM_PAYMENT;

            ResetButtonStyle(btnSelectTrip, currentStep == STEP_SELECT_TRIP);
            ResetButtonStyle(btnSelectSeats, currentStep == STEP_SELECT_SEATS);
            ResetButtonStyle(btnPassengerDetails, currentStep == STEP_PASSENGER_DETAILS);
            ResetButtonStyle(btnConfirmPayment, currentStep == STEP_CONFIRM_PAYMENT);
        }

        private void ResetButtonStyle(Guna.UI2.WinForms.Guna2Button button, bool isCurrent)
        {
            button.FillColor = Color.Transparent;
            button.ForeColor = Color.FromArgb(128, 64, 0);
            button.Font = isCurrent
                ? new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold)
                : new Font("Segoe UI Variable Display", 12F, FontStyle.Regular);
        }

        private void PopulateComboBoxes()
        {
            try
            {
                var terminalService = new TerminalService();
                var terminals = terminalService.DisplayTerminals();

                cbOrigin.DataSource = terminals.ToList();
                cbOrigin.DisplayMember = "TerminalName";
                cbOrigin.ValueMember = "TerminalId";

                cbDestination.DataSource = terminals.ToList();
                cbDestination.DisplayMember = "TerminalName";
                cbDestination.ValueMember = "TerminalId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading terminals: " + ex.Message);
            }
        }

        private void LoadTripCards(List<TripDetailsDTO> trips)
        {
            flowLayoutPanelTrips.SuspendLayout();
            flowLayoutPanelTrips.Controls.Clear();

            flowLayoutPanelTrips.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelTrips.WrapContents = false;
            flowLayoutPanelTrips.AutoScroll = true;
            flowLayoutPanelTrips.Padding = new Padding(10);

            flowLayoutPanelTrips.HorizontalScroll.Enabled = false;
            flowLayoutPanelTrips.HorizontalScroll.Visible = false;

            if (trips == null || !trips.Any())
            {
                flowLayoutPanelTrips.Controls.Add(new Label
                {
                    Text = "No trips available for the selected route and date.",
                    AutoSize = true,
                    ForeColor = Color.Gray,
                    Dock = DockStyle.Fill
                });
                flowLayoutPanelTrips.ResumeLayout();
                return;
            }

            foreach (var trip in trips)
            {
                var card = new TripCardControl
                {
                    Origin = trip.Origin,
                    TripCode = $"Trip #{trip.TripId}",
                    TravelTime = (trip.ArrivalTime - trip.DepartureTime).ToString(@"hh\:mm") + " hrs",
                    Destination = trip.Destination,
                    Departure = trip.DepartureTime.ToString(@"hh\:mm"),
                    Arrival = trip.ArrivalTime.ToString(@"hh\:mm"),
                    BusTypeTrip = trip.BusType ?? "Bus Type",
                    Fare = $"₱{trip.FareAmount:N2}",
                    Margin = new Padding(10),
                    Width = flowLayoutPanelTrips.ClientSize.Width - 30
                };
                card.SelectSeatsClicked += (s, e) =>
                {
                    try
                    {
                        if (string.IsNullOrEmpty(cbOrigin.Text) ||
                            string.IsNullOrEmpty(cbDestination.Text))
                        {
                            MessageBox.Show("Please search for trips first.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        SeatForm seatForm = new SeatForm(
                                //    t.origin, t.destination, t.type, t.cls,
                                //    t.dep.ToString("yyyy-MM-dd HH:mm"),
                                //    t.arr.ToString("yyyy-MM-dd HH:mm"),
                                //    t.fare, this, trips);

                                //seatForm.LoadSeatLayout(t.type, t.cls, t.fare);
                                //LoadFormInMainPanel(seatForm);
                                trip.Origin,
                                trip.Destination,
                                trip.BusType,
                                "Class",
                                trip.DepartureTime.ToString(@"hh\:mm"),
                                trip.ArrivalTime.ToString(@"hh\:mm"),
                                trip.FareAmount,
                                this,
                                trips);
                        seatForm.LoadSeatLayout(trip.BusType, trip.FareAmount);
                        LoadFormInMainPanel(seatForm);

                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                };

                flowLayoutPanelTrips.Controls.Add(card);
            }

            flowLayoutPanelTrips.ResumeLayout();
        }

        private void ClearForm()
        {
            cbOrigin.SelectedIndex = -1;
            cbDestination.SelectedIndex = -1;
        }

        private void SelectTripForm_Load(object sender, EventArgs e)
        {
            PopulateComboBoxes();
            UpdateNavigationButtons();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var service = new TripService();

            string origin = cbOrigin.Text;
            string destination = cbDestination.Text;
            DateTime date = dtpDeparture.Value.Date;

            if (string.IsNullOrEmpty(origin) || string.IsNullOrEmpty(destination))
            {
                MessageBox.Show("Please select both origin and destination.",
                    "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (origin == destination)
            {
                MessageBox.Show("Origin and destination cannot be the same.",
                    "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<TripDetailsDTO> trips = service.GetTrips(date, origin, destination);
            currentTrips = trips;
            MessageBox.Show($"Searching: {origin} → {destination} on {date}");

            if (trips == null || trips.Count == 0)
            {
                MessageBox.Show("No trips found for this route and date.");
                return;
            }

            string result = "";
            foreach (var trip in trips)
            {
                result += $"Trip ID: {trip.TripId}\n" +
                          $"Origin: {trip.Origin}\n" +
                          $"Destination: {trip.Destination}\n" +
                          $"Departure: {trip.DepartureTime}\n" +
                          $"Arrival: {trip.ArrivalTime}\n" +
                          $"Price: {trip.FareAmount}\n\n";
            }

            MessageBox.Show(result);
            LoadTripCards(trips);
            ApplyFilters();
        }
       
        private void ApplyFilters()
        {
            if (currentTrips == null || !currentTrips.Any())
            {
                flowLayoutPanelTrips.Controls.Clear();
                return;
            }

            var filteredTrips = currentTrips.Where(t =>
            {
                bool typeMatch = (!cbMini.Checked && !cbCoach.Checked && !cbTour.Checked)
                     || (cbMini.Checked && string.Equals(t.BusType, "Regular Mini Bus", StringComparison.OrdinalIgnoreCase))
                     || (cbCoach.Checked && string.Equals(t.BusType, "Regular Coach", StringComparison.OrdinalIgnoreCase))
                     || (cbTour.Checked && string.Equals(t.BusType, "Deluxe Tour Bus", StringComparison.OrdinalIgnoreCase));

                //bool classMatch = (!cbRegular.Checked && !cbDeluxe.Checked)
                //    || (cbRegular.Checked && string.Equals(t.BusClass, "Regular", StringComparison.OrdinalIgnoreCase))
                //    || (cbDeluxe.Checked && string.Equals(t.BusClass, "Deluxe", StringComparison.OrdinalIgnoreCase));

                return typeMatch;
                //return typeMatch && classMatch;
            }).ToList();

            LoadTripCards(filteredTrips);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            LandingForm landing = new LandingForm();
            landing.Show();
            KioskBaseForm? parent = this.ParentForm as KioskBaseForm;
            if (parent != null) parent.Close();
            else this.Close();
        }

        private void cbDestination_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cbMini_CheckedChanged(object sender, EventArgs e) { }

        private void flowLayoutPanelTrips_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}