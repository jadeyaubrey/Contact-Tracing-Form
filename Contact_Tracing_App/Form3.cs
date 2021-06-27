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
    public partial class frmReadVisitors : Form
    {
        public frmReadVisitors()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmWelcome f1 = new frmWelcome();
            f1.Show();

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;
            inputFile = File.OpenText("visitors.txt");

            while(!inputFile.EndOfStream)
            {
                rtextVisitors.Text = inputFile.ReadLine();
            }
        }
    }
}
