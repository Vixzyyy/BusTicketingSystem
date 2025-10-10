using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using UserInterfaceLayer.KioskApplication.Forms;
using UserInterfaceLayer.StaffApplication.AdminForms;

namespace UserInterfaceLayer.StaffApplication.Forms
{
    public partial class BaseDashboardForm : Form
    {
        private const int CollapsedButtonWidth = 65;
        private const int ExpandedButtonWidth = 167;
        private const int CollapsedButtonX = 52;
        private const int ExpandedButtonX = 3;
        private const int ButtonHeight = 56;
        private Guna2Button selectedButton = null;

        public BaseDashboardForm()
        {
            InitializeComponent();

            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += SidebarTimer_Tick;

            btnDashboard.Click += btn_Click;
            btnTickets.Click += btn_Click;
            btnTrips.Click += btn_Click;
            btnPassengers.Click += btn_Click;
            btnReservations.Click += btn_Click;
            btnPayments.Click += btn_Click;
            btnReports.Click += btn_Click;
            btnBusDriver.Click += btn_Click;
            btnStaff.Click += btn_Click;

            InitializeButtonsAppearance();

            OpenChildForm(new DashboardForm());
            SelectButton(btnDashboard);
        }

        private void InitializeButtonsAppearance()
        {
            foreach (Control c in guna2Panel1.Controls)
            {
                if (c is Guna2Button btn)
                { 
                    if (btn.Tag == null || !(btn.Tag is string))
                    {
                        btn.Tag = btn.Text;
                    }

                    btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                    btn.Checked = false;

                    btn.Location = new Point(CollapsedButtonX, btn.Location.Y);
                    btn.Width = CollapsedButtonWidth;
                    btn.Height = ButtonHeight;
                    btn.FillColor = Color.Transparent;
                    btn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    btn.ForeColor = Color.White;
                    btn.TextAlign = HorizontalAlignment.Left;
                    btn.ImageAlign = HorizontalAlignment.Left;
                    btn.ImageOffset = new Point(8, 0);
                    btn.TextOffset = new Point(5, 0);
                    btn.BorderRadius = 15;

                    btn.CheckedState.FillColor = Color.White;
                    btn.CheckedState.ForeColor = Color.FromArgb(128, 64, 0);

                    btn.Text = "";
                }
            }
        }

        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            bool allAnimationsDone = true;

            foreach (Control c in guna2Panel1.Controls)
            {
                if (c is Guna2Button btn)
                {
                    bool isSelected = (btn == selectedButton);
                    int targetWidth = isSelected ? ExpandedButtonWidth : CollapsedButtonWidth;
                    int targetX = isSelected ? ExpandedButtonX : CollapsedButtonX;

                    if (btn.Width != targetWidth)
                    {
                        allAnimationsDone = false;

                        if (isSelected)
                        {
                            btn.Width += 15;
                            if (btn.Width >= targetWidth)
                            {
                                btn.Width = targetWidth;
                            }
                        }
                        else
                        {
                            btn.Width -= 15;
                            if (btn.Width <= targetWidth)
                            {
                                btn.Width = targetWidth;
                            }
                        }
                    }

                    if (btn.Location.X != targetX)
                    {
                        btn.Location = new Point(targetX, btn.Location.Y);
                    }
                }
            }

            if (allAnimationsDone)
            {
                sidebarTimer.Stop();
            }
        }

        private void SelectButton(Guna2Button btn)
        {
            if (selectedButton != null && selectedButton != btn)
            {
                selectedButton.Checked = false;
                selectedButton.Text = "";
            }

            selectedButton = btn;
            selectedButton.Checked = true;

            if (selectedButton.Tag is string text)
            {
                selectedButton.Text = text;
            }

            sidebarTimer.Start();
        }

        private void OpenChildForm(Form childForm)
        {
            mainPanel.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(childForm);
            childForm.Show();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            var clickedBtn = (Guna2Button)sender;
            SelectButton(clickedBtn);

            if (clickedBtn == btnDashboard)
                OpenChildForm(new DashboardForm());
            else if (clickedBtn == btnTickets)
                OpenChildForm(new TicketsForm());
            else if (clickedBtn == btnTrips)
                OpenChildForm(new TripsForm());
            else if (clickedBtn == btnPassengers)
                OpenChildForm(new PassengersForm());
            else if (clickedBtn == btnReservations)
                OpenChildForm(new ReservationsForm());
            else if (clickedBtn == btnPayments)
                OpenChildForm(new PaymentsForm());
            else if (clickedBtn == btnReports)
                OpenChildForm(new ReportsForm());
            else if (clickedBtn == btnBusDriver)
                OpenChildForm(new BusnDriverForm());
            else if (clickedBtn == btnStaff)
                OpenChildForm(new UserStaffForm());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DashboardForm());
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TicketsForm());
        }

        private void btnTrips_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TripsForm());
        }

        private void btnPassengers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PassengersForm());
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReservationsForm());
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PaymentsForm());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReportsForm());
        }

        private void btnBusDriver_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BusnDriverForm());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserStaffForm());
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e) { }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e) { }
        private void lblDateTime_Click(object sender, EventArgs e) { }
        private void mainPanel_Paint(object sender, PaintEventArgs e) { }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            StaffLoginForm staffLogin = new StaffLoginForm();
            if (result == DialogResult.Yes)
            {
                staffLogin.Show();
                this.Hide();
            }
        }
    }
}