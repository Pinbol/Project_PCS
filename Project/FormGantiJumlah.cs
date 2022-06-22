using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class FormGantiJumlah : Form
    {
        public String idMember;

        public FormGantiJumlah()
        {
            InitializeComponent();
        }

        public FormGantiJumlah(String produk, String format, String quantity, String id)
        {
            InitializeComponent();

            tb_produk.Text = produk;
            tb_format.Text = format;
            tb_quantityOld.Text = quantity;

            idMember = id;
        }

        private void FormGantiJumlah_Load(object sender, EventArgs e)
        {

        }

        private void btn_ganti_Click(object sender, EventArgs e)
        {
            if (tb_quantityNew.Text == "") MessageBox.Show("Isi jumlah baru terlebih dahulu !");
            else if (!tb_quantityNew.Text.All(char.IsDigit)) MessageBox.Show("Input jumlah baru harus berupa angka !");
            else
            {
                MySqlCommand cmdID = new MySqlCommand();
                cmdID.CommandText = "SELECT sc.`ID` FROM shopping_cart sc, format_product fp, product p, FORMAT f WHERE sc.`PRODUCT_ID` = fp.`ID` AND fp.`FORMAT_ID` = f.id AND fp.`PRODUCT_ID` = p.`ID` AND p.`NAME` = @product AND f.name = @format AND sc.`MEMBER_ID` = @member;";
                cmdID.Parameters.AddWithValue("@product", tb_produk.Text);
                cmdID.Parameters.AddWithValue("@format", tb_format.Text);
                cmdID.Parameters.AddWithValue("@member", idMember);
                cmdID.Connection = koneksi.getConn();

                koneksi.openConn();
                String ID = cmdID.ExecuteScalar().ToString();
                koneksi.closeConn();

                try
                {
                    MySqlCommand cmdUpdate = new MySqlCommand();
                    cmdUpdate.CommandText = "update shopping_cart set quantity = @new where id = @id";
                    cmdUpdate.Parameters.AddWithValue("@new", tb_quantityNew.Text);
                    cmdUpdate.Parameters.AddWithValue("@id", ID);
                    cmdUpdate.Connection = koneksi.getConn();

                    koneksi.openConn();
                    cmdUpdate.ExecuteNonQuery();
                    koneksi.closeConn();

                    MessageBox.Show("Shopping cart berhasil diupdate !");
                    this.Close();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
