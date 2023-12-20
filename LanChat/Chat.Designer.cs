namespace LanChat
{
    partial class Chat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trvDepartment = new System.Windows.Forms.TreeView();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.txtremoteport = new System.Windows.Forms.TextBox();
            this.txtlocalport = new System.Windows.Forms.TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtmsg = new System.Windows.Forms.TextBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_cancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_add = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lst_msg = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblocalport = new System.Windows.Forms.Label();
            this.lbremoteport = new System.Windows.Forms.Label();
            this.lbMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.splitContainer1.Panel1.Controls.Add(this.trvDepartment);
            this.splitContainer1.Panel1.Controls.Add(this.lstUsers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(32)))));
            this.splitContainer1.Panel2.Controls.Add(this.lbMsg);
            this.splitContainer1.Panel2.Controls.Add(this.lbremoteport);
            this.splitContainer1.Panel2.Controls.Add(this.lblocalport);
            this.splitContainer1.Panel2.Controls.Add(this.txtremoteport);
            this.splitContainer1.Panel2.Controls.Add(this.txtlocalport);
            this.splitContainer1.Panel2.Controls.Add(this.guna2Button1);
            this.splitContainer1.Panel2.Controls.Add(this.txtmsg);
            this.splitContainer1.Panel2.Controls.Add(this.guna2GradientButton1);
            this.splitContainer1.Panel2.Controls.Add(this.btn_cancel);
            this.splitContainer1.Panel2.Controls.Add(this.btn_add);
            this.splitContainer1.Panel2.Controls.Add(this.lst_msg);
            this.splitContainer1.Size = new System.Drawing.Size(1040, 543);
            this.splitContainer1.SplitterDistance = 208;
            this.splitContainer1.TabIndex = 0;
            // 
            // trvDepartment
            // 
            this.trvDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.trvDepartment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trvDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.trvDepartment.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvDepartment.ForeColor = System.Drawing.Color.White;
            this.trvDepartment.Location = new System.Drawing.Point(0, 0);
            this.trvDepartment.Name = "trvDepartment";
            this.trvDepartment.Size = new System.Drawing.Size(208, 275);
            this.trvDepartment.TabIndex = 1;
            this.trvDepartment.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvDepartment_AfterSelect);
            // 
            // lstUsers
            // 
            this.lstUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.lstUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstUsers.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUsers.ForeColor = System.Drawing.Color.White;
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 25;
            this.lstUsers.Location = new System.Drawing.Point(0, 293);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(208, 250);
            this.lstUsers.TabIndex = 0;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            // 
            // txtremoteport
            // 
            this.txtremoteport.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtremoteport.ForeColor = System.Drawing.Color.Black;
            this.txtremoteport.Location = new System.Drawing.Point(697, 313);
            this.txtremoteport.Name = "txtremoteport";
            this.txtremoteport.Size = new System.Drawing.Size(74, 27);
            this.txtremoteport.TabIndex = 19;
            // 
            // txtlocalport
            // 
            this.txtlocalport.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlocalport.ForeColor = System.Drawing.Color.Black;
            this.txtlocalport.Location = new System.Drawing.Point(276, 313);
            this.txtlocalport.Name = "txtlocalport";
            this.txtlocalport.Size = new System.Drawing.Size(74, 27);
            this.txtlocalport.TabIndex = 18;
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(2, 293);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(51, 32);
            this.guna2Button1.TabIndex = 17;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtmsg
            // 
            this.txtmsg.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmsg.ForeColor = System.Drawing.Color.Black;
            this.txtmsg.Location = new System.Drawing.Point(320, 377);
            this.txtmsg.Name = "txtmsg";
            this.txtmsg.Size = new System.Drawing.Size(451, 27);
            this.txtmsg.TabIndex = 16;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.AutoRoundedCorners = true;
            this.guna2GradientButton1.BorderRadius = 14;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(238)))), ((int)(((byte)(254)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(173)))), ((int)(((byte)(254)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(354, 433);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(142, 30);
            this.guna2GradientButton1.TabIndex = 15;
            this.guna2GradientButton1.Text = "Send To All";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoRoundedCorners = true;
            this.btn_cancel.BorderRadius = 14;
            this.btn_cancel.CheckedState.Parent = this.btn_cancel;
            this.btn_cancel.CustomImages.Parent = this.btn_cancel;
            this.btn_cancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(238)))), ((int)(((byte)(254)))));
            this.btn_cancel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(173)))), ((int)(((byte)(254)))));
            this.btn_cancel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.btn_cancel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.btn_cancel.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_cancel.HoverState.Parent = this.btn_cancel;
            this.btn_cancel.Location = new System.Drawing.Point(629, 433);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.ShadowDecoration.Parent = this.btn_cancel;
            this.btn_cancel.Size = new System.Drawing.Size(142, 30);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_add
            // 
            this.btn_add.AutoRoundedCorners = true;
            this.btn_add.BorderRadius = 14;
            this.btn_add.CheckedState.Parent = this.btn_add;
            this.btn_add.CustomImages.Parent = this.btn_add;
            this.btn_add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(173)))), ((int)(((byte)(254)))));
            this.btn_add.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(238)))), ((int)(((byte)(254)))));
            this.btn_add.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.btn_add.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.btn_add.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_add.HoverState.Parent = this.btn_add;
            this.btn_add.Location = new System.Drawing.Point(82, 433);
            this.btn_add.Name = "btn_add";
            this.btn_add.ShadowDecoration.Parent = this.btn_add;
            this.btn_add.Size = new System.Drawing.Size(142, 30);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Send";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lst_msg
            // 
            this.lst_msg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.lst_msg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_msg.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_msg.ForeColor = System.Drawing.Color.White;
            this.lst_msg.FormattingEnabled = true;
            this.lst_msg.ItemHeight = 29;
            this.lst_msg.Location = new System.Drawing.Point(2, 30);
            this.lst_msg.Name = "lst_msg";
            this.lst_msg.Size = new System.Drawing.Size(826, 261);
            this.lst_msg.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblocalport
            // 
            this.lblocalport.AutoSize = true;
            this.lblocalport.BackColor = System.Drawing.Color.Transparent;
            this.lblocalport.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblocalport.ForeColor = System.Drawing.Color.White;
            this.lblocalport.Location = new System.Drawing.Point(79, 313);
            this.lblocalport.Name = "lblocalport";
            this.lblocalport.Size = new System.Drawing.Size(151, 18);
            this.lblocalport.TabIndex = 20;
            this.lblocalport.Text = "Enter Local Port :";
            // 
            // lbremoteport
            // 
            this.lbremoteport.AutoSize = true;
            this.lbremoteport.BackColor = System.Drawing.Color.Transparent;
            this.lbremoteport.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbremoteport.ForeColor = System.Drawing.Color.White;
            this.lbremoteport.Location = new System.Drawing.Point(479, 313);
            this.lbremoteport.Name = "lbremoteport";
            this.lbremoteport.Size = new System.Drawing.Size(172, 18);
            this.lbremoteport.TabIndex = 21;
            this.lbremoteport.Text = "Enter Remote Port :";
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.BackColor = System.Drawing.Color.Transparent;
            this.lbMsg.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsg.ForeColor = System.Drawing.Color.White;
            this.lbMsg.Location = new System.Drawing.Point(79, 377);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(224, 18);
            this.lbMsg.TabIndex = 22;
            this.lbMsg.Text = "Type Your Message Here :";
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 543);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmChat";
            this.Load += new System.EventHandler(this.Chat_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.TreeView trvDepartment;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox lst_msg;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_cancel;
        private Guna.UI2.WinForms.Guna2GradientButton btn_add;
        private System.Windows.Forms.TextBox txtmsg;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.TextBox txtremoteport;
        private System.Windows.Forms.TextBox txtlocalport;
        private System.Windows.Forms.Label lbMsg;
        private System.Windows.Forms.Label lbremoteport;
        private System.Windows.Forms.Label lblocalport;
    }
}