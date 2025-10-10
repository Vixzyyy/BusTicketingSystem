using Microsoft.VisualBasic.Devices;
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
    public partial class RefundForm : Form
    {
        private ReservationDetailsForm previousForm;
        public RefundForm(ReservationDetailsForm previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
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

        private void btnConfirmRef_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Refund confirmed! Refund issued.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            LandingForm landing = new LandingForm();
            landing.Show();

            (this.ParentForm as KioskBaseForm)?.Close();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            KioskBaseForm parent = GetKioskBaseForm();
            if (parent != null && previousForm != null)
            {
                parent.LoadFormInPanel(previousForm);
            }
            else
            {
                MessageBox.Show("Parent KioskBaseForm not found!");
            }
        }
    }
}
