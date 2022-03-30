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
    public partial class Not_Paid_Ins : MetroFramework.Forms.MetroForm
    {
        public Not_Paid_Ins(string dt)
        {
            InitializeComponent();
            DT = dt;
        }
        string DT;
        private void Not_Paid_Ins_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'DataSet7.DataTable_Not_Paid_Ins' table. You can move, or remove it, as needed.
                this.DataTable_Not_Paid_InsTableAdapter.Fill(this.DataSet7.DataTable_Not_Paid_Ins, DT);
                this.reportViewer_Not_Paid_Ins.RefreshReport();
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
