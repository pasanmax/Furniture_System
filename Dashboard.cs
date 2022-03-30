using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Furniture_System
{
    public partial class Dashboard : MetroFramework.Forms.MetroForm
    {
        public Dashboard(string un)
        {
            InitializeComponent();
            UN = un;
            this.lbl_Welcome_Name.Text = UN;
        }
        string UN;
        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Cus_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer obj = new Customer(UN);
            obj.Show();
            
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
            System.Windows.Forms.Application.ExitThread();
        }

        private void btn_Item_Click(object sender, EventArgs e)
        {
            this.Hide();
            Item obj = new Item(UN);
            obj.Show();
        }

        private void btn_Store_Click(object sender, EventArgs e)
        {
            this.Hide();
            Store obj = new Store(UN);
            obj.Show();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            this.Hide();
            Load obj = new Load(UN);
            obj.Show();
        }

        private void btn_Salesman_Click(object sender, EventArgs e)
        {
            this.Hide();
            Salesman obj = new Salesman(UN);
            obj.Show();
        }

        private void btn_Outlet_Click(object sender, EventArgs e)
        {
            this.Hide();
            Outlet obj = new Outlet(UN);
            obj.Show();
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports obj = new Reports(UN);
            obj.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Do  you want to Log Out?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Hide();
                Login_Sign_Up lg = new Login_Sign_Up();
                lg.Show();
            }
                
        }
    }
}
