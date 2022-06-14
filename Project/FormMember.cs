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
    public partial class FormMember : Form
    {
        public FormMember()
        {
            InitializeComponent();
        }

        private void FormMember_Load(object sender, EventArgs e)
        {
            fillCBSong_1();
            loadDg_product();
        }

        private void fillCBSong_1()
        {
            cb_Genre.Items.Clear();

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM genre ORDER BY CAST(ID AS UNSIGNED);", koneksi.getConn());

            koneksi.openConn();
            MySqlDataReader dr = cmd.ExecuteReader();

            cb_Genre.DisplayMember = "Text";
            cb_Genre.ValueMember = "Value";

            while (dr.Read())
            {
                cb_Genre.Items.Add(new { Text = dr.GetString(1), Value = dr.GetString(0) });
            }

            koneksi.closeConn();
            cb_Genre.SelectedIndex = -1;
        }
        private void loadDg_product()
        {
            dg_Produk.DataSource = null;

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT(p.`NAME`), DATE_FORMAT(p.`RELEASE_DATE`,'%d %M %Y') AS 'Release Date' , p.`DESCRIPTION`, tp.`TYPE_NAME`, p.`RATING` FROM product p ,product_song ps, songs s, genre g, type_product tp WHERE p.`ID` = ps.`PRODUCT_ID` AND ps.`SONG_ID` = s.`ID` AND s.`GENRE_ID` = g.`ID` AND p.`TYPE_ID` = tp.`ID`;", koneksi.getConn());
            MySqlDataAdapter da = new MySqlDataAdapter();

            koneksi.openConn();
            cmd.ExecuteReader();
            koneksi.closeConn();

            da.SelectCommand = cmd;
            da.Fill(dt);

            dg_Produk.DataSource = dt;
        }

        private void fillCb_Format()
        {
            cb_Format.Items.Clear();
           
            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }
            MySqlCommand cmdID = new MySqlCommand("SELECT p.`ID` FROM product p WHERE p.`NAME` = @name;", koneksi.getConn());
            cmdID.Parameters.AddWithValue("@name", tb_Nama2.Text);

            koneksi.openConn();
            string ID = cmdID.ExecuteScalar().ToString();
            koneksi.closeConn();

            MySqlCommand cmd = new MySqlCommand("SELECT fp.`ID`, f.name FROM FORMAT f, format_product fp, product p WHERE f.`ID` = fp.`ID` AND fp.`PRODUCT_ID` = p.`ID` AND p.`ID` = @id ORDER BY CAST(f.id AS UNSIGNED);", koneksi.getConn());
            cmd.Parameters.AddWithValue("@id", ID);
            koneksi.openConn();
            MySqlDataReader dr = cmd.ExecuteReader();

            cb_Format.DisplayMember = "Text";
            cb_Format.ValueMember = "Value";

            while (dr.Read())
            {
                cb_Format.Items.Add(new { Text = dr.GetString(1), Value = dr.GetString(0) });
            }

            koneksi.closeConn();
            cb_Format.SelectedIndex = -1;
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dg_Produk_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_Nama2.Text = dg_Produk.Rows[e.RowIndex].Cells[0].Value.ToString();
            rb_Deskripsi.Text = dg_Produk.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb_rating.Text = dg_Produk.Rows[e.RowIndex].Cells[4].Value.ToString();
            tb_type.Text = dg_Produk.Rows[e.RowIndex].Cells[3].Value.ToString();
            fillCb_Format();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_Nama2.Text = "";
            tb_rating.Text = "";
            tb_type.Text = "";
            rb_Deskripsi.Text = "";
            cb_Format.Items.Clear();
            cb_Format.Text = "";
        }
    }
}
