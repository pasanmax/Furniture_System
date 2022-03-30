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
    public partial class Load_Stock : MetroFramework.Forms.MetroForm
    {
        public Load_Stock(string ls)
        {
            InitializeComponent();
            LS = ls;
        }
        string LS;
        private void Load_Stock_Load(object sender, EventArgs e)
        {
            try
            {
                ReportParameterCollection rpc = new ReportParameterCollection();
                rpc.Add(new ReportParameter("ReportParameter_Load_No", LS));
                this.reportViewer_Load_bal.LocalReport.SetParameters(rpc);

                // TODO: This line of code loads data into the 'DataSet11.DataTable_Load_Bal' table. You can move, or remove it, as needed.
                this.DataTable_Load_BalTableAdapter.Fill(this.DataSet11.DataTable_Load_Bal, LS);
                this.LoadTableAdapter.Fill(this.DataSet11.Load, LS);

                this.reportViewer_Load_bal.RefreshReport();
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
