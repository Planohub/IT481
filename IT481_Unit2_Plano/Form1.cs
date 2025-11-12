using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IT481_Unit2_Plano
{
    public partial class Form1 : Form
    {
        DB database;
        private string user;
        private string password;
        private string server;
        private string database_name;
        public Form1()
        {
            InitializeComponent();
            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
            button3.Click += new EventHandler(button3_Click);
            button4.Click += new EventHandler(button4_Click);
            button5.Click += new EventHandler(button5_Click);
            button6.Click += new EventHandler(button6_Click);
            button7.Click += new EventHandler(button7_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database = new DB("Server = ALDUIN\\SQLEXPRESS; " + "Trusted_Connection = true;" + "Database = northwind;" + "User Instance = false;" + "Connection timeout = 30");

            MessageBox.Show("Connection information sent");

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string count = database.getCustomerCount();
            MessageBox.Show(count, "Customer count");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string names = database.getCompanyNames();
            MessageBox.Show(names, "Company names");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string count = database.getOrderCount();
            MessageBox.Show(count, "Order count");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string names = database.getCustomerID();
            MessageBox.Show(names, "CustomerID");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string count = database.getEmployeeCount();
            MessageBox.Show(count, "Employee count");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string names = database.getEmployeeLastName();
            MessageBox.Show(names, "Employee Last Name");
        }
    }
}
