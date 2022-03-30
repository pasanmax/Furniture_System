using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
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
    public partial class Reports : MetroFramework.Forms.MetroForm
    {
        public Reports(string un)
        {
            InitializeComponent();
            UN = un;
        }
        FurnitureDB FurDB = new FurnitureDB();
        double NewQan;
        string UN;

        private void Reports_FormClosing(object sender, FormClosingEventArgs e)
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
                        else
                            FurDB.Insert_Update_Delete("update Store_Items set Quantity=Quantity+'" + Convert.ToInt32(Qua) + "' where Stor_ID='" + ST_LD + "' and Item_CD='" + Itm + "'");
                    }
                }
            }

            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }


            Dashboard obj = new Dashboard(UN);
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
                        else
                            FurDB.Insert_Update_Delete("update Store_Items set Quantity=Quantity+'" + Convert.ToInt32(Qua) + "' where Stor_ID='" + ST_LD + "' and Item_CD='" + Itm + "'");
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
            Dashboard obj = new Dashboard(UN);
            obj.Show();
        }

        private void Reports_Load(object sender, EventArgs e)
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

                cmb_Status.SelectedIndex = -1;
                

                for (int i=0;i<8;i++)
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
                                Totfull = Totfull - (Totfull*Convert.ToInt32(txt_Discount_Pcnt.Text) * 0.01);
                            }

                            for (int i = 0; i < metroGrid_Rec_Itms.RowCount - 1; i++)
                            {
                                if (metroGrid_Rec_Itms.Rows[i].Cells["Payment_Type"].Value.ToString() == "Full Payment")
                                {
                                    if (FurDB.readData("select * from Full_Receipt where Receipt_No='"+txt_Receipt_No.Text+"'")==false)
                                    {
                                        FurDB.Insert_Update_Delete("insert into Full_Receipt (Receipt_No,Total_Amount,Payment_Type,Discount,Cus_ID,Full_SM) values ('" + txt_Receipt_No.Text + "','" + Totfull + "','" + metroGrid_Rec_Itms.Rows[i].Cells["Payment_Type"].Value.ToString() + "','" + dis + "','" + txt_NIC.Text + "','Admin')");
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
                                        FurDB.Insert_Update_Delete("insert into Installment_Receipt (Receipt_No,Total_Amount,Payment_Type,Cust_ID,Ins_SM) values('" + txt_Receipt_No.Text + "','" + TotIns + "','" + metroGrid_Rec_Itms.Rows[i].Cells["Payment_Type"].Value.ToString() + "','" + txt_NIC.Text + "','Admin')");
                                        FurDB.Insert_Update_Delete("insert into Item_Bought_Ins values('" + txt_Receipt_No.Text + "','" + txt_NIC.Text + "','" + metroGrid_Rec_Itms.Rows[i].Cells["Item_Code"].Value.ToString() + "','" + Convert.ToDouble(metroGrid_Rec_Itms.Rows[i].Cells["Downpayment"].Value.ToString()) + "','" + Convert.ToInt32(metroGrid_Rec_Itms.Rows[i].Cells["No_of_Installments"].Value.ToString()) + "','" + Convert.ToInt32(metroGrid_Rec_Itms.Rows[i].Cells["Quantity"].Value.ToString()) + "','" + Convert.ToDouble(metroGrid_Rec_Itms.Rows[i].Cells["Unit_Price"].Value.ToString()) + "')");
                                        //InsAmount = (TotIns - Totdown) / Convert.ToInt32(metroGrid_Rec_Itms.Rows[i].Cells["No_of_Installments"].Value.ToString());

                                        InsAmount = ((Convert.ToDouble(metroGrid_Rec_Itms.Rows[i].Cells["Unit_Price"].Value.ToString())*Convert.ToInt32(metroGrid_Rec_Itms.Rows[i].Cells["Quantity"].Value.ToString()))-Convert.ToDouble(metroGrid_Rec_Itms.Rows[i].Cells["Downpayment"].Value.ToString()))/Convert.ToInt32(metroGrid_Rec_Itms.Rows[i].Cells["No_of_Installments"].Value.ToString());

                                        for (int j = 1; j <= (Convert.ToInt32(metroGrid_Rec_Itms.Rows[i].Cells["No_of_Installments"].Value.ToString())); j++)
                                        {
                                            FurDB.Insert_Update_Delete("insert into Installment_Date (Rec_No,InItm_Code,Installment_Date,Installment_Amount,Status,SM_ID) values('" + txt_Receipt_No.Text + "','" + metroGrid_Rec_Itms.Rows[i].Cells["Item_Code"].Value.ToString() + "','" + date.AddMonths(j) + "','" + InsAmount + "','Not Paid','" + UN + "')");
                                        }
                                    }
                                    else
                                    {
                                        FurDB.Insert_Update_Delete("insert into Item_Bought_Ins values('" + txt_Receipt_No.Text + "','" + txt_NIC.Text + "','" + metroGrid_Rec_Itms.Rows[i].Cells["Item_Code"].Value.ToString() + "','" + Convert.ToDouble(metroGrid_Rec_Itms.Rows[i].Cells["Downpayment"].Value.ToString()) + "','" + Convert.ToInt32(metroGrid_Rec_Itms.Rows[i].Cells["No_of_Installments"].Value.ToString()) + "','" + Convert.ToInt32(metroGrid_Rec_Itms.Rows[i].Cells["Quantity"].Value.ToString()) + "','" + Convert.ToDouble(metroGrid_Rec_Itms.Rows[i].Cells["Unit_Price"].Value.ToString()) + "')");
                                        //InsAmount = (TotIns - Totdown) / Convert.ToInt32(metroGrid_Rec_Itms.Rows[i].Cells["No_of_Installments"].Value.ToString());

                                        InsAmount = ((Convert.ToDouble(metroGrid_Rec_Itms.Rows[i].Cells["Unit_Price"].Value.ToString()) * Convert.ToInt32(metroGrid_Rec_Itms.Rows[i].Cells["Quantity"].Value.ToString())) - Convert.ToDouble(metroGrid_Rec_Itms.Rows[i].Cells["Downpayment"].Value.ToString())) / Convert.ToInt32(metroGrid_Rec_Itms.Rows[i].Cells["No_of_Installments"].Value.ToString());

                                        for (int j = 1; j <= (Convert.ToInt32(metroGrid_Rec_Itms.Rows[i].Cells["No_of_Installments"].Value.ToString())); j++)
                                        {
                                            FurDB.Insert_Update_Delete("insert into Installment_Date (Rec_No,InItm_Code,Installment_Date,Installment_Amount,Status,SM_ID) values('" + txt_Receipt_No.Text + "','" + metroGrid_Rec_Itms.Rows[i].Cells["Item_Code"].Value.ToString() + "','" + date.AddMonths(j) + "','" + InsAmount + "','Not Paid','" + UN + "')");
                                        }
                                    }
                                }
                                
                            }
                            MetroFramework.MetroMessageBox.Show(this, "Successfull!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Receipt obj = new Receipt(txt_Receipt_No.Text,txt_NIC.Text);
                            obj.Show();
                            cmb_Payment_Type.SelectedIndex = -1; cmb_Item_Name.SelectedIndex = -1; cmb_Str_Ldr_Name.SelectedIndex = -1; cmb_Quantity.SelectedIndex = -1;
                            ckbox_From_Store.Checked = false; lbl_Item_Name.Text = ""; lbl_Str_Ld_Name.Text = ""; lbl_uPrice.Text = "";
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
        double Totdown, Totfull,Totsub,TotIns;
        private void btn_Add_Item_Click(object sender, EventArgs e)
        {
            try
            {
                if ((cmb_Payment_Type.SelectedIndex != -1) && (cmb_Item_Name.SelectedIndex != -1) && (cmb_Str_Ldr_Name.SelectedIndex != -1) && (cmb_Quantity.SelectedIndex != -1) && !(txt_Discount_Pcnt.Text.StartsWith("-")) && !(txt_Downpayment.Text.StartsWith("-")) && !(txt_No_of_Ins.Text.StartsWith("-")))
                {
                    if (cmb_Payment_Type.Text== "Full Payment")
                    {
                        if (ckbox_From_Store.CheckState==CheckState.Checked)
                        {
                            if (0 <= Convert.ToDouble(FurDB.readData("select Quantity from Store_Items where Stor_ID='" + cmb_Str_Ldr_Name.Text + "' and Item_CD='" + cmb_Item_Name.Text + "'", "Quantity"))- Convert.ToDouble(cmb_Quantity.Text))
                            {
                                NewQan = Convert.ToDouble(FurDB.readData("select Quantity from Store_Items where Stor_ID='" + cmb_Str_Ldr_Name.Text + "' and Item_CD='" + cmb_Item_Name.Text + "'", "Quantity")) - Convert.ToDouble(cmb_Quantity.Text);
                                DataGridViewRow row = (DataGridViewRow)metroGrid_Rec_Itms.Rows[0].Clone();
                                row.Cells[0].Value = cmb_Str_Ldr_Name.Text;
                                row.Cells[1].Value = cmb_Payment_Type.Text;
                                row.Cells[2].Value = cmb_Item_Name.Text;
                                row.Cells[3].Value = lbl_Item_Name.Text;
                                row.Cells[4].Value = cmb_Quantity.Text;
                                row.Cells[5].Value = FurDB.readData("select Price from Item where Item_Code='" + cmb_Item_Name.Text + "'", "Price", "").ToString();
                                metroGrid_Rec_Itms.Rows.Add(row);
                                FurDB.Insert_Update_Delete("update Store_Items set Quantity='" + NewQan + "' where Stor_ID='" + cmb_Str_Ldr_Name.Text + "' and Item_CD='" + cmb_Item_Name.Text + "'");
                                Totfull += Convert.ToDouble(FurDB.readData("select Price from Item where Item_Code='" + cmb_Item_Name.Text + "'", "Price", "")) * Convert.ToDouble(cmb_Quantity.Text);
                                
                                Totsub = Totfull + Totdown;
                                lbl_Tot_Full.Text = "Rs."+Totfull.ToString();
                                lbl_Sub_Tot.Text = "Rs." + Totsub.ToString();
                            }
                            else
                                MetroFramework.MetroMessageBox.Show(this, "No Balance in the Store!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (ckbox_From_Store.CheckState==CheckState.Unchecked)
                        {
                            if (0 <= Convert.ToDouble(FurDB.readData("select Quantity from Load_Items where L_ID='" + cmb_Str_Ldr_Name.Text + "' and Itm_ID='" + cmb_Item_Name.Text + "'", "Quantity"))- Convert.ToDouble(cmb_Quantity.Text))
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
                        
                    }

                    else if ((cmb_Payment_Type.Text== "Installment Payment")&&(txt_Downpayment.Text.Length!=0)&&(txt_Downpayment.Text.Any(char.IsDigit)&&(txt_No_of_Ins.Text.Length!=0)&&(txt_No_of_Ins.Text.Any(char.IsDigit))))
                    {
                        if (ckbox_From_Store.CheckState==CheckState.Checked)
                        {
                            if (0 <= Convert.ToDouble(FurDB.readData("select Quantity from Store_Items where Stor_ID='" + cmb_Str_Ldr_Name.Text + "' and Item_CD='" + cmb_Item_Name.Text + "'", "Quantity"))- Convert.ToDouble(cmb_Quantity.Text))
                            {
                                if (Convert.ToDouble(txt_Downpayment.Text)< Convert.ToDouble(FurDB.readData("select Price from Item where Item_Code='" + cmb_Item_Name.Text + "'", "Price", ""))*Convert.ToDouble(cmb_Quantity.Text))
                                {
                                    NewQan = Convert.ToDouble(FurDB.readData("select Quantity from Store_Items where Stor_ID='" + cmb_Str_Ldr_Name.Text + "' and Item_CD='" + cmb_Item_Name.Text + "'", "Quantity")) - Convert.ToDouble(cmb_Quantity.Text);
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
                                    FurDB.Insert_Update_Delete("update Store_Items set Quantity='" + NewQan + "' where Stor_ID='" + cmb_Str_Ldr_Name.Text + "' and Item_CD='" + cmb_Item_Name.Text + "'");
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
                                MetroFramework.MetroMessageBox.Show(this, "No Balance in the Store!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (ckbox_From_Store.CheckState==CheckState.Unchecked)
                        {
                            if (0 <= Convert.ToDouble(FurDB.readData("select Quantity from Load_Items where L_ID='" + cmb_Str_Ldr_Name.Text + "' and Itm_ID='" + cmb_Item_Name.Text + "'", "Quantity"))- Convert.ToDouble(cmb_Quantity.Text))
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

        private void btn_clear_Load_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (metroGrid_Rec_Itms.Rows.Count != 0)
            //    {
            //        for (int i = 0; i < metroGrid_Rec_Itms.RowCount-1; i++)
            //        {
            //            string ST_LD = metroGrid_Rec_Itms.Rows[i].Cells["Load_or_Store"].Value.ToString();
            //            string Itm = metroGrid_Rec_Itms.Rows[i].Cells["Item_Code"].Value.ToString();
            //            string Qua = metroGrid_Rec_Itms.Rows[i].Cells["Quantity"].Value.ToString();

            //            if (FurDB.Insert_Update_Delete("update Load_Items set Quantity=Quantity+'" + Convert.ToInt32(Qua) + "' where L_ID='" + ST_LD + "' and Itm_ID='" + Itm + "'") == 1)
            //            {}
            //            else
            //                FurDB.Insert_Update_Delete("update Store_Items set Quantity=Quantity+'" + Convert.ToInt32(Qua) + "' where Stor_ID='" + ST_LD + "' and Item_CD='" + Itm + "'");
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
            ckbox_From_Store.Checked = false; lbl_Item_Name.Text = ""; lbl_Str_Ld_Name.Text = ""; lbl_uPrice.Text = "";
            txt_Downpayment.Clear(); txt_No_of_Ins.Clear(); txt_Discount_Pcnt.Clear(); txt_Discount_Pcnt.Enabled = true; txt_Downpayment.Enabled = true;
            txt_No_of_Ins.Enabled = true;
        }

        private void cmb_Item_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbl_Item_Name.Text = FurDB.readData("select Item_Name from Item where Item_Code='" + cmb_Item_Name.Text + "'", "Item_Name", "");
                lbl_Str_Ld_Name.Text = "";

                lbl_uPrice.Text = "Rs." + FurDB.readData("select Price from Item where Item_Code='" + cmb_Item_Name.Text + "'", "Price", "");

                if (ckbox_From_Store.Checked == true)
                {
                    cmb_Str_Ldr_Name.DataSource = FurDB.getValue("select Stor_ID from Store_Items where Item_CD='" + cmb_Item_Name.Text + "'").Tables[0];
                    cmb_Str_Ldr_Name.ValueMember = "Stor_ID";
                    cmb_Str_Ldr_Name.Enabled = true;
                    cmb_Str_Ldr_Name.SelectedIndex = -1;
                }
                else
                {
                    cmb_Str_Ldr_Name.DataSource = FurDB.getValue("select L_ID from Load_Items where Itm_ID='" + cmb_Item_Name.Text + "'").Tables[0];
                    cmb_Str_Ldr_Name.ValueMember = "L_ID";
                    cmb_Str_Ldr_Name.Enabled = true;
                    cmb_Str_Ldr_Name.SelectedIndex = -1;

                }
            }

            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void cmb_Str_Ldr_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ckbox_From_Store.Checked == true)
                    lbl_Str_Ld_Name.Text = FurDB.readData("select Store_Name from Store where Store_No='" + cmb_Str_Ldr_Name.Text + "'", "Store_Name", "");
                else if (ckbox_From_Store.Checked == false)
                    lbl_Str_Ld_Name.Text = "";
            }

            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void txt_Discount_Pcnt_Click(object sender, EventArgs e)
        {

        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_View_Receipt_No.Text.Length != 0)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Do  you want to remove?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        if (FurDB.readData("select * from Full_Receipt where Receipt_No='" + txt_View_Receipt_No.Text + "'") == true)
                        {
                            if (FurDB.readData("select * from Installment_Receipt where Receipt_No='" + txt_View_Receipt_No.Text + "'") == true)
                            {
                                if (FurDB.delData("delete_Full", "@Rec", txt_View_Receipt_No.Text) == 0 && FurDB.delData("delete_Ins", "@Rec", txt_View_Receipt_No.Text) == 0)
                                    MetroFramework.MetroMessageBox.Show(this, "Successfully Deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else
                                    MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (FurDB.delData("delete_Full", "@Rec", txt_View_Receipt_No.Text) == 0)
                                    MetroFramework.MetroMessageBox.Show(this, "Successfully Deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else
                                    MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (FurDB.readData("select * from Installment_Receipt where Receipt_No='" + txt_View_Receipt_No.Text + "'") == true)
                        {
                            if (FurDB.readData("select * from Full_Receipt where Receipt_No='" + txt_View_Receipt_No.Text + "'") == true)
                            {
                                if (FurDB.delData("delete_Ins", "@Rec", txt_View_Receipt_No.Text) == 0 && FurDB.delData("delete_Full", "@Rec", txt_View_Receipt_No.Text) == 0)
                                    MetroFramework.MetroMessageBox.Show(this, "Successfully Deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else
                                    MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (FurDB.delData("delete_Ins", "@Rec", txt_View_Receipt_No.Text) == 0)
                                    MetroFramework.MetroMessageBox.Show(this, "Successfully Deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else
                                    MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                            MetroFramework.MetroMessageBox.Show(this, "No Records Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    txt_View_Receipt_No.Clear();
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "Please enter all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
                txt_View_Receipt_No.Clear();
            }

        }

        private void btn_search_Ins_Click(object sender, EventArgs e)
        {
            if (txt_Rec_No.Text.Length != 0)
            {
                this.DataTable_Ins_DateTableAdapter.Fill(this.DataSet4.DataTable_Ins_Date, txt_Rec_No.Text);
                this.DataTable_PaidAmtTableAdapter.Fill(this.DataSet4.DataTable_PaidAmt, txt_Rec_No.Text);
                this.DataTable_Cus_InfoTableAdapter.Fill(this.DataSet4.DataTable_Cus_Info, txt_Rec_No.Text);
                this.reportViewer_Ins_Rep.RefreshReport();
            }
            else
            {
                Not_Paid_Ins not_Paid = new Not_Paid_Ins(date.ToString("yyyy-MM-dd"));
                not_Paid.ShowDialog();
            }
            
        }

        private void Ins_Report_Click(object sender, EventArgs e)
        {

        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            Ins_Report Ins = new Ins_Report(metroDateTime_From.Text,metroDateTime_To.Text);
            Ins.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            txt_Rec_No.Clear();
        }

        private void btn_Search_IRec_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Search_IRec.Text.Length!=0)
                {
                    metroGrid_Ins_Rec.DataSource = FurDB.getData("select i.Rec_No as [Receipt No],i.InItm_Code as [Item No],i.Installment_Date as [Installment Date],i.Installment_Amount as [Installment Amount],i.Status as [Status] from Installment_Date i where i.Rec_No like '" + txt_Search_IRec.Text + "%'");
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
                        if (FurDB.Insert_Update_Delete("update Installment_Date set Status='Not Paid',SM_ID='Admin' where Rec_No='" + txt_IRec_No.Text + "' and Installment_Date='" + Convert.ToDateTime(txt_Ins_Date.Text) + "' and InItm_Code='" + txt_IItem_No.Text + "'") == 1 && FurDB.Insert_Update_Delete("insert into Installment_Date (Rec_No,InItm_Code,Installment_Date,Installment_Amount,Status,SM_ID) values('" + txt_IRec_No.Text + "','" + txt_IItem_No.Text + "','" + dt?.AddMonths(1) + "','" + Convert.ToDouble(txt_Ins_Amt.Text) + "','Not Paid','" + UN + "')") == 1)
                            MetroFramework.MetroMessageBox.Show(this, "Updated Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MetroFramework.MetroMessageBox.Show(this, "Admin cannot Update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!(String.Equals(txt_Status.Text, cmb_Status.Text)) && cmb_Status.SelectedIndex == 0)
                    {
                        if (FurDB.Insert_Update_Delete("update Installment_Date set Status='Paid',SM_ID='Admin' where Rec_No='" + txt_IRec_No.Text + "' and Installment_Date='" + Convert.ToDateTime(txt_Ins_Date.Text) + "' and InItm_Code='" + txt_IItem_No.Text + "'") == 1)
                            MetroFramework.MetroMessageBox.Show(this, "Updated Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MetroFramework.MetroMessageBox.Show(this, "Admin cannot Update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!(String.Equals(txt_Status.Text, cmb_Status.Text)) && cmb_Status.SelectedIndex == 1)
                    {
                        if (FurDB.Insert_Update_Delete("update Installment_Date set Status='Not Paid',SM_ID='Admin' where Rec_No='" + txt_IRec_No.Text + "' and Installment_Date='" + Convert.ToDateTime(txt_Ins_Date.Text) + "' and InItm_Code='" + txt_IItem_No.Text + "'") == 1 && FurDB.Insert_Update_Delete("insert into Installment_Date (Rec_No,InItm_Code,Installment_Date,Installment_Amount,Status,SM_ID) values('" + txt_IRec_No.Text + "','" + txt_IItem_No.Text + "','" + dt?.AddMonths(1) + "','" + Convert.ToDouble(txt_Ins_Amt.Text) + "','Not Paid','" + UN + "')") == 1)
                            MetroFramework.MetroMessageBox.Show(this, "Updated Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MetroFramework.MetroMessageBox.Show(this, "Admin cannot Update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_IRec_No.Text.Length!=0) &&(txt_IItem_No.Text.Length!=0) &&(txt_Ins_Date.Text.Length!=0)&&(txt_Ins_Amt.Text.Length!=0)&&(cmb_Status.SelectedIndex!=-1))
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Do  you want to remove?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        if (FurDB.Insert_Update_Delete("delete from Installment_Date where Rec_No='" + txt_IRec_No.Text + "' and InItm_Code='" + txt_IItem_No.Text + "' and Installment_Date='" + Convert.ToDateTime(txt_Ins_Date.Text) + "'") == 1)
                            MetroFramework.MetroMessageBox.Show(this, "Successfully Deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MetroFramework.MetroMessageBox.Show(this, "Data cannot Delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_Search_SM_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_SM_No.Text.Length != 0 && (cmb_SM_Type.SelectedIndex == -1))
                {
                    ReportParameterCollection rpc = new ReportParameterCollection();
                    rpc.Add(new ReportParameter("ReportParameter_From", metroDateTime_Sales_From.Text));
                    rpc.Add(new ReportParameter("ReportParameter_To", metroDateTime_Sales_To.Text));
                    this.reportViewer_reportViewer_Sales_Rep.LocalReport.SetParameters(rpc);
                    this.DataTable_SM_SalesTableAdapter.Fill(DataSet8.DataTable_SM_Sales, txt_SM_No.Text, metroDateTime_Sales_From.Text, metroDateTime_Sales_To.Text);
                    this.DataTable_SM_InfoTableAdapter.Fill(DataSet8.DataTable_SM_Info, txt_SM_No.Text);
                    this.reportViewer_reportViewer_Sales_Rep.RefreshReport();
                }
                else //if (txt_SM_No.Text.Length == 0 && (cmb_SM_Type.SelectedIndex != -1))
                {
                    //Sales_Report SR = new Sales_Report(cmb_SM_Type.Text, metroDateTime_Sales_From.Text, metroDateTime_Sales_To.Text);
                    //SR.ShowDialog();
                    MetroFramework.MetroMessageBox.Show(this, "Please enter a salesman ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void btn_Clear_SM_Click(object sender, EventArgs e)
        {
            txt_SM_No.Clear(); cmb_SM_Type.SelectedIndex = -1; 
        }

        private void btn_Clear_Stock_Click(object sender, EventArgs e)
        {
            ckbox_Load.Checked = false; ckbox_Store.Checked = false; cmb_Str_Ld.SelectedIndex = -1; lbl_Str_Name.Text = "";
        }

        private void btn_View_Stock_Click(object sender, EventArgs e)
        {
            try
            {
                if ((ckbox_Store.Checked!=false || ckbox_Load.Checked!=false) && cmb_Str_Ld.SelectedIndex!=-1)
                {
                    if (ckbox_Store.Checked == true)
                    {
                        Store_Stock ss = new Store_Stock(cmb_Str_Ld.Text);
                        ss.ShowDialog();
                    }
                    else if (ckbox_Load.Checked == true)
                    {
                        Load_Stock ls = new Load_Stock(cmb_Str_Ld.Text);
                        ls.ShowDialog();
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FurDB.CloseCon();
                }
            }

            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void ckbox_Load_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ckbox_Load.Checked == true)
                {
                    ckbox_Store.CheckState = CheckState.Unchecked;
                    cmb_Str_Ld.DataSource = FurDB.getValue("select Load_No from Load").Tables[0];
                    cmb_Str_Ld.ValueMember = "Load_No";
                    cmb_Str_Ld.Enabled = true;
                    cmb_Str_Ld.SelectedIndex = -1;
                }
                else
                    cmb_Str_Ld.DataSource = null;
                
            }

            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }

        }

        private void ckbox_Store_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ckbox_Store.Checked == true)
                {
                    ckbox_Load.CheckState = CheckState.Unchecked;
                    cmb_Str_Ld.DataSource = FurDB.getValue("select Store_No from Store").Tables[0];
                    cmb_Str_Ld.ValueMember = "Store_No";
                    cmb_Str_Ld.Enabled = true;
                    cmb_Str_Ld.SelectedIndex = -1;
                }
                else
                    cmb_Str_Ld.DataSource = null;

            }

            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void cmb_Str_Ld_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ckbox_Store.Checked==true)
                    lbl_Str_Name.Text = FurDB.readData("select Store_Name from Store where Store_No='" + cmb_Str_Ld.Text + "'", "Store_Name", "");
            }

            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void Print_Receipt_Click(object sender, EventArgs e)
        {

        }

        private void ckbox_From_Store_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ckbox_From_Store.Checked == true)
                {
                    cmb_Str_Ldr_Name.DataSource = FurDB.getValue("select Stor_ID from Store_Items where Item_CD='" + cmb_Item_Name.Text + "'").Tables[0];
                    cmb_Str_Ldr_Name.ValueMember = "Stor_ID";
                    cmb_Str_Ldr_Name.Enabled = true;
                    cmb_Str_Ldr_Name.SelectedIndex = -1;
                }
                else
                {
                    cmb_Str_Ldr_Name.DataSource = FurDB.getValue("select L_ID from Load_Items where Itm_ID='" + cmb_Item_Name.Text + "'").Tables[0];
                    cmb_Str_Ldr_Name.ValueMember = "L_ID";
                    cmb_Str_Ldr_Name.Enabled = true;
                    cmb_Str_Ldr_Name.SelectedIndex = -1;
                }
            }

            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        else
                            FurDB.Insert_Update_Delete("update Store_Items set Quantity=Quantity+'" + Convert.ToInt32(Qua) + "' where Stor_ID='" + ST_LD + "' and Item_CD='" + Itm + "'");
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
            ckbox_From_Store.Checked = false; lbl_Item_Name.Text = ""; lbl_Str_Ld_Name.Text = ""; lbl_uPrice.Text = "";
            txt_Downpayment.Clear(); txt_No_of_Ins.Clear(); txt_Discount_Pcnt.Clear(); txt_Discount_Pcnt.Enabled = true; txt_Downpayment.Enabled = true;
            txt_No_of_Ins.Enabled = true; txt_NIC.Clear(); txt_Receipt_No.Clear(); metroGrid_Rec_Itms.Rows.Clear();
            lbl_Sub_Tot.Text = ""; lbl_Tot_Down.Text = ""; lbl_Tot_Full.Text = ""; Totdown = 0;Totfull = 0;Totsub = 0; TotIns = 0;
        }
    }
}
