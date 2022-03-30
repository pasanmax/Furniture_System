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
    public partial class Passwd_Reset : MetroFramework.Forms.MetroForm
    {
        public Passwd_Reset()
        {
            InitializeComponent();
        }
        FurnitureDB FurDB = new FurnitureDB();
        string code;

        private void btn_Sign_Up_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Username.Text.Length != 0 && txt_Create_New_Passwd.Text.Length != 0 && txt_Confirm_Passwd.Text.Length != 0)
                {
                    if (FurDB.readData("select * from Salesman where Salesman_ID='" + txt_Username.Text + "'") == true && FurDB.readData("select * from Login_Data where username='" + txt_Username.Text + "'") == true)
                    {
                        if (txt_Create_New_Passwd.Text.Trim() == txt_Confirm_Passwd.Text.Trim())
                        {
                            if (FurDB.checkPass(txt_Create_New_Passwd.Text) == 1)
                            {
                                code = FurDB.RandomString(6);
                                if (FurDB.sendMail("PASSWORD RESETTING",code, txt_Username.Text, FurDB.readData("select NIC from Salesman where Salesman_ID='" + txt_Username.Text + "'", "NIC", ""), FurDB.readData("select Fname+Lname as [Name] from Salesman where Salesman_ID='" + txt_Username.Text + "'", "Name", ""), FurDB.readData("select Ac_Type from Salesman where Salesman_ID='" + txt_Username.Text + "'", "Ac_Type", "")) == 1)
                                {
                                    MetroFramework.MetroMessageBox.Show(this, "Verification code sent to Admin!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    btn_Verify.Visible = true; txt_Verify.Visible = true; btn_Reset.Visible = false;
                                }
                                else
                                    MetroFramework.MetroMessageBox.Show(this, "Verification code could not sent to Admin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MetroFramework.MetroMessageBox.Show(this, "Password does not Valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MetroFramework.MetroMessageBox.Show(this, "Passwords does not Match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Salesman not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_Verify_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Verify.Text.Length != 0)
                {
                    if (txt_Verify.Text == code)
                    {
                        if (FurDB.readData("select * from Salesman where Salesman_ID='" + txt_Username.Text + "'") == true && FurDB.readData("select * from Login_Data where username='" + txt_Username.Text + "'") == true)
                        {
                            if (txt_Create_New_Passwd.Text.Trim() == txt_Confirm_Passwd.Text.Trim())
                            {
                                if (FurDB.checkPass(txt_Create_New_Passwd.Text) == 1)
                                {
                                    if (FurDB.Insert_Update_Delete("update Login_Data set passwd='" + txt_Create_New_Passwd.Text + "' where username='" + txt_Username.Text + "'") == 1)
                                    {
                                        MetroFramework.MetroMessageBox.Show(this, "Successfull!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txt_Username.Clear(); txt_Create_New_Passwd.Clear(); txt_Confirm_Passwd.Clear(); txt_Verify.Clear(); txt_Verify.Visible = false; btn_Verify.Visible = false; btn_Reset.Visible = true;
                                    }
                                    else
                                        MetroFramework.MetroMessageBox.Show(this, "Unsuccessfull!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                    MetroFramework.MetroMessageBox.Show(this, "Password does not Valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MetroFramework.MetroMessageBox.Show(this, "Passwords does not Match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MetroFramework.MetroMessageBox.Show(this, "Salesman not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Verification code does not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_Clear_SP_Click(object sender, EventArgs e)
        {
            txt_Username.Clear(); txt_Create_New_Passwd.Clear(); txt_Confirm_Passwd.Clear(); txt_Verify.Clear(); txt_Verify.Visible = false; btn_Verify.Visible = false; btn_Reset.Visible = true;
        }

        private void txt_Create_New_Passwd_Click(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTextBox TB = (MetroFramework.Controls.MetroTextBox)sender;
            ToolTip tt = new ToolTip();
            tt.Show("Password minimum length = 6\nShould contain at least a Simple letter,number \nand a Special character", TB, 5, 20, 10000);
        }
    }
}
