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
    public partial class Item : MetroFramework.Forms.MetroForm
    {
        public Item(string un)
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_search.Text.Length != 0)
                    metroGrid_Itm.DataSource = FurDB.getData("select Item_Code as [Item Code],Item_Name as [Item name],Price as [Item Price] from Item where Item_Code like '" + txt_search.Text + "%'");

                if (txt_search.Text.Length == 0)
                    metroGrid_Itm.DataSource = FurDB.getData("select Item_Code as [Item Code],Item_Name as [Item name],Price as [Item Price] from Item");
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void Item_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard obj = new Dashboard(UN);
            obj.Show();
        }

        private void btn_Clear_AddItem_Click(object sender, EventArgs e)
        {
            txt_ItemCode.Clear(); txt_ItemName.Clear(); txt_Price.Clear();
        }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_ItemCode.Text.Length != 0) && (txt_ItemName.Text.Length != 0) && (txt_Price.Text.Length != 0) && (txt_Price.Text.Any(char.IsDigit)) && !(txt_Price.Text.StartsWith("-")) && txt_ItemName.Text.All(char.IsLetter))
                {
                    if (FurDB.Insert_Update_Delete("insert into Item values ('" + txt_ItemCode.Text + "', '" + txt_ItemName.Text + "', '" + Convert.ToDouble(txt_Price.Text) + "')") == 1)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Item Added Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_ItemCode.Clear(); txt_ItemName.Clear(); txt_Price.Clear();
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Item Cannot Add!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "Please enter all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_Item_Code_Edit.Text.Length != 0) && (txt_Item_Name_Edit.Text.Length != 0) && (txt_Item_Price_Edit.Text.Any(char.IsDigit)) && !(txt_Item_Price_Edit.Text.StartsWith("-")) && txt_Item_Name_Edit.Text.All(char.IsLetter))
                {
                    if ((FurDB.Insert_Update_Delete("update Item set Item_Name='" + txt_Item_Name_Edit.Text + "',Price='" + Convert.ToDouble(txt_Item_Price_Edit.Text) + "' where Item_Code='" + txt_Item_Code_Edit.Text + "'") == 1))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_Item_Code_Edit.Clear(); txt_Item_Name_Edit.Clear(); txt_Item_Price_Edit.Clear(); metroGrid_Itm_Edit.DataSource = null;
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

        private void btn_clear_Edit_Click(object sender, EventArgs e)
        {
            txt_Item_Code_Edit.Clear(); txt_Item_Name_Edit.Clear(); txt_Item_Price_Edit.Clear(); metroGrid_Itm_Edit.DataSource = null; txt_search2.Clear();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_Item_Code_Edit.Text.Length != 0) && (txt_Item_Name_Edit.Text.Length != 0) && (txt_Item_Price_Edit.Text.Any(char.IsDigit)) && !(txt_Item_Price_Edit.Text.StartsWith("-")))
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Do  you want to remove?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        if (FurDB.readData("select * from Item_Bought_Full where FItm_Code='" + txt_Item_Code_Edit.Text + "'") == true || FurDB.readData("select * from Item_Bought_Ins where IItm_Code='" + txt_Item_Code_Edit.Text + "'") == true)
                            MetroFramework.MetroMessageBox.Show(this, "Item already bought by a Customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            if (FurDB.readData("select * from Load_Items where Itm_ID='" + txt_Item_Code_Edit.Text + "'")==true)
                                MetroFramework.MetroMessageBox.Show(this, "Item already in a Load!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                if (FurDB.readData("select * from Store_Items where Item_CD='" + txt_Item_Code_Edit.Text + "'") == true)
                                        MetroFramework.MetroMessageBox.Show(this, "Item already in a Store!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                else
                                {
                                    if ((FurDB.Insert_Update_Delete("delete from Item where Item_Code='" + txt_Item_Code_Edit.Text + "'") == 1))
                                    {
                                        MetroFramework.MetroMessageBox.Show(this, "Item removed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txt_Item_Code_Edit.Clear(); txt_Item_Name_Edit.Clear(); txt_Item_Price_Edit.Clear(); metroGrid_Itm_Edit.DataSource = null; txt_search2.Clear();
                                    }
                                    else
                                        MetroFramework.MetroMessageBox.Show(this, "Data cannot remove!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
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

        private void btn_search2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_search2.Text.Length != 0)
                    metroGrid_Itm_Edit.DataSource = FurDB.getData("select Item_Code as [Item Code],Item_Name as [Item name],Price as [Item Price] from Item where Item_Code like '" + txt_search2.Text + "%'");

                if (txt_search2.Text.Length == 0)
                    metroGrid_Itm_Edit.DataSource = FurDB.getData("select Item_Code as [Item Code],Item_Name as [Item name],Price as [Item Price] from Item");
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void metroGrid_Itm_Edit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Item_Code_Edit.Text = metroGrid_Itm_Edit.CurrentRow.Cells[0].Value.ToString();
            txt_Item_Name_Edit.Text = metroGrid_Itm_Edit.CurrentRow.Cells[1].Value.ToString();
            txt_Item_Price_Edit.Text = metroGrid_Itm_Edit.CurrentRow.Cells[2].Value.ToString();
        }

        private void Item_Load(object sender, EventArgs e)
        {
            try
            {
                //cmb_Store.Items.Insert(0, "Store No");
                cmb_Store.DataSource = FurDB.getValue("select Store_No from Store").Tables[0];
                cmb_Store.ValueMember = "Store_No";
                cmb_Store.Enabled = true;
                cmb_Store.SelectedIndex = -1;

                cmb_Load_No.DataSource = FurDB.getValue("select Load_No from Load").Tables[0];
                cmb_Load_No.ValueMember = "Load_No";
                cmb_Load_No.Enabled = true;
                cmb_Load_No.SelectedIndex = -1;

                cmb_Item_Code_Item_Store.DataSource = FurDB.getValue("select Item_Code from Item").Tables[0];
                cmb_Item_Code_Item_Store.ValueMember = "Item_Code";
                cmb_Item_Code_Item_Store.Enabled = true;
                cmb_Item_Code_Item_Store.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void btn_clear_Item_Store_Click(object sender, EventArgs e)
        {
            cmb_Item_Code_Item_Store.SelectedIndex = -1; txt_quantity.Clear(); cmb_Store.SelectedIndex = -1;
        }

        private void btn_Add_to_Store_Click(object sender, EventArgs e)
        {
            try
            {
                if ((cmb_Item_Code_Item_Store.SelectedIndex != -1) && (txt_quantity.Text.Length != 0) && (txt_quantity.Text.Any(char.IsDigit)) && !(txt_quantity.Text.StartsWith("-")) && (cmb_Store.SelectedIndex != -1))
                {
                    if ((FurDB.readData("select * from Item where Item_Code='" + cmb_Item_Code_Item_Store.Text + "'") == true) && (FurDB.readData("select * from Store where Store_No='" + cmb_Store.Text + "'") == true))
                    {
                        if (FurDB.Insert_Update_Delete("insert into Store_Items values ('" + cmb_Store.Text + "','" + cmb_Item_Code_Item_Store.Text + "','" + Convert.ToInt32(txt_quantity.Text) + "')") == 1)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Items Added to Store Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cmb_Item_Code_Item_Store.SelectedIndex = -1; txt_quantity.Clear(); cmb_Store.SelectedIndex = -1;
                        }
                        else
                            MetroFramework.MetroMessageBox.Show(this, "Items cannot be Addded!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Details not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_Add_to_Load_Click(object sender, EventArgs e)
        {
            try
            {
                if ((cmb_Load_No.SelectedIndex != -1) && (cmb_Store_No.SelectedIndex != -1) && (cmb_Item_No.SelectedIndex != -1) && (txt_Load_Quantity.Text.Length != 0) && (txt_Load_Quantity.Text.Any(char.IsDigit)) && !(txt_Load_Quantity.Text.StartsWith("-")))
                {
                    if ((FurDB.readData("select * from Load where Load_No='" + cmb_Load_No.Text + "'") == true) && (FurDB.readData("select * from Store_Items where Stor_ID='" + cmb_Store_No.Text + "' and Item_CD='" + cmb_Item_No.Text + "'") == true))
                    {
                        if (FurDB.readData("select Quantity from Store_Items where Stor_ID='" + cmb_Store_No.Text + "' and Item_CD='" + cmb_Item_No.Text + "'", "Quantity") != 0)
                        {
                            double q = FurDB.readData("select Quantity from Store_Items where Stor_ID='" + cmb_Store_No.Text + "' and Item_CD='"+ cmb_Item_No.Text+ "'", "Quantity");
                            double ql = q - Convert.ToDouble(txt_Load_Quantity.Text);
                            if (ql < 0)
                                MetroFramework.MetroMessageBox.Show(this, "No Balance in the Store!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                if ((FurDB.Insert_Update_Delete("insert into Load_Items values('" + cmb_Load_No.Text + "','" + cmb_Item_No.Text + "','" + Convert.ToDouble(txt_Load_Quantity.Text) + "')") == 1)&&(FurDB.Insert_Update_Delete("update Store_Items set Quantity='"+ql+"' where Stor_ID='"+ cmb_Store_No.Text+ "' and Item_CD='"+ cmb_Item_No.Text+ "'")==1))
                                {
                                    MetroFramework.MetroMessageBox.Show(this, "Items Added to Store Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    cmb_Load_No.SelectedIndex = -1; cmb_Store_No.SelectedIndex = -1; cmb_Item_No.SelectedIndex = -1; txt_Load_Quantity.Clear();
                                }
                                else
                                    MetroFramework.MetroMessageBox.Show(this, "Items cannot be Addded!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                            MetroFramework.MetroMessageBox.Show(this, "No Balance in the Store!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Details not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            cmb_Load_No.SelectedIndex = -1; cmb_Store_No.SelectedIndex = -1; cmb_Item_No.SelectedIndex = -1; txt_Load_Quantity.Clear(); lbl_IStr.Text = "";
        }

        private void cmb_Load_No_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmb_Store_No.DataSource = FurDB.getValue("select St_ID from Load where Load_No='" + cmb_Load_No.Text + "'").Tables[0];
                cmb_Store_No.ValueMember = "St_ID";
                cmb_Store_No.Enabled = true;
                cmb_Store_No.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void cmb_Store_No_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmb_Item_No.DataSource = FurDB.getValue("select Item_CD from Store_Items where Stor_ID='" + cmb_Store_No.Text + "'").Tables[0];
                cmb_Item_No.ValueMember = "Item_CD";
                cmb_Item_No.Enabled = true;
                cmb_Item_No.SelectedIndex = -1;

                lbl_IStr.Text = FurDB.readData("select Store_Name from Store where Store_No='" + cmb_Store_No.Text + "'", "Store_Name", "");
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

        private void cmb_Item_Code_Item_Store_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbl_Itm_Name.Text = FurDB.readData("select Item_Name from Item where Item_Code='" + cmb_Item_Code_Item_Store.Text + "'", "Item_Name", "");
            }

            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void cmb_Item_No_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbl_IItm.Text = FurDB.readData("select Item_Name from Item where Item_Code='" + cmb_Item_No.Text + "'", "Item_Name", "");
                lbl_IQuan.Text = FurDB.readData("select Quantity from Store_Items where Stor_ID='" + cmb_Store_No.Text + "' and Item_CD='" + cmb_Item_No.Text + "'", "Quantity", "");
            }

            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }
    }
}
