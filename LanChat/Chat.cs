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
    public partial class Chat : Form
    {
        Socket sck;
        EndPoint eplocal, epremote;
        string txtlocalip,uid,txtremoteip=string.Empty;
        //,txtlocalport="80",txtremoteport="81"
        public Chat(string uid)
        {
            this.uid = uid;
            InitializeComponent();
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            txtlocalip = getlocalip();
            //txtremoteip = getremoteip();
        }

        string QRY = string.Empty;
        string CNS = ConfigurationManager.ConnectionStrings["cnStr"].ToString();
        SqlConnection CNN;
        SqlCommand CMD;

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
        private string getremoteip()
        {
            string x=string.Empty;
            QRY = "SELECT AB.IP_Address From Tbl_IP AB, Tbl_ChatOnline CH WHERE AB.IP_Id=CH.IP_Id";
            CNN = new SqlConnection(CNS);
            CMD = new SqlCommand(QRY, CNN);
            CNN.Open();
            SqlDataReader DR1 = CMD.ExecuteReader();
            while (DR1.Read())
            {
                x = DR1["IP_Address"].ToString();
            }
            DR1.Close();
            CMD.Dispose();
            CNN.Close();

            return x;
        }
        private void MessageCallBack(IAsyncResult aresult)
        {
            try
            {
                //int size = sck.EndReceiveFrom(aresult, ref epremote);
                //if (size > 0)
                //{
                byte[] receivedData = new byte[1464];
                receivedData = (byte[])aresult.AsyncState;
                ASCIIEncoding eEncoding = new ASCIIEncoding();
                string receivedmessage = eEncoding.GetString(receivedData);
                lst_msg.Items.Add(fname+" : " + receivedmessage);
                //}
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epremote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        private string MYREMOTEIP(string sid)
        {
            string rip = string.Empty;
            QRY = "SELECT IP_Address FROM Tbl_IP WHERE User_Id=" + sid;
            CNN = new SqlConnection(CNS);
            CMD = new SqlCommand(QRY, CNN);
            CNN.Open();
            SqlDataReader DR = CMD.ExecuteReader();
            while (DR.Read())
            {
                rip = DR["IP_Address"].ToString();
            }
            DR.Close();
            CNN.Close();
            return rip;
        }
        int REMOTEUSERID(string uname)
        {
            int sid=-1;
            QRY = "SELECT User_Id FROM Tbl_ChatOnline WHERE User_Displayname='" + uname+"'";
            CNN = new SqlConnection(CNS);
            CMD = new SqlCommand(QRY, CNN);
            CNN.Open();
            SqlDataReader DR = CMD.ExecuteReader();
            while (DR.Read())
            {
                sid = int.Parse(DR["User_Id"].ToString());
            }
            DR.Close();
            CNN.Close();
            return sid;
        }
        string fname=string.Empty;
        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtremoteip = MYREMOTEIP(REMOTEUSERID(lstUsers.SelectedItem.ToString()).ToString());
            if (txtlocalport.Text != string.Empty && txtremoteport.Text != string.Empty)
            {
                try
                {
                    eplocal = new IPEndPoint(IPAddress.Parse(txtlocalip), Convert.ToInt32(txtlocalport.Text));
                    sck.Bind(eplocal);
                    epremote = new IPEndPoint(IPAddress.Parse(txtremoteip), Convert.ToInt32(txtremoteport.Text));
                    sck.Connect(epremote);

                    byte[] buffer = new byte[1500];
                    sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epremote, new AsyncCallback(MessageCallBack), buffer);
                    txtmsg.Focus();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.ToString());
                }
                fname = lstUsers.SelectedItem.ToString();
            }
        }
        TreeNode TN;
        
        void LoadDepartment()
        {
            trvDepartment.Nodes.Clear();
            lstUsers.Items.Clear();
            QRY = "SELECT Dep_Id,Dep_Name FROM Tbl_Dept ";
            QRY += "WHERE Dep_IsActive='TRUE'";
            CNN = new SqlConnection(CNS);
            CMD = new SqlCommand(QRY, CNN);
            CNN.Open();
            SqlDataReader DR = CMD.ExecuteReader();
            while (DR.Read())
            {
                TN = new TreeNode();
                TN.Text = DR["Dep_Name"].ToString();
                TN.ToolTipText = DR["Dep_Id"].ToString();
                trvDepartment.Nodes.Add(TN);
            }
            DR.Close();
            CNN.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadDepartment();
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            LoadDepartment();
            //splitContainer1.Panel2.Enabled = false;
        }

        private void trvDepartment_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (!trvDepartment.SelectedNode.IsExpanded)
                {
                    QRY = "SELECT Desg_Id, Desg_Name FROM Tbl_Desgi ";
                    QRY += "WHERE Dep_Id=" + trvDepartment.SelectedNode.ToolTipText + " AND Desg_IsActive='TRUE' ";
                    CNN = new SqlConnection(CNS);
                    CMD = new SqlCommand(QRY, CNN);
                    CNN.Open();
                    SqlDataReader DR = CMD.ExecuteReader();
                    while (DR.Read())
                    {

                        TN = new TreeNode();
                        TN.Text = DR["Desg_Name"].ToString();
                        TN.Tag = DR["Desg_Id"].ToString();
                        trvDepartment.SelectedNode.Nodes.Add(TN);
                    }
                    DR.Close();
                    CNN.Close();
                    trvDepartment.SelectedNode.ExpandAll();

                }
            }
            catch (Exception e11)
            {
                lstUsers.Items.Clear();
                QRY = "SELECT CH.User_Displayname FROM Tbl_User US, Tbl_ChatOnline CH WHERE US.Desg_Id='" + trvDepartment.SelectedNode.Tag + "' AND CH.User_Id=US.User_Id";
                CNN = new SqlConnection(CNS);
                CMD = new SqlCommand(QRY, CNN);
                CNN.Open();
                SqlDataReader DR = CMD.ExecuteReader();
                    while (DR.Read())
                    {
                        lstUsers.Items.Add(DR["User_Displayname"].ToString());
                    }
                DR.Close();
                CNN.Close();
            }
        }
        

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txtmsg.Text != string.Empty)
            {
                try
                {
                    System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                    byte[] msg = new byte[1500];
                    msg = enc.GetBytes(txtmsg.Text);
                    sck.Send(msg);
                    lst_msg.Items.Add("You : " + txtmsg.Text);
                    txtmsg.Clear();
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString());
                }
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtlocalip);
            //MessageBox.Show(txtlocalport.Text);
            MessageBox.Show(txtremoteip);
            //MessageBox.Show(txtremoteport.Text);

            //try
            //{
            //    System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
            //    byte[] msg = new byte[1500];
            //    msg = enc.GetBytes(txtmsg.Text);
            //    sck.Send(msg);
            //    lst_msg.Items.Add("You : " + txtmsg.Text);
            //    txtmsg.Clear();
            //}
            //catch (Exception e2)
            //{
            //    MessageBox.Show(e2.ToString());
            //}
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txtmsg.Clear();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoadDepartment();
            lst_msg.Items.Clear();
            txtremoteport.Clear();
            txtlocalport.Clear();
            txtmsg.Clear();
        }
        

    }
}
