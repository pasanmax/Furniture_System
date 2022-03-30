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
    public partial class Installment_Receipt : MetroFramework.Forms.MetroForm
    {
        public Installment_Receipt(string rec,string itm,string date)
        {
            InitializeComponent();
            REC = rec;
            ITM = itm;
            DATE = date;
        }
        string REC, ITM, DATE;

        private void Installment_Receipt_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'DataSet6.DataTable_Ins_Rec' table. You can move, or remove it, as needed.
                this.DataTable_Ins_RecTableAdapter.Fill(this.DataSet6.DataTable_Ins_Rec, REC, ITM, DATE);
                // TODO: This line of code loads data into the 'DataSet6.DataTable_Cus_Info' table. You can move, or remove it, as needed.
                this.DataTable_Cus_InfoTableAdapter.Fill(this.DataSet6.DataTable_Cus_Info, REC);

                this.reportViewer_Ins_Receipt.RefreshReport();
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
