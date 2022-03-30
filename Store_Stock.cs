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
    public partial class Store_Stock : MetroFramework.Forms.MetroForm
    {
        public Store_Stock(string ss)
        {
            InitializeComponent();

            SS = ss;
        }
        string SS;
        private void Store_Stock_Load(object sender, EventArgs e)
        {
            try
            {
                ReportParameterCollection rpc = new ReportParameterCollection();
                rpc.Add(new ReportParameter("ReportParameter_St_No", SS));
                this.reportViewer_Store_bal.LocalReport.SetParameters(rpc);
                // TODO: This line of code loads data into the 'DataSet10.DataTable_Store_Bal' table. You can move, or remove it, as needed.
                this.DataTable_Store_BalTableAdapter.Fill(this.DataSet10.DataTable_Store_Bal, SS);
                this.StoreTableAdapter.Fill(this.DataSet10.Store, SS);
                this.reportViewer_Store_bal.RefreshReport();
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
