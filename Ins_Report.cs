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
    public partial class Ins_Report : MetroFramework.Forms.MetroForm
    {
        public Ins_Report(string frm,string to)
        {
            InitializeComponent();
            FROM = frm;
            TO = to;
        }
        string FROM, TO;
        private void Ins_Report_Load(object sender, EventArgs e)
        {
            try
            {
                ReportParameterCollection rpc = new ReportParameterCollection();
                rpc.Add(new ReportParameter("ReportParameter_From", FROM));
                rpc.Add(new ReportParameter("ReportParameter_To", TO));
                this.reportViewer_Ins_Report.LocalReport.SetParameters(rpc);

                //// TODO: This line of code loads data into the 'DataSet5.DataTable_Ins_View_All' table. You can move, or remove it, as needed.
                this.DataTable_Ins_View_AllTableAdapter.Fill(this.DataSet5.DataTable_Ins_View_All, FROM, TO);
                this.DataTable_Paid_TotTableAdapter.Fill(this.DataSet5.DataTable_Paid_Tot, FROM, TO);

                this.reportViewer_Ins_Report.RefreshReport();
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
