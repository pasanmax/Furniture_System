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
    public partial class Outlet : MetroFramework.Forms.MetroForm
    {
        public Outlet(string un)
        {
            InitializeComponent();
            UN = un;
        }
        FurnitureDB FurDB = new FurnitureDB();
        string UN;
        private void Outlet_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard obj = new Dashboard(UN);
            obj.Show();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard obj = new Dashboard(UN);
            obj.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_search.Text.Length != 0)
                    metroGrid_Outlet.DataSource = FurDB.getData("select Outlet_No as [Outlet No],Outlet_Name as [Outlet Name],AdrsL1 as [Address line 1],AdrsL2 as [Address line 2],AdrsL3 as [Address line 3],Contact_No as [Contact No],Str_ID as [Store No],Store_Name as [Store Name] from Outlet,Store where Str_ID=Store_No and Outlet_Name like '" + txt_search.Text + "%'");

                if (txt_search.Text.Length == 0)
                    metroGrid_Outlet.DataSource = FurDB.getData("select Outlet_No as [Outlet No],Outlet_Name as [Outlet Name],AdrsL1 as [Address line 1],AdrsL2 as [Address line 2],AdrsL3 as [Address line 3],Contact_No as [Contact No],Str_ID as [Store No],Store_Name as [Store Name] from Outlet,Store where Str_ID=Store_No");
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_Outlet_No.Text.Length != 0) && (txt_Outlet_Name.Text.Length != 0) && (txt_AdrsL1.Text.Length != 0) && (txt_AdrsL2.Text.Length != 0) && !(cmb_Store.SelectedIndex == -1) && (txt_Outlet_Contact_No.Text.Length == 10) && (txt_Outlet_Contact_No.Text.Any(char.IsDigit)) && txt_Outlet_Name.Text.All(char.IsLetter))
                    if (FurDB.Insert_Update_Delete("insert into Outlet values ('" + txt_Outlet_No.Text + "','" + txt_Outlet_Name.Text + "','" + txt_AdrsL1.Text + "','" + txt_AdrsL2.Text + "','" + txt_AdrsL3.Text + "','" + txt_Outlet_Contact_No.Text + "','" + cmb_Store.Text + "')") == 1)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Outlet Added Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_Outlet_No.Clear(); txt_Outlet_Name.Clear(); txt_AdrsL1.Clear(); txt_AdrsL2.Clear(); txt_AdrsL3.Clear(); cmb_Store.SelectedIndex = -1; txt_Outlet_Contact_No.Clear();
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Outlet Cannot Add!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MetroFramework.MetroMessageBox.Show(this, "Please enter all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_Outlet_No.Clear(); txt_Outlet_Name.Clear(); txt_AdrsL1.Clear(); txt_AdrsL2.Clear(); txt_AdrsL3.Clear(); cmb_Store.SelectedIndex = -1;
        }

        private void Outlet_Load(object sender, EventArgs e)
        {
            try
            {
                cmb_Store.DataSource = FurDB.getValue("select Store_No from Store").Tables[0];
                cmb_Store.ValueMember = "Store_No";
                cmb_Store.Enabled = true;
                cmb_Store.SelectedIndex = -1;

                cmb_Store_edit.DataSource = FurDB.getValue("select Store_No from Store").Tables[0];
                cmb_Store_edit.ValueMember = "Store_No";
                cmb_Store_edit.Enabled = true;
                cmb_Store_edit.SelectedIndex = -1;

                cmb_Salesman_No.DataSource = FurDB.getValue("select Salesman_ID from Salesman where Salesman.Ac_Type='Outlet Salesman Officer'").Tables[0];
                cmb_Salesman_No.ValueMember = "Salesman_ID";
                cmb_Salesman_No.Enabled = true;
                cmb_Salesman_No.SelectedIndex = -1;

                //metroGrid_Outlet_Sales.DataSource = FurDB.getData("select s.Salesman_ID as [Salesman ID],f.Receipt_No as [Receipt No],f.Cus_ID as [Customer NIC],f.Total_Amount as [Total Amount/Downpayment],f.Payment_Type as [Payment Type],f.Date as [Receipt Date] from Full_Receipt f, Salesman s where s.Ac_Type = 'Outlet Salesman Officer' union select s.Salesman_ID as [Salesman ID], i.Receipt_No as [Receipt No], i.Cust_ID as [Customer NIC], b.Downpayment as [Total Amount / Downpayment], i.Payment_Type as [Payment Type], i.Date as [Receipt Date] from Installment_Receipt i, Item_Bought_Ins b, Salesman s where s.Ac_Type = 'Outlet Salesman Officer' and i.Receipt_No = b.Rcipt_No");
            }

            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }

        }

        private void cmb_Store_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbl_Str_Name.Text = FurDB.readData("select Store_Name from Store where Store_No='" + cmb_Store.Text + "'", "Store_Name", "");
            }

            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void btn_search2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_search2.Text.Length != 0)
                    metroGrid_Out_Edit.DataSource = FurDB.getData("select Outlet_No as [Outlet No],Outlet_Name as [Outlet Name],AdrsL1 as [Address line 1],AdrsL2 as [Address line 2],AdrsL3 as [Address line 3],Contact_No as [Contact No],Str_ID as [Store No],Store_Name as [Store Name] from Outlet,Store where Str_ID=Store_No and Outlet_Name like '" + txt_search.Text + "%'");

                if (txt_search2.Text.Length == 0)
                    metroGrid_Out_Edit.DataSource = FurDB.getData("select Outlet_No as [Outlet No],Outlet_Name as [Outlet Name],AdrsL1 as [Address line 1],AdrsL2 as [Address line 2],AdrsL3 as [Address line 3],Contact_No as [Contact No],Str_ID as [Store No],Store_Name as [Store Name] from Outlet,Store where Str_ID=Store_No");
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_Outlet_No_Edit.Text.Length != 0) && (txt_Outlet_Name_Edit.Text.Length != 0) && (txt_Outlet_AdrsL1_Edit.Text.Length != 0) && (txt_Outlet_Adrsl2_Edit.Text.Length != 0) && (txt_Outlet_Contact_No_Edit.Text.Length == 10) && (txt_Outlet_Contact_No_Edit.Text.Any(char.IsDigit) && !(cmb_Store_edit.SelectedIndex == -1)) && txt_Outlet_Name_Edit.Text.All(char.IsLetter))
                    if (FurDB.Insert_Update_Delete("update Outlet set Outlet_No='" + txt_Outlet_No_Edit.Text + "',Outlet_Name='" + txt_Outlet_Name_Edit.Text + "',AdrsL1='" + txt_Outlet_AdrsL1_Edit.Text + "',AdrsL2='" + txt_Outlet_Adrsl2_Edit.Text + "',AdrsL3='" + txt_Outlet_Adrsl3_Edit.Text + "',Contact_No='" + txt_Outlet_Contact_No_Edit.Text + "',Str_ID='" + cmb_Store_edit.Text + "' where Outlet_No='"+txt_Outlet_No_Edit.Text+"'") == 1)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_Outlet_No_Edit.Clear(); txt_Outlet_Name_Edit.Clear(); txt_Outlet_AdrsL1_Edit.Clear(); txt_Outlet_Adrsl2_Edit.Clear(); txt_Outlet_Adrsl3_Edit.Clear(); txt_Outlet_Contact_No_Edit.Clear(); cmb_Store_edit.SelectedIndex = -1; lbl_Str_Name_Edit.Text = ""; txt_search2.Clear(); metroGrid_Out_Edit.DataSource = null;
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Data cannot update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MetroFramework.MetroMessageBox.Show(this, "Please enter all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_Outlet_No_Edit.Text.Length != 0) && (txt_Outlet_Name_Edit.Text.Length != 0) && (txt_Outlet_AdrsL1_Edit.Text.Length != 0) && (txt_Outlet_Adrsl2_Edit.Text.Length != 0) && (txt_Outlet_Contact_No_Edit.Text.Length == 10) && (txt_Outlet_Contact_No_Edit.Text.Any(char.IsDigit) && !(cmb_Store_edit.SelectedIndex == -1)))
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Do  you want to remove?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        if (FurDB.Insert_Update_Delete("delete from Outlet where Outlet_No='" + txt_Outlet_No_Edit.Text + "'") == 1)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Outlet removed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_Outlet_No_Edit.Clear(); txt_Outlet_Name_Edit.Clear(); txt_Outlet_AdrsL1_Edit.Clear(); txt_Outlet_Adrsl2_Edit.Clear(); txt_Outlet_Adrsl3_Edit.Clear(); txt_Outlet_Contact_No_Edit.Clear(); cmb_Store_edit.SelectedIndex = -1; lbl_Str_Name_Edit.Text = ""; txt_search2.Clear(); metroGrid_Out_Edit.DataSource = null;
                        }
                        else
                            MetroFramework.MetroMessageBox.Show(this, "Data cannot remove!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "Please enter all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void btn_clear_Edit_Click(object sender, EventArgs e)
        {
            txt_Outlet_No_Edit.Clear(); txt_Outlet_Name_Edit.Clear(); txt_Outlet_AdrsL1_Edit.Clear(); txt_Outlet_Adrsl2_Edit.Clear(); txt_Outlet_Adrsl3_Edit.Clear(); txt_Outlet_Contact_No_Edit.Clear(); cmb_Store_edit.SelectedIndex = -1; lbl_Str_Name_Edit.Text = ""; txt_search2.Clear(); metroGrid_Out_Edit.DataSource = null;
        }

        private void metroGrid_Out_Edit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Outlet_No_Edit.Text = metroGrid_Out_Edit.CurrentRow.Cells[0].Value.ToString();
            txt_Outlet_Name_Edit.Text = metroGrid_Out_Edit.CurrentRow.Cells[1].Value.ToString();
            txt_Outlet_AdrsL1_Edit.Text = metroGrid_Out_Edit.CurrentRow.Cells[2].Value.ToString();
            txt_Outlet_Adrsl2_Edit.Text = metroGrid_Out_Edit.CurrentRow.Cells[3].Value.ToString();
            txt_Outlet_Adrsl3_Edit.Text = metroGrid_Out_Edit.CurrentRow.Cells[4].Value.ToString();
            txt_Outlet_Contact_No_Edit.Text = metroGrid_Out_Edit.CurrentRow.Cells[5].Value.ToString();
            cmb_Store_edit.Text = metroGrid_Out_Edit.CurrentRow.Cells[6].Value.ToString();
            lbl_Str_Name_Edit.Text = metroGrid_Out_Edit.CurrentRow.Cells[7].Value.ToString();
        }

        private void cmb_Store_edit_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbl_Str_Name_Edit.Text = FurDB.readData("select Store_Name from Store where Store_No='" + cmb_Store_edit.Text + "'", "Store_Name", "");
            }

            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void btn_search3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_search3.Text.Length != 0)
                    metroGrid_Outlet_Sales.DataSource = FurDB.getData("select s.Salesman_ID as [Salesman ID],f.Receipt_No as [Receipt No],f.Cus_ID as [Customer NIC],f.Total_Amount as [Total Amount/Downpayment],f.Payment_Type as [Payment Type],f.Date as [Receipt Date] from Full_Receipt f, Salesman s where s.Ac_Type = 'Outlet Salesman Officer' and f.Cus_ID like '" + txt_search3.Text + "%' union select s.Salesman_ID as [Salesman ID], i.Receipt_No as [Receipt No], i.Cust_ID as [Customer NIC], b.Downpayment as [Total Amount / Downpayment], i.Payment_Type as [Payment Type], i.Date as [Receipt Date] from Installment_Receipt i, Item_Bought_Ins b, Salesman s where s.Ac_Type = 'Outlet Salesman Officer' and i.Receipt_No = b.Rcipt_No and i.Cust_ID like '" + txt_search3.Text + "%'");

                if (txt_search3.Text.Length == 0)
                    metroGrid_Outlet_Sales.DataSource = FurDB.getData("select s.Salesman_ID as [Salesman ID],f.Receipt_No as [Receipt No],f.Cus_ID as [Customer NIC],f.Total_Amount as [Total Amount/Downpayment],f.Payment_Type as [Payment Type],f.Date as [Receipt Date] from Full_Receipt f, Salesman s where s.Ac_Type = 'Outlet Salesman Officer' union select s.Salesman_ID as [Salesman ID], i.Receipt_No as [Receipt No], i.Cust_ID as [Customer NIC], b.Downpayment as [Total Amount / Downpayment], i.Payment_Type as [Payment Type], i.Date as [Receipt Date] from Installment_Receipt i, Item_Bought_Ins b, Salesman s where s.Ac_Type = 'Outlet Salesman Officer' and i.Receipt_No = b.Rcipt_No");
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void cmb_Salesman_No_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if ((cmb_Payment_Type.SelectedIndex == -1) && (txt_search3.Text.Length == 0))
                    metroGrid_Outlet_Sales.DataSource = FurDB.getData("select s.Salesman_ID as [Salesman ID],f.Receipt_No as [Receipt No],f.Cus_ID as [Customer NIC],f.Total_Amount as [Total Amount/Downpayment],f.Payment_Type as [Payment Type],f.Date as [Receipt Date] from Full_Receipt f, Salesman s where s.Ac_Type = 'Outlet Salesman Officer' and f.Full_SM = '" + cmb_Salesman_No.Text + "' union select s.Salesman_ID as [Salesman ID], i.Receipt_No as [Receipt No], i.Cust_ID as [Customer NIC], b.Downpayment as [Total Amount / Downpayment], i.Payment_Type as [Payment Type], i.Date as [Receipt Date] from Installment_Receipt i, Item_Bought_Ins b, Salesman s where s.Ac_Type = 'Outlet Salesman Officer' and i.Receipt_No = b.Rcipt_No and i.Ins_SM = '" + cmb_Salesman_No.Text + "'");
                else if ((cmb_Payment_Type.SelectedIndex == 0) && (txt_search3.Text.Length == 0))
                    metroGrid_Outlet_Sales.DataSource = FurDB.getData("select s.Salesman_ID as [Salesman ID],f.Receipt_No as [Receipt No],f.Cus_ID as [Customer NIC],f.Total_Amount as [Total Amount/Downpayment],f.Payment_Type as [Payment Type],f.Date as [Receipt Date] from Full_Receipt f, Salesman s where s.Ac_Type = 'Outlet Salesman Officer' and f.Full_SM = '" + cmb_Salesman_No.Text + "'");
                else if ((cmb_Payment_Type.SelectedIndex == 1) && (txt_search3.Text.Length == 0))
                    metroGrid_Outlet_Sales.DataSource = FurDB.getData("select s.Salesman_ID as [Salesman ID],i.Receipt_No as [Receipt No],i.Cust_ID as [Customer NIC],b.Downpayment as [Total Amount/Downpayment],i.Payment_Type as [Payment Type],i.Date as [Receipt Date] from Installment_Receipt i, Item_Bought_Ins b, Salesman s where s.Ac_Type = 'Outlet Salesman Officer' and i.Receipt_No = b.Rcipt_No and i.Ins_SM = '" + cmb_Salesman_No.Text + "'");
                else if ((cmb_Payment_Type.SelectedIndex == -1) && (txt_search3.Text.Length != 0))
                    metroGrid_Outlet_Sales.DataSource = FurDB.getData("select s.Salesman_ID as [Salesman ID],f.Receipt_No as [Receipt No],f.Cus_ID as [Customer NIC],f.Total_Amount as [Total Amount/Downpayment],f.Payment_Type as [Payment Type],f.Date as [Receipt Date] from Full_Receipt f, Salesman s where s.Ac_Type = 'Outlet Salesman Officer' and f.Full_SM = '" + cmb_Salesman_No.Text + "' and f.Cus_ID like '" + txt_search3.Text + "%' union select s.Salesman_ID as [Salesman ID], i.Receipt_No as [Receipt No], i.Cust_ID as [Customer NIC], b.Downpayment as [Total Amount / Downpayment], i.Payment_Type as [Payment Type], i.Date as [Receipt Date] from Installment_Receipt i, Item_Bought_Ins b, Salesman s where s.Ac_Type = 'Outlet Salesman Officer' and i.Receipt_No = b.Rcipt_No and i.Ins_SM = '" + cmb_Salesman_No.Text + "' and i.Cust_ID like '" + txt_search3.Text + "%'");
                else if ((cmb_Payment_Type.SelectedIndex == 0) && (txt_search3.Text.Length != 0))
                    metroGrid_Outlet_Sales.DataSource = FurDB.getData("select s.Salesman_ID as [Salesman ID],f.Receipt_No as [Receipt No],f.Cus_ID as [Customer NIC],f.Total_Amount as [Total Amount/Downpayment],f.Payment_Type as [Payment Type],f.Date as [Receipt Date] from Full_Receipt f, Salesman s where s.Ac_Type = 'Outlet Salesman Officer' and f.Full_SM = '" + cmb_Salesman_No.Text + "' and f.Cus_ID like '" + txt_search3.Text + "%'");
                else if ((cmb_Payment_Type.SelectedIndex == 1) && (txt_search3.Text.Length != 0))
                    metroGrid_Outlet_Sales.DataSource = FurDB.getData("select s.Salesman_ID as [Salesman ID],i.Receipt_No as [Receipt No],i.Cust_ID as [Customer NIC],b.Downpayment as [Total Amount/Downpayment],i.Payment_Type as [Payment Type],i.Date as [Receipt Date] from Installment_Receipt i, Item_Bought_Ins b, Salesman s where s.Ac_Type = 'Outlet Salesman Officer' and i.Receipt_No = b.Rcipt_No and i.Ins_SM = '" + cmb_Salesman_No.Text + "' and i.Cust_ID like '" + txt_search3.Text + "%'");
            }

            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void cmb_Payment_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if ((cmb_Salesman_No.SelectedIndex == -1) && (txt_search3.Text.Length == 0))
                    metroGrid_Outlet_Sales.DataSource = FurDB.getData("select s.Salesman_ID as [Salesman ID],f.Receipt_No as [Receipt No],f.Cus_ID as [Customer NIC],f.Total_Amount as [Total Amount/Downpayment],f.Payment_Type as [Payment Type],f.Date as [Receipt Date] from Full_Receipt f, Salesman s where s.Ac_Type = 'Outlet Salesman Officer' and f.Payment_Type = '" + cmb_Payment_Type.Text + "' union select s.Salesman_ID as [Salesman ID], i.Receipt_No as [Receipt No], i.Cust_ID as [Customer NIC], b.Downpayment as [Total Amount / Downpayment], i.Payment_Type as [Payment Type], i.Date as [Receipt Date] from Installment_Receipt i, Item_Bought_Ins b, Salesman s where s.Ac_Type = 'Outlet Salesman Officer' and i.Receipt_No = b.Rcipt_No and i.Payment_Type = '" + cmb_Payment_Type.Text + "'");
                else if ((cmb_Salesman_No.SelectedIndex != -1) && (txt_search3.Text.Length == 0))
                    metroGrid_Outlet_Sales.DataSource = FurDB.getData("select s.Salesman_ID as [Salesman ID],f.Receipt_No as [Receipt No],f.Cus_ID as [Customer NIC],f.Total_Amount as [Total Amount/Downpayment],f.Payment_Type as [Payment Type],f.Date as [Receipt Date] from Full_Receipt f, Salesman s where s.Ac_Type = 'Outlet Salesman Officer' and f.Payment_Type = '" + cmb_Payment_Type.Text + "' and f.Full_SM = '" + cmb_Salesman_No.Text + "' union select s.Salesman_ID as [Salesman ID], i.Receipt_No as [Receipt No], i.Cust_ID as [Customer NIC], b.Downpayment as [Total Amount / Downpayment], i.Payment_Type as [Payment Type], i.Date as [Receipt Date] from Installment_Receipt i, Item_Bought_Ins b, Salesman s where s.Ac_Type = 'Outlet Salesman Officer' and i.Receipt_No = b.Rcipt_No and i.Payment_Type = '" + cmb_Payment_Type.Text + "' and i.Ins_SM = '" + cmb_Salesman_No.Text + "'");
                else if ((cmb_Salesman_No.SelectedIndex == -1) && (txt_search3.Text.Length != 0))
                    metroGrid_Outlet_Sales.DataSource = FurDB.getData("select s.Salesman_ID as [Salesman ID],f.Receipt_No as [Receipt No],f.Cus_ID as [Customer NIC],f.Total_Amount as [Total Amount/Downpayment],f.Payment_Type as [Payment Type],f.Date as [Receipt Date] from Full_Receipt f, Salesman s where s.Ac_Type = 'Outlet Salesman Officer' and f.Payment_Type = '" + cmb_Payment_Type.Text + "' and f.Cus_ID like '" + txt_search3.Text + "%' union select s.Salesman_ID as [Salesman ID], i.Receipt_No as [Receipt No], i.Cust_ID as [Customer NIC], b.Downpayment as [Total Amount / Downpayment], i.Payment_Type as [Payment Type], i.Date as [Receipt Date] from Installment_Receipt i, Item_Bought_Ins b, Salesman s where s.Ac_Type = 'Outlet Salesman Officer' and i.Receipt_No = b.Rcipt_No and i.Payment_Type = '" + cmb_Payment_Type.Text + "' and i.Cust_ID like '" + txt_search3.Text + "%'");
                else if ((cmb_Salesman_No.SelectedIndex != -1) && (txt_search3.Text.Length != 0))
                    metroGrid_Outlet_Sales.DataSource = FurDB.getData("select s.Salesman_ID as [Salesman ID],f.Receipt_No as [Receipt No],f.Cus_ID as [Customer NIC],f.Total_Amount as [Total Amount/Downpayment],f.Payment_Type as [Payment Type],f.Date as [Receipt Date] from Full_Receipt f, Salesman s where s.Ac_Type = 'Outlet Salesman Officer' and f.Payment_Type = '" + cmb_Payment_Type.Text + "' and f.Cus_ID like '" + txt_search3.Text + "%' and f.Full_SM = '" + cmb_Salesman_No.Text + "' union select s.Salesman_ID as [Salesman ID], i.Receipt_No as [Receipt No], i.Cust_ID as [Customer NIC], b.Downpayment as [Total Amount / Downpayment], i.Payment_Type as [Payment Type], i.Date as [Receipt Date] from Installment_Receipt i, Item_Bought_Ins b, Salesman s where s.Ac_Type = 'Outlet Salesman Officer' and i.Receipt_No = b.Rcipt_No and i.Payment_Type = '" + cmb_Payment_Type.Text + "' and i.Cust_ID like '" + txt_search3.Text + "%' and i.Ins_SM = '" + cmb_Salesman_No.Text + "'");
            }

            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            cmb_Salesman_No.SelectedIndex = -1; cmb_Payment_Type.SelectedIndex = -1; txt_search3.Clear();
            //metroGrid_Outlet_Sales.DataSource = FurDB.getData("select s.Salesman_ID as [Salesman ID],f.Receipt_No as [Receipt No],f.Cus_ID as [Customer NIC],f.Total_Amount as [Total Amount/Downpayment],f.Payment_Type as [Payment Type],f.Date as [Receipt Date] from Full_Receipt f, Salesman s where s.Ac_Type = 'Outlet Salesman Officer' union select s.Salesman_ID as [Salesman ID], i.Receipt_No as [Receipt No], i.Cust_ID as [Customer NIC], b.Downpayment as [Total Amount / Downpayment], i.Payment_Type as [Payment Type], i.Date as [Receipt Date] from Installment_Receipt i, Item_Bought_Ins b, Salesman s where s.Ac_Type = 'Outlet Salesman Officer' and i.Receipt_No = b.Rcipt_No");
        }
    }
}
