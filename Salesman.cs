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
    public partial class Salesman : MetroFramework.Forms.MetroForm
    {
        public Salesman(string un)
        {
            InitializeComponent();
            UN = un;
        }
        FurnitureDB FurDB = new FurnitureDB();
        string UN;
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard obj = new Dashboard(UN);
            obj.Show();
        }

        private void Salesman_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard obj = new Dashboard(UN);
            obj.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_search.Text.Length != 0)
                    metroGrid_Salesman.DataSource = FurDB.getData("select Salesman_ID as [Salesman ID],Fname as [First Name],Lname as [Last Name],NIC as [NIC],Ac_Type as [Account Type],Contact_No as [Contact No] from Salesman where Fname like '" + txt_search.Text + "%'");
                else if (txt_search.Text.Length == 0)
                    metroGrid_Salesman.DataSource = FurDB.getData("select Salesman_ID as [Salesman ID],Fname as [First Name],Lname as [Last Name],NIC as [NIC],Ac_Type as [Account Type],Contact_No as [Contact No] from Salesman");
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
                    metroGrid_Salesman_Details.DataSource = FurDB.getData("select Salesman_ID as [Salesman ID],Fname as [First Name],Lname as [Last Name],NIC as [NIC],Ac_Type as [Account Type],Contact_No as [Contact No] from Salesman where Fname like '" + txt_search2.Text + "%'");
                else if (txt_search2.Text.Length == 0)
                    metroGrid_Salesman_Details.DataSource = FurDB.getData("select Salesman_ID as [Salesman ID],Fname as [First Name],Lname as [Last Name],NIC as [NIC],Ac_Type as [Account Type],Contact_No as [Contact No] from Salesman");
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
                if ((txt_Sm_ID.Text.Length != 0) && (txt_Fname.Text.Length != 0) && (txt_Lname.Text.Length != 0) && (txt_NIC.Text.Length != 0) && (txt_Contact_No.Text.Length != 0) && (txt_Contact_No.Text.Length == 10) && (txt_Contact_No.Text.Any(char.IsDigit)) && (cmb_Ac_Type.SelectedIndex!=-1) && txt_Fname.Text.All(char.IsLetter) && txt_Lname.Text.All(char.IsLetter))
                {
                    if (FurDB.Insert_Update_Delete("update Salesman set Salesman_ID='" + txt_Sm_ID.Text + "',Fname='" + txt_Fname.Text + "',Lname='" + txt_Lname.Text + "',NIC='" + txt_NIC.Text + "',Ac_Type='" + cmb_Ac_Type.Text + "',Contact_No='" + txt_Contact_No.Text + "' where Salesman_ID='" + txt_Sm_ID.Text+"'") == 1)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Updated Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_Sm_ID.Clear(); txt_Fname.Clear(); txt_Lname.Clear(); txt_NIC.Clear(); txt_Contact_No.Clear(); cmb_Ac_Type.SelectedIndex = -1; metroGrid_Salesman_Details.DataSource = null;
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Data cannot Update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_Sm_ID.Text.Length != 0) && (txt_Fname.Text.Length != 0) && (txt_Lname.Text.Length != 0) && (txt_NIC.Text.Length != 0) && (txt_Contact_No.Text.Length != 0) && (txt_Contact_No.Text.Length == 10) && (txt_Contact_No.Text.Any(char.IsDigit)))
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Do  you want to remove?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        if (FurDB.readData("select * from Full_Receipt where Full_SM='"+txt_Sm_ID.Text+"'")==true)
                            MetroFramework.MetroMessageBox.Show(this, "Salesman already sold a Product!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else if (FurDB.readData("select * from Installment_Receipt where Ins_SM='"+txt_Sm_ID.Text+"'")==true)
                            MetroFramework.MetroMessageBox.Show(this, "Salesman already sold a Product!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            if (FurDB.Insert_Update_Delete("delete from Salesman where Salesman_ID='" + txt_Sm_ID.Text + "'") == 1 && FurDB.Insert_Update_Delete("delete from Login_Data where username='" + txt_Sm_ID.Text + "'") == 1)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Salesman removed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txt_Sm_ID.Clear(); txt_Fname.Clear(); txt_Lname.Clear(); txt_NIC.Clear(); txt_Contact_No.Clear(); cmb_Ac_Type.SelectedIndex = -1; metroGrid_Salesman_Details.DataSource = null;
                            }
                            else
                                MetroFramework.MetroMessageBox.Show(this, "Data cannot Delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_Sm_ID.Clear(); txt_Fname.Clear(); txt_Lname.Clear(); txt_NIC.Clear(); txt_Contact_No.Clear(); cmb_Ac_Type.SelectedIndex = -1; metroGrid_Salesman_Details.DataSource = null;
        }

        private void metroGrid_Salesman_Details_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Sm_ID.Text = metroGrid_Salesman_Details.CurrentRow.Cells[0].Value.ToString();
            txt_Fname.Text = metroGrid_Salesman_Details.CurrentRow.Cells[1].Value.ToString();
            txt_Lname.Text = metroGrid_Salesman_Details.CurrentRow.Cells[2].Value.ToString();
            txt_NIC.Text = metroGrid_Salesman_Details.CurrentRow.Cells[3].Value.ToString();
            txt_Contact_No.Text = metroGrid_Salesman_Details.CurrentRow.Cells[5].Value.ToString();
            cmb_Ac_Type.Text = metroGrid_Salesman_Details.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_search3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_search3.Text.Length != 0)
                    metroGrid_Salesman_Sales.DataSource = FurDB.getData("select s.Salesman_ID as [Salesman ID],f.Receipt_No as [Receipt No],f.Cus_ID as [Customer NIC],f.Total_Amount as [Total Amount/Downpayment],f.Payment_Type as [Payment Type],f.Date as [Receipt Date] from Full_Receipt f, Salesman s where s.Ac_Type = 'Salesman Officer' and f.Cus_ID like '" + txt_search3.Text + "%' union select s.Salesman_ID as [Salesman ID], i.Receipt_No as [Receipt No], i.Cust_ID as [Customer NIC], b.Downpayment as [Total Amount / Downpayment], i.Payment_Type as [Payment Type], i.Date as [Receipt Date] from Installment_Receipt i, Item_Bought_Ins b, Salesman s where s.Ac_Type = 'Salesman Officer' and i.Receipt_No=b.Rcipt_No and i.Cust_ID like '" + txt_search3.Text + "%'");

                if (txt_search3.Text.Length == 0)
                    metroGrid_Salesman_Sales.DataSource = FurDB.getData("select s.Salesman_ID as [Salesman ID],f.Receipt_No as [Receipt No],f.Cus_ID as [Customer NIC],f.Total_Amount as [Total Amount/Downpayment],f.Payment_Type as [Payment Type],f.Date as [Receipt Date] from Full_Receipt f, Salesman s where s.Ac_Type = 'Salesman Officer' union select s.Salesman_ID as [Salesman ID], i.Receipt_No as [Receipt No], i.Cust_ID as [Customer NIC], b.Downpayment as [Total Amount / Downpayment], i.Payment_Type as [Payment Type], i.Date as [Receipt Date] from Installment_Receipt i, Item_Bought_Ins b, Salesman s where s.Ac_Type = 'Salesman Officer' and i.Receipt_No = b.Rcipt_No");
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
                    metroGrid_Salesman_Sales.DataSource = FurDB.getData("select s.Salesman_ID as [Salesman ID],f.Receipt_No as [Receipt No],f.Cus_ID as [Customer NIC],f.Total_Amount as [Total Amount/Downpayment],f.Payment_Type as [Payment Type],f.Date as [Receipt Date] from Full_Receipt f, Salesman s where s.Ac_Type = 'Salesman Officer' and f.Full_SM = '"+cmb_Salesman_No.Text+ "' union select s.Salesman_ID as [Salesman ID], i.Receipt_No as [Receipt No], i.Cust_ID as [Customer NIC], b.Downpayment as [Total Amount / Downpayment], i.Payment_Type as [Payment Type], i.Date as [Receipt Date] from Installment_Receipt i, Item_Bought_Ins b, Salesman s where s.Ac_Type = 'Salesman Officer' and i.Receipt_No = b.Rcipt_No and i.Ins_SM = '" + cmb_Salesman_No.Text + "'");
                else if ((cmb_Payment_Type.SelectedIndex == 0) && (txt_search3.Text.Length == 0))
                    metroGrid_Salesman_Sales.DataSource = FurDB.getData("select s.Salesman_ID as [Salesman ID],f.Receipt_No as [Receipt No],f.Cus_ID as [Customer NIC],f.Total_Amount as [Total Amount/Downpayment],f.Payment_Type as [Payment Type],f.Date as [Receipt Date] from Full_Receipt f, Salesman s where s.Ac_Type = 'Salesman Officer' and f.Full_SM = '" + cmb_Salesman_No.Text + "'");
                else if ((cmb_Payment_Type.SelectedIndex == 1) && (txt_search3.Text.Length == 0))
                    metroGrid_Salesman_Sales.DataSource = FurDB.getData("select s.Salesman_ID as [Salesman ID],i.Receipt_No as [Receipt No],i.Cust_ID as [Customer NIC],b.Downpayment as [Total Amount/Downpayment],i.Payment_Type as [Payment Type],i.Date as [Receipt Date] from Installment_Receipt i, Item_Bought_Ins b, Salesman s where s.Ac_Type = 'Salesman Officer' and i.Receipt_No = b.Rcipt_No and i.Ins_SM = '" + cmb_Salesman_No.Text + "'");
                else if ((cmb_Payment_Type.SelectedIndex == -1) && (txt_search3.Text.Length != 0))
                    metroGrid_Salesman_Sales.DataSource = FurDB.getData("select s.Salesman_ID as [Salesman ID],f.Receipt_No as [Receipt No],f.Cus_ID as [Customer NIC],f.Total_Amount as [Total Amount/Downpayment],f.Payment_Type as [Payment Type],f.Date as [Receipt Date] from Full_Receipt f, Salesman s where s.Ac_Type = 'Salesman Officer' and f.Full_SM = '" + cmb_Salesman_No.Text + "' and f.Cus_ID like '" + txt_search3.Text + "%' union select s.Salesman_ID as [Salesman ID], i.Receipt_No as [Receipt No], i.Cust_ID as [Customer NIC], b.Downpayment as [Total Amount / Downpayment], i.Payment_Type as [Payment Type], i.Date as [Receipt Date] from Installment_Receipt i, Item_Bought_Ins b, Salesman s where s.Ac_Type = 'Salesman Officer' and i.Receipt_No = b.Rcipt_No and i.Ins_SM = '" + cmb_Salesman_No.Text + "' and i.Cust_ID like '" + txt_search3.Text + "%'");
                else if ((cmb_Payment_Type.SelectedIndex == 0) && (txt_search3.Text.Length != 0))
                    metroGrid_Salesman_Sales.DataSource = FurDB.getData("select s.Salesman_ID as [Salesman ID],f.Receipt_No as [Receipt No],f.Cus_ID as [Customer NIC],f.Total_Amount as [Total Amount/Downpayment],f.Payment_Type as [Payment Type],f.Date as [Receipt Date] from Full_Receipt f, Salesman s where s.Ac_Type = 'Salesman Officer' and f.Full_SM = '" + cmb_Salesman_No.Text + "' and f.Cus_ID like '" + txt_search3.Text + "%'");
                else if ((cmb_Payment_Type.SelectedIndex == 1) && (txt_search3.Text.Length != 0))
                    metroGrid_Salesman_Sales.DataSource = FurDB.getData("select s.Salesman_ID as [Salesman ID],i.Receipt_No as [Receipt No],i.Cust_ID as [Customer NIC],b.Downpayment as [Total Amount/Downpayment],i.Payment_Type as [Payment Type],i.Date as [Receipt Date] from Installment_Receipt i, Item_Bought_Ins b, Salesman s where s.Ac_Type = 'Salesman Officer' and i.Receipt_No = b.Rcipt_No and i.Ins_SM = '" + cmb_Salesman_No.Text + "' and i.Cust_ID like '" + txt_search3.Text + "%'");
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
                    metroGrid_Salesman_Sales.DataSource = FurDB.getData("select s.Salesman_ID as [Salesman ID],f.Receipt_No as [Receipt No],f.Cus_ID as [Customer NIC],f.Total_Amount as [Total Amount/Downpayment],f.Payment_Type as [Payment Type],f.Date as [Receipt Date] from Full_Receipt f, Salesman s where s.Ac_Type = 'Salesman Officer' and f.Payment_Type = '" + cmb_Payment_Type.Text + "' union select s.Salesman_ID as [Salesman ID], i.Receipt_No as [Receipt No], i.Cust_ID as [Customer NIC], b.Downpayment as [Total Amount / Downpayment], i.Payment_Type as [Payment Type], i.Date as [Receipt Date] from Installment_Receipt i, Item_Bought_Ins b, Salesman s where s.Ac_Type = 'Salesman Officer' and i.Receipt_No = b.Rcipt_No and i.Payment_Type = '" + cmb_Payment_Type.Text + "'");
                else if ((cmb_Salesman_No.SelectedIndex != -1) && (txt_search3.Text.Length == 0))
                    metroGrid_Salesman_Sales.DataSource = FurDB.getData("select s.Salesman_ID as [Salesman ID],f.Receipt_No as [Receipt No],f.Cus_ID as [Customer NIC],f.Total_Amount as [Total Amount/Downpayment],f.Payment_Type as [Payment Type],f.Date as [Receipt Date] from Full_Receipt f, Salesman s where s.Ac_Type = 'Salesman Officer' and f.Payment_Type = '" + cmb_Payment_Type.Text + "' and f.Full_SM = '" + cmb_Salesman_No.Text + "' union select s.Salesman_ID as [Salesman ID], i.Receipt_No as [Receipt No], i.Cust_ID as [Customer NIC], b.Downpayment as [Total Amount / Downpayment], i.Payment_Type as [Payment Type], i.Date as [Receipt Date] from Installment_Receipt i, Item_Bought_Ins b, Salesman s where s.Ac_Type = 'Salesman Officer' and i.Receipt_No = b.Rcipt_No and i.Payment_Type = '" + cmb_Payment_Type.Text + "' and i.Ins_SM = '" + cmb_Salesman_No.Text + "'");
                else if ((cmb_Salesman_No.SelectedIndex == -1) && (txt_search3.Text.Length != 0))
                    metroGrid_Salesman_Sales.DataSource = FurDB.getData("select s.Salesman_ID as [Salesman ID],f.Receipt_No as [Receipt No],f.Cus_ID as [Customer NIC],f.Total_Amount as [Total Amount/Downpayment],f.Payment_Type as [Payment Type],f.Date as [Receipt Date] from Full_Receipt f, Salesman s where s.Ac_Type = 'Salesman Officer' and f.Payment_Type = '" + cmb_Payment_Type.Text + "' and f.Cus_ID like '" + txt_search3.Text + "%' union select s.Salesman_ID as [Salesman ID], i.Receipt_No as [Receipt No], i.Cust_ID as [Customer NIC], b.Downpayment as [Total Amount / Downpayment], i.Payment_Type as [Payment Type], i.Date as [Receipt Date] from Installment_Receipt i, Item_Bought_Ins b, Salesman s where s.Ac_Type = 'Salesman Officer' and i.Receipt_No = b.Rcipt_No and i.Payment_Type = '" + cmb_Payment_Type.Text + "' and i.Cust_ID like '" + txt_search3.Text + "%'");
                else if ((cmb_Salesman_No.SelectedIndex != -1) && (txt_search3.Text.Length != 0))
                    metroGrid_Salesman_Sales.DataSource = FurDB.getData("select s.Salesman_ID as [Salesman ID],f.Receipt_No as [Receipt No],f.Cus_ID as [Customer NIC],f.Total_Amount as [Total Amount/Downpayment],f.Payment_Type as [Payment Type],f.Date as [Receipt Date] from Full_Receipt f, Salesman s where s.Ac_Type = 'Salesman Officer' and f.Payment_Type = '" + cmb_Payment_Type.Text + "' and f.Cus_ID like '" + txt_search3.Text + "%' and f.Full_SM = '" + cmb_Salesman_No.Text + "' union select s.Salesman_ID as [Salesman ID], i.Receipt_No as [Receipt No], i.Cust_ID as [Customer NIC], b.Downpayment as [Total Amount / Downpayment], i.Payment_Type as [Payment Type], i.Date as [Receipt Date] from Installment_Receipt i, Item_Bought_Ins b, Salesman s where s.Ac_Type = 'Salesman Officer' and i.Receipt_No = b.Rcipt_No and i.Payment_Type = '" + cmb_Payment_Type.Text + "' and i.Cust_ID like '" + txt_search3.Text + "%' and i.Ins_SM = '" + cmb_Salesman_No.Text + "'");
            }

            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void btn_Clear2_Click(object sender, EventArgs e)
        {
            txt_search3.Clear(); cmb_Salesman_No.SelectedIndex = -1; cmb_Payment_Type.SelectedIndex = -1;
            //metroGrid_Salesman_Sales.DataSource = FurDB.getData("select s.Salesman_ID as [Salesman ID],f.Receipt_No as [Receipt No],f.Cus_ID as [Customer NIC],f.Total_Amount as [Total Amount/Downpayment],f.Payment_Type as [Payment Type],f.Date as [Receipt Date] from Full_Receipt f, Salesman s where s.Ac_Type = 'Salesman Officer' union select s.Salesman_ID as [Salesman ID], i.Receipt_No as [Receipt No], i.Cust_ID as [Customer NIC], b.Downpayment as [Total Amount / Downpayment], i.Payment_Type as [Payment Type], i.Date as [Receipt Date] from Installment_Receipt i, Item_Bought_Ins b, Salesman s where s.Ac_Type = 'Salesman Officer' and i.Receipt_No = b.Rcipt_No");
        }

        private void Salesman_Load(object sender, EventArgs e)
        {
            try
            {
                cmb_Salesman_No.DataSource = FurDB.getValue("select Salesman_ID from Salesman where Salesman.Ac_Type='Salesman Officer'").Tables[0];
                cmb_Salesman_No.ValueMember = "Salesman_ID";
                cmb_Salesman_No.Enabled = true;
                cmb_Salesman_No.SelectedIndex = -1;

                //metroGrid_Salesman_Sales.DataSource = FurDB.getData("select s.Salesman_ID as [Salesman ID],f.Receipt_No as [Receipt No],f.Cus_ID as [Customer NIC],f.Total_Amount as [Total Amount/Downpayment],f.Payment_Type as [Payment Type],f.Date as [Receipt Date] from Full_Receipt f, Salesman s where s.Ac_Type = 'Salesman Officer' union select s.Salesman_ID as [Salesman ID], i.Receipt_No as [Receipt No], i.Cust_ID as [Customer NIC], b.Downpayment as [Total Amount / Downpayment], i.Payment_Type as [Payment Type], i.Date as [Receipt Date] from Installment_Receipt i, Item_Bought_Ins b, Salesman s where s.Ac_Type = 'Salesman Officer' and i.Receipt_No = b.Rcipt_No");
            }

            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }
    }
}
