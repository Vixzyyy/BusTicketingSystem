using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceLayer.KioskApplication.Forms
{
    public partial class InputResIDForm : Form
    {
        public InputResIDForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string resID = tbInputResID.Text?.Trim();

            if (string.IsNullOrWhiteSpace(resID))
            {
                MessageBox.Show("Please enter a Reservation ID.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ReservationDetailsForm detailsForm = new ReservationDetailsForm(this);

            KioskBaseForm parent = GetKioskBaseForm();
            if (parent != null)
            {
                parent.LoadFormInPanel(detailsForm);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LandingForm landing = new LandingForm();
            landing.Show();

            KioskBaseForm parent = GetKioskBaseForm();
            parent?.Close();
        }

        protected KioskBaseForm GetKioskBaseForm()
        {
            Control current = this;
            while (current != null)
            {
                if (current is KioskBaseForm)
                    return (KioskBaseForm)current;
                current = current.Parent;
            }
            return null;
        }

        private void pnlCheckRes_Paint(object sender, PaintEventArgs e) { }
        private void InputResIDForm_Load(object sender, EventArgs e) { }
    }
}
