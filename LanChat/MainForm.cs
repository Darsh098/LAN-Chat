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

namespace LanChat
{
    public partial class MainForm : Form
    {
        private int childFormNumber = 0;

        string CNS = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
        string QRY = string.Empty;
        SqlConnection CNN;
        SqlCommand CMD;

        public MainForm(string uid)
        {
            InitializeComponent();
                label1.Text = uid;
        }

        //private void ShowNewForm(object sender, EventArgs e)
        //{
        //    Form childForm = new Form();
        //    childForm.MdiParent = this;
        //    childForm.Text = "Window " + childFormNumber++;
        //    childForm.Show();
        //}
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UserDetailsOff();
            this.IsMdiContainer = false;
            Chat Frm2 = new Chat(label1.Text);
            this.IsMdiContainer = true;
            Frm2.MdiParent = this;
            Frm2.Show();
        }

        void LoadUser_Id()
        {
            QRY = "SELECT User_Id FROM Tbl_ChatOnline WHERE Cht_IsActive='TRUE'";
            CNN = new SqlConnection(CNS);
            CMD = new SqlCommand(QRY, CNN);
            CNN.Open();
            SqlDataReader DR = CMD.ExecuteReader();
            while (DR.Read())
            {
                label1.Text = DR["User_Id"].ToString();
            }
            DR.Close();
            CNN.Close();
        }
        private void MDIParent1_Load(object sender, EventArgs e)
        {
            string desgID = "0";
            QRY = "SELECT Desg_Id FROM Tbl_User WHERE User_Id=" + label1.Text;
            CNN = new SqlConnection(CNS);
            CMD = new SqlCommand(QRY, CNN);
            CNN.Open();
            SqlDataReader DR = CMD.ExecuteReader();
            while (DR.Read())
            {
                desgID = DR["Desg_Id"].ToString();
            }
            DR.Close();
            CMD.Dispose();
            CNN.Close();
            if (int.Parse(desgID.ToString()) != 1)
            {
                guna2Button4.Visible = false;
                guna2Button6.Visible = false;
                guna2Button7.Location = new Point(-1, 335);
            }

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            UserDetailsOff();
            this.IsMdiContainer = false;
            SignUp Frm3 = new SignUp(label1.Text);
            this.IsMdiContainer = true;
            Frm3.MdiParent = this;
            Frm3.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UserDetailsOff();
            this.IsMdiContainer = false;
            Announcement Frm4 = new Announcement(label1.Text);
            this.IsMdiContainer = true;
            Frm4.MdiParent = this;
            Frm4.Show();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            p1.Visible = true;
            p2.Visible = true;
            p3.Visible = true;
            p4.Visible = true;
            guna2CirclePictureBox2.Visible = true;

            QRY = "SELECT User_Name,User_Displayname,User_Dob,User_gender FROM Tbl_User WHERE User_IsActive='TRUE' AND User_Id="+label1.Text;
            CNN = new SqlConnection(CNS);
            CMD = new SqlCommand(QRY, CNN);
            CNN.Open();
            SqlDataReader DR = CMD.ExecuteReader();
            while (DR.Read())
            {
                label3.Text = DR["User_Displayname"].ToString();
                label5.Text = DR["User_Name"].ToString();
                label7.Text = DR["User_Dob"].ToString();
                label9.Text = DR["User_gender"].ToString();
            }
            DR.Close();
            CNN.Close();
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            ExitPage();
        }
        void ExitPage()
        {
            QRY = "DELETE FROM Tbl_IP WHERE User_Id=" + label1.Text;
            CNN = new SqlConnection(CNS);
            CMD = new SqlCommand(QRY, CNN);
            CNN.Open();
            CMD.ExecuteNonQuery();
            CMD.Dispose();

            QRY = "DELETE FROM Tbl_ChatOnline WHERE User_Id=" + label1.Text;
            CMD = new SqlCommand(QRY, CNN);
            CMD.ExecuteNonQuery();
            CNN.Close();
        }

        ToolTip Tp = new ToolTip();

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UserDetailsOff();
            this.IsMdiContainer = false;
            News Frm5 = new News();
            //notepad_demo.Form1 Frm5 = new notepad_demo.Form1();
            this.IsMdiContainer = true;
            Frm5.MdiParent = this;
            Frm5.Show();
        }

        private void guna2Button5_MouseLeave(object sender, EventArgs e)
        {
            Tp.Active = false;
        }

        private void guna2Button1_MouseEnter(object sender, EventArgs e)
        {
            Tp.Active = true;
            Tp.SetToolTip(guna2Button1, "Messages");
            
        }

        private void guna2Button2_MouseEnter(object sender, EventArgs e)
        {
            Tp.Active = true;
            Tp.SetToolTip(guna2Button2, "Announcement");
            
        }

        private void guna2Button3_MouseEnter(object sender, EventArgs e)
        {
            Tp.Active = true;
            Tp.SetToolTip(guna2Button3, "News");
            
        }

        private void guna2Button4_MouseEnter(object sender, EventArgs e)
        {
            Tp.Active = true;
            Tp.SetToolTip(guna2Button4, "Create New User");
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            UserDetailsOff();
            this.IsMdiContainer = false;
            UserStatus Frm6 = new UserStatus();
            this.IsMdiContainer = true;
            Frm6.MdiParent = this;
            Frm6.Show();

        }

        private void guna2Button7_MouseEnter(object sender, EventArgs e)
        {
            Tp.Active = true;
            Tp.SetToolTip(guna2Button7, "LogOut");
        }

        void UserDetailsOff()
        {
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            p1.Visible = false;
            p2.Visible = false;
            p3.Visible = false;
            p4.Visible = false;
            guna2CirclePictureBox2.Visible = false;
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            int i = -1;
            ExitPage();
            label1.Text = i.ToString();
            this.IsMdiContainer = false;
            guna2Button6.Visible = false;
            guna2Button4.Visible = false;
            guna2Button7.Visible = true;
            guna2Button7.Location = new Point(-1, 346);

            UserDetailsOff();
            label3.Text = string.Empty;
            label5.Text = string.Empty;
            label7.Text = string.Empty;
            label9.Text = string.Empty;
            guna2CirclePictureBox1.Visible=false;
            guna2Button1.Visible = false;
        }

        private void guna2Button6_MouseEnter(object sender, EventArgs e)
        {
            Tp.Active = true;
            Tp.SetToolTip(guna2Button6, "User Status");
        }
    }
}