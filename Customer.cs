using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Furniture_System
{
    public partial class Customer : MetroFramework.Forms.MetroForm
    {
        public Customer(string un)
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

        private void Customer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard obj = new Dashboard(UN);
            obj.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_search.Text.Length != 0)
                    metroGrid_Cus.DataSource = FurDB.getData("select Fname as [First name],Lname as [Last name],NIC as [NIC no],AdrsL1 as [Address line1],AdrsL2 as [Address line2],AdrsL3 as [Address line3],Customer_No as [Contact No] from Customer where Fname like '"+txt_search.Text+"%'");

                if (txt_search.Text.Length == 0)
                    metroGrid_Cus.DataSource = FurDB.getData("select Fname as [First name],Lname as [Last name],NIC as [NIC no],AdrsL1 as [Address line1],AdrsL2 as [Address line2],AdrsL3 as [Address line3],Customer_No as [Contact No] from Customer");
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
                if ((txt_Fname.Text.Length != 0) && (txt_Lname.Text.Length != 0) && (txt_NIC.Text.Length != 0) && (txt_AdrsL1.Text.Length != 0) && (txt_AdrsL2.Text.Length != 0) && (txt_Customer_No.Text.Length != 0) && (txt_Customer_No.Text.Length == 10) && (txt_Customer_No.Text.Any(char.IsDigit)) && txt_Fname.Text.All(char.IsLetter) && txt_Lname.Text.All(char.IsLetter))
                {
                    if ((FurDB.Insert_Update_Delete("update Customer set Fname='" + txt_Fname.Text + "',Lname='" + txt_Lname.Text + "',AdrsL1='" + txt_AdrsL1.Text + "',AdrsL2='" + txt_AdrsL2.Text + "',AdrsL3='" + txt_AdrsL3.Text + "',Customer_No='" + txt_Customer_No.Text + "' where NIC='" + txt_NIC.Text + "'") == 1))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_Fname.Clear(); txt_Lname.Clear(); txt_NIC.Clear(); txt_AdrsL1.Clear(); txt_AdrsL2.Clear(); txt_AdrsL3.Clear(); txt_Customer_No.Clear(); metroGrid_CusDetails.DataSource = null;
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Data cannot update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "Please enter all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception)
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
                    metroGrid_CusDetails.DataSource = FurDB.getData("select Fname as [First name],Lname as [Last name],NIC as [NIC no],AdrsL1 as [Address line1],AdrsL2 as [Address line2],AdrsL3 as [Address line3],Customer_No as [Contact No] from Customer where Fname like '" + txt_search2.Text + "%'");

                if (txt_search2.Text.Length == 0)
                    metroGrid_CusDetails.DataSource = FurDB.getData("select Fname as [First name],Lname as [Last name],NIC as [NIC no],AdrsL1 as [Address line1],AdrsL2 as [Address line2],AdrsL3 as [Address line3],Customer_No as [Contact No] from Customer");
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void metroGrid_CusDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Fname.Text = metroGrid_CusDetails.CurrentRow.Cells[0].Value.ToString();
            txt_Lname.Text = metroGrid_CusDetails.CurrentRow.Cells[1].Value.ToString();
            txt_NIC.Text = metroGrid_CusDetails.CurrentRow.Cells[2].Value.ToString();
            txt_AdrsL1.Text = metroGrid_CusDetails.CurrentRow.Cells[3].Value.ToString();
            txt_AdrsL2.Text = metroGrid_CusDetails.CurrentRow.Cells[4].Value.ToString();
            txt_AdrsL3.Text = metroGrid_CusDetails.CurrentRow.Cells[5].Value.ToString();
            txt_Customer_No.Text = metroGrid_CusDetails.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_Fname.Clear();txt_Lname.Clear();txt_NIC.Clear();txt_AdrsL1.Clear();txt_AdrsL2.Clear();txt_AdrsL3.Clear();txt_Customer_No.Clear();metroGrid_CusDetails.DataSource = null;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_Fname.Text.Length != 0) && (txt_Lname.Text.Length != 0) && (txt_NIC.Text.Length != 0) && (txt_AdrsL1.Text.Length != 0) && (txt_AdrsL2.Text.Length != 0) && (txt_Customer_No.Text.Length != 0))
                {
                    if (FurDB.readData("select * from Full_Receipt where Cus_ID='"+txt_NIC.Text+"'")==false || FurDB.readData("select * from Installment_Receipt where Cust_ID='"+txt_NIC.Text+"'")==false)
                    {
                        if (MetroFramework.MetroMessageBox.Show(this, "Do  you want to remove?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            if (FurDB.Insert_Update_Delete("delete from Customer where NIC = '" + txt_NIC.Text + "'") == 1)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Customer removed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txt_Fname.Clear(); txt_Lname.Clear(); txt_NIC.Clear(); txt_AdrsL1.Clear(); txt_AdrsL2.Clear(); txt_AdrsL3.Clear(); txt_Customer_No.Clear(); metroGrid_CusDetails.DataSource = null;
                            }
                            else
                                MetroFramework.MetroMessageBox.Show(this, "Customer cannot remove!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Customer already bought an Item(s)!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
