using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace LanChat
{
    public partial class Messaging : Form
    {
        Socket sck;
        EndPoint eplocal, epremote;
        public Messaging()
        {
            InitializeComponent();
            sck = new Socket(AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            txtlocalip.Text = getlocalip();
            
        }
     private string getlocalip()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
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
                    lst_msg.Items.Add("Friend : "+receivedmessage);
                //}
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epremote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            try
            {
                eplocal = new IPEndPoint(IPAddress.Parse(txtlocalip.Text), Convert.ToInt32(txtlocalport.Text));
                sck.Bind(eplocal);
                epremote = new IPEndPoint(IPAddress.Parse(txtremoteip.Text), Convert.ToInt32(txtremoteport.Text));
                sck.Connect(epremote);

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epremote, new AsyncCallback(MessageCallBack), buffer);
                btnconnect.Text = "Connected";
                btnconnect.Enabled = false;
                btnsendmsg.Enabled = true;
                txtmsg.Focus();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }

        private void btnsendmsg_Click(object sender, EventArgs e)
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
   
}
