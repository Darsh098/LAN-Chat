namespace LanChat
{
    partial class Announcement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_view = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lb_annMsg = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_cancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_add = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txt_Annmsg = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_anntitle = new System.Windows.Forms.Label();
            this.txt_AnnTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.DtGrd_Ann = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrd_Ann)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_view);
            this.splitContainer1.Panel1.Controls.Add(this.lb_annMsg);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.btn_cancel);
            this.splitContainer1.Panel1.Controls.Add(this.btn_add);
            this.splitContainer1.Panel1.Controls.Add(this.txt_Annmsg);
            this.splitContainer1.Panel1.Controls.Add(this.lb_anntitle);
            this.splitContainer1.Panel1.Controls.Add(this.txt_AnnTitle);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DtGrd_Ann);
            this.splitContainer1.Size = new System.Drawing.Size(1040, 543);
            this.splitContainer1.SplitterDistance = 299;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_view
            // 
            this.btn_view.AutoRoundedCorners = true;
            this.btn_view.BorderRadius = 14;
            this.btn_view.CheckedState.Parent = this.btn_view;
            this.btn_view.CustomImages.Parent = this.btn_view;
            this.btn_view.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(173)))), ((int)(((byte)(254)))));
            this.btn_view.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(238)))), ((int)(((byte)(254)))));
            this.btn_view.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.btn_view.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.btn_view.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_view.HoverState.Parent = this.btn_view;
            this.btn_view.Location = new System.Drawing.Point(898, 267);
            this.btn_view.Name = "btn_view";
            this.btn_view.ShadowDecoration.Parent = this.btn_view;
            this.btn_view.Size = new System.Drawing.Size(142, 30);
            this.btn_view.TabIndex = 35;
            this.btn_view.Text = "View";
            this.btn_view.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // lb_annMsg
            // 
            this.lb_annMsg.AutoSize = true;
            this.lb_annMsg.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_annMsg.ForeColor = System.Drawing.Color.White;
            this.lb_annMsg.Location = new System.Drawing.Point(171, 149);
            this.lb_annMsg.Name = "lb_annMsg";
            this.lb_annMsg.Size = new System.Drawing.Size(175, 29);
            this.lb_annMsg.TabIndex = 34;
            this.lb_annMsg.Text = "Description : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Verdana", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(382, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(278, 43);
            this.label10.TabIndex = 33;
            this.label10.Text = "Announcement";
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
            this.btn_cancel.Location = new System.Drawing.Point(545, 251);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.ShadowDecoration.Parent = this.btn_cancel;
            this.btn_cancel.Size = new System.Drawing.Size(142, 30);
            this.btn_cancel.TabIndex = 32;
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
            this.btn_add.Location = new System.Drawing.Point(366, 251);
            this.btn_add.Name = "btn_add";
            this.btn_add.ShadowDecoration.Parent = this.btn_add;
            this.btn_add.Size = new System.Drawing.Size(142, 30);
            this.btn_add.TabIndex = 31;
            this.btn_add.Text = "Send";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_Annmsg
            // 
            this.txt_Annmsg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Annmsg.DefaultText = "";
            this.txt_Annmsg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Annmsg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Annmsg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Annmsg.DisabledState.Parent = this.txt_Annmsg;
            this.txt_Annmsg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Annmsg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Annmsg.FocusedState.Parent = this.txt_Annmsg;
            this.txt_Annmsg.ForeColor = System.Drawing.Color.Black;
            this.txt_Annmsg.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Annmsg.HoverState.Parent = this.txt_Annmsg;
            this.txt_Annmsg.Location = new System.Drawing.Point(366, 149);
            this.txt_Annmsg.Multiline = true;
            this.txt_Annmsg.Name = "txt_Annmsg";
            this.txt_Annmsg.PasswordChar = '\0';
            this.txt_Annmsg.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.txt_Annmsg.PlaceholderText = "";
            this.txt_Annmsg.SelectedText = "";
            this.txt_Annmsg.ShadowDecoration.Parent = this.txt_Annmsg;
            this.txt_Annmsg.Size = new System.Drawing.Size(321, 81);
            this.txt_Annmsg.TabIndex = 30;
            // 
            // lb_anntitle
            // 
            this.lb_anntitle.AutoSize = true;
            this.lb_anntitle.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_anntitle.ForeColor = System.Drawing.Color.White;
            this.lb_anntitle.Location = new System.Drawing.Point(256, 97);
            this.lb_anntitle.Name = "lb_anntitle";
            this.lb_anntitle.Size = new System.Drawing.Size(90, 29);
            this.lb_anntitle.TabIndex = 29;
            this.lb_anntitle.Text = "Title : ";
            // 
            // txt_AnnTitle
            // 
            this.txt_AnnTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_AnnTitle.DefaultText = "";
            this.txt_AnnTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_AnnTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_AnnTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_AnnTitle.DisabledState.Parent = this.txt_AnnTitle;
            this.txt_AnnTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_AnnTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_AnnTitle.FocusedState.Parent = this.txt_AnnTitle;
            this.txt_AnnTitle.ForeColor = System.Drawing.Color.Black;
            this.txt_AnnTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_AnnTitle.HoverState.Parent = this.txt_AnnTitle;
            this.txt_AnnTitle.Location = new System.Drawing.Point(366, 97);
            this.txt_AnnTitle.Name = "txt_AnnTitle";
            this.txt_AnnTitle.PasswordChar = '\0';
            this.txt_AnnTitle.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.txt_AnnTitle.PlaceholderText = "";
            this.txt_AnnTitle.SelectedText = "";
            this.txt_AnnTitle.ShadowDecoration.Parent = this.txt_AnnTitle;
            this.txt_AnnTitle.Size = new System.Drawing.Size(321, 19);
            this.txt_AnnTitle.TabIndex = 28;
            // 
            // DtGrd_Ann
            // 
            this.DtGrd_Ann.AllowUserToAddRows = false;
            this.DtGrd_Ann.AllowUserToDeleteRows = false;
            this.DtGrd_Ann.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtGrd_Ann.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtGrd_Ann.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGrd_Ann.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtGrd_Ann.DefaultCellStyle = dataGridViewCellStyle4;
            this.DtGrd_Ann.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtGrd_Ann.Location = new System.Drawing.Point(0, 0);
            this.DtGrd_Ann.Name = "DtGrd_Ann";
            this.DtGrd_Ann.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtGrd_Ann.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DtGrd_Ann.RowHeadersVisible = false;
            this.DtGrd_Ann.RowTemplate.Height = 55;
            this.DtGrd_Ann.Size = new System.Drawing.Size(1040, 240);
            this.DtGrd_Ann.TabIndex = 20;
            this.DtGrd_Ann.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Ann_Title";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Announcement Title";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Ann_Desc";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Announcement Description";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 736;
            // 
            // Announcement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1040, 543);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Announcement";
            this.Text = "Announcement";
            this.Load += new System.EventHandler(this.Announcement_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtGrd_Ann)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2GradientButton btn_cancel;
        private Guna.UI2.WinForms.Guna2GradientButton btn_add;
        private Guna.UI2.WinForms.Guna2TextBox txt_Annmsg;
        private System.Windows.Forms.Label lb_anntitle;
        private Guna.UI2.WinForms.Guna2TextBox txt_AnnTitle;
        private System.Windows.Forms.Label lb_annMsg;
        private System.Windows.Forms.DataGridView DtGrd_Ann;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Guna.UI2.WinForms.Guna2GradientButton btn_view;


    }
}