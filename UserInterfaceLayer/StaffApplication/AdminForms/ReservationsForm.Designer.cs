namespace UserInterfaceLayer.StaffApplication.Forms
{
    partial class ReservationsForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            btnEdit = new Guna.UI2.WinForms.Guna2Button();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            dgvReservations = new Guna.UI2.WinForms.Guna2DataGridView();
            dgvDepartureTime = new DataGridViewTextBoxColumn();
            dgvRoute = new DataGridViewTextBoxColumn();
            dgvDriver = new DataGridViewTextBoxColumn();
            dgvBusPlate = new DataGridViewTextBoxColumn();
            dgvSeatAvail = new DataGridViewTextBoxColumn();
            dgvStatus = new DataGridViewTextBoxColumn();
            label2 = new Label();
            tbSearch = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 50;
            guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 29F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(43, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(484, 57);
            label1.TabIndex = 5;
            label1.Text = "Reservation's List";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnCancel);
            panel1.Location = new Point(967, 92);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 253);
            panel1.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Maiandra GD", 11F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(128, 64, 0);
            label3.Location = new Point(62, 35);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(139, 22);
            label3.TabIndex = 6;
            label3.Text = "Quick Actions";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEdit
            // 
            btnEdit.Animated = true;
            btnEdit.BackColor = Color.Transparent;
            btnEdit.BorderColor = Color.FromArgb(255, 192, 128);
            btnEdit.BorderRadius = 15;
            btnEdit.BorderThickness = 1;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.CustomizableEdges = customizableEdges1;
            btnEdit.DisabledState.BorderColor = Color.DarkGray;
            btnEdit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEdit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEdit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEdit.FillColor = Color.White;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.FromArgb(255, 192, 128);
            btnEdit.HoverState.FillColor = Color.FromArgb(110, 255, 235, 220);
            btnEdit.HoverState.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEdit.HoverState.ForeColor = Color.White;
            btnEdit.ImageAlign = HorizontalAlignment.Left;
            btnEdit.ImageSize = new Size(35, 35);
            btnEdit.IndicateFocus = true;
            btnEdit.Location = new Point(27, 124);
            btnEdit.Name = "btnEdit";
            btnEdit.PressedColor = Color.FromArgb(130, 235, 200, 180);
            btnEdit.PressedDepth = 6;
            btnEdit.ShadowDecoration.BorderRadius = 20;
            btnEdit.ShadowDecoration.Color = Color.FromArgb(30, 0, 0, 0);
            btnEdit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnEdit.ShadowDecoration.Depth = 5;
            btnEdit.ShadowDecoration.Enabled = true;
            btnEdit.Size = new Size(200, 46);
            btnEdit.TabIndex = 10115;
            btnEdit.Text = "Edit Reservation";
            btnEdit.UseTransparentBackground = true;
            // 
            // btnAdd
            // 
            btnAdd.Animated = true;
            btnAdd.BackColor = Color.Transparent;
            btnAdd.BorderColor = Color.FromArgb(255, 192, 128);
            btnAdd.BorderRadius = 15;
            btnAdd.BorderThickness = 1;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.CustomizableEdges = customizableEdges3;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = Color.White;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.FromArgb(255, 192, 128);
            btnAdd.HoverState.FillColor = Color.FromArgb(110, 255, 235, 220);
            btnAdd.HoverState.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdd.HoverState.ForeColor = Color.White;
            btnAdd.ImageAlign = HorizontalAlignment.Left;
            btnAdd.ImageSize = new Size(35, 35);
            btnAdd.IndicateFocus = true;
            btnAdd.Location = new Point(27, 72);
            btnAdd.Name = "btnAdd";
            btnAdd.PressedColor = Color.FromArgb(130, 235, 200, 180);
            btnAdd.PressedDepth = 6;
            btnAdd.ShadowDecoration.BorderRadius = 20;
            btnAdd.ShadowDecoration.Color = Color.FromArgb(30, 0, 0, 0);
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAdd.ShadowDecoration.Depth = 5;
            btnAdd.ShadowDecoration.Enabled = true;
            btnAdd.Size = new Size(200, 46);
            btnAdd.TabIndex = 10114;
            btnAdd.Text = "Add Reservation";
            btnAdd.UseTransparentBackground = true;
            // 
            // btnCancel
            // 
            btnCancel.Animated = true;
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BorderColor = Color.FromArgb(255, 192, 128);
            btnCancel.BorderRadius = 15;
            btnCancel.BorderThickness = 1;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.CustomizableEdges = customizableEdges5;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.White;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(255, 192, 128);
            btnCancel.HoverState.FillColor = Color.FromArgb(110, 255, 235, 220);
            btnCancel.HoverState.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancel.HoverState.ForeColor = Color.White;
            btnCancel.ImageAlign = HorizontalAlignment.Left;
            btnCancel.ImageSize = new Size(35, 35);
            btnCancel.IndicateFocus = true;
            btnCancel.Location = new Point(27, 176);
            btnCancel.Name = "btnCancel";
            btnCancel.PressedColor = Color.FromArgb(130, 235, 200, 180);
            btnCancel.PressedDepth = 6;
            btnCancel.ShadowDecoration.BorderRadius = 20;
            btnCancel.ShadowDecoration.Color = Color.FromArgb(30, 0, 0, 0);
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnCancel.ShadowDecoration.Depth = 5;
            btnCancel.ShadowDecoration.Enabled = true;
            btnCancel.Size = new Size(200, 46);
            btnCancel.TabIndex = 10113;
            btnCancel.Text = "Delete Reservation";
            btnCancel.UseTransparentBackground = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Linen;
            panel2.Controls.Add(dgvReservations);
            panel2.Location = new Point(15, 92);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(944, 805);
            panel2.TabIndex = 9;
            // 
            // dgvReservations
            // 
            dgvReservations.AllowUserToAddRows = false;
            dgvReservations.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvReservations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvReservations.BackgroundColor = Color.SeaShell;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReservations.ColumnHeadersHeight = 29;
            dgvReservations.Columns.AddRange(new DataGridViewColumn[] { dgvDepartureTime, dgvRoute, dgvDriver, dgvBusPlate, dgvSeatAvail, dgvStatus });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvReservations.DefaultCellStyle = dataGridViewCellStyle3;
            dgvReservations.EnableHeadersVisualStyles = true;
            dgvReservations.GridColor = Color.PeachPuff;
            dgvReservations.Location = new Point(3, 3);
            dgvReservations.Name = "dgvReservations";
            dgvReservations.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.AntiqueWhite;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle4.SelectionBackColor = Color.PeachPuff;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvReservations.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvReservations.RowHeadersVisible = false;
            dgvReservations.RowHeadersWidth = 51;
            dgvReservations.Size = new Size(938, 799);
            dgvReservations.TabIndex = 10117;
            dgvReservations.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvReservations.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvReservations.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvReservations.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvReservations.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvReservations.ThemeStyle.BackColor = Color.SeaShell;
            dgvReservations.ThemeStyle.GridColor = Color.PeachPuff;
            dgvReservations.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvReservations.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvReservations.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvReservations.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvReservations.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvReservations.ThemeStyle.HeaderStyle.Height = 29;
            dgvReservations.ThemeStyle.ReadOnly = true;
            dgvReservations.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvReservations.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReservations.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvReservations.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvReservations.ThemeStyle.RowsStyle.Height = 29;
            dgvReservations.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvReservations.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // dgvDepartureTime
            // 
            dgvDepartureTime.HeaderText = "Departure Time";
            dgvDepartureTime.MinimumWidth = 6;
            dgvDepartureTime.Name = "dgvDepartureTime";
            dgvDepartureTime.ReadOnly = true;
            // 
            // dgvRoute
            // 
            dgvRoute.HeaderText = "Route";
            dgvRoute.MinimumWidth = 6;
            dgvRoute.Name = "dgvRoute";
            dgvRoute.ReadOnly = true;
            // 
            // dgvDriver
            // 
            dgvDriver.HeaderText = "Driver";
            dgvDriver.MinimumWidth = 6;
            dgvDriver.Name = "dgvDriver";
            dgvDriver.ReadOnly = true;
            // 
            // dgvBusPlate
            // 
            dgvBusPlate.HeaderText = "Plate";
            dgvBusPlate.MinimumWidth = 6;
            dgvBusPlate.Name = "dgvBusPlate";
            dgvBusPlate.ReadOnly = true;
            // 
            // dgvSeatAvail
            // 
            dgvSeatAvail.HeaderText = "Seat Available";
            dgvSeatAvail.MinimumWidth = 6;
            dgvSeatAvail.Name = "dgvSeatAvail";
            dgvSeatAvail.ReadOnly = true;
            // 
            // dgvStatus
            // 
            dgvStatus.HeaderText = "Status";
            dgvStatus.MinimumWidth = 6;
            dgvStatus.Name = "dgvStatus";
            dgvStatus.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(892, 53);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 11;
            label2.Text = "Search:";
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 12F);
            tbSearch.Location = new Point(999, 48);
            tbSearch.Margin = new Padding(4, 5, 4, 5);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(220, 34);
            tbSearch.TabIndex = 10;
            // 
            // ReservationsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1235, 913);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(tbSearch);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ReservationsForm";
            Text = "ReservationsForm";
            Load += ReservationsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvReservations;
        private DataGridViewTextBoxColumn dgvDepartureTime;
        private DataGridViewTextBoxColumn dgvRoute;
        private DataGridViewTextBoxColumn dgvDriver;
        private DataGridViewTextBoxColumn dgvBusPlate;
        private DataGridViewTextBoxColumn dgvSeatAvail;
        private DataGridViewTextBoxColumn dgvStatus;
        private Label label2;
        private TextBox tbSearch;
    }
}