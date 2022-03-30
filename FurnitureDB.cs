using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text.RegularExpressions;

namespace Furniture_System
{
    class FurnitureDB
    {
        private static Random random = new Random();
        private string rstr;
        private double rdou;
        private bool rboo;
        private int i;
        private DateTime? dt;
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        
        public FurnitureDB()
        {
            con = new SqlConnection("Data Source=PaSaN;Initial Catalog=FurnitureDB;Integrated Security=True");
        }

        public void OpenCon()
        {
            con.Open();
        }

        public void CloseCon()
        {
            con.Close();
        }

        public int Insert_Update_Delete(string q)
        {
            OpenCon();
            cmd = new SqlCommand(q, con);
            i = cmd.ExecuteNonQuery();
            CloseCon();
            return i;
        }

        public bool readData(string q)
        {
            OpenCon();
            cmd = new SqlCommand(q, con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                rboo = true;
            }
            else
            {
                rboo = false;
            }
            CloseCon();
            return rboo;
        }

        public double readData(string q, string a)
        {
            OpenCon();
            cmd = new SqlCommand(q, con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                rdou = Convert.ToDouble(dr[a]);
            }
            else
                rdou = 0;
            dr.Close();
            CloseCon();
            return rdou;
        } //new

        public string readData(string q, string a, string b)
        {
            OpenCon();
            cmd = new SqlCommand(q, con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                rstr = Convert.ToString((dr[a]));
            }
            else
                rstr = null;
            dr.Close();
            CloseCon();
            return rstr;
        }

        public DataTable getData(string q)
        {
            OpenCon();
            da = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable(); 
            da.Fill(dt);
            CloseCon();
            return dt;
        }
        
        public DataSet getValue(string q)
        {
            OpenCon();
            DataSet ds = new DataSet();
            da = new SqlDataAdapter(q, con);
            da.Fill(ds);
            CloseCon();
            return ds;
        }

        public int delData(string q,string w,string e)
        {
            cmd = new SqlCommand(q, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(w, e);
            OpenCon();
            cmd.ExecuteNonQuery();
            i = cmd.ExecuteNonQuery();
            CloseCon();
            return i;
        }

        public DateTime? getDate(string q)
        {
            OpenCon();
            cmd = new SqlCommand(q, con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
                dt = Convert.ToDateTime(dr[0]);
            else
                dt = null;
            CloseCon();
            return dt; 
        }

        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public int checkPass(string p)
        {
            if (Regex.IsMatch(p, @"^(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{6,}$"))
                return 1;
            else
                return 0;
        }

        public int sendMail(string method,string code,string SID,string SNIC,string SNAME,string SACT)
        {
            
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com",587);
            SmtpServer.Timeout = 100000;
            SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new NetworkCredential("yourgmail@gmail.com", "yourgmailpassword");
            SmtpServer.EnableSsl = true;
            MailMessage mail = new MailMessage();
            mail.To.Add("sendergmail@gmail.com");
            mail.From = new MailAddress("yourgmail@gmail.com");

            if (method == "NEW MEMBER REGISTRATION")
            {
                
                mail.Subject = method;
                mail.Body = "Salesman ID : " + SID + "\nNIC : " + SNIC + "\nFull Name : " + SNAME + "\nAccount Type : " + SACT + "\nVerification Code : " + code + "\n\nMail sent by Ransilu Enterprises";
                SmtpServer.Send(mail);
                return 1;
            }
            else if (method == "PASSWORD RESETTING")
            {
                mail.Subject = method;
                mail.Body = "Salesman ID : " + SID + "\nFull Name : " + SNAME + "\nAccount Type : " + SACT + "\nVerification Code : " + code + "\n\nMail sent by Ransilu Enterprises";
                SmtpServer.Send(mail);
                return 1;
            }
            else
                return 0;
            
        }

        public bool ckLogin(string q)
        {
            OpenCon();
            da = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 1)
                rboo = true;
            else
                rboo = false;
            CloseCon();
            return rboo;
        }
    }
}
