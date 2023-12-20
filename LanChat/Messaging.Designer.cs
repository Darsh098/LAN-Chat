namespace LanChat
{
    partial class Messaging
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grp_User = new System.Windows.Forms.GroupBox();
            this.txtlocalport = new System.Windows.Forms.TextBox();
            this.txtlocalip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_Friend = new System.Windows.Forms.GroupBox();
            this.txtremoteport = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtremoteip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnconnect = new System.Windows.Forms.Button();
            this.lst_msg = new System.Windows.Forms.ListBox();
            this.btnsendmsg = new System.Windows.Forms.Button();
            this.txtmsg = new System.Windows.Forms.TextBox();
            this.grp_User.SuspendLayout();
            this.grp_Friend.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_User
            // 
            this.grp_User.Controls.Add(this.txtlocalport);
            this.grp_User.Controls.Add(this.txtlocalip);
            this.grp_User.Controls.Add(this.label2);
            this.grp_User.Controls.Add(this.label1);
            this.grp_User.Location = new System.Drawing.Point(24, 42);
            this.grp_User.Margin = new System.Windows.Forms.Padding(4);
            this.grp_User.Name = "grp_User";
            this.grp_User.Padding = new System.Windows.Forms.Padding(4);
            this.grp_User.Size = new System.Drawing.Size(386, 168);
            this.grp_User.TabIndex = 0;
            this.grp_User.TabStop = false;
            this.grp_User.Text = "groupBox1";
            // 
            // txtlocalport
            // 
            this.txtlocalport.Location = new System.Drawing.Point(148, 75);
            this.txtlocalport.Name = "txtlocalport";
            this.txtlocalport.Size = new System.Drawing.Size(177, 23);
            this.txtlocalport.TabIndex = 3;
            // 
            // txtlocalip
            // 
            this.txtlocalip.Location = new System.Drawing.Point(143, 28);
            this.txtlocalip.Name = "txtlocalip";
            this.txtlocalip.Size = new System.Drawing.Size(182, 23);
            this.txtlocalip.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter User Port :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter User Ip :";
            // 
            // grp_Friend
            // 
            this.grp_Friend.Controls.Add(this.txtremoteport);
            this.grp_Friend.Controls.Add(this.label4);
            this.grp_Friend.Controls.Add(this.txtremoteip);
            this.grp_Friend.Controls.Add(this.label3);
            this.grp_Friend.Location = new System.Drawing.Point(646, 42);
            this.grp_Friend.Margin = new System.Windows.Forms.Padding(4);
            this.grp_Friend.Name = "grp_Friend";
            this.grp_Friend.Padding = new System.Windows.Forms.Padding(4);
            this.grp_Friend.Size = new System.Drawing.Size(331, 168);
            this.grp_Friend.TabIndex = 1;
            this.grp_Friend.TabStop = false;
            this.grp_Friend.Text = "groupBox2";
            // 
            // txtremoteport
            // 
            this.txtremoteport.Location = new System.Drawing.Point(147, 78);
            this.txtremoteport.Name = "txtremoteport";
            this.txtremoteport.Size = new System.Drawing.Size(177, 23);
            this.txtremoteport.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter Friend Ip :";
            // 
            // txtremoteip
            // 
            this.txtremoteip.Location = new System.Drawing.Point(142, 31);
            this.txtremoteip.Name = "txtremoteip";
            this.txtremoteip.Size = new System.Drawing.Size(182, 23);
            this.txtremoteip.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Friends Port :";
            // 
            // btnconnect
            // 
            this.btnconnect.Location = new System.Drawing.Point(1032, 93);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(113, 44);
            this.btnconnect.TabIndex = 2;
            this.btnconnect.Text = "Start";
            this.btnconnect.UseVisualStyleBackColor = true;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // lst_msg
            // 
            this.lst_msg.FormattingEnabled = true;
            this.lst_msg.ItemHeight = 16;
            this.lst_msg.Location = new System.Drawing.Point(325, 217);
            this.lst_msg.Name = "lst_msg";
            this.lst_msg.Size = new System.Drawing.Size(478, 180);
            this.lst_msg.TabIndex = 3;
            // 
            // btnsendmsg
            // 
            this.btnsendmsg.Location = new System.Drawing.Point(851, 424);
            this.btnsendmsg.Name = "btnsendmsg";
            this.btnsendmsg.Size = new System.Drawing.Size(126, 37);
            this.btnsendmsg.TabIndex = 4;
            this.btnsendmsg.Text = "Send";
            this.btnsendmsg.UseVisualStyleBackColor = true;
            this.btnsendmsg.Click += new System.EventHandler(this.btnsendmsg_Click);
            // 
            // txtmsg
            // 
            this.txtmsg.Location = new System.Drawing.Point(325, 431);
            this.txtmsg.Name = "txtmsg";
            this.txtmsg.Size = new System.Drawing.Size(478, 23);
            this.txtmsg.TabIndex = 5;
            // 
            // Messaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 480);
            this.Controls.Add(this.txtmsg);
            this.Controls.Add(this.btnsendmsg);
            this.Controls.Add(this.lst_msg);
            this.Controls.Add(this.btnconnect);
            this.Controls.Add(this.grp_Friend);
            this.Controls.Add(this.grp_User);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Messaging";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.grp_User.ResumeLayout(false);
            this.grp_User.PerformLayout();
            this.grp_Friend.ResumeLayout(false);
            this.grp_Friend.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_User;
        private System.Windows.Forms.TextBox txtlocalport;
        private System.Windows.Forms.TextBox txtlocalip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_Friend;
        private System.Windows.Forms.TextBox txtremoteport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtremoteip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnconnect;
        private System.Windows.Forms.ListBox lst_msg;
        private System.Windows.Forms.Button btnsendmsg;
        private System.Windows.Forms.TextBox txtmsg;
    }
}

