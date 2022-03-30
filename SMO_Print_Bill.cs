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
    public partial class SMO_Print_Bill : MetroFramework.Forms.MetroForm
    {
        public SMO_Print_Bill(string sm,string nm)
        {
            InitializeComponent();
            SM = sm;
            NM = nm;
        }
        FurnitureDB FurDB = new FurnitureDB();
        double NewQan;
        string SM,NM;

        private void SMO_Print_Bill_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (metroGrid_Rec_Itms.Rows.Count != 0)
                {
                    for (int i = 0; i < metroGrid_Rec_Itms.RowCount - 1; i++)
                    {
                        string ST_LD = metroGrid_Rec_Itms.Rows[i].Cells["Load_or_Store"].Value.ToString();
                        string Itm = metroGrid_Rec_Itms.Rows[i].Cells["Item_Code"].Value.ToString();
                        string Qua = metroGrid_Rec_Itms.Rows[i].Cells["Quantity"].Value.ToString();

                        if (FurDB.Insert_Update_Delete("update Load_Items set Quantity=Quantity+'" + Convert.ToInt32(Qua) + "' where L_ID='" + ST_LD + "' and Itm_ID='" + Itm + "'") == 1)
                        { }
                    }
                }
            }

            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }


            SMO_Dashboard obj = new SMO_Dashboard(SM,NM);
            obj.Show();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroGrid_Rec_Itms.Rows.Count != 0)
                {
                    for (int i = 0; i < metroGrid_Rec_Itms.RowCount - 1; i++)
                    {
                        string ST_LD = metroGrid_Rec_Itms.Rows[i].Cells["Load_or_Store"].Value.ToString();
                        string Itm = metroGrid_Rec_Itms.Rows[i].Cells["Item_Code"].Value.ToString();
                        string Qua = metroGrid_Rec_Itms.Rows[i].Cells["Quantity"].Value.ToString();

                        if (FurDB.Insert_Update_Delete("update Load_Items set Quantity=Quantity+'" + Convert.ToInt32(Qua) + "' where L_ID='" + ST_LD + "' and Itm_ID='" + Itm + "'") == 1)
                        { }
                    }
                }
            }

            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }

            this.Hide();
            SMO_Dashboard obj = new SMO_Dashboard(SM,NM);
            obj.Show();
        }

        private void SMO_Print_Bill_Load(object sender, EventArgs e)
        {
            try
            {

                cmb_Str_Ldr_Name.DataSource = FurDB.getValue("select Load_No from Load").Tables[0];
                cmb_Str_Ldr_Name.ValueMember = "Load_No";
                cmb_Str_Ldr_Name.Enabled = true;
                cmb_Str_Ldr_Name.SelectedIndex = -1;

                cmb_Item_Name.DataSource = FurDB.getValue("select Item_Code from Item").Tables[0];
                cmb_Item_Name.ValueMember = "Item_Code";
                cmb_Item_Name.Enabled = true;
                cmb_Item_Name.SelectedIndex = -1;
                lbl_uPrice.Text = "";

                for (int i = 0; i < 8; i++)
                {
                    metroGrid_Rec_Itms.Columns[i].Width = 100;
                }
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        DateTime date = DateTime.Now;
        int dis;
        private void btn_Print_Click(object sender, EventArgs e)
        {
            
            try
            {
                if ((txt_Receipt_No.Text.Length != 0) && (txt_NIC.Text.Length != 0) && (metroGrid_Rec_Itms.Rows.Count != 0))
                {
                    if (FurDB.readData("select * from Full_Receipt where Receipt_No='" + txt_Receipt_No.Text + "'") == true && FurDB.readData("select * from Installment_Receipt where Receipt_No='" + txt_Receipt_No.Text + "'") == true && FurDB.readData("select * from Installment_Date where Rec_No='" + txt_Receipt_No.Text + "'") == true)
                        MetroFramework.MetroMessageBox.Show(this, "Receipt already Issued!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (FurDB.readData("select * from Customer where NIC='" + txt_NIC.Text + "'") == true)
                        {
                            if (txt_Discount_Pcnt.Text.Length == 0)
                                dis = 0;
                            else
                            {
                                dis = Convert.ToInt32(txt_Discount_Pcnt.Text);
                                Totfull = Totfull - (Totfull * Convert.ToInt32(txt_Discount_Pcnt.Text) * 0.01);
                            }

                            for (int i = 0; i < metroGrid_Rec_Itms.RowCount - 1; i++)
                            {
                                if (metroGrid_Rec_Itms.Rows[i].Cells["Payment_Type"].Value.ToString() == "Full Payment")
                                {
                                    if (FurDB.readData("select * from Full_Receipt where Receipt_No='" + txt_Receipt_No.Text + "'") == false)
                                    {
                                        FurDB.Insert_Update_Delete("insert into Full_Receipt (Receipt_No,Total_Amount,Payment_Type,Discount,Cus_ID,Full_SM) values ('" + txt_Receipt_No.Text + "','" + Totfull + "','" + metroGrid_Rec_Itms.Rows[i].Cells["Payment_Type"].Value.ToString() + "','" + dis + "','" + txt_NIC.Text + "','" + SM + "')");
                                        FurDB.Insert_Update_Delete("insert into Item_Bought_Full values('" + txt_Receipt_No.Text + "','" + txt_NIC.Text + "','" + metroGrid_Rec_Itms.Rows[i].Cells["Item_Code"].Value.ToString() + "','" + metroGrid_Rec_Itms.Rows[i].Cells["Quantity"].Value.ToString() + "','" + metroGrid_Rec_Itms.Rows[i].Cells["Unit_Price"].Value.ToString() + "')");
                                    }
                                    else
                                        FurDB.Insert_Update_Delete("insert into Item_Bought_Full values('" + txt_Receipt_No.Text + "','" + txt_NIC.Text + "','" + metroGrid_Rec_Itms.Rows[i].Cells["Item_Code"].Value.ToString() + "','" + metroGrid_Rec_Itms.Rows[i].Cells["Quantity"].Value.ToString() + "','" + metroGrid_Rec_Itms.Rows[i].Cells["Unit_Price"].Value.ToString() + "')");
                                }
                                else if (metroGrid_Rec_Itms.Rows[i].Cells["Payment_Type"].Value.ToString() == "Installment Payment")
                                {
                                    double InsAmount;

                                    if (FurDB.readData("select * from Installment_Receipt where Receipt_No='" + txt_Receipt_No.Text + "'") == false)
                                    {
                                        FurDB.Insert_Update_Delete("insert into Installment_Receipt (Receipt_No,Total_Amount,Payment_Type,Cust_ID,Ins_SM) values('" + txt_Receipt_No.Text + "','" + TotIns + "','" + metroGrid_Rec_Itms.Rows[i].Cells["Payment_Type"].Value.ToString() + "','" + txt_NIC.Text + "','" + SM + "')");
                                        FurDB.Insert_Update_Delete("insert into Item_Bought_Ins values('" + txt_Receipt_No.Text + "','" + txt_NIC.Text + "','" + metroGrid_Rec_Itms.Rows[i].Cells["Item_Code"].Value.ToString() + "','" + Convert.ToDouble(metroGrid_Rec_Itms.Rows[i].Cells["Downpayment"].Value.ToString()) + "','" + Convert.ToInt32(metroGrid_Rec_Itms.Rows[i].Cells["No_of_Installments"].Value.ToString()) + "','" + Convert.ToInt32(metroGrid_Rec_Itms.Rows[i].Cells["Quantity"].Value.ToString()) + "','" + Convert.ToDouble(metroGrid_Rec_Itms.Rows[i].Cells["Unit_Price"].Value.ToString()) + "')");
                                        //InsAmount = (TotIns - Totdown) / Convert.ToInt32(metroGrid_Rec_Itms.Rows[i].Cells["No_of_Installments"].Value.ToString());

                                        InsAmount = ((Convert.ToDouble(metroGrid_Rec_Itms.Rows[i].Cells["Unit_Price"].Value.ToString()) * Convert.ToInt32(metroGrid_Rec_Itms.Rows[i].Cells["Quantity"].Value.ToString())) - Convert.ToDouble(metroGrid_Rec_Itms.Rows[i].Cells["Downpayment"].Value.ToString())) / Convert.ToInt32(metroGrid_Rec_Itms.Rows[i].Cells["No_of_Installments"].Value.ToString());

                                        for (int j = 1; j <= (Convert.ToInt32(metroGrid_Rec_Itms.Rows[i].Cells["No_of_Installments"].Value.ToString())); j++)
                                        {
                                            FurDB.Insert_Update_Delete("insert into Installment_Date (Rec_No,InItm_Code,Installment_Date,Installment_Amount,Status,SM_ID) values('" + txt_Receipt_No.Text + "','" + metroGrid_Rec_Itms.Rows[i].Cells["Item_Code"].Value.ToString() + "','" + date.AddMonths(j) + "','" + InsAmount + "','Not Paid','" + SM + "')");
                                        }
                                    }
                                    else
                                    {
                                        FurDB.Insert_Update_Delete("insert into Item_Bought_Ins values('" + txt_Receipt_No.Text + "','" + txt_NIC.Text + "','" + metroGrid_Rec_Itms.Rows[i].Cells["Item_Code"].Value.ToString() + "','" + Convert.ToDouble(metroGrid_Rec_Itms.Rows[i].Cells["Downpayment"].Value.ToString()) + "','" + Convert.ToInt32(metroGrid_Rec_Itms.Rows[i].Cells["No_of_Installments"].Value.ToString()) + "','" + Convert.ToInt32(metroGrid_Rec_Itms.Rows[i].Cells["Quantity"].Value.ToString()) + "','" + Convert.ToDouble(metroGrid_Rec_Itms.Rows[i].Cells["Unit_Price"].Value.ToString()) + "')");
                                        //InsAmount = (TotIns - Totdown) / Convert.ToInt32(metroGrid_Rec_Itms.Rows[i].Cells["No_of_Installments"].Value.ToString());

                                        InsAmount = ((Convert.ToDouble(metroGrid_Rec_Itms.Rows[i].Cells["Unit_Price"].Value.ToString()) * Convert.ToInt32(metroGrid_Rec_Itms.Rows[i].Cells["Quantity"].Value.ToString())) - Convert.ToDouble(metroGrid_Rec_Itms.Rows[i].Cells["Downpayment"].Value.ToString())) / Convert.ToInt32(metroGrid_Rec_Itms.Rows[i].Cells["No_of_Installments"].Value.ToString());

                                        for (int j = 1; j <= (Convert.ToInt32(metroGrid_Rec_Itms.Rows[i].Cells["No_of_Installments"].Value.ToString())); j++)
                                        {
                                            FurDB.Insert_Update_Delete("insert into Installment_Date (Rec_No,InItm_Code,Installment_Date,Installment_Amount,Status,SM_ID) values('" + txt_Receipt_No.Text + "','" + metroGrid_Rec_Itms.Rows[i].Cells["Item_Code"].Value.ToString() + "','" + date.AddMonths(j) + "','" + InsAmount + "','Not Paid','" + SM + "')");
                                        }
                                    }
                                }

                            }
                            MetroFramework.MetroMessageBox.Show(this, "Successfull!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Receipt obj = new Receipt(txt_Receipt_No.Text, txt_NIC.Text);
                            obj.Show();
                            cmb_Payment_Type.SelectedIndex = -1; cmb_Item_Name.SelectedIndex = -1; cmb_Str_Ldr_Name.SelectedIndex = -1; cmb_Quantity.SelectedIndex = -1;
                            lbl_Item_Name.Text = ""; lbl_uPrice.Text = "";
                            txt_Downpayment.Clear(); txt_No_of_Ins.Clear(); txt_Discount_Pcnt.Clear(); txt_Discount_Pcnt.Enabled = true; txt_Downpayment.Enabled = true;
                            txt_No_of_Ins.Enabled = true; txt_NIC.Clear(); txt_Receipt_No.Clear(); metroGrid_Rec_Itms.Rows.Clear();
                            lbl_Sub_Tot.Text = ""; lbl_Tot_Down.Text = ""; lbl_Tot_Full.Text = ""; Totdown = 0; Totfull = 0; Totsub = 0; TotIns = 0;

                        }
                        else
                            MetroFramework.MetroMessageBox.Show(this, "Customer not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        double Totdown, Totfull, Totsub, TotIns;

        private void cmb_Payment_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Payment_Type.Text == "Full Payment")
            {
                txt_Discount_Pcnt.Enabled = true;
                txt_Downpayment.Enabled = false;
                txt_No_of_Ins.Enabled = false; txt_Downpayment.Clear(); txt_No_of_Ins.Clear();
            }
            else if (cmb_Payment_Type.Text == "Installment Payment")
            {
                txt_Downpayment.Enabled = true;
                txt_No_of_Ins.Enabled = true;
                txt_Discount_Pcnt.Enabled = false; txt_Discount_Pcnt.Clear();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Add_Customer Addcus = new Add_Customer();
            Addcus.ShowDialog();
        }

        private void btn_search2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_View_Receipt_No.Text.Length != 0)
                {
                    this.DataTable_InsTableAdapter.Fill(this.DataSet3.DataTable_Ins, txt_View_Receipt_No.Text, FurDB.readData("select f.FCus_ID as [NIC] from Item_Bought_Full f where f.Rcpt_No = '" + txt_View_Receipt_No.Text + "' union select i.ICus_ID as [NIC] from Item_Bought_Ins i where i.Rcipt_No = '" + txt_View_Receipt_No.Text + "'", "NIC", ""));
                    // TODO: This line of code loads data into the 'DataSet2.DataTable_Full' table. You can move, or remove it, as needed.
                    this.DataTable_FullTableAdapter.Fill(this.DataSet2.DataTable_Full, txt_View_Receipt_No.Text, FurDB.readData("select f.FCus_ID as [NIC] from Item_Bought_Full f where f.Rcpt_No = '" + txt_View_Receipt_No.Text + "' union select i.ICus_ID as [NIC] from Item_Bought_Ins i where i.Rcipt_No = '" + txt_View_Receipt_No.Text + "'", "NIC", ""));
                    // TODO: This line of code loads data into the 'DataSet1.Customer_Detail' table. You can move, or remove it, as needed.
                    this.Customer_DetailTableAdapter.Fill(this.DataSet1.Customer_Detail, FurDB.readData("select f.FCus_ID as [NIC] from Item_Bought_Full f where f.Rcpt_No = '" + txt_View_Receipt_No.Text + "' union select i.ICus_ID as [NIC] from Item_Bought_Ins i where i.Rcipt_No = '" + txt_View_Receipt_No.Text + "'", "NIC", ""));
                    this.reportViewer_View_Receipts.RefreshReport();
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "Please enter all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                MetroFramework.MetroMessageBox.Show(this, "No Records Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void btn_clear_all_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroGrid_Rec_Itms.Rows.Count != 0)
                {
                    for (int i = 0; i < metroGrid_Rec_Itms.RowCount - 1; i++)
                    {
                        string ST_LD = metroGrid_Rec_Itms.Rows[i].Cells["Load_or_Store"].Value.ToString();
                        string Itm = metroGrid_Rec_Itms.Rows[i].Cells["Item_Code"].Value.ToString();
                        string Qua = metroGrid_Rec_Itms.Rows[i].Cells["Quantity"].Value.ToString();

                        if (FurDB.Insert_Update_Delete("update Load_Items set Quantity=Quantity+'" + Convert.ToInt32(Qua) + "' where L_ID='" + ST_LD + "' and Itm_ID='" + Itm + "'") == 1)
                        { }
                    }
                }
            }

            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }


            cmb_Payment_Type.SelectedIndex = -1; cmb_Item_Name.SelectedIndex = -1; cmb_Str_Ldr_Name.SelectedIndex = -1; cmb_Quantity.SelectedIndex = -1;
            lbl_Item_Name.Text = ""; lbl_uPrice.Text = "";
            txt_Downpayment.Clear(); txt_No_of_Ins.Clear(); txt_Discount_Pcnt.Clear(); txt_Discount_Pcnt.Enabled = true; txt_Downpayment.Enabled = true;
            txt_No_of_Ins.Enabled = true; txt_NIC.Clear(); txt_Receipt_No.Clear(); metroGrid_Rec_Itms.Rows.Clear();
            lbl_Sub_Tot.Text = ""; lbl_Tot_Down.Text = ""; lbl_Tot_Full.Text = ""; Totdown = 0; Totfull = 0; Totsub = 0; TotIns = 0;
        }

        private void cmb_Item_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbl_Item_Name.Text = FurDB.readData("select Item_Name from Item where Item_Code='" + cmb_Item_Name.Text + "'", "Item_Name", "");

                lbl_uPrice.Text = "Rs." + FurDB.readData("select Price from Item where Item_Code='" + cmb_Item_Name.Text + "'", "Price", "");


                cmb_Str_Ldr_Name.DataSource = FurDB.getValue("select L_ID from Load_Items where Itm_ID='" + cmb_Item_Name.Text + "'").Tables[0];
                cmb_Str_Ldr_Name.ValueMember = "L_ID";
                cmb_Str_Ldr_Name.Enabled = true;
                cmb_Str_Ldr_Name.SelectedIndex = -1;


            }

            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void btn_clear_Load_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (metroGrid_Rec_Itms.Rows.Count != 0)
            //    {
            //        for (int i = 0; i < metroGrid_Rec_Itms.RowCount - 1; i++)
            //        {
            //            string ST_LD = metroGrid_Rec_Itms.Rows[i].Cells["Load_or_Store"].Value.ToString();
            //            string Itm = metroGrid_Rec_Itms.Rows[i].Cells["Item_Code"].Value.ToString();
            //            string Qua = metroGrid_Rec_Itms.Rows[i].Cells["Quantity"].Value.ToString();

            //            if (FurDB.Insert_Update_Delete("update Load_Items set Quantity=Quantity+'" + Convert.ToInt32(Qua) + "' where L_ID='" + ST_LD + "' and Itm_ID='" + Itm + "'") == 1)
            //            { }
            //        }
            //    }
            //}

            //catch (Exception)
            //{
            //    //MessageBox.Show(ex.Message);
            //    MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    FurDB.CloseCon();
            //}


            cmb_Payment_Type.SelectedIndex = -1; cmb_Item_Name.SelectedIndex = -1; cmb_Str_Ldr_Name.SelectedIndex = -1; cmb_Quantity.SelectedIndex = -1;
            lbl_Item_Name.Text = ""; lbl_uPrice.Text = "";
            txt_Downpayment.Clear(); txt_No_of_Ins.Clear(); txt_Discount_Pcnt.Clear(); txt_Discount_Pcnt.Enabled = true; txt_Downpayment.Enabled = true;
            txt_No_of_Ins.Enabled = true;
        }

        private void btn_Add_Item_Click(object sender, EventArgs e)
        {
            try
            {
                if ((cmb_Payment_Type.SelectedIndex != -1) && (cmb_Item_Name.SelectedIndex != -1) && (cmb_Str_Ldr_Name.SelectedIndex != -1) && (cmb_Quantity.SelectedIndex != -1) && !(txt_Discount_Pcnt.Text.StartsWith("-")) && !(txt_Downpayment.Text.StartsWith("-")) && !(txt_No_of_Ins.Text.StartsWith("-")))
                {
                    if (cmb_Payment_Type.Text == "Full Payment")
                    {

                        if (0 <= Convert.ToDouble(FurDB.readData("select Quantity from Load_Items where L_ID='" + cmb_Str_Ldr_Name.Text + "' and Itm_ID='" + cmb_Item_Name.Text + "'", "Quantity")) - Convert.ToDouble(cmb_Quantity.Text))
                        {
                            NewQan = Convert.ToDouble(FurDB.readData("select Quantity from Load_Items where L_ID='" + cmb_Str_Ldr_Name.Text + "' and Itm_ID='" + cmb_Item_Name.Text + "'", "Quantity")) - Convert.ToDouble(cmb_Quantity.Text);
                            DataGridViewRow row = (DataGridViewRow)metroGrid_Rec_Itms.Rows[0].Clone();
                            row.Cells[0].Value = cmb_Str_Ldr_Name.Text;
                            row.Cells[1].Value = cmb_Payment_Type.Text;
                            row.Cells[2].Value = cmb_Item_Name.Text;
                            row.Cells[3].Value = lbl_Item_Name.Text;
                            row.Cells[4].Value = cmb_Quantity.Text;
                            row.Cells[5].Value = FurDB.readData("select Price from Item where Item_Code='" + cmb_Item_Name.Text + "'", "Price", "").ToString();
                            metroGrid_Rec_Itms.Rows.Add(row);
                            FurDB.Insert_Update_Delete("update Load_Items set Quantity='" + NewQan + "' where L_ID='" + cmb_Str_Ldr_Name.Text + "' and Itm_ID='" + cmb_Item_Name.Text + "'");
                            Totfull += Convert.ToDouble(FurDB.readData("select Price from Item where Item_Code='" + cmb_Item_Name.Text + "'", "Price", "")) * Convert.ToDouble(cmb_Quantity.Text);
                            Totsub = Totfull + Totdown;
                            lbl_Tot_Full.Text = "Rs." + Totfull.ToString();
                            lbl_Sub_Tot.Text = "Rs." + Totsub.ToString();
                        }
                        else
                            MetroFramework.MetroMessageBox.Show(this, "No Balance in the Load!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }

                    else if ((cmb_Payment_Type.Text == "Installment Payment") && (txt_Downpayment.Text.Length != 0) && (txt_Downpayment.Text.Any(char.IsDigit) && (txt_No_of_Ins.Text.Length != 0) && (txt_No_of_Ins.Text.Any(char.IsDigit))))
                    {

                        if (0 <= Convert.ToDouble(FurDB.readData("select Quantity from Load_Items where L_ID='" + cmb_Str_Ldr_Name.Text + "' and Itm_ID='" + cmb_Item_Name.Text + "'", "Quantity")) - Convert.ToDouble(cmb_Quantity.Text))
                        {
                            if (Convert.ToDouble(txt_Downpayment.Text) < Convert.ToDouble(FurDB.readData("select Price from Item where Item_Code='" + cmb_Item_Name.Text + "'", "Price", "")) * Convert.ToDouble(cmb_Quantity.Text))
                            {
                                NewQan = Convert.ToDouble(FurDB.readData("select Quantity from Load_Items where L_ID='" + cmb_Str_Ldr_Name.Text + "' and Itm_ID='" + cmb_Item_Name.Text + "'", "Quantity")) - Convert.ToDouble(cmb_Quantity.Text);
                                DataGridViewRow row = (DataGridViewRow)metroGrid_Rec_Itms.Rows[0].Clone();
                                row.Cells[0].Value = cmb_Str_Ldr_Name.Text;
                                row.Cells[1].Value = cmb_Payment_Type.Text;
                                row.Cells[2].Value = cmb_Item_Name.Text;
                                row.Cells[3].Value = lbl_Item_Name.Text;
                                row.Cells[4].Value = cmb_Quantity.Text;
                                row.Cells[5].Value = FurDB.readData("select Price from Item where Item_Code='" + cmb_Item_Name.Text + "'", "Price", "").ToString();
                                row.Cells[6].Value = txt_Downpayment.Text;
                                row.Cells[7].Value = txt_No_of_Ins.Text;
                                metroGrid_Rec_Itms.Rows.Add(row);
                                FurDB.Insert_Update_Delete("update Load_Items set Quantity='" + NewQan + "' where L_ID='" + cmb_Str_Ldr_Name.Text + "' and Itm_ID='" + cmb_Item_Name.Text + "'");
                                Totdown += Convert.ToDouble(txt_Downpayment.Text);
                                TotIns += Convert.ToDouble(cmb_Quantity.Text) * Convert.ToDouble(FurDB.readData("select Price from Item where Item_Code='" + cmb_Item_Name.Text + "'", "Price", ""));
                                Totsub = Totfull + Totdown;
                                lbl_Tot_Down.Text = "Rs." + Totdown.ToString();
                                lbl_Sub_Tot.Text = "Rs." + Totsub.ToString();
                            }
                            else
                                MetroFramework.MetroMessageBox.Show(this, "Enter a valid Downpayment!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                            MetroFramework.MetroMessageBox.Show(this, "No Balance in the Load!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Please enter all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
