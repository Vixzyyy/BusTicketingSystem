
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace UserInterfaceLayer.KioskApplication.Forms
{
    public partial class PassengerDetailsForm : Form
    {
        private string selectedSeats;
        private string busTypeClass;
        private string route;
        private string dateTime;
        private decimal farePerSeat;
        private decimal totalAmount;
        private SelectTripForm parentTripForm;
        private SeatForm previousSeatForm;

        public PassengerDetailsForm(string seats, string busType, string busClass,
                                    string origin, string destination, string tripDateTime,
                                    decimal fare, decimal total,
                                    SelectTripForm parentTripForm, SeatForm previousSeatForm)
        {
            InitializeComponent();

            this.parentTripForm = parentTripForm;
            this.previousSeatForm = previousSeatForm;
            this.selectedSeats = seats;
            this.busTypeClass = $"{busType} - {busClass}";
            this.route = $"{origin} → {destination}";
            this.dateTime = tripDateTime;
            this.farePerSeat = fare;
            this.totalAmount = total;

            InitializeBookingSummary();
            InitializeOtherPassengerInputs();
        }

        private void InitializeBookingSummary()
        {
            lblSeats.Text = selectedSeats;
            lblTypeClass.Text = busTypeClass;
            lblRoute.Text = route;
            lblDateTime.Text = dateTime;
            lblFareSeat.Text = $"₱{farePerSeat:N2}";
            lblTotalAmount.Text = $"₱{totalAmount:N2}";

            lblSeats.AutoSize = true;
            lblSeats.MaximumSize = new Size(guna2ShadowPanel2.Width - lblSeats.Location.X - 20, 0);
            lblSeats.AutoEllipsis = true;
            lblSeats.TextAlign = ContentAlignment.TopLeft;
        }

        private void InitializeOtherPassengerInputs()
        {
            Label lblTitle = new Label
            {
                Text = "Other Passenger Information",
                Font = new Font("Segoe UI Black", 18, FontStyle.Bold),
                ForeColor = Color.FromArgb(128, 64, 0),
                Location = new Point(100, 11),
                AutoSize = true
            };
            pnlOtherPassengers.Controls.Add(lblTitle);

            string[] seatNumbers = selectedSeats.Split(',')
                                                .Select(s => s.Trim())
                                                .Where(s => !string.IsNullOrEmpty(s))
                                                .ToArray();

            int yPosition = 71;
            foreach (string seat in seatNumbers)
            {
                AddPassengerRow(seat, yPosition);
                yPosition += 50;
            }
        }

        private void AddPassengerRow(string seatNumber, int yPosition)
        {
            Label lblSeat = new Label
            {
                Text = $"[{seatNumber}]",
                Font = new Font("Segoe UI Variable Display Semib", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(128, 64, 0),
                Location = new Point(30, yPosition),
                AutoSize = true
            };

            Guna2TextBox tbName = new Guna2TextBox
            {
                Name = $"tb_{seatNumber}",
                Size = new Size(340, 40),
                Location = new Point(120, yPosition - 3),
                Font = new Font("Segoe UI Variable Text", 10.8f, FontStyle.Regular),
                ForeColor = Color.Black,
                BorderColor = Color.FromArgb(213, 218, 223),
                BorderRadius = 19,
                TextOffset = new Point(10, 0),
                PlaceholderText = "Enter name"
            };

            Guna2ComboBox cbType = new Guna2ComboBox
            {
                Name = $"cb_{seatNumber}",
                Size = new Size(150, 40),
                Location = new Point(470, yPosition - 3),
                Font = new Font("Segoe UI Variable Text", 10.8f, FontStyle.Regular),
                ForeColor = Color.Black,
                BorderColor = Color.FromArgb(213, 218, 223),
                BorderRadius = 19,
                DrawMode = DrawMode.OwnerDrawFixed,
                DropDownStyle = ComboBoxStyle.DropDownList,
                TextOffset = new Point(10, 0)
            }; // Close the initializer here

            cbType.Items.AddRange(new object[] { "Regular", "Student", "PWD", "Senior Citizen" });
            cbType.SelectedIndex = 0; // Set selected index after adding items

            pnlOtherPassengers.Controls.Add(lblSeat);
            pnlOtherPassengers.Controls.Add(tbName);
            pnlOtherPassengers.Controls.Add(cbType);
        }

        public void SetPassengerInfo(string name, int age, string gender,
                                     string contact, string email, string address)
        {
            tbFName.Text = name;
            nudAge.Value = age;

            if (gender == "Female") rbFemale.Checked = true;
            else if (gender == "Male") rbMale.Checked = true;
            else rbSecret.Checked = true;

            tbContactNo.Text = contact;
            tbEmail.Text = email;
            tbAddress.Text = address;
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            if (parentTripForm != null && previousSeatForm != null)
            {
                parentTripForm.LoadFormInMainPanel(previousSeatForm);
            }
        }

        //private void btnNext_Click(object sender, EventArgs e)
        //{
        //    if (!ValidateMainPassenger(out string error))
        //    {
        //        MessageBox.Show(error, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    ConfirmPaymentForm confirmForm = new ConfirmPaymentForm(
        //        tbFName.Text,
        //        (int)nudAge.Value,
        //        GetSelectedGender(),
        //        tbContactNo.Text,
        //        tbEmail.Text,
        //        tbAddress.Text,
        //        selectedSeats,
        //        busTypeClass,
        //        route,
        //        dateTime,
        //        farePerSeat,
        //        selectedSeats.Split(',').Length,
        //        parentTripForm,
        //        this
        //    );

        //    parentTripForm.LoadFormInMainPanel(confirmForm);
        //}

        //private bool ValidateMainPassenger(out string error)
        //{
        //    //var validator = new PassengerValidationService();

        //    //return validator.ValidateName(tbFName.Text, out error) &&
        //    //       validator.ValidateAge((int)nudAge.Value, out error) &&
        //    //       validator.ValidateContact(tbContactNo.Text, out error) &&
        //    //       validator.ValidateEmail(tbEmail.Text, out error);
            
        //}

        private string GetSelectedGender()
        {
            if (rbFemale.Checked) return "Female";
            if (rbMale.Checked) return "Male";
            return "Prefer not to say";
        }

        private void BookSeatForm_Paint(object sender, PaintEventArgs e) { }
        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e) { }
        private void guna2ShadowPanel2_Paint(object sender, PaintEventArgs e) { }
        private void guna2ShadowPanel3_Paint(object sender, PaintEventArgs e) { }

        private void tbFName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}