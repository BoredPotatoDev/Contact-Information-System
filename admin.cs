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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();

        }
        private void admin_Load_1(object sender, EventArgs e)
        {
            // Creates our table and columns
            DataTable dt = new DataTable();

            dt.Columns.Add("First Name", typeof(string));
            dt.Columns.Add("Last Name", typeof(string));
            dt.Columns.Add("Middle Initial", typeof(string));
            dt.Columns.Add("Birth Date", typeof(string));
            dt.Columns.Add("Age", typeof(string));
            dt.Columns.Add("Contact no.", typeof(string));

            dataGridView1.DataSource = dt;

            //Read all the lines
            string[] lines = File.ReadAllLines(@"Contact_Info.txt");
            string[] values;

            // Takes lines and splits each info with their "," seperator and puts them to their corresponding column and creates the rows
            for (int x = 0; x < lines.Length; x++)
            {
                values = lines[x].ToString().Split(',');
                string[] row = new string[values.Length];

                for (int y = 0; y < values.Length; y++)
                {
                    row[y] = values[y].Trim();
                }
                dt.Rows.Add(row);
            }
        }
    }
}
