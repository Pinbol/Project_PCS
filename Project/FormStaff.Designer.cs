
namespace Project
{
    partial class FormStaff
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
            this.registerMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restockProdukToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membershipMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.radioButton_Female = new System.Windows.Forms.RadioButton();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_membership_register = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnDaftarMember = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_ADDRESS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_PASSWORD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_USERNAME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_NAME = new System.Windows.Forms.TextBox();
            this.panelRestock = new System.Windows.Forms.Panel();
            this.cb_produk_restock = new System.Windows.Forms.ComboBox();
            this.button_insertProduct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TB_QUANTITY = new System.Windows.Forms.TextBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label_staff = new System.Windows.Forms.Label();
            this.panelMembership = new System.Windows.Forms.Panel();
            this.btn_membership = new System.Windows.Forms.Button();
            this.cb_membership_update = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_nama_update = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dg_membership = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.btn_deliver_order = new System.Windows.Forms.Button();
            this.tb_noteNumber_order = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dg_order = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dg_memberList = new System.Windows.Forms.DataGridView();
            this.btn_orderDetail = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelRegister.SuspendLayout();
            this.panelRestock.SuspendLayout();
            this.panelMembership.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_membership)).BeginInit();
            this.panelOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_memberList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerMemberToolStripMenuItem,
            this.restockProdukToolStripMenuItem,
            this.membershipMemberToolStripMenuItem,
            this.orderMemberToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registerMemberToolStripMenuItem
            // 
            this.registerMemberToolStripMenuItem.Name = "registerMemberToolStripMenuItem";
            this.registerMemberToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.registerMemberToolStripMenuItem.Text = "Register Member";
            this.registerMemberToolStripMenuItem.Click += new System.EventHandler(this.registerMemberToolStripMenuItem_Click);
            // 
            // restockProdukToolStripMenuItem
            // 
            this.restockProdukToolStripMenuItem.Name = "restockProdukToolStripMenuItem";
            this.restockProdukToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.restockProdukToolStripMenuItem.Text = "Restock Produk";
            this.restockProdukToolStripMenuItem.Click += new System.EventHandler(this.restockProdukToolStripMenuItem_Click);
            // 
            // membershipMemberToolStripMenuItem
            // 
            this.membershipMemberToolStripMenuItem.Name = "membershipMemberToolStripMenuItem";
            this.membershipMemberToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.membershipMemberToolStripMenuItem.Text = "Membership Member";
            this.membershipMemberToolStripMenuItem.Click += new System.EventHandler(this.membershipMemberToolStripMenuItem_Click);
            // 
            // orderMemberToolStripMenuItem
            // 
            this.orderMemberToolStripMenuItem.Name = "orderMemberToolStripMenuItem";
            this.orderMemberToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.orderMemberToolStripMenuItem.Text = "Order Member";
            this.orderMemberToolStripMenuItem.Click += new System.EventHandler(this.orderMemberToolStripMenuItem_Click);
            // 
            // panelRegister
            // 
            this.panelRegister.Controls.Add(this.dg_memberList);
            this.panelRegister.Controls.Add(this.label15);
            this.panelRegister.Controls.Add(this.radioButton_Female);
            this.panelRegister.Controls.Add(this.radioButton_Male);
            this.panelRegister.Controls.Add(this.label10);
            this.panelRegister.Controls.Add(this.cb_membership_register);
            this.panelRegister.Controls.Add(this.dateTimePicker_DateOfBirth);
            this.panelRegister.Controls.Add(this.btnDaftarMember);
            this.panelRegister.Controls.Add(this.label5);
            this.panelRegister.Controls.Add(this.label6);
            this.panelRegister.Controls.Add(this.label7);
            this.panelRegister.Controls.Add(this.TB_ADDRESS);
            this.panelRegister.Controls.Add(this.label8);
            this.panelRegister.Controls.Add(this.label3);
            this.panelRegister.Controls.Add(this.TB_PASSWORD);
            this.panelRegister.Controls.Add(this.label4);
            this.panelRegister.Controls.Add(this.TB_USERNAME);
            this.panelRegister.Controls.Add(this.label1);
            this.panelRegister.Controls.Add(this.TB_NAME);
            this.panelRegister.Location = new System.Drawing.Point(0, 69);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(800, 480);
            this.panelRegister.TabIndex = 42;
            // 
            // radioButton_Female
            // 
            this.radioButton_Female.AutoSize = true;
            this.radioButton_Female.Location = new System.Drawing.Point(191, 121);
            this.radioButton_Female.Name = "radioButton_Female";
            this.radioButton_Female.Size = new System.Drawing.Size(67, 17);
            this.radioButton_Female.TabIndex = 49;
            this.radioButton_Female.TabStop = true;
            this.radioButton_Female.Text = "FEMALE";
            this.radioButton_Female.UseVisualStyleBackColor = true;
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Location = new System.Drawing.Point(131, 121);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(54, 17);
            this.radioButton_Male.TabIndex = 48;
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.Text = "MALE";
            this.radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 16);
            this.label10.TabIndex = 46;
            this.label10.Text = "Register Member";
            // 
            // cb_membership_register
            // 
            this.cb_membership_register.FormattingEnabled = true;
            this.cb_membership_register.Location = new System.Drawing.Point(131, 198);
            this.cb_membership_register.Name = "cb_membership_register";
            this.cb_membership_register.Size = new System.Drawing.Size(200, 21);
            this.cb_membership_register.TabIndex = 47;
            // 
            // dateTimePicker_DateOfBirth
            // 
            this.dateTimePicker_DateOfBirth.Location = new System.Drawing.Point(131, 175);
            this.dateTimePicker_DateOfBirth.Name = "dateTimePicker_DateOfBirth";
            this.dateTimePicker_DateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_DateOfBirth.TabIndex = 41;
            // 
            // btnDaftarMember
            // 
            this.btnDaftarMember.Location = new System.Drawing.Point(90, 240);
            this.btnDaftarMember.Name = "btnDaftarMember";
            this.btnDaftarMember.Size = new System.Drawing.Size(75, 23);
            this.btnDaftarMember.TabIndex = 40;
            this.btnDaftarMember.Text = "DAFTAR";
            this.btnDaftarMember.UseVisualStyleBackColor = true;
            this.btnDaftarMember.Click += new System.EventHandler(this.btnDaftarMember_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "MEMBERSHIP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "DATE OF BIRTH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "ADDRESS";
            // 
            // TB_ADDRESS
            // 
            this.TB_ADDRESS.Location = new System.Drawing.Point(131, 146);
            this.TB_ADDRESS.Name = "TB_ADDRESS";
            this.TB_ADDRESS.Size = new System.Drawing.Size(200, 20);
            this.TB_ADDRESS.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "GENDER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "PASSWORD";
            // 
            // TB_PASSWORD
            // 
            this.TB_PASSWORD.Location = new System.Drawing.Point(131, 90);
            this.TB_PASSWORD.Name = "TB_PASSWORD";
            this.TB_PASSWORD.PasswordChar = '*';
            this.TB_PASSWORD.Size = new System.Drawing.Size(200, 20);
            this.TB_PASSWORD.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "USERNAME";
            // 
            // TB_USERNAME
            // 
            this.TB_USERNAME.Location = new System.Drawing.Point(131, 64);
            this.TB_USERNAME.Name = "TB_USERNAME";
            this.TB_USERNAME.Size = new System.Drawing.Size(200, 20);
            this.TB_USERNAME.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "NAME";
            // 
            // TB_NAME
            // 
            this.TB_NAME.Location = new System.Drawing.Point(131, 38);
            this.TB_NAME.Name = "TB_NAME";
            this.TB_NAME.Size = new System.Drawing.Size(200, 20);
            this.TB_NAME.TabIndex = 28;
            // 
            // panelRestock
            // 
            this.panelRestock.Controls.Add(this.cb_produk_restock);
            this.panelRestock.Controls.Add(this.button_insertProduct);
            this.panelRestock.Controls.Add(this.label2);
            this.panelRestock.Controls.Add(this.label18);
            this.panelRestock.Controls.Add(this.label17);
            this.panelRestock.Controls.Add(this.TB_QUANTITY);
            this.panelRestock.Location = new System.Drawing.Point(0, 69);
            this.panelRestock.Name = "panelRestock";
            this.panelRestock.Size = new System.Drawing.Size(800, 480);
            this.panelRestock.TabIndex = 43;
            // 
            // cb_produk_restock
            // 
            this.cb_produk_restock.FormattingEnabled = true;
            this.cb_produk_restock.Location = new System.Drawing.Point(131, 44);
            this.cb_produk_restock.Name = "cb_produk_restock";
            this.cb_produk_restock.Size = new System.Drawing.Size(200, 21);
            this.cb_produk_restock.TabIndex = 49;
            // 
            // button_insertProduct
            // 
            this.button_insertProduct.Location = new System.Drawing.Point(167, 97);
            this.button_insertProduct.Name = "button_insertProduct";
            this.button_insertProduct.Size = new System.Drawing.Size(164, 23);
            this.button_insertProduct.TabIndex = 48;
            this.button_insertProduct.Text = "RESTOCK PRODUCT";
            this.button_insertProduct.UseVisualStyleBackColor = true;
            this.button_insertProduct.Click += new System.EventHandler(this.button_insertProduct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Restock Produk";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "PRODUK";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 13);
            this.label17.TabIndex = 47;
            this.label17.Text = "QUANTITY";
            // 
            // TB_QUANTITY
            // 
            this.TB_QUANTITY.Location = new System.Drawing.Point(131, 71);
            this.TB_QUANTITY.Name = "TB_QUANTITY";
            this.TB_QUANTITY.Size = new System.Drawing.Size(200, 20);
            this.TB_QUANTITY.TabIndex = 46;
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(713, 27);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 44;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // label_staff
            // 
            this.label_staff.AutoSize = true;
            this.label_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_staff.Location = new System.Drawing.Point(11, 27);
            this.label_staff.Name = "label_staff";
            this.label_staff.Size = new System.Drawing.Size(49, 24);
            this.label_staff.TabIndex = 45;
            this.label_staff.Text = "Staff";
            // 
            // panelMembership
            // 
            this.panelMembership.Controls.Add(this.btn_membership);
            this.panelMembership.Controls.Add(this.cb_membership_update);
            this.panelMembership.Controls.Add(this.label12);
            this.panelMembership.Controls.Add(this.tb_nama_update);
            this.panelMembership.Controls.Add(this.label11);
            this.panelMembership.Controls.Add(this.dg_membership);
            this.panelMembership.Controls.Add(this.label9);
            this.panelMembership.Location = new System.Drawing.Point(0, 69);
            this.panelMembership.Name = "panelMembership";
            this.panelMembership.Size = new System.Drawing.Size(800, 480);
            this.panelMembership.TabIndex = 46;
            // 
            // btn_membership
            // 
            this.btn_membership.Location = new System.Drawing.Point(133, 434);
            this.btn_membership.Name = "btn_membership";
            this.btn_membership.Size = new System.Drawing.Size(127, 23);
            this.btn_membership.TabIndex = 54;
            this.btn_membership.Text = "Update Membership";
            this.btn_membership.UseVisualStyleBackColor = true;
            this.btn_membership.Click += new System.EventHandler(this.btn_membership_Click);
            // 
            // cb_membership_update
            // 
            this.cb_membership_update.FormattingEnabled = true;
            this.cb_membership_update.Location = new System.Drawing.Point(108, 398);
            this.cb_membership_update.Name = "cb_membership_update";
            this.cb_membership_update.Size = new System.Drawing.Size(152, 21);
            this.cb_membership_update.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 401);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 52;
            this.label12.Text = "Membership :";
            // 
            // tb_nama_update
            // 
            this.tb_nama_update.Location = new System.Drawing.Point(108, 372);
            this.tb_nama_update.Name = "tb_nama_update";
            this.tb_nama_update.ReadOnly = true;
            this.tb_nama_update.Size = new System.Drawing.Size(152, 20);
            this.tb_nama_update.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 375);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Nama :";
            // 
            // dg_membership
            // 
            this.dg_membership.AllowUserToAddRows = false;
            this.dg_membership.AllowUserToDeleteRows = false;
            this.dg_membership.AllowUserToResizeColumns = false;
            this.dg_membership.AllowUserToResizeRows = false;
            this.dg_membership.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_membership.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_membership.Location = new System.Drawing.Point(0, 38);
            this.dg_membership.Name = "dg_membership";
            this.dg_membership.ReadOnly = true;
            this.dg_membership.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_membership.Size = new System.Drawing.Size(800, 319);
            this.dg_membership.TabIndex = 49;
            this.dg_membership.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_membership_CellDoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 16);
            this.label9.TabIndex = 48;
            this.label9.Text = "Membership Member";
            // 
            // panelOrder
            // 
            this.panelOrder.Controls.Add(this.btn_orderDetail);
            this.panelOrder.Controls.Add(this.btn_deliver_order);
            this.panelOrder.Controls.Add(this.tb_noteNumber_order);
            this.panelOrder.Controls.Add(this.label14);
            this.panelOrder.Controls.Add(this.dg_order);
            this.panelOrder.Controls.Add(this.label13);
            this.panelOrder.Location = new System.Drawing.Point(0, 69);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(800, 480);
            this.panelOrder.TabIndex = 47;
            // 
            // btn_deliver_order
            // 
            this.btn_deliver_order.Location = new System.Drawing.Point(531, 409);
            this.btn_deliver_order.Name = "btn_deliver_order";
            this.btn_deliver_order.Size = new System.Drawing.Size(75, 23);
            this.btn_deliver_order.TabIndex = 53;
            this.btn_deliver_order.Text = "Deliver";
            this.btn_deliver_order.UseVisualStyleBackColor = true;
            this.btn_deliver_order.Click += new System.EventHandler(this.btn_deliver_order_Click);
            // 
            // tb_noteNumber_order
            // 
            this.tb_noteNumber_order.Location = new System.Drawing.Point(108, 411);
            this.tb_noteNumber_order.Name = "tb_noteNumber_order";
            this.tb_noteNumber_order.ReadOnly = true;
            this.tb_noteNumber_order.Size = new System.Drawing.Size(152, 20);
            this.tb_noteNumber_order.TabIndex = 52;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 414);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 51;
            this.label14.Text = "Note Number :";
            // 
            // dg_order
            // 
            this.dg_order.AllowUserToAddRows = false;
            this.dg_order.AllowUserToDeleteRows = false;
            this.dg_order.AllowUserToResizeColumns = false;
            this.dg_order.AllowUserToResizeRows = false;
            this.dg_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_order.Location = new System.Drawing.Point(0, 31);
            this.dg_order.Name = "dg_order";
            this.dg_order.ReadOnly = true;
            this.dg_order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_order.Size = new System.Drawing.Size(800, 367);
            this.dg_order.TabIndex = 50;
            this.dg_order.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_order_CellDoubleClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 16);
            this.label13.TabIndex = 49;
            this.label13.Text = "Order List";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(389, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 16);
            this.label15.TabIndex = 50;
            this.label15.Text = "Member List";
            // 
            // dg_memberList
            // 
            this.dg_memberList.AllowUserToAddRows = false;
            this.dg_memberList.AllowUserToDeleteRows = false;
            this.dg_memberList.AllowUserToResizeColumns = false;
            this.dg_memberList.AllowUserToResizeRows = false;
            this.dg_memberList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_memberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_memberList.Location = new System.Drawing.Point(392, 38);
            this.dg_memberList.Name = "dg_memberList";
            this.dg_memberList.ReadOnly = true;
            this.dg_memberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_memberList.Size = new System.Drawing.Size(396, 319);
            this.dg_memberList.TabIndex = 51;
            // 
            // btn_orderDetail
            // 
            this.btn_orderDetail.Location = new System.Drawing.Point(339, 409);
            this.btn_orderDetail.Name = "btn_orderDetail";
            this.btn_orderDetail.Size = new System.Drawing.Size(106, 23);
            this.btn_orderDetail.TabIndex = 54;
            this.btn_orderDetail.Text = "Order Detail";
            this.btn_orderDetail.UseVisualStyleBackColor = true;
            this.btn_orderDetail.Click += new System.EventHandler(this.btn_orderDetail_Click);
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.panelOrder);
            this.Controls.Add(this.panelRegister);
            this.Controls.Add(this.panelRestock);
            this.Controls.Add(this.panelMembership);
            this.Controls.Add(this.label_staff);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormStaff";
            this.Text = "FormStaff";
            this.Load += new System.EventHandler(this.FormStaff_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.panelRestock.ResumeLayout(false);
            this.panelRestock.PerformLayout();
            this.panelMembership.ResumeLayout(false);
            this.panelMembership.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_membership)).EndInit();
            this.panelOrder.ResumeLayout(false);
            this.panelOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_memberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registerMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restockProdukToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membershipMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderMemberToolStripMenuItem;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateOfBirth;
        private System.Windows.Forms.Button btnDaftarMember;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_ADDRESS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_PASSWORD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_USERNAME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_NAME;
        private System.Windows.Forms.Panel panelRestock;
        private System.Windows.Forms.Button button_insertProduct;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TB_QUANTITY;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label_staff;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_membership_register;
        private System.Windows.Forms.ComboBox cb_produk_restock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panelMembership;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dg_membership;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_membership;
        private System.Windows.Forms.ComboBox cb_membership_update;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_nama_update;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dg_order;
        private System.Windows.Forms.Button btn_deliver_order;
        private System.Windows.Forms.TextBox tb_noteNumber_order;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton radioButton_Female;
        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.DataGridView dg_memberList;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_orderDetail;
    }
}