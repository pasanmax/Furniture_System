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
    public partial class SMO_Dashboard : MetroFramework.Forms.MetroForm
    {
        public SMO_Dashboard(string sm,string nm)
        {
            InitializeComponent();
            SM = sm;
            NM = nm;
            this.lbl_Welcome_Name.Text = NM;
        }
        string SM, NM;
        private void btn_logout_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Do  you want to Log Out?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Hide();
                Login_Sign_Up lg = new Login_Sign_Up();
                lg.Show();
            }
        }

        private void SMO_Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void btn_Print_Bill_Click(object sender, EventArgs e)
        {
            this.Hide();
            SMO_Print_Bill pb = new SMO_Print_Bill(SM, NM);
            pb.Show();
        }
    }
}
