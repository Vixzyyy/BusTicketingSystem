using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace UserInterfaceLayer.UserControls
{
    public partial class TripCardControl : UserControl
    {
        public TripCardControl()
        {
            InitializeComponent();
        }

        private void TripCardControl_Load(object sender, EventArgs e) { }

        // === Event to handle Select Seats button ===
        public event EventHandler? SelectSeatsClicked;

        private void btnSelectSeats_Click(object sender, EventArgs e)
        {
            SelectSeatsClicked?.Invoke(this, EventArgs.Empty);
        }

        // === Exposed Properties with Designer support ===
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Category("Trip Data")]
        [Description("Bus type")]
        public string BusTypeTrip
        {
            get => lblBusTypeTrip.Text;
            set => lblBusTypeTrip.Text = value;
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Category("Trip Data")]
        [Description("Seat layout")]
        public string AvailableSeats
        {
            get => lblAvailableSeats.Text;
            set => lblAvailableSeats.Text = value;
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Category("Trip Data")]
        public string TripCode
        {
            get => lblTripId.Text;
            set => lblTripId.Text = value;
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Category("Trip Data")]
        public string Departure
        {
            get => lblDeparture.Text;
            set => lblDeparture.Text = value;
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Category("Trip Data")]
        public string Arrival
        {
            get => lblArrival.Text;
            set => lblArrival.Text = value;
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Category("Trip Data")]
        public string Origin
        {
            get => lblOriginn.Text;
            set => lblOriginn.Text = value;
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Category("Trip Data")]
        public string Destination
        {
            get => lblDestinationn.Text;
            set => lblDestinationn.Text = value;
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Category("Trip Data")]
        public string TravelTime
        {
            get => lblTravelTime.Text;
            set => lblTravelTime.Text = value;
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Category("Trip Data")]
        public string Fare
        {
            get => lblFare.Text;
            set => lblFare.Text = value;
        }
    }
}
