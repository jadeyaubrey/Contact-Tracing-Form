using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_App
{
    public partial class frmCTA : Form
    {
        public frmCTA()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLN.Clear();
            txtFN.Clear();
            txtMI.Clear();
            txtAge.Clear();
            txtSex.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtHouse.Clear();
            txtBrgy.Clear();
            txtCity.Clear();
            txtProvince.Clear();
            txtZip.Clear();


        }
    }
}
