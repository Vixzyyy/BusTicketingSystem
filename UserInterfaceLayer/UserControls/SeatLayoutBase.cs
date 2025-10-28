using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace UserInterfaceLayer.KioskApplication.Forms
{
    public class SeatLayoutBase : UserControl
    {
        protected List<Guna2Button> selectedSeats = new List<Guna2Button>();
        protected Label lblSelectedSeats;
        protected Label lblTotalAmount;
        protected Label lblFareSeat;
        protected decimal farePerSeat = 0; // will be passed from SeatForm

        public SeatLayoutBase()
        {
            this.Load += (s, e) => AttachSeatClickEvents(this);
        }

        private void AttachSeatClickEvents(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is Guna2Button btn)
                {
                    // Default (available)
                    btn.FillColor = Color.White;
                    btn.ForeColor = Color.FromArgb(237, 164, 80);

                    // Hover effect
                    btn.HoverState.FillColor = Color.FromArgb(255, 245, 210); // peach
                    btn.HoverState.ForeColor = btn.ForeColor; // keep same font color

                    btn.Click += Seat_Click;
                }

                if (ctrl.HasChildren)
                    AttachSeatClickEvents(ctrl);
            }
        }

        private void Seat_Click(object sender, EventArgs e)
        {
            var btn = sender as Guna2Button;
            if (btn == null) return;

            if (btn.FillColor == Color.Red) return;

            // Toggle selection
            if (btn.FillColor == Color.FromArgb(237, 164, 80) && btn.ForeColor == Color.White)
            {
                // Deselected → white bg, orange font
                btn.FillColor = Color.White;
                btn.ForeColor = Color.FromArgb(237, 164, 80);
            }
            else
            {
                // Selected → orange bg, white font
                btn.FillColor = Color.FromArgb(237, 164, 80);
                btn.ForeColor = Color.White;
            }

            UpdateSummary();
        }

        public void MarkSeatAsTaken(Guna2Button btn)
        {
            btn.FillColor = Color.Red;
            btn.ForeColor = Color.White;
            btn.Enabled = false;
        }

        ToolTip tt = new ToolTip();
        protected void UpdateSummary()
        {
            if (lblSelectedSeats != null)
            {
                lblSelectedSeats.Text = selectedSeats.Count > 0
                    ? string.Join(", ", selectedSeats.Select(s => s.Text))
                    : "None";

                lblSelectedSeats.Text = lblSelectedSeats.Text;
                tt.SetToolTip(lblSelectedSeats, lblSelectedSeats.Text);
            }

            if (lblFareSeat != null)
            {
                lblFareSeat.Text = "₱" + farePerSeat.ToString("N2");
            }

            if (lblTotalAmount != null)
            {
                lblTotalAmount.Text = "₱" + (selectedSeats.Count * farePerSeat).ToString("N2");
            }
        }

        public void SetSummaryLabels(Label lblSeats, Label lblAmount, Label lblFare, decimal fare)
        {
            lblSelectedSeats = lblSeats;
            lblTotalAmount = lblAmount;
            lblFareSeat = lblFare;
            farePerSeat = fare;

            UpdateSummary();
        }
    }
}

