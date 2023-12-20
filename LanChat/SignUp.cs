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
    public partial class SignUp : Form
    {
        string uid = string.Empty;
        public SignUp(string uid)
        {
            InitializeComponent();
            this.uid = uid;
        }

        string CNS = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
        string QRY = string.Empty;
        SqlConnection CNN;
        SqlCommand CMD;

        private void NewUser_Form_Load(object sender, EventArgs e)
        {
            if (int.Parse(uid) > 2 || int.Parse(uid)==-1)
                {
                    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                }
            // TODO: This line of code loads data into the 'dS_Dept.Tbl_Dept' table. You can move, or remove it, as needed.
            LoadDeparments();
            LoadGender();
            ClearControls();
        }
        void LoadGender()
        {
            txt_gender.Items.Insert(0, "-- Select Gender --");
            txt_gender.Items.Insert(1, "Male");
            txt_gender.Items.Insert(2, "Female");
            txt_gender.Items.Insert(3, "Other");
            txt_gender.SelectedIndex = 0;
        }
        void ClearControls()
        {
            txt_address.Clear();
            txt_cpass.Clear();
            txt_gender.SelectedIndex = 0;
            txt_pass.Clear();
            txt_usname.Clear();
            txtName.Clear();
        }
        void LoadDeparments()
        {
            txtDes.Items.Clear();
            QRY = "SELECT Dep_Id,Dep_Name FROM Tbl_Dept ";
            QRY += "WHERE Dep_IsActive='TRUE'";

            CNN = new SqlConnection(CNS);
            CMD = new SqlCommand(QRY, CNN);
            DataSet DS = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter(CMD);
            DA.Fill(DS);
            txtDept.DataSource = DS.Tables[0];
            txtDept.DisplayMember = DS.Tables[0].Columns["Dep_Name"].ToString();
            txtDept.ValueMember = DS.Tables[0].Columns["Dep_Id"].ToString();
            CNN.Close();
            
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_pass.Text.Equals(txt_cpass.Text))
            {
                QRY = "INSERT INTO Tbl_User VALUES (";
                QRY += "(SELECT MAX(User_Id) + 1 FROM Tbl_User), ";
                QRY += "'" + txtName.Text + "', ";
                QRY += "'" + txt_usname.Text + "', ";
                QRY += "'" + txt_pass.Text + "', ";
                QRY += "'" + txt_address.Text + "', ";
                QRY += "'" + txt_dob.Value.ToShortDateString() + "', ";
                QRY += "'" + txt_gender.SelectedItem.ToString() + "', ";
                QRY +="'"+txtDes.SelectedValue.ToString()+"', ";
                if (int.Parse(uid) > 2 || int.Parse(uid) == -1)
                {
                    QRY += "'FALSE' ";
                }
                else
                {
                    QRY += "'TRUE' ";
                }
                QRY += ")";

                CNN = new SqlConnection(CNS);
                CMD = new SqlCommand(QRY, CNN);
                CNN.Open();
                CMD.ExecuteNonQuery();
                CNN.Close();
                MessageBox.Show("User Created SuccessFully");
                ClearControls();
                if (int.Parse(uid) > 2 || int.Parse(uid) == -1)
                {
                    SignIn g = new SignIn();
                    this.Hide();
                    g.ShowDialog();
                    this.Close();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Password Must Be Same","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txt_pass.Clear();
                txt_cpass.Clear();
                txt_pass.Focus();
            }
        }

        private void chkshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkshowpassword.Checked)
                txt_pass.UseSystemPasswordChar = false;
            else
                txt_pass.UseSystemPasswordChar = true;
        }

        private void txtDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDes.DataSource = null;
            txtDes.Items.Clear();
            if (txtDept.SelectedIndex > -1)
            {
                try
                {
                    QRY = "SELECT Desg_Id,Desg_Name FROM Tbl_Desgi ";
                    QRY += "WHERE Desg_IsActive='TRUE' AND Dep_Id=" + txtDept.SelectedValue.ToString();
                    CNN = new SqlConnection(CNS);
                    CMD = new SqlCommand(QRY, CNN);

                    SqlDataAdapter DA = new SqlDataAdapter(CMD);
                    DataSet DS1 = new DataSet();
                    DA.Fill(DS1);
                    txtDes.DataSource = DS1.Tables[0];
                    txtDes.DisplayMember = DS1.Tables[0].Columns["Desg_Name"].ToString();
                    txtDes.ValueMember = DS1.Tables[0].Columns["Desg_Id"].ToString();                
                }
                catch
                { }
                
            }
            if (txtDes.Items.Count == 0)
            {
                
                txtDes.Items.Add("-- Select Designation --");
            }
            txtDes.SelectedIndex = 0;
        }

        private void txtDes_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(txtDes.ValueMember.ToString());
        }
    }
}
