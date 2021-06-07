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
        byte visitor_count = 0;

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
            cmbxSex.ResetText();
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

            if (txtFN.Text == "" || txtLN.Text == "" || txtAge.Text == "" || cmbxSex.Text == "" || txtTemp.Text == "" || txtPhone.Text == "" || txtEmail.Text == "" 
                || txtHouse.Text =="" || txtBrgy.Text == "" || txtCity.Text == "" || txtProvince.Text == "")
            {
                MessageBox.Show("Please provide input on the required fields!");

            }

            else
            {
                visitor_count++;

                customerLog = File.AppendText("visitors.txt");
                customerLog.WriteLine("Visitor # " + visitor_count.ToString());
                customerLog.WriteLine("Date: " + datePicker.Text);
                customerLog.WriteLine("Name: " + txtLN.Text + ", " + txtFN.Text + " " + txtMI.Text);
                customerLog.WriteLine("Age: " + txtAge.Text);
                customerLog.WriteLine("Sex: " + cmbxSex.Text);
                customerLog.WriteLine("Temperature: " + txtTemp.Text);
                customerLog.WriteLine("Phone: " + txtPhone.Text);
                customerLog.WriteLine("Email Address: " + txtEmail.Text);
                customerLog.WriteLine("Address: " + txtHouse.Text + ", " + txtBrgy.Text + ", " + txtCity.Text + ", " + txtProvince.Text);
                customerLog.WriteLine("Zipcode: " + txtZip.Text);
                customerLog.WriteLine("  ");
                customerLog.WriteLine("  ");
                customerLog.Close();

                MessageBox.Show("Thank you for your cooperation. Enjoy your visit!");

                //clear textbox fields
                txtLN.Clear();
                txtFN.Clear();
                txtMI.Clear();
                txtAge.Clear();
                cmbxSex.ResetText();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
