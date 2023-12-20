using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Net.Sockets;

namespace LanChat
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();

        }
        string CNS = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
        string QRY = string.Empty;
        SqlConnection CNN;
        SqlCommand CMD;

        private void chkshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkshowpassword.Checked)
                txtpassword.UseSystemPasswordChar = false;
            else
                txtpassword.UseSystemPasswordChar = true;
        }

        private string getlocalip()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string uname=string.Empty, udisplay=string.Empty, upass=string.Empty,uid=string.Empty;
            QRY = "select * from Tbl_User where ";
            QRY += "User_Name = '" + txtusername.Text + "' AND ";
            QRY += "User_Password = '" + txtpassword.Text + "' AND User_IsActive='TRUE'";

            CNN = new SqlConnection(CNS);
            CMD = new SqlCommand(QRY, CNN);
            SqlDataReader DR;
            CNN.Open();
            DR = CMD.ExecuteReader();
            while (DR.Read())
            {
                uid = DR["User_Id"].ToString();
                udisplay = DR["User_Displayname"].ToString();
                uname = DR["User_Name"].ToString();
                upass = DR["User_Password"].ToString();
            }

            if ((uname == txtusername.Text) && (upass == txtpassword.Text))
            {
                DR.Close();
                CMD.Dispose();

                QRY = "INSERT INTO Tbl_IP VALUES (";
                QRY += "(SELECT MAX(IP_Id)+1 FROM Tbl_IP), ";
                QRY += "" + uid + ", ";
                QRY += "'" + getlocalip() + "', 'TRUE' )";

                CMD = new SqlCommand(QRY, CNN);
                CMD.ExecuteNonQuery();
                CMD.Dispose();

                QRY = "INSERT INTO Tbl_ChatOnline ";
                QRY += "VALUES( ";
                QRY += "" + uid + ", ";
                QRY += "(SELECT IP_Id FROM Tbl_IP WHERE User_Id="+uid+"), ";
                QRY += "'" + udisplay + "', 'TRUE' ";
                QRY += ")";
                CMD = new SqlCommand(QRY, CNN);
                CMD.ExecuteNonQuery();
                CNN.Close();

                //((Form)this.MdiParent).Controls["label1"].Text = uid;
                MainForm g = new MainForm(uid);
                this.Hide();
                g.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong UserName Or Password", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtusername.Clear();
                txtpassword.Clear();
                txtusername.Focus();
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp g = new SignUp("-1");
            this.Hide();
            g.ShowDialog();
            this.Close();
        }
    }
}
