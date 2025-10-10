namespace UserInterfaceLayer.StaffApplication.Forms
{
    partial class PassengersForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            tbSearch = new TextBox();
            panel2 = new Panel();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            label3 = new Label();
            btnEdit = new Guna.UI2.WinForms.Guna2Button();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            dgvPassengers = new Guna.UI2.WinForms.Guna2DataGridView();
            dgvDepartureTime = new DataGridViewTextBoxColumn();
            dgvRoute = new DataGridViewTextBoxColumn();
            dgvDriver = new DataGridViewTextBoxColumn();
            dgvBusPlate = new DataGridViewTextBoxColumn();
            dgvSeatAvail = new DataGridViewTextBoxColumn();
            dgvStatus = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPassengers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 29F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(43, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(438, 57);
            label1.TabIndex = 4;
            label1.Text = "Passenger's List";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(895, 55);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 4;
            label2.Text = "Search:";
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 12F);
            tbSearch.Location = new Point(1002, 50);
            tbSearch.Margin = new Padding(4, 5, 4, 5);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(220, 34);
            tbSearch.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Linen;
            panel2.Controls.Add(dgvPassengers);
            panel2.Location = new Point(18, 94);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(944, 805);
            panel2.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 50;
            guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnCancel);
            panel1.Location = new Point(970, 94);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 253);
            panel1.TabIndex = 8;
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
            btnEdit.CustomizableEdges = customizableEdges7;
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
            btnEdit.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnEdit.ShadowDecoration.Depth = 5;
            btnEdit.ShadowDecoration.Enabled = true;
            btnEdit.Size = new Size(200, 46);
            btnEdit.TabIndex = 10115;
            btnEdit.Text = "Edit Passenger";
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
            btnAdd.CustomizableEdges = customizableEdges9;
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
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnAdd.ShadowDecoration.Depth = 5;
            btnAdd.ShadowDecoration.Enabled = true;
            btnAdd.Size = new Size(200, 46);
            btnAdd.TabIndex = 10114;
            btnAdd.Text = "Add Passenger";
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
            btnCancel.CustomizableEdges = customizableEdges11;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.White;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnCancel.ShadowDecoration.Depth = 5;
            btnCancel.ShadowDecoration.Enabled = true;
            btnCancel.Size = new Size(200, 46);
            btnCancel.TabIndex = 10113;
            btnCancel.Text = "Delete Passenger";
            btnCancel.UseTransparentBackground = true;
            // 
            // dgvPassengers
            // 
            dgvPassengers.AllowUserToAddRows = false;
            dgvPassengers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dgvPassengers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvPassengers.BackgroundColor = Color.SeaShell;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvPassengers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvPassengers.ColumnHeadersHeight = 29;
            dgvPassengers.Columns.AddRange(new DataGridViewColumn[] { dgvDepartureTime, dgvRoute, dgvDriver, dgvBusPlate, dgvSeatAvail, dgvStatus });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvPassengers.DefaultCellStyle = dataGridViewCellStyle7;
            dgvPassengers.EnableHeadersVisualStyles = true;
            dgvPassengers.GridColor = Color.PeachPuff;
            dgvPassengers.Location = new Point(3, 3);
            dgvPassengers.Name = "dgvPassengers";
            dgvPassengers.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.AntiqueWhite;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle8.SelectionBackColor = Color.PeachPuff;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvPassengers.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvPassengers.RowHeadersVisible = false;
            dgvPassengers.RowHeadersWidth = 51;
            dgvPassengers.Size = new Size(938, 799);
            dgvPassengers.TabIndex = 10117;
            dgvPassengers.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvPassengers.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvPassengers.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvPassengers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvPassengers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvPassengers.ThemeStyle.BackColor = Color.SeaShell;
            dgvPassengers.ThemeStyle.GridColor = Color.PeachPuff;
            dgvPassengers.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvPassengers.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPassengers.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvPassengers.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvPassengers.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPassengers.ThemeStyle.HeaderStyle.Height = 29;
            dgvPassengers.ThemeStyle.ReadOnly = true;
            dgvPassengers.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvPassengers.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPassengers.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvPassengers.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvPassengers.ThemeStyle.RowsStyle.Height = 29;
            dgvPassengers.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvPassengers.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
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
            // PassengersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1235, 913);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(tbSearch);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "PassengersForm";
            Text = "PassengersForm";
            Load += PassengersForm_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPassengers).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Panel panel1;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPassengers;
        private DataGridViewTextBoxColumn dgvDepartureTime;
        private DataGridViewTextBoxColumn dgvRoute;
        private DataGridViewTextBoxColumn dgvDriver;
        private DataGridViewTextBoxColumn dgvBusPlate;
        private DataGridViewTextBoxColumn dgvSeatAvail;
        private DataGridViewTextBoxColumn dgvStatus;
    }
}