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
    public partial class UserStatus : Form
    {
        string QRY = string.Empty;
        string CNS = ConfigurationManager.ConnectionStrings["cnStr"].ToString();
        SqlConnection CNN;
        SqlCommand CMD;

        public UserStatus()
        {
            InitializeComponent();
        }
        void DeactivateUserList()
        {
            QRY = "SELECT User_Id,User_Displayname FROM Tbl_User WHERE User_IsActive='FALSE'";
            CNN = new SqlConnection(CNS);
            CMD = new SqlCommand(QRY, CNN);
            SqlDataAdapter DA = new SqlDataAdapter(CMD);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }
        void ActivateUserList()
        {
            QRY = "SELECT User_Id,User_Displayname FROM Tbl_User WHERE User_IsActive='TRUE'";
            CNN = new SqlConnection(CNS);
            CMD = new SqlCommand(QRY, CNN);
            SqlDataAdapter DA = new SqlDataAdapter(CMD);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView2.DataSource = DS.Tables[0];
        }

        private void UserStatus_Load(object sender, EventArgs e)
        {
            ActivateUserList();
            DeactivateUserList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                QRY = "UPDATE Tbl_User SET User_IsActive='TRUE'";
                QRY += " WHERE User_Id=" + dataGridView1[1, e.RowIndex].Value;
                CNN = new SqlConnection(CNS);
                CMD = new SqlCommand(QRY, CNN);
                CNN.Open();
                CMD.ExecuteNonQuery();
                CNN.Close();
                ActivateUserList();
                DeactivateUserList();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                QRY = "UPDATE Tbl_User SET User_IsActive='FALSE'";
                QRY += " WHERE User_Id=" + dataGridView2[1, e.RowIndex].Value;
                CNN = new SqlConnection(CNS);
                CMD = new SqlCommand(QRY, CNN);
                CNN.Open();
                CMD.ExecuteNonQuery();
                CNN.Close();
                ActivateUserList();
                DeactivateUserList();
            }
        }
    }
}
