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
    public partial class Announcement : Form
    {
        string uid;
        public Announcement(string uid)
        {
            InitializeComponent();
            this.uid = uid;
        }
        string QRY = string.Empty;
        string CNS = ConfigurationManager.ConnectionStrings["cnStr"].ToString();
        SqlConnection CNN;
        SqlCommand CMD;

        private void Announcement_Load(object sender, EventArgs e)
        {

            if (int.Parse(uid) > 2 || int.Parse(uid) == -1)
            {
                DtGrd_Ann.Visible = true;
            }
            else DtGrd_Ann.Visible = false;

            string desgID = "0";
            QRY = "SELECT Desg_Id FROM Tbl_User WHERE User_Id=" + uid;
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

            if (int.Parse(desgID.ToString()) < 1 || int.Parse(desgID.ToString())>3)
            {
                txt_Annmsg.Visible = false;
                txt_AnnTitle.Visible = false;
                lb_anntitle.Visible = false;
                lb_annMsg.Visible = false;
                btn_add.Visible = false;
                btn_cancel.Visible = false;
                splitContainer1.SplitterDistance = 76;
            }
            LoadAnnouncement();

        }
        //private void trvDepartment_AfterSelect(object sender, TreeViewEventArgs e)
        //{
        //    try
        //    {               
        //        if (trvDepartment.SelectedNode != null)
        //        {
        //            e.Node.Nodes.Clear();
        //            QRY = "SELECT Desg_Id, Desg_Name FROM Tbl_Desgi ";
        //            QRY += "WHERE Dep_Id=" + trvDepartment.SelectedNode.ToolTipText + " AND Desg_IsActive='TRUE' ";
        //        }
        //        //else
        //        //{
        //        //    QRY = "SELECT User_Displayname FROM Tbl_User WHERE Desg_Id='" + trvDepartment.SelectedNode.Tag + "'";
        //        //}
        //        CNN = new SqlConnection(CNS);
        //            CMD = new SqlCommand(QRY, CNN);
        //            CNN.Open();
        //            SqlDataReader DR = CMD.ExecuteReader();
        //            while (DR.Read())
        //            {

        //                TN = new TreeNode();
        //                TN.Text = DR["Desg_Name"].ToString();
        //                TN.Tag = DR["Desg_Id"].ToString();
        //                trvDepartment.SelectedNode.Nodes.Add(TN);
        //            }
        //            DR.Close();
        //            CNN.Close();
        //            trvDepartment.SelectedNode.ExpandAll();
        //        }            
        //    catch (Exception e11)
        //    {
        //        lstUsers.Items.Clear();
        //        QRY = "SELECT US.User_Displayname FROM Tbl_User US, Tbl_ChatOnline CH WHERE US.Desg_Id='" + trvDepartment.SelectedNode.Tag + "' AND US.User_Id=CH.User_Id";
        //        CNN = new SqlConnection(CNS);
        //        CMD = new SqlCommand(QRY, CNN);
        //        CNN.Open();
        //        SqlDataReader DR = CMD.ExecuteReader();
        //        while (DR.Read())
        //        {
        //            lstUsers.Items.Add(DR["User_Displayname"].ToString());
        //        }
        //        DR.Close();
        //        CNN.Close();
        //    }
        //}



        private void btn_add_Click(object sender, EventArgs e)
        {

            if (txt_AnnTitle.Text != string.Empty && txt_Annmsg.Text != string.Empty)
            {
                QRY = "INSERT INTO Tbl_Ann VALUES ( ";
                QRY += "(SELECT MAX(Ann_Id) + 1 FROM Tbl_Ann), ";
                QRY += "'" + txt_AnnTitle.Text + "', ";
                QRY += "'" + txt_Annmsg.Text + "', 'TRUE' )";

                CNN = new SqlConnection(CNS);
                CMD = new SqlCommand(QRY, CNN);
                CNN.Open();
                CMD.ExecuteNonQuery();
                CNN.Close();
                //splitContainer1.SplitterDistance = 76;
                LoadAnnouncement();
                txt_AnnTitle.Clear();
                txt_Annmsg.Clear();
                txt_AnnTitle.Focus();
            }
            
        }
        void LoadAnnouncement()
        {
            QRY = "SELECT Ann_Title,Ann_Desc FROM Tbl_Ann WHERE Ann_IsActive='TRUE'";
            CNN = new SqlConnection(CNS);
            CMD = new SqlCommand(QRY, CNN);
            SqlDataAdapter DA = new SqlDataAdapter(CMD);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            DtGrd_Ann.DataSource = DS.Tables[0];
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_AnnTitle.Clear();
            txt_Annmsg.Clear();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (btn_view.Text == "View")
            {
                btn_view.Text = "Back";
                DtGrd_Ann.Visible = true;
                splitContainer1.SplitterDistance = 76;
                btn_view.Location = new Point(895, 47);
            }
            else if (btn_view.Text == "Back")
            {
                btn_view.Text = "View";
                splitContainer1.SplitterDistance = 299;
                DtGrd_Ann.Visible = false;
                btn_view.Location = new Point(898, 267);
            }
        }

    }
}
