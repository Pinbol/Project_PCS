
namespace Project
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterMembershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterOccupationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelStaff = new System.Windows.Forms.Panel();
            this.dg_staff = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name_staff = new System.Windows.Forms.TextBox();
            this.tb_username_staff = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_password_staff = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_alamat_staff = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rb_l = new System.Windows.Forms.RadioButton();
            this.rb_p = new System.Windows.Forms.RadioButton();
            this.btn_insert_staff = new System.Windows.Forms.Button();
            this.btn_delete_staff = new System.Windows.Forms.Button();
            this.btn_update_staff = new System.Windows.Forms.Button();
            this.btn_clear_staff = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_dob_staff = new System.Windows.Forms.DateTimePicker();
            this.lbl_status_staff = new System.Windows.Forms.Label();
            this.rb_aktif = new System.Windows.Forms.RadioButton();
            this.gb_status = new System.Windows.Forms.GroupBox();
            this.rb_tdk_aktif = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.panelStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_staff)).BeginInit();
            this.gb_status.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterStaffToolStripMenuItem,
            this.masterMembershipToolStripMenuItem,
            this.masterOccupationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterStaffToolStripMenuItem
            // 
            this.masterStaffToolStripMenuItem.Name = "masterStaffToolStripMenuItem";
            this.masterStaffToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.masterStaffToolStripMenuItem.Text = "Master Staff";
            this.masterStaffToolStripMenuItem.Click += new System.EventHandler(this.masterStaffToolStripMenuItem_Click);
            // 
            // masterMembershipToolStripMenuItem
            // 
            this.masterMembershipToolStripMenuItem.Name = "masterMembershipToolStripMenuItem";
            this.masterMembershipToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.masterMembershipToolStripMenuItem.Text = "Master Membership";
            this.masterMembershipToolStripMenuItem.Click += new System.EventHandler(this.masterMembershipToolStripMenuItem_Click);
            // 
            // masterOccupationToolStripMenuItem
            // 
            this.masterOccupationToolStripMenuItem.Name = "masterOccupationToolStripMenuItem";
            this.masterOccupationToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.masterOccupationToolStripMenuItem.Text = "Master Occupation";
            // 
            // panelStaff
            // 
            this.panelStaff.Controls.Add(this.gb_status);
            this.panelStaff.Controls.Add(this.lbl_status_staff);
            this.panelStaff.Controls.Add(this.dtp_dob_staff);
            this.panelStaff.Controls.Add(this.label6);
            this.panelStaff.Controls.Add(this.btn_clear_staff);
            this.panelStaff.Controls.Add(this.btn_update_staff);
            this.panelStaff.Controls.Add(this.btn_delete_staff);
            this.panelStaff.Controls.Add(this.btn_insert_staff);
            this.panelStaff.Controls.Add(this.rb_p);
            this.panelStaff.Controls.Add(this.rb_l);
            this.panelStaff.Controls.Add(this.label5);
            this.panelStaff.Controls.Add(this.tb_alamat_staff);
            this.panelStaff.Controls.Add(this.label4);
            this.panelStaff.Controls.Add(this.tb_password_staff);
            this.panelStaff.Controls.Add(this.label3);
            this.panelStaff.Controls.Add(this.tb_username_staff);
            this.panelStaff.Controls.Add(this.label2);
            this.panelStaff.Controls.Add(this.tb_name_staff);
            this.panelStaff.Controls.Add(this.label1);
            this.panelStaff.Controls.Add(this.dg_staff);
            this.panelStaff.Location = new System.Drawing.Point(0, 54);
            this.panelStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelStaff.Name = "panelStaff";
            this.panelStaff.Size = new System.Drawing.Size(880, 541);
            this.panelStaff.TabIndex = 1;
            // 
            // dg_staff
            // 
            this.dg_staff.AllowUserToAddRows = false;
            this.dg_staff.AllowUserToDeleteRows = false;
            this.dg_staff.AllowUserToResizeColumns = false;
            this.dg_staff.AllowUserToResizeRows = false;
            this.dg_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_staff.Location = new System.Drawing.Point(3, 34);
            this.dg_staff.Name = "dg_staff";
            this.dg_staff.ReadOnly = true;
            this.dg_staff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_staff.Size = new System.Drawing.Size(874, 322);
            this.dg_staff.TabIndex = 0;
            this.dg_staff.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_staff_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama :";
            // 
            // tb_name_staff
            // 
            this.tb_name_staff.Location = new System.Drawing.Point(109, 361);
            this.tb_name_staff.Name = "tb_name_staff";
            this.tb_name_staff.Size = new System.Drawing.Size(291, 20);
            this.tb_name_staff.TabIndex = 2;
            // 
            // tb_username_staff
            // 
            this.tb_username_staff.Location = new System.Drawing.Point(109, 388);
            this.tb_username_staff.Name = "tb_username_staff";
            this.tb_username_staff.Size = new System.Drawing.Size(291, 20);
            this.tb_username_staff.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username :";
            // 
            // tb_password_staff
            // 
            this.tb_password_staff.Location = new System.Drawing.Point(109, 417);
            this.tb_password_staff.Name = "tb_password_staff";
            this.tb_password_staff.Size = new System.Drawing.Size(291, 20);
            this.tb_password_staff.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password :";
            // 
            // tb_alamat_staff
            // 
            this.tb_alamat_staff.Location = new System.Drawing.Point(515, 360);
            this.tb_alamat_staff.Name = "tb_alamat_staff";
            this.tb_alamat_staff.Size = new System.Drawing.Size(291, 20);
            this.tb_alamat_staff.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alamat :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Jenis Kelamin :";
            // 
            // rb_l
            // 
            this.rb_l.AutoSize = true;
            this.rb_l.Location = new System.Drawing.Point(515, 389);
            this.rb_l.Name = "rb_l";
            this.rb_l.Size = new System.Drawing.Size(68, 17);
            this.rb_l.TabIndex = 10;
            this.rb_l.TabStop = true;
            this.rb_l.Text = "Laki-Laki";
            this.rb_l.UseVisualStyleBackColor = true;
            // 
            // rb_p
            // 
            this.rb_p.AutoSize = true;
            this.rb_p.Location = new System.Drawing.Point(611, 389);
            this.rb_p.Name = "rb_p";
            this.rb_p.Size = new System.Drawing.Size(79, 17);
            this.rb_p.TabIndex = 11;
            this.rb_p.TabStop = true;
            this.rb_p.Text = "Perempuan";
            this.rb_p.UseVisualStyleBackColor = true;
            // 
            // btn_insert_staff
            // 
            this.btn_insert_staff.Location = new System.Drawing.Point(515, 484);
            this.btn_insert_staff.Name = "btn_insert_staff";
            this.btn_insert_staff.Size = new System.Drawing.Size(75, 23);
            this.btn_insert_staff.TabIndex = 12;
            this.btn_insert_staff.Text = "Insert";
            this.btn_insert_staff.UseVisualStyleBackColor = true;
            this.btn_insert_staff.Click += new System.EventHandler(this.btn_insert_staff_Click);
            // 
            // btn_delete_staff
            // 
            this.btn_delete_staff.Enabled = false;
            this.btn_delete_staff.Location = new System.Drawing.Point(700, 484);
            this.btn_delete_staff.Name = "btn_delete_staff";
            this.btn_delete_staff.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_staff.TabIndex = 13;
            this.btn_delete_staff.Text = "Delete";
            this.btn_delete_staff.UseVisualStyleBackColor = true;
            this.btn_delete_staff.Click += new System.EventHandler(this.btn_delete_staff_Click);
            // 
            // btn_update_staff
            // 
            this.btn_update_staff.Enabled = false;
            this.btn_update_staff.Location = new System.Drawing.Point(606, 484);
            this.btn_update_staff.Name = "btn_update_staff";
            this.btn_update_staff.Size = new System.Drawing.Size(75, 23);
            this.btn_update_staff.TabIndex = 14;
            this.btn_update_staff.Text = "Update";
            this.btn_update_staff.UseVisualStyleBackColor = true;
            this.btn_update_staff.Click += new System.EventHandler(this.btn_update_staff_Click);
            // 
            // btn_clear_staff
            // 
            this.btn_clear_staff.Location = new System.Drawing.Point(793, 484);
            this.btn_clear_staff.Name = "btn_clear_staff";
            this.btn_clear_staff.Size = new System.Drawing.Size(75, 23);
            this.btn_clear_staff.TabIndex = 15;
            this.btn_clear_staff.Text = "Clear";
            this.btn_clear_staff.UseVisualStyleBackColor = true;
            this.btn_clear_staff.Click += new System.EventHandler(this.btn_clear_staff_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(793, 27);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tanggal Lahir :";
            // 
            // dtp_dob_staff
            // 
            this.dtp_dob_staff.Location = new System.Drawing.Point(515, 414);
            this.dtp_dob_staff.Name = "dtp_dob_staff";
            this.dtp_dob_staff.Size = new System.Drawing.Size(200, 20);
            this.dtp_dob_staff.TabIndex = 17;
            // 
            // lbl_status_staff
            // 
            this.lbl_status_staff.AutoSize = true;
            this.lbl_status_staff.Location = new System.Drawing.Point(419, 456);
            this.lbl_status_staff.Name = "lbl_status_staff";
            this.lbl_status_staff.Size = new System.Drawing.Size(43, 13);
            this.lbl_status_staff.TabIndex = 18;
            this.lbl_status_staff.Text = "Status :";
            this.lbl_status_staff.Visible = false;
            // 
            // rb_aktif
            // 
            this.rb_aktif.AutoSize = true;
            this.rb_aktif.Location = new System.Drawing.Point(18, 16);
            this.rb_aktif.Name = "rb_aktif";
            this.rb_aktif.Size = new System.Drawing.Size(46, 17);
            this.rb_aktif.TabIndex = 19;
            this.rb_aktif.TabStop = true;
            this.rb_aktif.Text = "Aktif";
            this.rb_aktif.UseVisualStyleBackColor = true;
            // 
            // gb_status
            // 
            this.gb_status.Controls.Add(this.rb_tdk_aktif);
            this.gb_status.Controls.Add(this.rb_aktif);
            this.gb_status.Location = new System.Drawing.Point(515, 438);
            this.gb_status.Name = "gb_status";
            this.gb_status.Size = new System.Drawing.Size(200, 40);
            this.gb_status.TabIndex = 20;
            this.gb_status.TabStop = false;
            this.gb_status.Visible = false;
            // 
            // rb_tdk_aktif
            // 
            this.rb_tdk_aktif.AutoSize = true;
            this.rb_tdk_aktif.Location = new System.Drawing.Point(80, 16);
            this.rb_tdk_aktif.Name = "rb_tdk_aktif";
            this.rb_tdk_aktif.Size = new System.Drawing.Size(76, 17);
            this.rb_tdk_aktif.TabIndex = 20;
            this.rb_tdk_aktif.TabStop = true;
            this.rb_tdk_aktif.Text = "Tidak Aktif";
            this.rb_tdk_aktif.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 593);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.panelStaff);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelStaff.ResumeLayout(false);
            this.panelStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_staff)).EndInit();
            this.gb_status.ResumeLayout(false);
            this.gb_status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterMembershipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterOccupationToolStripMenuItem;
        private System.Windows.Forms.Panel panelStaff;
        private System.Windows.Forms.DataGridView dg_staff;
        private System.Windows.Forms.Button btn_update_staff;
        private System.Windows.Forms.Button btn_delete_staff;
        private System.Windows.Forms.Button btn_insert_staff;
        private System.Windows.Forms.RadioButton rb_p;
        private System.Windows.Forms.RadioButton rb_l;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_alamat_staff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_password_staff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_username_staff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_name_staff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clear_staff;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.DateTimePicker dtp_dob_staff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gb_status;
        private System.Windows.Forms.RadioButton rb_tdk_aktif;
        private System.Windows.Forms.RadioButton rb_aktif;
        private System.Windows.Forms.Label lbl_status_staff;
    }
}