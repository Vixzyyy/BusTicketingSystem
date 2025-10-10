namespace UserInterfaceLayer.UserControls
{
    partial class TripCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TripCard));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnSelectSeats = new Guna.UI2.WinForms.Guna2Button();
            lblFare = new Label();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            lblTravelTime = new Label();
            lblArrival = new Label();
            lblDeparture = new Label();
            lblDestinationn = new Label();
            lblOriginn = new Label();
            lblTripId = new Label();
            lblAvailableSeats = new Label();
            lblBusTypeTrip = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSelectSeats
            // 
            btnSelectSeats.Animated = true;
            btnSelectSeats.BackColor = Color.Transparent;
            btnSelectSeats.BorderColor = Color.FromArgb(50, 255, 255, 255);
            btnSelectSeats.BorderRadius = 15;
            btnSelectSeats.BorderThickness = 1;
            btnSelectSeats.Cursor = Cursors.Hand;
            btnSelectSeats.CustomizableEdges = customizableEdges5;
            btnSelectSeats.DisabledState.BorderColor = Color.DarkGray;
            btnSelectSeats.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSelectSeats.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSelectSeats.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSelectSeats.FillColor = Color.FromArgb(255, 192, 128);
            btnSelectSeats.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelectSeats.ForeColor = Color.White;
            btnSelectSeats.HoverState.FillColor = Color.FromArgb(110, 255, 235, 220);
            btnSelectSeats.HoverState.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSelectSeats.HoverState.ForeColor = Color.White;
            btnSelectSeats.ImageAlign = HorizontalAlignment.Left;
            btnSelectSeats.ImageSize = new Size(35, 35);
            btnSelectSeats.IndicateFocus = true;
            btnSelectSeats.Location = new Point(724, 76);
            btnSelectSeats.Margin = new Padding(3, 2, 3, 2);
            btnSelectSeats.Name = "btnSelectSeats";
            btnSelectSeats.PressedColor = Color.FromArgb(130, 235, 200, 180);
            btnSelectSeats.PressedDepth = 6;
            btnSelectSeats.ShadowDecoration.BorderRadius = 20;
            btnSelectSeats.ShadowDecoration.Color = Color.FromArgb(30, 0, 0, 0);
            btnSelectSeats.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSelectSeats.ShadowDecoration.Depth = 5;
            btnSelectSeats.ShadowDecoration.Enabled = true;
            btnSelectSeats.Size = new Size(175, 34);
            btnSelectSeats.TabIndex = 10116;
            btnSelectSeats.Text = "Select Seats";
            btnSelectSeats.UseTransparentBackground = true;
            // 
            // lblFare
            // 
            lblFare.AutoSize = true;
            lblFare.Font = new Font("Segoe UI Variable Small Semibol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFare.ForeColor = Color.FromArgb(128, 64, 0);
            lblFare.Location = new Point(772, 51);
            lblFare.Name = "lblFare";
            lblFare.Size = new Size(81, 26);
            lblFare.TabIndex = 10115;
            lblFare.Text = "₱150.00";
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges7;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(440, 69);
            guna2PictureBox1.Margin = new Padding(3, 2, 3, 2);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2PictureBox1.Size = new Size(16, 21);
            guna2PictureBox1.TabIndex = 10114;
            guna2PictureBox1.TabStop = false;
            // 
            // lblTravelTime
            // 
            lblTravelTime.AutoSize = true;
            lblTravelTime.Font = new Font("Segoe UI Variable Text", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTravelTime.ForeColor = Color.FromArgb(64, 64, 64);
            lblTravelTime.Location = new Point(416, 89);
            lblTravelTime.Name = "lblTravelTime";
            lblTravelTime.Size = new Size(71, 19);
            lblTravelTime.TabIndex = 10113;
            lblTravelTime.Text = "03:30 min";
            // 
            // lblArrival
            // 
            lblArrival.AutoSize = true;
            lblArrival.Font = new Font("Segoe UI Variable Text", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArrival.ForeColor = Color.FromArgb(64, 64, 64);
            lblArrival.Location = new Point(545, 89);
            lblArrival.Name = "lblArrival";
            lblArrival.Size = new Size(36, 19);
            lblArrival.TabIndex = 10112;
            lblArrival.Text = "9:20";
            // 
            // lblDeparture
            // 
            lblDeparture.AutoSize = true;
            lblDeparture.Font = new Font("Segoe UI Variable Text", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDeparture.ForeColor = Color.FromArgb(64, 64, 64);
            lblDeparture.Location = new Point(275, 89);
            lblDeparture.Name = "lblDeparture";
            lblDeparture.Size = new Size(40, 19);
            lblDeparture.TabIndex = 10111;
            lblDeparture.Text = "8:20 ";
            // 
            // lblDestinationn
            // 
            lblDestinationn.AutoSize = true;
            lblDestinationn.Font = new Font("Segoe UI Variable Small Semibol", 13.8F, FontStyle.Bold);
            lblDestinationn.ForeColor = Color.Black;
            lblDestinationn.Location = new Point(536, 66);
            lblDestinationn.Name = "lblDestinationn";
            lblDestinationn.Size = new Size(103, 26);
            lblDestinationn.TabIndex = 10110;
            lblDestinationn.Text = "Terminal C";
            // 
            // lblOriginn
            // 
            lblOriginn.AutoSize = true;
            lblOriginn.Font = new Font("Segoe UI Variable Small Semibol", 13.8F, FontStyle.Bold);
            lblOriginn.ForeColor = Color.Black;
            lblOriginn.Location = new Point(263, 66);
            lblOriginn.Name = "lblOriginn";
            lblOriginn.Size = new Size(104, 26);
            lblOriginn.TabIndex = 10109;
            lblOriginn.Text = "Terminal A";
            // 
            // lblTripId
            // 
            lblTripId.AutoSize = true;
            lblTripId.Font = new Font("Segoe UI Variable Small Semibol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTripId.ForeColor = Color.FromArgb(128, 64, 0);
            lblTripId.Location = new Point(28, 96);
            lblTripId.Name = "lblTripId";
            lblTripId.Size = new Size(73, 19);
            lblTripId.TabIndex = 10108;
            lblTripId.Text = "Trip Code";
            // 
            // lblAvailableSeats
            // 
            lblAvailableSeats.AutoSize = true;
            lblAvailableSeats.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvailableSeats.ForeColor = Color.FromArgb(64, 64, 64);
            lblAvailableSeats.Location = new Point(28, 61);
            lblAvailableSeats.Name = "lblAvailableSeats";
            lblAvailableSeats.Size = new Size(108, 16);
            lblAvailableSeats.TabIndex = 10107;
            lblAvailableSeats.Text = "(50) Available Seats";
            // 
            // lblBusTypeTrip
            // 
            lblBusTypeTrip.BackColor = Color.Transparent;
            lblBusTypeTrip.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBusTypeTrip.ForeColor = Color.FromArgb(128, 64, 0);
            lblBusTypeTrip.Location = new Point(28, 34);
            lblBusTypeTrip.Margin = new Padding(3, 2, 3, 2);
            lblBusTypeTrip.Name = "lblBusTypeTrip";
            lblBusTypeTrip.Size = new Size(270, 26);
            lblBusTypeTrip.TabIndex = 10106;
            lblBusTypeTrip.Text = "Coach - Terminal A - Terminal C";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // TripCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 231, 207);
            Controls.Add(btnSelectSeats);
            Controls.Add(lblFare);
            Controls.Add(guna2PictureBox1);
            Controls.Add(lblTravelTime);
            Controls.Add(lblArrival);
            Controls.Add(lblDeparture);
            Controls.Add(lblDestinationn);
            Controls.Add(lblOriginn);
            Controls.Add(lblTripId);
            Controls.Add(lblAvailableSeats);
            Controls.Add(lblBusTypeTrip);
            Name = "TripCard";
            Size = new Size(926, 148);
            Load += TripCard_Load;
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSelectSeats;
        private Label lblFare;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Label lblTravelTime;
        private Label lblArrival;
        private Label lblDeparture;
        private Label lblDestinationn;
        private Label lblOriginn;
        private Label lblTripId;
        private Label lblAvailableSeats;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBusTypeTrip;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
