﻿
namespace Project
{
    partial class FormMember
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
            this.BeliBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBiodataToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Nama = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_GantiJumlah = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Order = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.nud_Jumlah = new System.Windows.Forms.NumericUpDown();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_Format = new System.Windows.Forms.ComboBox();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rb_Deskripsi = new System.Windows.Forms.RichTextBox();
            this.tb_rating = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Nama2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Genre = new System.Windows.Forms.ComboBox();
            this.dg_Cart = new System.Windows.Forms.DataGridView();
            this.dg_Produk = new System.Windows.Forms.DataGridView();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_payment_beliMember = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Jumlah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Cart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Produk)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BeliBarangToolStripMenuItem,
            this.ReviewToolStripMenuItem,
            this.updateBiodataToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BeliBarangToolStripMenuItem
            // 
            this.BeliBarangToolStripMenuItem.Name = "BeliBarangToolStripMenuItem";
            this.BeliBarangToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.BeliBarangToolStripMenuItem.Text = "Beli Barang";
            this.BeliBarangToolStripMenuItem.Click += new System.EventHandler(this.BeliBarangToolStripMenuItem_Click);
            // 
            // ReviewToolStripMenuItem
            // 
            this.ReviewToolStripMenuItem.Name = "ReviewToolStripMenuItem";
            this.ReviewToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ReviewToolStripMenuItem.Text = "Review";
            // 
            // updateBiodataToolStripMenuItem1
            // 
            this.updateBiodataToolStripMenuItem1.Name = "updateBiodataToolStripMenuItem1";
            this.updateBiodataToolStripMenuItem1.Size = new System.Drawing.Size(100, 20);
            this.updateBiodataToolStripMenuItem1.Text = "Update Biodata";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genre:";
            // 
            // tb_Nama
            // 
            this.tb_Nama.Location = new System.Drawing.Point(46, 2);
            this.tb_Nama.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Nama.Name = "tb_Nama";
            this.tb_Nama.Size = new System.Drawing.Size(168, 20);
            this.tb_Nama.TabIndex = 4;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(436, 2);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(56, 20);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Member";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cb_payment_beliMember);
            this.panel1.Controls.Add(this.btn_GantiJumlah);
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.btn_Order);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.nud_Jumlah);
            this.panel1.Controls.Add(this.btn_Clear);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cb_Format);
            this.panel1.Controls.Add(this.tb_type);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.rb_Deskripsi);
            this.panel1.Controls.Add(this.tb_rating);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_Nama2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cb_Genre);
            this.panel1.Controls.Add(this.dg_Cart);
            this.panel1.Controls.Add(this.dg_Produk);
            this.panel1.Controls.Add(this.tb_Nama);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 588);
            this.panel1.TabIndex = 9;
            // 
            // btn_GantiJumlah
            // 
            this.btn_GantiJumlah.Location = new System.Drawing.Point(516, 542);
            this.btn_GantiJumlah.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_GantiJumlah.Name = "btn_GantiJumlah";
            this.btn_GantiJumlah.Size = new System.Drawing.Size(59, 37);
            this.btn_GantiJumlah.TabIndex = 26;
            this.btn_GantiJumlah.Text = "Ganti Jumlah";
            this.btn_GantiJumlah.UseVisualStyleBackColor = true;
            this.btn_GantiJumlah.Click += new System.EventHandler(this.btn_GantiJumlah_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(443, 542);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(59, 37);
            this.btn_Delete.TabIndex = 25;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Order
            // 
            this.btn_Order.Location = new System.Drawing.Point(369, 541);
            this.btn_Order.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(59, 37);
            this.btn_Order.TabIndex = 24;
            this.btn_Order.Text = "Order";
            this.btn_Order.UseVisualStyleBackColor = true;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(253, 346);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(59, 37);
            this.btn_Add.TabIndex = 23;
            this.btn_Add.Text = "Add to Cart";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 531);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Jumlah:";
            // 
            // nud_Jumlah
            // 
            this.nud_Jumlah.Location = new System.Drawing.Point(62, 529);
            this.nud_Jumlah.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nud_Jumlah.Name = "nud_Jumlah";
            this.nud_Jumlah.Size = new System.Drawing.Size(166, 20);
            this.nud_Jumlah.TabIndex = 21;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(253, 296);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(59, 37);
            this.btn_Clear.TabIndex = 11;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 498);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Format:";
            // 
            // cb_Format
            // 
            this.cb_Format.FormattingEnabled = true;
            this.cb_Format.Location = new System.Drawing.Point(62, 496);
            this.cb_Format.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Format.Name = "cb_Format";
            this.cb_Format.Size = new System.Drawing.Size(168, 21);
            this.cb_Format.TabIndex = 19;
            // 
            // tb_type
            // 
            this.tb_type.Location = new System.Drawing.Point(62, 461);
            this.tb_type.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(168, 20);
            this.tb_type.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 461);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 327);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Deskripsi:";
            // 
            // rb_Deskripsi
            // 
            this.rb_Deskripsi.Location = new System.Drawing.Point(62, 325);
            this.rb_Deskripsi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_Deskripsi.Name = "rb_Deskripsi";
            this.rb_Deskripsi.Size = new System.Drawing.Size(168, 82);
            this.rb_Deskripsi.TabIndex = 15;
            this.rb_Deskripsi.Text = "";
            // 
            // tb_rating
            // 
            this.tb_rating.Location = new System.Drawing.Point(62, 426);
            this.tb_rating.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_rating.Name = "tb_rating";
            this.tb_rating.Size = new System.Drawing.Size(168, 20);
            this.tb_rating.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 426);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Rating:";
            // 
            // tb_Nama2
            // 
            this.tb_Nama2.Location = new System.Drawing.Point(62, 296);
            this.tb_Nama2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Nama2.Name = "tb_Nama2";
            this.tb_Nama2.Size = new System.Drawing.Size(168, 20);
            this.tb_Nama2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 296);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nama:";
            // 
            // cb_Genre
            // 
            this.cb_Genre.FormattingEnabled = true;
            this.cb_Genre.Location = new System.Drawing.Point(271, 2);
            this.cb_Genre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Genre.Name = "cb_Genre";
            this.cb_Genre.Size = new System.Drawing.Size(162, 21);
            this.cb_Genre.TabIndex = 10;
            // 
            // dg_Cart
            // 
            this.dg_Cart.AllowUserToAddRows = false;
            this.dg_Cart.AllowUserToDeleteRows = false;
            this.dg_Cart.AllowUserToResizeColumns = false;
            this.dg_Cart.AllowUserToResizeRows = false;
            this.dg_Cart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_Cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Cart.Location = new System.Drawing.Point(369, 288);
            this.dg_Cart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dg_Cart.Name = "dg_Cart";
            this.dg_Cart.ReadOnly = true;
            this.dg_Cart.RowHeadersWidth = 51;
            this.dg_Cart.RowTemplate.Height = 24;
            this.dg_Cart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Cart.Size = new System.Drawing.Size(370, 204);
            this.dg_Cart.TabIndex = 1;
            this.dg_Cart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Cart_CellClick);
            // 
            // dg_Produk
            // 
            this.dg_Produk.AllowUserToAddRows = false;
            this.dg_Produk.AllowUserToDeleteRows = false;
            this.dg_Produk.AllowUserToResizeColumns = false;
            this.dg_Produk.AllowUserToResizeRows = false;
            this.dg_Produk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_Produk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Produk.Location = new System.Drawing.Point(3, 27);
            this.dg_Produk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dg_Produk.Name = "dg_Produk";
            this.dg_Produk.ReadOnly = true;
            this.dg_Produk.RowHeadersWidth = 51;
            this.dg_Produk.RowTemplate.Height = 24;
            this.dg_Produk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Produk.Size = new System.Drawing.Size(736, 257);
            this.dg_Produk.TabIndex = 0;
            this.dg_Produk.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Produk_CellDoubleClick);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Location = new System.Drawing.Point(668, 34);
            this.btn_LogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(71, 41);
            this.btn_LogOut.TabIndex = 10;
            this.btn_LogOut.Text = "Log out";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(366, 506);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Payment :";
            // 
            // cb_payment_beliMember
            // 
            this.cb_payment_beliMember.FormattingEnabled = true;
            this.cb_payment_beliMember.Location = new System.Drawing.Point(436, 503);
            this.cb_payment_beliMember.Margin = new System.Windows.Forms.Padding(2);
            this.cb_payment_beliMember.Name = "cb_payment_beliMember";
            this.cb_payment_beliMember.Size = new System.Drawing.Size(168, 21);
            this.cb_payment_beliMember.TabIndex = 27;
            // 
            // FormMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 670);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMember";
            this.Text = "FormMember";
            this.Load += new System.EventHandler(this.FormMember_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Jumlah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Cart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Produk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BeliBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReviewToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Nama;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dg_Produk;
        private System.Windows.Forms.ToolStripMenuItem updateBiodataToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dg_Cart;
        private System.Windows.Forms.ComboBox cb_Genre;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rb_Deskripsi;
        private System.Windows.Forms.TextBox tb_rating;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Nama2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Format;
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nud_Jumlah;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_GantiJumlah;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_payment_beliMember;
    }
}