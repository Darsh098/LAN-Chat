using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filepath;
        bool fedit = false;
        public void newfile()
        {
            rbt1.ForeColor = System.Drawing.Color.Black;
            rbt1.BackColor = System.Drawing.Color.White;
            rbt1.Text = string.Empty;
            rbt1.SelectedText = string.Empty;
            rbt1.SelectedRtf = string.Empty;
            rbt1.Font = new Font("Times New Roman ", 12);
            rbt1.SelectionBackColor = System.Drawing.Color.White;
            this.Text = "Notepad";
            filepath = string.Empty;
            fedit = false;
        }
        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fedit)
                if (DialogResult.Yes == MessageBox.Show("Do You Save This File", "Save File", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    saveToolStripMenuItem_Click(sender, e);
            newfile();
        }

        private void rbt1_TextChanged(object sender, EventArgs e)
        {
            lb1.Text = "Total Characters : "+rbt1.Text.Trim().Length.ToString();
            fedit = true;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbt1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbt1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbt1.Paste();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if(rbt1.SelectedText.Length > 0)
            {
             
                fd.ShowColor = true;
                fd.Font = rbt1.SelectionFont;
                fd.Color = rbt1.SelectionColor;
                 if (DialogResult.OK == fd.ShowDialog())
                {
                    rbt1.SelectionFont = fd.Font;
                    rbt1.SelectionColor = fd.Color;
                    fedit = true;
                }

            }
            else
            {   
              
                fd.ShowColor = true;
                fd.Font = rbt1.Font;
                fd.Color = rbt1.ForeColor;
                 if (DialogResult.OK == fd.ShowDialog())
                {
                    rbt1.Font = fd.Font;
                    rbt1.ForeColor = fd.Color;
                    fedit = true;
                }
            }
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (rbt1.SelectedText.Length > 0)
            {
                cd.Color = rbt1.SelectionBackColor;
                if (DialogResult.OK == cd.ShowDialog())
                {
                    rbt1.SelectionBackColor = cd.Color;
                    fedit = true;
                }
            }
            else
            {
                cd.Color = rbt1.BackColor;
                if (DialogResult.OK == cd.ShowDialog())
                {
                    rbt1.BackColor = cd.Color;
                    fedit = true;
                }
            }
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text File |*.txt|Rich Text|*.rtf";
            if (fedit)
                if (DialogResult.Yes == MessageBox.Show("Do You Save This File", "Save File", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    saveToolStripMenuItem_Click(sender, e);
            if (DialogResult.OK == ofd.ShowDialog())
            {
                if (ofd.FileName.ToString().Contains(".txt"))
                    rbt1.LoadFile(ofd.FileName.ToString(), RichTextBoxStreamType.PlainText);
                else
                    rbt1.LoadFile(ofd.FileName.ToString(), RichTextBoxStreamType.RichText);
            }
            this.Text =mysplit(ofd.FileName.ToString()) + " : Notepad";
            filepath = ofd.FileName.ToString();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (filepath =="")
                saveAsToolStripMenuItem_Click_1(sender, e); 
            else
                if (filepath.ToString().Contains(".txt"))
                    rbt1.SaveFile(filepath.ToString(), RichTextBoxStreamType.PlainText);
                else
                    rbt1.SaveFile(filepath.ToString(), RichTextBoxStreamType.RichText);
                
        }

        private void saveAsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File |*.txt|Rich Text|*.rtf";
            if (DialogResult.OK == sfd.ShowDialog())
            {
                if (sfd.FileName.ToString().Contains(".txt"))
                    rbt1.SaveFile(sfd.FileName.ToString(), RichTextBoxStreamType.PlainText);
                else
                    rbt1.SaveFile(sfd.FileName.ToString(), RichTextBoxStreamType.RichText);
            }
            this.Text =mysplit(sfd.FileName.ToString()) + " : Notepad";
            filepath = sfd.FileName.ToString();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are You Sure You Want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newfile();
        }

        public string mysplit(string fn)
        {
            if (fn.Trim() != "")

                return fn.Split('\\')[fn.Split('\\').Length - 1];
            else
                return null;
        }

      

    }
}
