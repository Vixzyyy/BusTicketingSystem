namespace UserInterfaceLayer.KioskApplication.Forms
{
    partial class LandingForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            elipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            lblDateTime = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            label5 = new Label();
            btnCheckID = new Guna.UI2.WinForms.Guna2Button();
            btnBuyTicket = new Guna.UI2.WinForms.Guna2Button();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // elipse
            // 
            elipse.BorderRadius = 50;
            elipse.TargetControl = this;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.BackColor = Color.Transparent;
            guna2GradientPanel1.Controls.Add(lblDateTime);
            guna2GradientPanel1.Controls.Add(label1);
            guna2GradientPanel1.Controls.Add(pictureBox1);
            guna2GradientPanel1.Controls.Add(panel1);
            guna2GradientPanel1.CustomizableEdges = customizableEdges5;
            guna2GradientPanel1.FillColor = Color.FromArgb(255, 192, 128);
            guna2GradientPanel1.FillColor2 = Color.White;
            guna2GradientPanel1.Location = new Point(0, 0);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2GradientPanel1.Size = new Size(1269, 741);
            guna2GradientPanel1.TabIndex = 1;
            guna2GradientPanel1.UseTransparentBackground = true;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Cursor = Cursors.Hand;
            lblDateTime.Font = new Font("Segoe UI Variable Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateTime.ForeColor = Color.FromArgb(255, 192, 128);
            lblDateTime.Location = new Point(956, 18);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(14, 21);
            lblDateTime.TabIndex = 3;
            lblDateTime.Text = ".";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI Variable Display", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 706);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 2;
            label1.Text = "Staff Log-In";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnCheckID);
            panel1.Controls.Add(btnBuyTicket);
            panel1.Controls.Add(guna2Separator1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.FillColor = Color.Linen;
            panel1.Location = new Point(114, 46);
            panel1.Name = "panel1";
            panel1.Radius = 15;
            panel1.ShadowColor = Color.Black;
            panel1.ShadowDepth = 200;
            panel1.Size = new Size(1144, 685);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(128, 64, 0);
            label5.Location = new Point(312, 508);
            label5.Name = "label5";
            label5.Size = new Size(515, 60);
            label5.TabIndex = 7;
            label5.Text = resources.GetString("label5.Text");
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCheckID
            // 
            btnCheckID.BorderRadius = 20;
            btnCheckID.Cursor = Cursors.Hand;
            btnCheckID.CustomizableEdges = customizableEdges1;
            btnCheckID.DisabledState.BorderColor = Color.DarkGray;
            btnCheckID.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCheckID.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCheckID.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCheckID.FillColor = Color.FromArgb(255, 192, 128);
            btnCheckID.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheckID.ForeColor = Color.White;
            btnCheckID.HoverState.FillColor = Color.FromArgb(230, 150, 90);
            btnCheckID.HoverState.Font = new Font("Segoe UI Variable Display Semib", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckID.HoverState.ForeColor = Color.FromArgb(255, 240, 230);
            btnCheckID.Location = new Point(597, 416);
            btnCheckID.Name = "btnCheckID";
            btnCheckID.PressedColor = Color.FromArgb(200, 120, 60);
            btnCheckID.ShadowDecoration.BorderRadius = 50;
            btnCheckID.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCheckID.Size = new Size(313, 72);
            btnCheckID.TabIndex = 5;
            btnCheckID.Text = "Check Reservation";
            btnCheckID.Click += btnCheckID_Click;
            // 
            // btnBuyTicket
            // 
            btnBuyTicket.BorderRadius = 20;
            btnBuyTicket.Cursor = Cursors.Hand;
            btnBuyTicket.CustomizableEdges = customizableEdges3;
            btnBuyTicket.DisabledState.BorderColor = Color.DarkGray;
            btnBuyTicket.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBuyTicket.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBuyTicket.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBuyTicket.FillColor = Color.FromArgb(255, 192, 128);
            btnBuyTicket.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuyTicket.ForeColor = Color.White;
            btnBuyTicket.HoverState.FillColor = Color.FromArgb(230, 150, 90);
            btnBuyTicket.HoverState.Font = new Font("Segoe UI Variable Display Semib", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuyTicket.HoverState.ForeColor = Color.FromArgb(255, 240, 230);
            btnBuyTicket.Location = new Point(242, 416);
            btnBuyTicket.Name = "btnBuyTicket";
            btnBuyTicket.PressedColor = Color.FromArgb(200, 120, 60);
            btnBuyTicket.ShadowDecoration.BorderRadius = 50;
            btnBuyTicket.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnBuyTicket.Size = new Size(313, 72);
            btnBuyTicket.TabIndex = 4;
            btnBuyTicket.Text = "Reserve Trip";
            btnBuyTicket.Click += btnBuyTicket_Click;
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillColor = Color.FromArgb(255, 192, 128);
            guna2Separator1.FillThickness = 3;
            guna2Separator1.Location = new Point(144, 264);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(444, 9);
            guna2Separator1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(128, 64, 0);
            label4.Location = new Point(135, 276);
            label4.Name = "label4";
            label4.Size = new Size(475, 43);
            label4.TabIndex = 2;
            label4.Text = "One Ride, Like No Other";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(128, 64, 0);
            label3.Location = new Point(362, 132);
            label3.Name = "label3";
            label3.Size = new Size(488, 116);
            label3.TabIndex = 1;
            label3.Text = "EXPRESS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 75F);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(122, 138);
            label2.Name = "label2";
            label2.Size = new Size(248, 119);
            label2.TabIndex = 0;
            label2.Text = "UNO";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // LandingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1262, 739);
            Controls.Add(guna2GradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LandingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LandingForm";
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elipse;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnBuyTicket;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button btnCheckID;
        private System.Windows.Forms.Label label5;
        private Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
    }
}