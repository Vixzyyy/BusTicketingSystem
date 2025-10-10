using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterfaceLayer.KioskApplication.Forms;

namespace UserInterfaceLayer.UserControls
{
    public partial class TripCard : UserControl
    {
        public TripCard()
        {
            InitializeComponent();
        }

        // === Event to handle Select Seats button ===
        public event EventHandler SelectSeatsClicked;

        private void btnSelectSeats_Click(object sender, EventArgs e)
        {
            SelectSeatsClicked?.Invoke(this, EventArgs.Empty);
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string TripInfo
        {
            get => lblTripId.Text;
            set => lblTripId.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string BusTypeTrip
        {
            get => lblBusTypeTrip.Text;
            set => lblBusTypeTrip.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string AvailableSeats
        {
            get => lblAvailableSeats.Text;
            set => lblAvailableSeats.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Origin
        {
            get => lblOriginn.Text;
            set => lblOriginn.Text = value;
        }
        
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Destination
        {
            get => lblDestinationn.Text;
            set => lblDestinationn.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Departure
        {
            get => lblDeparture.Text;
            set => lblDeparture.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Arrival
        {
            get => lblArrival.Text;
            set => lblArrival.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Price
        {
            get => lblFare.Text;
            set => lblFare.Text = value;
        }



        private void TripCard_Load(object sender, EventArgs e)
        {

        }
    }
}
