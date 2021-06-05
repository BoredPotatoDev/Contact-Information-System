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

namespace Contact_Information_System
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Gets all inputs
            String[] data = new string[6];
            data[0] = FN.Text;
            data[1] = LN.Text;
            data[2] = MI.Text;
            data[3] = BD.Text;
            data[4] = AGE.Text;
            data[5] = CN.Text;

            // Writes the new data on top of the old data
            StreamWriter sw = new StreamWriter(@"Contact_Info.txt",true);
            sw.WriteLine(data[0] + ", "
                         + data[1] + ", "
                         + data[2] + ", "
                         + data[3] + ", "
                         + data[4] + ", "
                         + data[5]);
            sw.Close();

            // Clear all text box inputs and shows you have been registered
            MessageBox.Show("Your Input has been Registered!", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FN.Text = String.Empty;
            LN.Text = String.Empty;
            MI.Text = String.Empty;
            BD.Text = ("MM/DD/YYYY");
            AGE.Text = String.Empty;
            CN.Text = String.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THIS INFORMATION IS CONFIDENTIAL! \nClick OK to continue.", "admin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            admin admin = new admin();
            admin.ShowDialog();
        }
    }
}