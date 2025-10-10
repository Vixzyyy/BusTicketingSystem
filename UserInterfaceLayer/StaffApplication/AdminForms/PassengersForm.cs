using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceLayer.StaffApplication.Forms
{
    public partial class PassengersForm: Form
    {
        public PassengersForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void PassengersForm_Load(object sender, EventArgs e)
        {
            LoadPassengers();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddPassengerForm addForm = new AddPassengerForm(this);
            LoadControlInPanel(addForm);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dgvPassengers.SelectedRows.Count > 0)
            {
                string passengerId = dgvPassengers.SelectedRows[0].Cells["dgvPassengerID"].Value.ToString();
                EditPassengerForm editForm = new EditPassengerForm(passengerId, this);
                LoadControlInPanel(editForm);
            }
            else
            {
                MessageBox.Show("Please select a passenger first before editing.",
                                "No Passenger Selected",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvPassengers.SelectedRows.Count > 0)
            {
                string passengerId = dgvPassengers.SelectedRows[0].Cells["PassengerID"].Value.ToString();
                string fullName = dgvPassengers.SelectedRows[0].Cells["FullName"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete Passenger #{passengerId} ({fullName})?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Passenger deleted successfully.");
                    LoadPassengers();
                }
            }
            else
            {
                MessageBox.Show("Please select a passenger first before deleting.",
                                "No Passenger Selected",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
        private void LoadPassengers()
        {
            dgvPassengers.Rows.Clear();
        }
        public void LoadControlInPanel(Form frm)
        {
            panel2.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panel2.Controls.Add(frm);
            frm.Show();
        }


        public void ShowPassengersGrid()
        {
            panel2.Controls.Clear();
            dgvPassengers.Dock = DockStyle.Fill;
            panel2.Controls.Add(dgvPassengers);

            LoadPassengers();
        }


        private void dgvPassengers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
