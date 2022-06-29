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
    public partial class FormDetailProduct : Form
    {

        String productName;
        public FormDetailProduct()
        {
            InitializeComponent();
        }

        public FormDetailProduct(String name)
        {
            productName = name;

            InitializeComponent();

            label1.Text = "Daftar Lagu " + productName;

            fillDGDetail();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillDGDetail()
        {
            dg_detailLagu.DataSource = null;

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT s.`NAME` AS 'Judul Lagu', s.`DESCRIPTION` AS 'Description', g.`NAME` AS 'Genre', CONCAT(LPAD(s.`LENGTH` DIV 60,2,'0'), ':',LPAD(s.`LENGTH` MOD 60,2,'0')) AS 'Length' FROM product p, product_song ps, songs s, genre g WHERE p.`ID` = ps.`PRODUCT_ID` AND ps.`SONG_ID` = s.`ID` AND g.`ID` = s.`GENRE_ID` AND p.`NAME`=@name;", koneksi.getConn());
            cmd.Parameters.AddWithValue("@name", productName);
            MySqlDataAdapter da = new MySqlDataAdapter();

            koneksi.openConn();
            cmd.ExecuteReader();
            koneksi.closeConn();

            da.SelectCommand = cmd;
            da.Fill(dt);

            dg_detailLagu.DataSource = dt;
        }
    }
}
