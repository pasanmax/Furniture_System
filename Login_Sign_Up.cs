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
    public partial class Login_Sign_Up : MetroFramework.Forms.MetroForm
    {
        public Login_Sign_Up()
        {
            InitializeComponent();
        }
        FurnitureDB FurDB = new FurnitureDB();
        string code;

        private void btn_Sign_Up_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_Sm_ID.Text.Length != 0) && (txt_Fname.Text.Length != 0) && (txt_Lname.Text.Length != 0) && (txt_NIC.Text.Length != 0) && (txt_Contact_No.Text.Length != 0) && (txt_Contact_No.Text.Length == 10) && (txt_Contact_No.Text.Any(char.IsDigit)) && (txt_Create_Passwd.Text.Length != 0) && (txt_Confirm_Passwd.Text.Length != 0) && txt_Fname.Text.All(char.IsLetter) && txt_Lname.Text.All(char.IsLetter))
                {
                    if (FurDB.readData("select * from Salesman where Salesman_ID='" + txt_Sm_ID.Text + "'") == true || FurDB.readData("select * from Salesman where NIC='" + txt_NIC.Text + "'") == true || FurDB.readData("select * from Login_Data where username='" + txt_Sm_ID.Text + "'") == true)
                        MetroFramework.MetroMessageBox.Show(this, "Salesman already found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if ((txt_Create_Passwd.Text.Trim() == txt_Confirm_Passwd.Text.Trim()))
                        {
                            if (FurDB.checkPass(txt_Create_Passwd.Text) == 1)
                            {

                                code = FurDB.RandomString(6);
                                if (FurDB.sendMail("NEW MEMBER REGISTRATION", code, txt_Sm_ID.Text, txt_NIC.Text, txt_Fname.Text + " " + txt_Lname.Text, cmb_Ac_Type.Text) == 1)
                                {
                                    MetroFramework.MetroMessageBox.Show(this, "Verification code sent to Admin!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    btn_Verify.Visible = true; txt_Verify.Visible = true; btn_Sign_Up.Visible = false;
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
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "Please check all fields in correct data type or blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MetroFramework.MetroMessageBox.Show(this, "Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurDB.CloseCon();
            }
        }

        private void btn_Clear_SP_Click(object sender, EventArgs e)
        {
            txt_Sm_ID.Clear(); txt_Fname.Clear(); txt_Lname.Clear(); txt_NIC.Clear(); txt_Contact_No.Clear(); cmb_Ac_Type.SelectedIndex = -1; txt_Create_Passwd.Clear(); txt_Confirm_Passwd.Clear(); txt_Verify.Clear(); txt_Verify.Visible = false; btn_Verify.Visible = false; btn_Sign_Up.Visible = true;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Username.Text.Length != 0 && txt_Passwd.Text.Length != 0)
                {
                    if (FurDB.ckLogin("select * from Login_Data where username='"+txt_Username.Text.Trim()+"' and passwd='"+txt_Passwd.Text.Trim()+"'")==true)
                    {
                        if (txt_Username.Text == "Admin")
                        {
                            Dashboard db = new Dashboard(txt_Username.Text); this.Hide(); db.Show();
                        }
                        else if (FurDB.readData("select Ac_Type from Salesman where Salesman_ID='" + txt_Username.Text + "'", "Ac_Type", "")== "Salesman Officer")
                        {
                            SMO_Dashboard db = new SMO_Dashboard(txt_Username.Text, FurDB.readData("select Fname from Salesman where Salesman_ID='" + txt_Username.Text + "'", "Fname", "")); this.Hide(); db.Show();
                        }
                        else if (FurDB.readData("select Ac_Type from Salesman where Salesman_ID='" + txt_Username.Text + "'", "Ac_Type", "") == "Outlet Salesman Officer")
                        {
                            OSMO_Dashboard db = new OSMO_Dashboard(txt_Username.Text, FurDB.readData("select Fname from Salesman where Salesman_ID='" + txt_Username.Text + "'", "Fname", "")); this.Hide(); db.Show();
                        }
                        else if (FurDB.readData("select Ac_Type from Salesman where Salesman_ID='" + txt_Username.Text + "'", "Ac_Type", "") == "Recovery Officer")
                        {
                            RO_Dashboard db = new RO_Dashboard(txt_Username.Text, FurDB.readData("select Fname from Salesman where Salesman_ID='" + txt_Username.Text + "'", "Fname", "")); this.Hide(); db.Show();
                        }
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Check Username & Password Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_Username.Clear(); txt_Passwd.Clear();
        }

        private void txt_Create_Passwd_Enter(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTextBox TB = (MetroFramework.Controls.MetroTextBox)sender;
            ToolTip tt = new ToolTip();
            tt.Show("Password minimum length = 6\nShould contain at least a Simple letter,number \nand a Special character", TB, 5, 20, 10000);
        }

        private void btn_Verify_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Verify.Text.Length!=0)
                {
                    if (txt_Verify.Text == code)
                    {
                        if (FurDB.readData("select * from Salesman where Salesman_ID='" + txt_Sm_ID.Text + "'") == true || FurDB.readData("select * from Salesman where NIC='" + txt_NIC.Text + "'") == true || FurDB.readData("select * from Login_Data where username='" + txt_Sm_ID.Text + "'") == true)
                            MetroFramework.MetroMessageBox.Show(this, "Salesman already found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            if ((txt_Create_Passwd.Text.Trim() == txt_Confirm_Passwd.Text.Trim()))
                            {
                                if (FurDB.checkPass(txt_Create_Passwd.Text) == 1)
                                {
                                    if (FurDB.Insert_Update_Delete("insert into Salesman values('" + txt_Sm_ID.Text + "','" + txt_Fname.Text + "','" + txt_Lname.Text + "','" + txt_NIC.Text + "','" + cmb_Ac_Type.Text + "','" + txt_Contact_No.Text + "')") == 1 && FurDB.Insert_Update_Delete("insert into Login_Data values ('" + txt_Sm_ID.Text + "','" + txt_Create_Passwd.Text.Trim() + "')") == 1)
                                    {
                                        MetroFramework.MetroMessageBox.Show(this, "Successfull!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txt_Sm_ID.Clear(); txt_Fname.Clear(); txt_Lname.Clear(); txt_NIC.Clear(); txt_Contact_No.Clear(); cmb_Ac_Type.SelectedIndex = -1; txt_Create_Passwd.Clear(); txt_Confirm_Passwd.Clear(); txt_Verify.Clear(); btn_Verify.Visible = false; txt_Verify.Visible = false; btn_Sign_Up.Visible = true;
                                    }
                                    else
                                        MetroFramework.MetroMessageBox.Show(this, "Unsuccessful!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                    MetroFramework.MetroMessageBox.Show(this, "Password does not Valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MetroFramework.MetroMessageBox.Show(this, "Passwords does not Match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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

        private void Forgot_Passwd_Click(object sender, EventArgs e)
        {
            Passwd_Reset pr = new Passwd_Reset();
            pr.ShowDialog();
        }

        private void Login_Sign_Up_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
