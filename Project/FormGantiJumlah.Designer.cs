
namespace Project
{
    partial class FormGantiJumlah
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
            this.label_produk = new System.Windows.Forms.Label();
            this.label_quantityBegin = new System.Windows.Forms.Label();
            this.label_format = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_produk = new System.Windows.Forms.TextBox();
            this.tb_quantityOld = new System.Windows.Forms.TextBox();
            this.tb_quantityNew = new System.Windows.Forms.TextBox();
            this.tb_format = new System.Windows.Forms.TextBox();
            this.btn_ganti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_produk
            // 
            this.label_produk.AutoSize = true;
            this.label_produk.Location = new System.Drawing.Point(31, 44);
            this.label_produk.Name = "label_produk";
            this.label_produk.Size = new System.Drawing.Size(47, 13);
            this.label_produk.TabIndex = 0;
            this.label_produk.Text = "Produk :";
            // 
            // label_quantityBegin
            // 
            this.label_quantityBegin.AutoSize = true;
            this.label_quantityBegin.Location = new System.Drawing.Point(31, 93);
            this.label_quantityBegin.Name = "label_quantityBegin";
            this.label_quantityBegin.Size = new System.Drawing.Size(72, 13);
            this.label_quantityBegin.TabIndex = 1;
            this.label_quantityBegin.Text = "Jumlah Awal :";
            // 
            // label_format
            // 
            this.label_format.AutoSize = true;
            this.label_format.Location = new System.Drawing.Point(31, 67);
            this.label_format.Name = "label_format";
            this.label_format.Size = new System.Drawing.Size(45, 13);
            this.label_format.TabIndex = 2;
            this.label_format.Text = "Format :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jumlah Baru :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ganti Jumlah";
            // 
            // tb_produk
            // 
            this.tb_produk.Location = new System.Drawing.Point(136, 37);
            this.tb_produk.Name = "tb_produk";
            this.tb_produk.ReadOnly = true;
            this.tb_produk.Size = new System.Drawing.Size(148, 20);
            this.tb_produk.TabIndex = 5;
            // 
            // tb_quantityOld
            // 
            this.tb_quantityOld.Location = new System.Drawing.Point(136, 90);
            this.tb_quantityOld.Name = "tb_quantityOld";
            this.tb_quantityOld.ReadOnly = true;
            this.tb_quantityOld.Size = new System.Drawing.Size(148, 20);
            this.tb_quantityOld.TabIndex = 6;
            // 
            // tb_quantityNew
            // 
            this.tb_quantityNew.Location = new System.Drawing.Point(136, 118);
            this.tb_quantityNew.Name = "tb_quantityNew";
            this.tb_quantityNew.Size = new System.Drawing.Size(148, 20);
            this.tb_quantityNew.TabIndex = 7;
            // 
            // tb_format
            // 
            this.tb_format.Location = new System.Drawing.Point(136, 64);
            this.tb_format.Name = "tb_format";
            this.tb_format.ReadOnly = true;
            this.tb_format.Size = new System.Drawing.Size(148, 20);
            this.tb_format.TabIndex = 8;
            // 
            // btn_ganti
            // 
            this.btn_ganti.Location = new System.Drawing.Point(111, 157);
            this.btn_ganti.Name = "btn_ganti";
            this.btn_ganti.Size = new System.Drawing.Size(75, 23);
            this.btn_ganti.TabIndex = 9;
            this.btn_ganti.Text = "Ganti";
            this.btn_ganti.UseVisualStyleBackColor = true;
            this.btn_ganti.Click += new System.EventHandler(this.btn_ganti_Click);
            // 
            // FormGantiJumlah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 210);
            this.Controls.Add(this.btn_ganti);
            this.Controls.Add(this.tb_format);
            this.Controls.Add(this.tb_quantityNew);
            this.Controls.Add(this.tb_quantityOld);
            this.Controls.Add(this.tb_produk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_format);
            this.Controls.Add(this.label_quantityBegin);
            this.Controls.Add(this.label_produk);
            this.Name = "FormGantiJumlah";
            this.Text = "FormGantiJumlah";
            this.Load += new System.EventHandler(this.FormGantiJumlah_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_produk;
        private System.Windows.Forms.Label label_quantityBegin;
        private System.Windows.Forms.Label label_format;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_produk;
        private System.Windows.Forms.TextBox tb_quantityOld;
        private System.Windows.Forms.TextBox tb_quantityNew;
        private System.Windows.Forms.TextBox tb_format;
        private System.Windows.Forms.Button btn_ganti;
    }
}