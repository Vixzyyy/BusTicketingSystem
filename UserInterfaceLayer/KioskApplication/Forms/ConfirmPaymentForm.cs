using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;
using System.Drawing.Printing;


namespace UserInterfaceLayer.KioskApplication.Forms
{
    public partial class ConfirmPaymentForm : Form
    {
        private string passengerName;
        private int passengerAge;
        private string passengerGender;
        private string passengerContact;
        private string passengerEmail;
        private string passengerAddress;

        private string seats;
        private string busTypeClass;
        private string route;
        private string tripDateTime;
        private decimal farePerSeat;
        private int noOfSeats;
        private SelectTripForm parentTripForm;
        private PassengerDetailsForm previousPassengerForm;
        private Panel pnlPassInfo;

        public ConfirmPaymentForm(string mainName, int age, string gender, string contact,
                          string email, string address,
                          string seats, string busTypeClass, string route, string dateTime,
                          decimal farePerSeat, int noOfSeats,
                          SelectTripForm parentTripForm, PassengerDetailsForm previousPassengerForm)
        {
            InitializeComponent();
            this.parentTripForm = parentTripForm;
            this.previousPassengerForm = previousPassengerForm;

            passengerName = mainName;
            passengerAge = age;
            passengerGender = gender;
            passengerContact = contact;
            passengerEmail = email;
            passengerAddress = address;

            this.seats = seats;
            this.busTypeClass = busTypeClass;
            this.route = route;
            this.tripDateTime = dateTime;
            this.farePerSeat = farePerSeat;
            this.noOfSeats = noOfSeats;

            lblFName.Text = mainName;
            lblAge.Text = age.ToString();
            lblGender.Text = gender;
            lblContactNo.Text = contact;
            lblEmail.Text = email;
            lblAddress.Text = address;

            lblSeats.Text = seats;
            lblTypeClass.Text = busTypeClass;
            lblRoute.Text = route;
            lblDateTime.Text = dateTime;

            lblFareSeat.Text = $"₱{farePerSeat:N2}";
            lblSeatCount.Text = noOfSeats.ToString();

            lblSeats.MaximumSize = new Size(guna2ShadowPanel1.Width - lblSeats.Location.X - 20, 0);
            lblSeats.AutoEllipsis = true;
            lblSeats.TextAlign = ContentAlignment.MiddleLeft;
            lblSeats.AutoSize = true;
            ToolTip seatTooltip = new ToolTip();
            seatTooltip.SetToolTip(lblSeats, lblSeats.Text);

            pnlPassInfo = new Panel
            {
                Name = "pnlPassInfo",
                Location = new Point(26, 188),
                Size = new Size(617, 95),
                AutoScroll = false,
                BackColor = Color.White,
                BorderStyle = BorderStyle.None
            };

            var otherPassengers = previousPassengerForm.Controls
                .Find("pnlOtherPassengers", true)
                .FirstOrDefault() as Panel;

            if (otherPassengers != null)
            {
                int y = 10;

                var passengerTextBoxes = otherPassengers.Controls
                    .OfType<Guna.UI2.WinForms.Guna2TextBox>()
                    .Where(tb => tb.Name.StartsWith("tb_"))
                    .ToList();

                foreach (var txtName in passengerTextBoxes)
                {
                    if (!string.IsNullOrWhiteSpace(txtName.Text))
                    {
                        string seatNumber = txtName.Name.Replace("tb_", "");

                        var cbType = otherPassengers.Controls
                            .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                            .FirstOrDefault(cb => cb.Name == $"cb_{seatNumber}");

                        string passengerFullName = txtName.Text.Trim();
                        string passType = cbType?.SelectedItem?.ToString() ?? "Regular";

                        Label lblPassLine = new Label
                        {
                            Text = $"[ {seatNumber} ] - {passengerFullName}",
                            Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                            ForeColor = Color.FromArgb(60, 40, 20),
                            Location = new Point(15, y),
                            AutoSize = false,
                            Width = 340,
                            TextAlign = ContentAlignment.MiddleLeft
                        };

                        Label lblPassType = new Label
                        {
                            Text = passType,
                            Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                            ForeColor = Color.FromArgb(60, 40, 20),
                            Location = new Point(360, y),
                            AutoSize = false,
                            Width = 250,
                            TextAlign = ContentAlignment.MiddleLeft
                        };

                        pnlPassInfo.Controls.Add(lblPassLine);
                        pnlPassInfo.Controls.Add(lblPassType);
                        y += 25;
                    }
                }
            }

            if (pnlPassInfo.Controls.Count == 0)
            {
                Label lblNoPassengers = new Label
                {
                    Text = "No additional passenger information",
                    Font = new Font("Segoe UI", 9F, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    Location = new Point(15, 35),
                    AutoSize = true
                };
                pnlPassInfo.Controls.Add(lblNoPassengers);
            }
            else
            {
                int totalContentHeight = pnlPassInfo.Controls.Count > 0
                    ? pnlPassInfo.Controls.Cast<Control>().Max(c => c.Bottom)
                    : 0;

                if (totalContentHeight > pnlPassInfo.Height)
                {
                    pnlPassInfo.AutoScroll = true;
                    pnlPassInfo.HorizontalScroll.Enabled = false;
                    pnlPassInfo.HorizontalScroll.Visible = false;
                }
            }

            guna2ShadowPanel2.Controls.Add(pnlPassInfo);
            pnlPassInfo.BringToFront();
            pnlPassInfo.Visible = true;

            UpdateFare();
        }

        private void UpdateFare()
        {
            decimal totalFare = 0;
            decimal totalDiscount = 0;
            int discountedCount = 0;

            var otherPassengers = previousPassengerForm.Controls
                .Find("pnlOtherPassengers", true)
                .FirstOrDefault() as Panel;

            if (otherPassengers != null)
            {
                foreach (Control c in otherPassengers.Controls)
                {
                    if (c is Guna.UI2.WinForms.Guna2ComboBox cb)
                    {
                        string passType = cb.SelectedItem?.ToString() ?? "Regular";

                        decimal fare = farePerSeat;

                        if (passType == "Senior Citizen" || passType == "Student" || passType == "PWD")
                        {
                            decimal discountAmount = fare * 0.20m;
                            fare -= discountAmount;
                            totalDiscount += discountAmount;
                            discountedCount++;
                        }

                        totalFare += fare;
                    }
                }
            }
            if (discountedCount > 0)
            {
                lblDiscountedFare.Text = $"({discountedCount}) - ₱{totalDiscount:N2}";
            }
            else
            {
                lblDiscountedFare.Text = "₱0.00";
            }

            lblSeatCount.Text = noOfSeats.ToString();
            lblTotalAmount.Text = $"₱{totalFare:N2}";
        }

        private void BookSeatForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSeats_Click(object sender, EventArgs e)
        {

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                $"Confirm payment of {lblTotalAmount.Text}?\n\nSeats: {seats}\nRoute: {route}",
                "Confirm Payment",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            MessageBox.Show("Payment confirmed! Ticket issued.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            LandingForm landing = new LandingForm();
            landing.Show();

            KioskBaseForm kioskParent = this.ParentForm as KioskBaseForm;
            if (kioskParent != null) kioskParent.Close();
            else this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (parentTripForm != null && previousPassengerForm != null)
            {
                parentTripForm.LoadFormInMainPanel(previousPassengerForm);
            }
        }
    }
}