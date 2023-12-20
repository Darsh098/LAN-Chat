using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanChat
{
    public partial class GunaUI : Form
    {
        private SignIn frm_SignIn;

        public GunaUI()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ListBox LB = new ListBox();
            LB.Name = "LB_MSG";
            LB.BorderStyle = BorderStyle.None;
            LB.Dock = DockStyle.Top;
            LB.BackColor = Color.FromArgb(78, 173, 254);
            LB.Height = 200;
            splitContainer1.Panel2.Controls.Add(LB);

            TextBox TB = new TextBox();
            TB.Name = "TxtMsg";
            TB.BorderStyle = BorderStyle.None;
            LB.BackColor = Color.FromArgb(4, 238, 254);
            TB.Location = new Point((splitContainer1.Panel2.Width) / 4, 357);
            TB.Height = splitContainer1.Panel2.Height/5;
            TB.Width = splitContainer1.Panel2.Width-((splitContainer1.Panel2.Width) / 2);
            splitContainer1.Panel2.Controls.Add(TB);
            
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GunaUI_Load(object sender, EventArgs e)
        {
            Button btnrun = new Button();
            btnrun.Text = "Run time";
            btnrun.FlatStyle = FlatStyle.Flat;
            btnrun.BackColor = Color.FromArgb(4, 238, 254);
            btnrun.Location = new Point(76,192);
            panel2.Controls.Add(btnrun);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
