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
    public partial class News : Form
    {
        public News()
        {
            InitializeComponent();
        }

        string CNS = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
        string QRY = string.Empty;
        SqlConnection CNN;
        SqlCommand CMD;

        void LoadData()
        {
            QRY = "SELECT Nw_Title,Nw_Desc FROM Tbl_News WHERE Nw_IsActive='TRUE' ORDER BY Nw_Id";
            CNN = new SqlConnection(CNS);
            CMD = new SqlCommand(QRY, CNN);
            SqlDataAdapter DA = new SqlDataAdapter(CMD);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            DtGrd_News.DataSource = DS.Tables[0];
        }

        private void News_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
