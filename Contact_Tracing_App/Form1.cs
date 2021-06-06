using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            txtTemp.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtHouse.Clear();
            txtBrgy.Clear();
            txtCity.Clear();
            txtProvince.Clear();
            txtZip.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StreamWriter customerLog;
            customerLog = File.AppendText("visitors.txt");
            customerLog.WriteLine("Name: " + txtLN.Text + ", " + txtFN.Text + " " + txtMI.Text);
            customerLog.WriteLine("Age: " + txtAge.Text);
            customerLog.WriteLine("Sex: " + txtSex.Text);
            customerLog.WriteLine("Temperature: " + txtTemp.Text);
            customerLog.WriteLine("Phone: " + txtPhone.Text);
            customerLog.WriteLine("Email Address: " + txtEmail.Text);
            customerLog.WriteLine("Address: " + txtHouse.Text + ", " + txtBrgy.Text + ", " + txtCity.Text + ", " + txtProvince.Text);
            customerLog.WriteLine("Zipcode: " + txtZip.Text);
            customerLog.Close();

            //clear textbox fields
            txtLN.Clear();
            txtFN.Clear();
            txtMI.Clear();
            txtAge.Clear();
            txtSex.Clear();
            txtTemp.Clear();
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
