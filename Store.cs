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
    public partial class Store : MetroFramework.Forms.MetroForm
    {
        public Store(string un)
        {
            InitializeComponent();
            UN = un;
        }
        FurnitureDB FurDB = new FurnitureDB();
        string UN;
        private void Store_FormClosed(object sender, FormClosedEventArgs e)
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
                    metroGrid_Str.DataSource = FurDB.getData("select Store_No as [Store No],Store_Name as [Store name] from Store where Store_Name like '" + txt_search.Text + "%'");

                if (txt_search.Text.Length == 0)
                    metroGrid_Str.DataSource = FurDB.getData("select Store_No as [Store No],Store_Name as [Store name] from Store");
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void btn_AddStore_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_StoreNo.Text.Length != 0) && (txt_StoreName.Text.Length != 0) && txt_StoreName.Text.All(char.IsLetter))
                {
                    if (FurDB.Insert_Update_Delete("insert into Store values ('" + txt_StoreNo.Text + "', '" + txt_StoreName.Text + "')") == 1)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Store Added Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_StoreNo.Clear(); txt_StoreName.Clear();
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Store Cannot Add!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_Clear_AddStore_Click(object sender, EventArgs e)
        {
            txt_StoreNo.Clear(); txt_StoreName.Clear();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_Store_No_Edit.Text.Length != 0) && (txt_Store_Name_Edit.Text.Length != 0) && txt_Store_Name_Edit.Text.All(char.IsLetter))
                {
                    if ((FurDB.Insert_Update_Delete("update Store set Store_Name='" + txt_Store_Name_Edit.Text + "' where Store_No='" + txt_Store_No_Edit.Text + "'") == 1))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_Store_No_Edit.Clear(); txt_Store_Name_Edit.Clear(); txt_search2.Clear(); metroGrid_Str_Edit.DataSource = null;
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Data cannot update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if ((txt_Store_No_Edit.Text.Length != 0) && (txt_Store_Name_Edit.Text.Length != 0))
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Do  you want to remove?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        if(FurDB.readData("select * from Store_Items where Stor_ID='"+txt_Store_No_Edit.Text+"'")==true)
                            MetroFramework.MetroMessageBox.Show(this, "Store has Items!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            if (FurDB.readData("select * from Load where St_ID='"+txt_Store_No_Edit.Text+"'")==true)
                                MetroFramework.MetroMessageBox.Show(this, "A Load is assinged to this Store!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                if ((FurDB.Insert_Update_Delete("delete from Store where Store_No='" + txt_Store_No_Edit.Text + "'") == 1))
                                {
                                    MetroFramework.MetroMessageBox.Show(this, "Store removed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txt_Store_No_Edit.Clear(); txt_Store_Name_Edit.Clear(); txt_search2.Clear(); metroGrid_Str_Edit.DataSource = null;
                                }
                                else
                                    MetroFramework.MetroMessageBox.Show(this, "Data cannot remove!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
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

        private void btn_clear_Edit_Click(object sender, EventArgs e)
        {
            txt_Store_No_Edit.Clear(); txt_Store_Name_Edit.Clear(); txt_search2.Clear(); metroGrid_Str_Edit.DataSource = null;
        }

        private void btn_search2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_search.Text.Length != 0)
                    metroGrid_Str_Edit.DataSource = FurDB.getData("select Store_No as [Store No],Store_Name as [Store name] from Store where Store_Name like '" + txt_search2.Text + "%'");

                if (txt_search.Text.Length == 0)
                    metroGrid_Str_Edit.DataSource = FurDB.getData("select Store_No as [Store No],Store_Name as [Store name] from Store");
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void metroGrid_Str_Edit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Store_No_Edit.Text = metroGrid_Str_Edit.CurrentRow.Cells[0].Value.ToString();
            txt_Store_Name_Edit.Text = metroGrid_Str_Edit.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn_search_Store_Item_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_search.Text.Length != 0)
                    metroGrid_Str_Itm.DataSource = FurDB.getData("select Stor_ID as [Store No],Store_Name as [Store Name],Item_CD as [Item Code],Item_Name as [Item Name],Price as [Item Price],Quantity as [Store Quantity] from Store_Items,Item,Store  where Item_CD=Item_Code and Stor_ID=Store_No and Store_Name like '" + txt_search.Text + "%'");

                if (txt_search.Text.Length == 0)
                    metroGrid_Str_Itm.DataSource = FurDB.getData("select Stor_ID as [Store No],Store_Name as [Store Name],Item_CD as [Item Code],Item_Name as [Item Name],Price as [Item Price],Quantity as [Store Quantity] from Store_Items,Item,Store  where Item_CD=Item_Code and Stor_ID=Store_No");
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void txt_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_Store_No_Update.Text.Length != 0) && (txt_Item_No_Update.Text.Length != 0) && (txt_Quantity.Text.Length != 0) && (txt_Quantity.Text.Any(char.IsDigit)) && !(txt_Quantity.Text.StartsWith("-")))
                {
                    if ((FurDB.Insert_Update_Delete("update Store_Items set Stor_ID='" + txt_Store_No_Update.Text + "',Item_CD='" + txt_Item_No_Update.Text + "',Quantity ='" + Convert.ToDouble(txt_Quantity.Text) + "' where Stor_ID='" + txt_Store_No_Update.Text + "' and Item_CD='" + txt_Item_No_Update.Text + "'") == 1))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_Store_No_Update.Clear(); txt_Item_No_Update.Clear(); txt_Quantity.Clear(); metroGrid_Up_Str_Itm.DataSource = null;
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Data cannot update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_clear_Update_Store_Click(object sender, EventArgs e)
        {
            txt_Store_No_Update.Clear(); txt_Item_No_Update.Clear(); txt_Quantity.Clear(); metroGrid_Up_Str_Itm.DataSource = null; txt_search3.Clear();
        }

        private void btn_search3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_search.Text.Length != 0)
                    metroGrid_Up_Str_Itm.DataSource = FurDB.getData("select Stor_ID as [Store No],Store_Name as [Store Name],Item_CD as [Item Code],Item_Name as [Item Name],Price as [Item Price],Quantity as [Store Quantity] from Store_Items,Item,Store  where Item_CD=Item_Code and Stor_ID=Store_No and Store_Name like '" + txt_search.Text + "%'");

                if (txt_search.Text.Length == 0)
                    metroGrid_Up_Str_Itm.DataSource = FurDB.getData("select Stor_ID as [Store No],Store_Name as [Store Name],Item_CD as [Item Code],Item_Name as [Item Name],Price as [Item Price],Quantity as [Store Quantity] from Store_Items,Item,Store  where Item_CD=Item_Code and Stor_ID=Store_No");
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void btn_remove_Str_Itm_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_Store_No_Update.Text.Length != 0) && (txt_Item_No_Update.Text.Length != 0) && (txt_Quantity.Text.Length != 0) && (txt_Quantity.Text.Any(char.IsDigit)) && !(txt_Quantity.Text.StartsWith("-")))
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Do  you want to remove?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        if (FurDB.Insert_Update_Delete("delete from Store_Items where Item_CD='" + txt_Item_No_Update.Text + "'") == 1)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Item removed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_Store_No_Update.Clear(); txt_Item_No_Update.Clear(); txt_Quantity.Clear(); metroGrid_Up_Str_Itm.DataSource = null; txt_search3.Clear();
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

        private void metroGrid_Up_Str_Itm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Store_No_Update.Text = metroGrid_Up_Str_Itm.CurrentRow.Cells[0].Value.ToString();
            txt_Item_No_Update.Text = metroGrid_Up_Str_Itm.CurrentRow.Cells[2].Value.ToString();
            txt_Quantity.Text = metroGrid_Up_Str_Itm.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
