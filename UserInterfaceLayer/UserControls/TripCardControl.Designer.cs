namespace UserInterfaceLayer.UserControls
{
    partial class TripCardControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TripCardControl));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            lblBusTypeTrip = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblAvailableSeats = new Label();
            lblTripId = new Label();
            lblOriginn = new Label();
            lblDestinationn = new Label();
            lblDeparture = new Label();
            lblArrival = new Label();
            lblTravelTime = new Label();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            lblFare = new Label();
            btnSelectSeats = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // lblBusTypeTrip
            // 
            lblBusTypeTrip.BackColor = Color.Transparent;
            lblBusTypeTrip.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBusTypeTrip.ForeColor = Color.FromArgb(128, 64, 0);
            lblBusTypeTrip.Location = new Point(28, 32);
            lblBusTypeTrip.Margin = new Padding(3, 2, 3, 2);
            lblBusTypeTrip.Name = "lblBusTypeTrip";
            lblBusTypeTrip.Size = new Size(270, 26);
            lblBusTypeTrip.TabIndex = 0;
            lblBusTypeTrip.Text = "Coach - Terminal A - Terminal C";
            // 
            // lblAvailableSeats
            // 
            lblAvailableSeats.AutoSize = true;
            lblAvailableSeats.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvailableSeats.ForeColor = Color.FromArgb(64, 64, 64);
            lblAvailableSeats.Location = new Point(28, 59);
            lblAvailableSeats.Name = "lblAvailableSeats";
            lblAvailableSeats.Size = new Size(108, 16);
            lblAvailableSeats.TabIndex = 1;
            lblAvailableSeats.Text = "(50) Available Seats";
            // 
            // lblTripId
            // 
            lblTripId.AutoSize = true;
            lblTripId.Font = new Font("Segoe UI Variable Small Semibol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTripId.ForeColor = Color.FromArgb(128, 64, 0);
            lblTripId.Location = new Point(28, 94);
            lblTripId.Name = "lblTripId";
            lblTripId.Size = new Size(73, 19);
            lblTripId.TabIndex = 2;
            lblTripId.Text = "Trip Code";
            // 
            // lblOriginn
            // 
            lblOriginn.AutoSize = true;
            lblOriginn.Font = new Font("Segoe UI Variable Small Semibol", 13.8F, FontStyle.Bold);
            lblOriginn.ForeColor = Color.Black;
            lblOriginn.Location = new Point(263, 64);
            lblOriginn.Name = "lblOriginn";
            lblOriginn.Size = new Size(104, 26);
            lblOriginn.TabIndex = 3;
            lblOriginn.Text = "Terminal A";
            // 
            // lblDestinationn
            // 
            lblDestinationn.AutoSize = true;
            lblDestinationn.Font = new Font("Segoe UI Variable Small Semibol", 13.8F, FontStyle.Bold);
            lblDestinationn.ForeColor = Color.Black;
            lblDestinationn.Location = new Point(536, 64);
            lblDestinationn.Name = "lblDestinationn";
            lblDestinationn.Size = new Size(103, 26);
            lblDestinationn.TabIndex = 4;
            lblDestinationn.Text = "Terminal C";
            // 
            // lblDeparture
            // 
            lblDeparture.AutoSize = true;
            lblDeparture.Font = new Font("Segoe UI Variable Text", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDeparture.ForeColor = Color.FromArgb(64, 64, 64);
            lblDeparture.Location = new Point(276, 91);
            lblDeparture.Name = "lblDeparture";
            lblDeparture.Size = new Size(40, 19);
            lblDeparture.TabIndex = 5;
            lblDeparture.Text = "8:20 ";
            // 
            // lblArrival
            // 
            lblArrival.AutoSize = true;
            lblArrival.Font = new Font("Segoe UI Variable Text", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArrival.ForeColor = Color.FromArgb(64, 64, 64);
            lblArrival.Location = new Point(551, 92);
            lblArrival.Name = "lblArrival";
            lblArrival.Size = new Size(36, 19);
            lblArrival.TabIndex = 6;
            lblArrival.Text = "9:20";
            // 
            // lblTravelTime
            // 
            lblTravelTime.AutoSize = true;
            lblTravelTime.Font = new Font("Segoe UI Variable Text", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTravelTime.ForeColor = Color.FromArgb(64, 64, 64);
            lblTravelTime.Location = new Point(416, 92);
            lblTravelTime.Name = "lblTravelTime";
            lblTravelTime.Size = new Size(71, 19);
            lblTravelTime.TabIndex = 7;
            lblTravelTime.Text = "03:30 min";
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges3;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(441, 69);
            guna2PictureBox1.Margin = new Padding(3, 2, 3, 2);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2PictureBox1.Size = new Size(16, 21);
            guna2PictureBox1.TabIndex = 9;
            guna2PictureBox1.TabStop = false;
            // 
            // lblFare
            // 
            lblFare.AutoSize = true;
            lblFare.Font = new Font("Segoe UI Variable Small Semibol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFare.ForeColor = Color.FromArgb(128, 64, 0);
            lblFare.Location = new Point(772, 39);
            lblFare.Name = "lblFare";
            lblFare.Size = new Size(81, 26);
            lblFare.TabIndex = 10;
            lblFare.Text = "₱150.00";
            // 
            // btnSelectSeats
            // 
            btnSelectSeats.Animated = true;
            btnSelectSeats.BackColor = Color.Transparent;
            btnSelectSeats.BorderColor = Color.FromArgb(50, 255, 255, 255);
            btnSelectSeats.BorderRadius = 15;
            btnSelectSeats.BorderThickness = 1;
            btnSelectSeats.Cursor = Cursors.Hand;
            btnSelectSeats.CustomizableEdges = customizableEdges1;
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
            btnSelectSeats.Location = new Point(724, 74);
            btnSelectSeats.Margin = new Padding(3, 2, 3, 2);
            btnSelectSeats.Name = "btnSelectSeats";
            btnSelectSeats.PressedColor = Color.FromArgb(130, 235, 200, 180);
            btnSelectSeats.PressedDepth = 6;
            btnSelectSeats.ShadowDecoration.BorderRadius = 20;
            btnSelectSeats.ShadowDecoration.Color = Color.FromArgb(30, 0, 0, 0);
            btnSelectSeats.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSelectSeats.ShadowDecoration.Depth = 5;
            btnSelectSeats.ShadowDecoration.Enabled = true;
            btnSelectSeats.Size = new Size(175, 34);
            btnSelectSeats.TabIndex = 10105;
            btnSelectSeats.Text = "Select Seats";
            btnSelectSeats.UseTransparentBackground = true;
            btnSelectSeats.Click += btnSelectSeats_Click;
            // 
            // TripCardControl
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
            Margin = new Padding(18, 15, 18, 15);
            Name = "TripCardControl";
            Size = new Size(926, 148);
            Load += TripCardControl_Load;
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label lblAvailableSeats;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBusTypeTrip;
        private Label lblTripId;
        private Label lblDeparture;
        private Label lblDestinationn;
        private Label lblOriginn;
        private Label lblArrival;
        private Label lblFare;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Label lblTravelTime;
        private Guna.UI2.WinForms.Guna2Button btnSelectSeats;
    }
}
