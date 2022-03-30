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
    public partial class Sales_Report : MetroFramework.Forms.MetroForm
    {
        public Sales_Report(string sm,string from,string to)
        {
            InitializeComponent();
            SM = sm; FROM = from; TO = to;
        }
        string SM, FROM, TO;
        private void Sales_Report_Load(object sender, EventArgs e)
        {
            try
            {
                ReportParameterCollection rpc = new ReportParameterCollection();
                rpc.Add(new ReportParameter("ReportParameter_From", FROM));
                rpc.Add(new ReportParameter("ReportParameter_To", TO));
                rpc.Add(new ReportParameter("ReportParameter_SM_Type", SM));
                this.reportViewer_SM_Report.LocalReport.SetParameters(rpc);

                // TODO: This line of code loads data into the 'DataSet9.DataTable_SM_Type_Sales' table. You can move, or remove it, as needed.
                this.DataTable_SM_Type_SalesTableAdapter.Fill(this.DataSet9.DataTable_SM_Type_Sales, SM, FROM, TO);

                this.reportViewer_SM_Report.RefreshReport();
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
