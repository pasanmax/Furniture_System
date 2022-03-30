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
    public partial class Add_Customer : MetroFramework.Forms.MetroForm
    {
        public Add_Customer()
        {
            InitializeComponent();
        }
        FurnitureDB FurDB = new FurnitureDB();

        private void btn_Add_Cus_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Fname.Text.Length != 0 && txt_Lname.Text.Length != 0 && txt_NIC.Text.Length != 0 && txt_AdrsL1.Text.Length != 0 && txt_AdrsL2.Text.Length != 0 && txt_Customer_No.Text.Length != 0 && txt_Customer_No.Text.Length == 10 && txt_Customer_No.Text.Any(char.IsDigit) && txt_Fname.Text.All(char.IsLetter) && txt_Lname.Text.All(char.IsLetter))
                {
                    if (FurDB.readData("select * from Customer where NIC='" + txt_NIC.Text + "'") == false)
                    {
                        if (FurDB.Insert_Update_Delete("insert into Customer values ('" + txt_NIC.Text + "','" + txt_Fname.Text + "','" + txt_Lname.Text + "','" + txt_AdrsL1.Text + "','" + txt_AdrsL2.Text + "','" + txt_AdrsL3.Text + "','" + txt_Customer_No.Text + "')") == 1)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Customer Added Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_Fname.Clear(); txt_Lname.Clear(); txt_NIC.Clear(); txt_AdrsL1.Clear(); txt_AdrsL2.Clear(); txt_AdrsL3.Clear(); txt_Customer_No.Clear();
                        }
                        else
                            MetroFramework.MetroMessageBox.Show(this, "Customer Cannot Add!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Customer already found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_Fname.Clear(); txt_Lname.Clear(); txt_NIC.Clear(); txt_AdrsL1.Clear(); txt_AdrsL2.Clear(); txt_AdrsL3.Clear(); txt_Customer_No.Clear();
        }
    }
}
