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
    public partial class RO_Print_Bill : MetroFramework.Forms.MetroForm
    {
        public RO_Print_Bill(string sm, string nm)
        {
            InitializeComponent();
            SM = sm;
            NM = nm;
        }
        FurnitureDB FurDB = new FurnitureDB();
        string SM, NM;
        DateTime date = DateTime.Now;
        private void btn_search_Ins_Click(object sender, EventArgs e)
        {
            Not_Paid_Ins not_Paid = new Not_Paid_Ins(date.ToString("yyyy-MM-dd"));
            not_Paid.ShowDialog();
        }

        private void btn_Search_IRec_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Search_IRec.Text.Length != 0)
                {
                    metroGrid_Ins_Rec.DataSource = FurDB.getData("select i.Rec_No as [Receipt No],i.InItm_Code as [Item No],i.Installment_Date as [Installment Date],i.Installment_Amount as [Installment Amount],i.Status as [Status] from Installment_Date i where i.Rec_No like '" + txt_Search_IRec.Text + "%' and i.Installment_Date='" + date.ToString("yyyy-MM-dd") + "'");
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "Please enter a Receipt No!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void metroGrid_Ins_Rec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_IRec_No.Text = metroGrid_Ins_Rec.CurrentRow.Cells[0].Value.ToString();
            txt_IItem_No.Text = metroGrid_Ins_Rec.CurrentRow.Cells[1].Value.ToString();
            txt_Ins_Date.Text = metroGrid_Ins_Rec.CurrentRow.Cells[2].Value.ToString();
            txt_Ins_Amt.Text = metroGrid_Ins_Rec.CurrentRow.Cells[3].Value.ToString();
            txt_Status.Text = metroGrid_Ins_Rec.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_Print_Ins_Receipt_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_IRec_No.Text.Length != 0 && txt_IItem_No.Text.Length != 0 && txt_Ins_Date.Text.Length != 0 && txt_Ins_Amt.Text.Length != 0 && txt_Status.Text.Length != 0)
                {
                    if (FurDB.readData("select Status from Installment_Date where Rec_No = '" + txt_IRec_No.Text + "' and InItm_Code = '" + txt_IItem_No.Text + "' and Installment_Date = '" + Convert.ToDateTime(txt_Ins_Date.Text) + "' and Status = 'Paid'") == true)
                    {
                        Installment_Receipt InsRec = new Installment_Receipt(txt_IRec_No.Text, txt_IItem_No.Text, txt_Ins_Date.Text);
                        InsRec.ShowDialog();
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Only Paid receipts can print!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "Please enter all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime? dt = FurDB.getDate("select Installment_Date from Installment_Date where Installment_Date = (select Top 1 Installment_Date from Installment_Date where Rec_No = '" + txt_IRec_No.Text + "' and InItm_Code = '" + txt_IItem_No.Text + "' order by Installment_Date_No DESC)");

                if ((txt_IRec_No.Text.Length != 0) && (txt_IItem_No.Text.Length != 0) && (txt_Ins_Date.Text.Length != 0) && (txt_Ins_Amt.Text.Length != 0))
                {
                    if (String.Equals(txt_Status.Text, cmb_Status.Text) && cmb_Status.SelectedIndex == 0)
                        MetroFramework.MetroMessageBox.Show(this, "Already Paid!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (String.Equals(txt_Status.Text, cmb_Status.Text) && cmb_Status.SelectedIndex == 1)
                    {
                        if (FurDB.Insert_Update_Delete("update Installment_Date set Status='Not Paid',SM_ID='" + SM + "' where Rec_No='" + txt_IRec_No.Text + "' and Installment_Date='" + Convert.ToDateTime(txt_Ins_Date.Text) + "' and InItm_Code='" + txt_IItem_No.Text + "'") == 1 && FurDB.Insert_Update_Delete("insert into Installment_Date (Rec_No,InItm_Code,Installment_Date,Installment_Amount,Status,SM_ID) values('" + txt_IRec_No.Text + "','" + txt_IItem_No.Text + "','" + dt?.AddMonths(1) + "','" + Convert.ToDouble(txt_Ins_Amt.Text) + "','Not Paid','" + SM + "')") == 1)
                            MetroFramework.MetroMessageBox.Show(this, "Updated Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MetroFramework.MetroMessageBox.Show(this, "Data canot Update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!(String.Equals(txt_Status.Text, cmb_Status.Text)) && cmb_Status.SelectedIndex == 0)
                    {
                        if (FurDB.Insert_Update_Delete("update Installment_Date set Status='Paid',SM_ID='" + SM + "' where Rec_No='" + txt_IRec_No.Text + "' and Installment_Date='" + Convert.ToDateTime(txt_Ins_Date.Text) + "' and InItm_Code='" + txt_IItem_No.Text + "'") == 1)
                            MetroFramework.MetroMessageBox.Show(this, "Updated Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MetroFramework.MetroMessageBox.Show(this, "Data canot Update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!(String.Equals(txt_Status.Text, cmb_Status.Text)) && cmb_Status.SelectedIndex == 1)
                    {
                        if (FurDB.Insert_Update_Delete("update Installment_Date set Status='Not Paid',SM_ID='" + SM + "' where Rec_No='" + txt_IRec_No.Text + "' and Installment_Date='" + Convert.ToDateTime(txt_Ins_Date.Text) + "' and InItm_Code='" + txt_IItem_No.Text + "'") == 1 && FurDB.Insert_Update_Delete("insert into Installment_Date (Rec_No,InItm_Code,Installment_Date,Installment_Amount,Status,SM_ID) values('" + txt_IRec_No.Text + "','" + txt_IItem_No.Text + "','" + dt?.AddMonths(1) + "','" + Convert.ToDouble(txt_Ins_Amt.Text) + "','Not Paid','" + SM + "')") == 1)
                            MetroFramework.MetroMessageBox.Show(this, "Updated Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MetroFramework.MetroMessageBox.Show(this, "Data canot Update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "Please enter all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void btn_clear_IRec_Click(object sender, EventArgs e)
        {
            txt_Search_IRec.Clear(); txt_IRec_No.Clear(); txt_IItem_No.Clear(); txt_Ins_Date.Clear(); txt_Ins_Amt.Clear();
            cmb_Status.SelectedIndex = -1; metroGrid_Ins_Rec.DataSource = null; txt_Status.Clear();
        }

        private void RO_Print_Bill_FormClosing(object sender, FormClosingEventArgs e)
        {
            RO_Dashboard obj = new RO_Dashboard(SM, NM);
            obj.Show();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            RO_Dashboard obj = new RO_Dashboard(SM,NM);
            obj.Show();
        }
    }
}
