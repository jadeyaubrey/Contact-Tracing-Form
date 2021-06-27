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
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void btnVisitor_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCTA f2 = new frmCTA();
            f2.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReadVisitors f3 = new frmReadVisitors();
            f3.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
