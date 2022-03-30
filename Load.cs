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
    public partial class Load : MetroFramework.Forms.MetroForm
    {
        public Load(string un)
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

        private void Load_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dashboard obj = new Dashboard(UN);
            obj.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_search.Text.Length != 0)
                    metroGrid_Ld.DataSource = FurDB.getData("select Load_No as [Load No],St_ID as [Store No],Store_Name as [Store Name] from Load,Store where St_ID=Store_No and Load_No like '" + txt_search.Text + "%'");

                if (txt_search.Text.Length == 0)
                    metroGrid_Ld.DataSource = FurDB.getData("select Load_No as [Load No],St_ID as [Store No],Store_Name as [Store Name] from Load,Store where St_ID=Store_No");
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void Load_Load(object sender, EventArgs e)
        {
            try
            {
                cmb_Store_No.DataSource = FurDB.getValue("select Store_No from Store").Tables[0];
                cmb_Store_No.ValueMember = "Store_No";
                cmb_Store_No.Enabled = true;
                cmb_Store_No.SelectedIndex = -1;

                cmb_Store_No_Edit.DataSource = FurDB.getValue("select Store_No from Store").Tables[0];
                cmb_Store_No_Edit.ValueMember = "Store_No";
                cmb_Store_No_Edit.Enabled = true;
                cmb_Store_No_Edit.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void btn_AddLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_LoadNo.Text.Length != 0) && (cmb_Store_No.SelectedIndex != -1))
                {
                    if (FurDB.Insert_Update_Delete("insert into Load values ('" + txt_LoadNo.Text + "', '" + cmb_Store_No.Text + "')") == 1)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Store Added Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_LoadNo.Clear(); cmb_Store_No.SelectedIndex = -1;
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Load Cannot Add!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_Clear_AddLoad_Click(object sender, EventArgs e)
        {
            txt_LoadNo.Clear(); cmb_Store_No.SelectedIndex = -1;
        }

        private void btn_search2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_search2.Text.Length != 0)
                    metroGrid_Ld_Edit.DataSource = FurDB.getData("select Load_No as [Load No],St_ID as [Store No],Store_Name as [Store Name] from Load,Store where St_ID=Store_No and Load_No like '" + txt_search2.Text + "%'");

                if (txt_search2.Text.Length == 0)
                    metroGrid_Ld_Edit.DataSource = FurDB.getData("select Load_No as [Load No],St_ID as [Store No],Store_Name as [Store Name] from Load,Store where St_ID=Store_No");
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
                if ((txt_Load_No_Edit.Text.Length != 0) && (cmb_Store_No_Edit.SelectedIndex != -1))
                    if (FurDB.Insert_Update_Delete("update Load set St_ID='" + cmb_Store_No_Edit.Text + "' where Load_No='"+ txt_Load_No_Edit.Text+"'") == 1)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_Load_No_Edit.Clear(); cmb_Store_No_Edit.SelectedIndex = -1; txt_search2.Clear(); metroGrid_Ld_Edit.DataSource = null;
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
                if ((txt_Load_No_Edit.Text.Length != 0) && (cmb_Store_No_Edit.SelectedIndex != -1))
                    if ((FurDB.readData("select * from Load_Items where L_ID='" + txt_Load_No_Edit.Text + "'") == true))
                        MetroFramework.MetroMessageBox.Show(this, "This Load has Items remaining!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (MetroFramework.MetroMessageBox.Show(this, "Do  you want to remove?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            if (FurDB.Insert_Update_Delete("delete from Load where Load_No='" + txt_Load_No_Edit.Text + "'") == 1)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Load removed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txt_Load_No_Edit.Clear(); cmb_Store_No_Edit.SelectedIndex = -1; txt_search2.Clear(); metroGrid_Ld_Edit.DataSource = null;
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
            txt_Load_No_Edit.Clear(); cmb_Store_No_Edit.SelectedIndex = -1; txt_search2.Clear(); metroGrid_Ld_Edit.DataSource = null;
        }

        private void metroGrid_Ld_Edit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Load_No_Edit.Text = metroGrid_Ld_Edit.CurrentRow.Cells[0].Value.ToString();
        }

        private void btn_search_Load_Item_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Load_No.Text.Length != 0)
                    metroGrid_Ld_Itm.DataSource = FurDB.getData("select L_ID as [Load No],Itm_ID as [Item No],Item_Name as [Item Name],Price as [Price],Quantity as [Load Quantity] from Load_Items,Item where Itm_ID=Item_Code and L_ID like '" + txt_Load_No.Text + "%'");

                if (txt_Load_No.Text.Length == 0)
                    metroGrid_Ld_Itm.DataSource = FurDB.getData("select L_ID as [Load No],Itm_ID as [Item No],Item_Name as [Item Name],Price as [Price],Quantity as [Load Quantity] from Load_Items,Item where Itm_ID=Item_Code");
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
                    metroGrid_Up_Ld_Itm.DataSource = FurDB.getData("select L_ID as [Load No],Itm_ID as [Item No],Item_Name as [Item Name],Price as [Price],Quantity as [Load Quantity] from Load_Items,Item where Itm_ID=Item_Code and L_ID like '" + txt_search3.Text + "%'");

                if (txt_search3.Text.Length == 0)
                    metroGrid_Up_Ld_Itm.DataSource = FurDB.getData("select L_ID as [Load No],Itm_ID as [Item No],Item_Name as [Item Name],Price as [Price],Quantity as [Load Quantity] from Load_Items,Item where Itm_ID=Item_Code");
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
                if ((txt_Load_No_Update.Text.Length != 0) && (txt_Item_No_Update.Text.Length != 0) && (txt_Quantity.Text.Length != 0) && (txt_Quantity.Text.Any(char.IsDigit)) && !(txt_Quantity.Text.StartsWith("-")) && (txt_New_Quantity.Text.Length != 0) && (txt_New_Quantity.Text.Any(char.IsDigit)) && ((Convert.ToDouble(txt_New_Quantity.Text))!=0))
                {

                    string str = FurDB.readData("select St_ID from Load where Load_No = '" + txt_Load_No_Update.Text + "'", "St_ID", "");
                    double StQan = FurDB.readData("select Quantity from Store_Items where Stor_ID = '"+ str + "' and Item_CD='"+txt_Item_No_Update.Text+"'", "Quantity");
                    double LdQan = Convert.ToDouble(txt_Quantity.Text);
                    
                    if ((Convert.ToDouble(txt_New_Quantity.Text)) > StQan)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "No Balance in the Store!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        double New_LdQan = Convert.ToDouble(txt_New_Quantity.Text) + LdQan; StQan = StQan - Convert.ToDouble(txt_New_Quantity.Text);
                        if ((FurDB.Insert_Update_Delete("update Load_Items set Quantity='" + New_LdQan + "' where L_ID='" + txt_Load_No_Update.Text + "' and Itm_ID='" + txt_Item_No_Update.Text + "'") == 1) && (FurDB.Insert_Update_Delete("update Store_Items set Quantity='" + StQan + "' where Item_CD='" + txt_Item_No_Update.Text + "' and Stor_ID='"+str+"'") == 1))
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_Load_No_Update.Clear(); txt_Item_No_Update.Clear(); txt_Quantity.Clear(); txt_search3.Clear(); metroGrid_Up_Ld_Itm.DataSource = null; txt_New_Quantity.Clear();
                        }
                        else
                            MetroFramework.MetroMessageBox.Show(this, "Data cannot update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_remove_Ld_Itm_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_Load_No_Update.Text.Length != 0) && (txt_Item_No_Update.Text.Length != 0) && (txt_Quantity.Text.Length != 0) && (txt_Quantity.Text.Any(char.IsDigit)) && !(txt_Quantity.Text.StartsWith("-")))
                    if (FurDB.Insert_Update_Delete("delete from Load_Items where L_ID='" + txt_Load_No_Update.Text + "' and Itm_ID='" + txt_Item_No_Update.Text + "'") == 1)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Item removed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_Load_No_Update.Clear(); txt_Item_No_Update.Clear(); txt_Quantity.Clear(); txt_search3.Clear(); metroGrid_Up_Ld_Itm.DataSource = null; txt_New_Quantity.Clear();
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Data cannot remove!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MetroFramework.MetroMessageBox.Show(this, "Please enter all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }

        }

        private void btn_clear_Update_Load_Click(object sender, EventArgs e)
        {
            txt_Load_No_Update.Clear(); txt_Item_No_Update.Clear(); txt_Quantity.Clear(); txt_search3.Clear(); metroGrid_Up_Ld_Itm.DataSource = null; txt_New_Quantity.Clear();
        }

        private void metroGrid_Up_Ld_Itm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Load_No_Update.Text = metroGrid_Up_Ld_Itm.CurrentRow.Cells[0].Value.ToString();
            txt_Item_No_Update.Text = metroGrid_Up_Ld_Itm.CurrentRow.Cells[1].Value.ToString();
            txt_Quantity.Text = metroGrid_Up_Ld_Itm.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
