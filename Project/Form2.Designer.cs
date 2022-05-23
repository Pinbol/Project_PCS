
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
            this.panelMembership = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dg_membership = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_name_membership = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_harga_membership = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.nud_wkt_membership = new System.Windows.Forms.NumericUpDown();
            this.btn_insert_membership = new System.Windows.Forms.Button();
            this.btn_update_membership = new System.Windows.Forms.Button();
            this.btn_clear_membership = new System.Windows.Forms.Button();
            this.btn_delete_membership = new System.Windows.Forms.Button();
            this.masterProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPayment = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.dg_payment = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_name_payment = new System.Windows.Forms.TextBox();
            this.btn_delete_payment = new System.Windows.Forms.Button();
            this.btn_clear_payment = new System.Windows.Forms.Button();
            this.btn_update_payment = new System.Windows.Forms.Button();
            this.btn_insert_payment = new System.Windows.Forms.Button();
            this.masterOccupationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.masterPersonelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterProductSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterProductSellingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelOccupation = new System.Windows.Forms.Panel();
            this.btn_delete_occupation = new System.Windows.Forms.Button();
            this.btn_clear_occupation = new System.Windows.Forms.Button();
            this.btn_update_occupation = new System.Windows.Forms.Button();
            this.btn_insert_occupation = new System.Windows.Forms.Button();
            this.tb_name_occupation = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dg_occupation = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_staff)).BeginInit();
            this.gb_status.SuspendLayout();
            this.panelMembership.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_membership)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_wkt_membership)).BeginInit();
            this.panelPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_payment)).BeginInit();
            this.panelOccupation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_occupation)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterStaffToolStripMenuItem,
            this.masterMembershipToolStripMenuItem,
            this.masterOccupationToolStripMenuItem,
            this.masterProductToolStripMenuItem,
            this.masterPaymentToolStripMenuItem});
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
            this.masterOccupationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterOccupationToolStripMenuItem1,
            this.masterPersonelToolStripMenuItem,
            this.masterGroupToolStripMenuItem});
            this.masterOccupationToolStripMenuItem.Name = "masterOccupationToolStripMenuItem";
            this.masterOccupationToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.masterOccupationToolStripMenuItem.Text = "Master Personel";
            // 
            // panelStaff
            // 
            this.panelStaff.Controls.Add(this.label8);
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
            // panelMembership
            // 
            this.panelMembership.Controls.Add(this.btn_delete_membership);
            this.panelMembership.Controls.Add(this.btn_clear_membership);
            this.panelMembership.Controls.Add(this.btn_update_membership);
            this.panelMembership.Controls.Add(this.btn_insert_membership);
            this.panelMembership.Controls.Add(this.nud_wkt_membership);
            this.panelMembership.Controls.Add(this.tb_harga_membership);
            this.panelMembership.Controls.Add(this.label12);
            this.panelMembership.Controls.Add(this.label11);
            this.panelMembership.Controls.Add(this.tb_name_membership);
            this.panelMembership.Controls.Add(this.label10);
            this.panelMembership.Controls.Add(this.dg_membership);
            this.panelMembership.Controls.Add(this.label9);
            this.panelMembership.Location = new System.Drawing.Point(0, 54);
            this.panelMembership.Name = "panelMembership";
            this.panelMembership.Size = new System.Drawing.Size(880, 541);
            this.panelMembership.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Admin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Master Staff";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Master Membership";
            // 
            // dg_membership
            // 
            this.dg_membership.AllowUserToAddRows = false;
            this.dg_membership.AllowUserToDeleteRows = false;
            this.dg_membership.AllowUserToResizeColumns = false;
            this.dg_membership.AllowUserToResizeRows = false;
            this.dg_membership.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_membership.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_membership.Location = new System.Drawing.Point(17, 34);
            this.dg_membership.Name = "dg_membership";
            this.dg_membership.ReadOnly = true;
            this.dg_membership.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_membership.Size = new System.Drawing.Size(851, 300);
            this.dg_membership.TabIndex = 1;
            this.dg_membership.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_membership_CellDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Nama :";
            // 
            // tb_name_membership
            // 
            this.tb_name_membership.Location = new System.Drawing.Point(168, 344);
            this.tb_name_membership.Name = "tb_name_membership";
            this.tb_name_membership.Size = new System.Drawing.Size(164, 20);
            this.tb_name_membership.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 403);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Waktu Expired (bulan) :";
            // 
            // tb_harga_membership
            // 
            this.tb_harga_membership.Location = new System.Drawing.Point(168, 373);
            this.tb_harga_membership.Name = "tb_harga_membership";
            this.tb_harga_membership.Size = new System.Drawing.Size(164, 20);
            this.tb_harga_membership.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 376);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Harga :";
            // 
            // nud_wkt_membership
            // 
            this.nud_wkt_membership.Location = new System.Drawing.Point(168, 401);
            this.nud_wkt_membership.Name = "nud_wkt_membership";
            this.nud_wkt_membership.Size = new System.Drawing.Size(164, 20);
            this.nud_wkt_membership.TabIndex = 8;
            // 
            // btn_insert_membership
            // 
            this.btn_insert_membership.Location = new System.Drawing.Point(480, 484);
            this.btn_insert_membership.Name = "btn_insert_membership";
            this.btn_insert_membership.Size = new System.Drawing.Size(75, 23);
            this.btn_insert_membership.TabIndex = 9;
            this.btn_insert_membership.Text = "Insert";
            this.btn_insert_membership.UseVisualStyleBackColor = true;
            this.btn_insert_membership.Click += new System.EventHandler(this.btn_insert_membership_Click);
            // 
            // btn_update_membership
            // 
            this.btn_update_membership.Location = new System.Drawing.Point(579, 484);
            this.btn_update_membership.Name = "btn_update_membership";
            this.btn_update_membership.Size = new System.Drawing.Size(75, 23);
            this.btn_update_membership.TabIndex = 10;
            this.btn_update_membership.Text = "Update";
            this.btn_update_membership.UseVisualStyleBackColor = true;
            this.btn_update_membership.Click += new System.EventHandler(this.btn_update_membership_Click);
            // 
            // btn_clear_membership
            // 
            this.btn_clear_membership.Location = new System.Drawing.Point(763, 484);
            this.btn_clear_membership.Name = "btn_clear_membership";
            this.btn_clear_membership.Size = new System.Drawing.Size(75, 23);
            this.btn_clear_membership.TabIndex = 11;
            this.btn_clear_membership.Text = "Clear";
            this.btn_clear_membership.UseVisualStyleBackColor = true;
            this.btn_clear_membership.Click += new System.EventHandler(this.btn_clear_membership_Click);
            // 
            // btn_delete_membership
            // 
            this.btn_delete_membership.Location = new System.Drawing.Point(670, 484);
            this.btn_delete_membership.Name = "btn_delete_membership";
            this.btn_delete_membership.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_membership.TabIndex = 12;
            this.btn_delete_membership.Text = "Delete";
            this.btn_delete_membership.UseVisualStyleBackColor = true;
            this.btn_delete_membership.Click += new System.EventHandler(this.btn_delete_membership_Click);
            // 
            // masterProductToolStripMenuItem
            // 
            this.masterProductToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterGenreToolStripMenuItem,
            this.masterSongToolStripMenuItem,
            this.masterFormatToolStripMenuItem,
            this.masterProductSongToolStripMenuItem,
            this.masterProductSellingToolStripMenuItem});
            this.masterProductToolStripMenuItem.Name = "masterProductToolStripMenuItem";
            this.masterProductToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.masterProductToolStripMenuItem.Text = "Master Product";
            // 
            // masterPaymentToolStripMenuItem
            // 
            this.masterPaymentToolStripMenuItem.Name = "masterPaymentToolStripMenuItem";
            this.masterPaymentToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.masterPaymentToolStripMenuItem.Text = "Master Payment";
            this.masterPaymentToolStripMenuItem.Click += new System.EventHandler(this.masterPaymentToolStripMenuItem_Click);
            // 
            // panelPayment
            // 
            this.panelPayment.Controls.Add(this.btn_delete_payment);
            this.panelPayment.Controls.Add(this.btn_clear_payment);
            this.panelPayment.Controls.Add(this.btn_update_payment);
            this.panelPayment.Controls.Add(this.btn_insert_payment);
            this.panelPayment.Controls.Add(this.tb_name_payment);
            this.panelPayment.Controls.Add(this.label14);
            this.panelPayment.Controls.Add(this.dg_payment);
            this.panelPayment.Controls.Add(this.label13);
            this.panelPayment.Location = new System.Drawing.Point(0, 54);
            this.panelPayment.Name = "panelPayment";
            this.panelPayment.Size = new System.Drawing.Size(880, 541);
            this.panelPayment.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Master Payment";
            // 
            // dg_payment
            // 
            this.dg_payment.AllowUserToAddRows = false;
            this.dg_payment.AllowUserToDeleteRows = false;
            this.dg_payment.AllowUserToResizeColumns = false;
            this.dg_payment.AllowUserToResizeRows = false;
            this.dg_payment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_payment.Location = new System.Drawing.Point(21, 34);
            this.dg_payment.Name = "dg_payment";
            this.dg_payment.ReadOnly = true;
            this.dg_payment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_payment.Size = new System.Drawing.Size(847, 289);
            this.dg_payment.TabIndex = 1;
            this.dg_payment.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_payment_CellDoubleClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 347);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Nama :";
            // 
            // tb_name_payment
            // 
            this.tb_name_payment.Location = new System.Drawing.Point(87, 344);
            this.tb_name_payment.Name = "tb_name_payment";
            this.tb_name_payment.Size = new System.Drawing.Size(163, 20);
            this.tb_name_payment.TabIndex = 3;
            // 
            // btn_delete_payment
            // 
            this.btn_delete_payment.Enabled = false;
            this.btn_delete_payment.Location = new System.Drawing.Point(700, 504);
            this.btn_delete_payment.Name = "btn_delete_payment";
            this.btn_delete_payment.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_payment.TabIndex = 16;
            this.btn_delete_payment.Text = "Delete";
            this.btn_delete_payment.UseVisualStyleBackColor = true;
            this.btn_delete_payment.Click += new System.EventHandler(this.btn_delete_payment_Click);
            // 
            // btn_clear_payment
            // 
            this.btn_clear_payment.Location = new System.Drawing.Point(793, 504);
            this.btn_clear_payment.Name = "btn_clear_payment";
            this.btn_clear_payment.Size = new System.Drawing.Size(75, 23);
            this.btn_clear_payment.TabIndex = 15;
            this.btn_clear_payment.Text = "Clear";
            this.btn_clear_payment.UseVisualStyleBackColor = true;
            this.btn_clear_payment.Click += new System.EventHandler(this.btn_clear_payment_Click);
            // 
            // btn_update_payment
            // 
            this.btn_update_payment.Enabled = false;
            this.btn_update_payment.Location = new System.Drawing.Point(609, 504);
            this.btn_update_payment.Name = "btn_update_payment";
            this.btn_update_payment.Size = new System.Drawing.Size(75, 23);
            this.btn_update_payment.TabIndex = 14;
            this.btn_update_payment.Text = "Update";
            this.btn_update_payment.UseVisualStyleBackColor = true;
            this.btn_update_payment.Click += new System.EventHandler(this.btn_update_payment_Click);
            // 
            // btn_insert_payment
            // 
            this.btn_insert_payment.Location = new System.Drawing.Point(510, 504);
            this.btn_insert_payment.Name = "btn_insert_payment";
            this.btn_insert_payment.Size = new System.Drawing.Size(75, 23);
            this.btn_insert_payment.TabIndex = 13;
            this.btn_insert_payment.Text = "Insert";
            this.btn_insert_payment.UseVisualStyleBackColor = true;
            this.btn_insert_payment.Click += new System.EventHandler(this.btn_insert_payment_Click);
            // 
            // masterOccupationToolStripMenuItem1
            // 
            this.masterOccupationToolStripMenuItem1.Name = "masterOccupationToolStripMenuItem1";
            this.masterOccupationToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.masterOccupationToolStripMenuItem1.Text = "Master Occupation";
            this.masterOccupationToolStripMenuItem1.Click += new System.EventHandler(this.masterOccupationToolStripMenuItem1_Click);
            // 
            // masterPersonelToolStripMenuItem
            // 
            this.masterPersonelToolStripMenuItem.Name = "masterPersonelToolStripMenuItem";
            this.masterPersonelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.masterPersonelToolStripMenuItem.Text = "Master Personel";
            // 
            // masterGroupToolStripMenuItem
            // 
            this.masterGroupToolStripMenuItem.Name = "masterGroupToolStripMenuItem";
            this.masterGroupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.masterGroupToolStripMenuItem.Text = "Master Group";
            // 
            // masterGenreToolStripMenuItem
            // 
            this.masterGenreToolStripMenuItem.Name = "masterGenreToolStripMenuItem";
            this.masterGenreToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.masterGenreToolStripMenuItem.Text = "Master Genre";
            // 
            // masterSongToolStripMenuItem
            // 
            this.masterSongToolStripMenuItem.Name = "masterSongToolStripMenuItem";
            this.masterSongToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.masterSongToolStripMenuItem.Text = "Master Song";
            // 
            // masterFormatToolStripMenuItem
            // 
            this.masterFormatToolStripMenuItem.Name = "masterFormatToolStripMenuItem";
            this.masterFormatToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.masterFormatToolStripMenuItem.Text = "Master Format";
            // 
            // masterProductSongToolStripMenuItem
            // 
            this.masterProductSongToolStripMenuItem.Name = "masterProductSongToolStripMenuItem";
            this.masterProductSongToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.masterProductSongToolStripMenuItem.Text = "Master Product-Song";
            // 
            // masterProductSellingToolStripMenuItem
            // 
            this.masterProductSellingToolStripMenuItem.Name = "masterProductSellingToolStripMenuItem";
            this.masterProductSellingToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.masterProductSellingToolStripMenuItem.Text = "Master Product-Selling";
            // 
            // panelOccupation
            // 
            this.panelOccupation.Controls.Add(this.btn_delete_occupation);
            this.panelOccupation.Controls.Add(this.btn_clear_occupation);
            this.panelOccupation.Controls.Add(this.btn_update_occupation);
            this.panelOccupation.Controls.Add(this.btn_insert_occupation);
            this.panelOccupation.Controls.Add(this.tb_name_occupation);
            this.panelOccupation.Controls.Add(this.label15);
            this.panelOccupation.Controls.Add(this.dg_occupation);
            this.panelOccupation.Controls.Add(this.label16);
            this.panelOccupation.Location = new System.Drawing.Point(0, 54);
            this.panelOccupation.Name = "panelOccupation";
            this.panelOccupation.Size = new System.Drawing.Size(880, 541);
            this.panelOccupation.TabIndex = 17;
            // 
            // btn_delete_occupation
            // 
            this.btn_delete_occupation.Enabled = false;
            this.btn_delete_occupation.Location = new System.Drawing.Point(700, 504);
            this.btn_delete_occupation.Name = "btn_delete_occupation";
            this.btn_delete_occupation.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_occupation.TabIndex = 16;
            this.btn_delete_occupation.Text = "Delete";
            this.btn_delete_occupation.UseVisualStyleBackColor = true;
            this.btn_delete_occupation.Click += new System.EventHandler(this.btn_delete_occupation_Click);
            // 
            // btn_clear_occupation
            // 
            this.btn_clear_occupation.Location = new System.Drawing.Point(793, 504);
            this.btn_clear_occupation.Name = "btn_clear_occupation";
            this.btn_clear_occupation.Size = new System.Drawing.Size(75, 23);
            this.btn_clear_occupation.TabIndex = 15;
            this.btn_clear_occupation.Text = "Clear";
            this.btn_clear_occupation.UseVisualStyleBackColor = true;
            this.btn_clear_occupation.Click += new System.EventHandler(this.btn_clear_occupation_Click);
            // 
            // btn_update_occupation
            // 
            this.btn_update_occupation.Enabled = false;
            this.btn_update_occupation.Location = new System.Drawing.Point(609, 504);
            this.btn_update_occupation.Name = "btn_update_occupation";
            this.btn_update_occupation.Size = new System.Drawing.Size(75, 23);
            this.btn_update_occupation.TabIndex = 14;
            this.btn_update_occupation.Text = "Update";
            this.btn_update_occupation.UseVisualStyleBackColor = true;
            this.btn_update_occupation.Click += new System.EventHandler(this.btn_update_occupation_Click);
            // 
            // btn_insert_occupation
            // 
            this.btn_insert_occupation.Location = new System.Drawing.Point(510, 504);
            this.btn_insert_occupation.Name = "btn_insert_occupation";
            this.btn_insert_occupation.Size = new System.Drawing.Size(75, 23);
            this.btn_insert_occupation.TabIndex = 13;
            this.btn_insert_occupation.Text = "Insert";
            this.btn_insert_occupation.UseVisualStyleBackColor = true;
            this.btn_insert_occupation.Click += new System.EventHandler(this.btn_insert_occupation_Click);
            // 
            // tb_name_occupation
            // 
            this.tb_name_occupation.Location = new System.Drawing.Point(87, 344);
            this.tb_name_occupation.Name = "tb_name_occupation";
            this.tb_name_occupation.Size = new System.Drawing.Size(163, 20);
            this.tb_name_occupation.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 347);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Nama :";
            // 
            // dg_occupation
            // 
            this.dg_occupation.AllowUserToAddRows = false;
            this.dg_occupation.AllowUserToDeleteRows = false;
            this.dg_occupation.AllowUserToResizeColumns = false;
            this.dg_occupation.AllowUserToResizeRows = false;
            this.dg_occupation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_occupation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_occupation.Location = new System.Drawing.Point(21, 34);
            this.dg_occupation.Name = "dg_occupation";
            this.dg_occupation.ReadOnly = true;
            this.dg_occupation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_occupation.Size = new System.Drawing.Size(847, 289);
            this.dg_occupation.TabIndex = 1;
            this.dg_occupation.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_occupation_CellDoubleClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(17, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "Master Occupation";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 593);
            this.Controls.Add(this.panelOccupation);
            this.Controls.Add(this.panelPayment);
            this.Controls.Add(this.panelMembership);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panelStaff);
            this.Controls.Add(this.btn_logout);
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
            this.panelMembership.ResumeLayout(false);
            this.panelMembership.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_membership)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_wkt_membership)).EndInit();
            this.panelPayment.ResumeLayout(false);
            this.panelPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_payment)).EndInit();
            this.panelOccupation.ResumeLayout(false);
            this.panelOccupation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_occupation)).EndInit();
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
        private System.Windows.Forms.Panel panelMembership;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dg_membership;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_harga_membership;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_name_membership;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_delete_membership;
        private System.Windows.Forms.Button btn_clear_membership;
        private System.Windows.Forms.Button btn_update_membership;
        private System.Windows.Forms.Button btn_insert_membership;
        private System.Windows.Forms.NumericUpDown nud_wkt_membership;
        private System.Windows.Forms.ToolStripMenuItem masterProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterPaymentToolStripMenuItem;
        private System.Windows.Forms.Panel panelPayment;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dg_payment;
        private System.Windows.Forms.Button btn_delete_payment;
        private System.Windows.Forms.Button btn_clear_payment;
        private System.Windows.Forms.Button btn_update_payment;
        private System.Windows.Forms.Button btn_insert_payment;
        private System.Windows.Forms.TextBox tb_name_payment;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStripMenuItem masterOccupationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem masterPersonelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterGenreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterProductSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterProductSellingToolStripMenuItem;
        private System.Windows.Forms.Panel panelOccupation;
        private System.Windows.Forms.Button btn_delete_occupation;
        private System.Windows.Forms.Button btn_clear_occupation;
        private System.Windows.Forms.Button btn_update_occupation;
        private System.Windows.Forms.Button btn_insert_occupation;
        private System.Windows.Forms.TextBox tb_name_occupation;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dg_occupation;
        private System.Windows.Forms.Label label16;
    }
}