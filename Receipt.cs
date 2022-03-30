using Microsoft.Reporting.WinForms;
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
    public partial class Receipt : MetroFramework.Forms.MetroForm
    {
        public Receipt(string rec,string nic)
        {
            InitializeComponent();
            NIC = nic;
            REC = rec;
        }
        string NIC;
        string REC;
        private void Receipt_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'DataSet3.DataTable_Ins' table. You can move, or remove it, as needed.
                this.DataTable_InsTableAdapter.Fill(this.DataSet3.DataTable_Ins, REC, NIC);
                // TODO: This line of code loads data into the 'DataSet2.DataTable_Full' table. You can move, or remove it, as needed.
                this.DataTable_FullTableAdapter.Fill(this.DataSet2.DataTable_Full, REC, NIC);
                // TODO: This line of code loads data into the 'DataSet1.Customer_Detail' table. You can move, or remove it, as needed.
                this.Customer_DetailTableAdapter.Fill(this.DataSet1.Customer_Detail, NIC);
                //this.Receipt_report.LocalReport.SetParameters(para);

                //this.customerTableAdapter1.Fill(this.dataSet_Receipt1.Customer, NIC);
                //this.dataTable_FullTableAdapter1.Fill(this.dataSet_Receipt1.DataTable_Full, REC, NIC);
                //this.dataTable_InsTableAdapter1.Fill(this.dataSet_Receipt1.DataTable_Ins, REC, NIC);
                this.Receipt_report.RefreshReport();
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
