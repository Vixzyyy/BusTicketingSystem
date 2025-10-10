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
    public partial class CancelTripForm: Form
    {
        public CancelTripForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TripsForm parent = (TripsForm)this.ParentForm;
            parent.ReloadTripsList();
        }
    }
}
