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
        public String member_username;
        public String member_id;
        public String member_name;

        public DataTable dtInternalCart = new DataTable();

        public int cartRowIndex;
        public int reviewRowIndex;

        public FormMember(String username)
        {
            InitializeComponent();
            member_username = username;
        }

        private void FormMember_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panelBiodata.Visible = false;
            panelReview.Visible = false;
            panelHistory.Visible = false;

            fillForm();

            if (dtInternalCart.Columns.Count == 0) prepareDTInternalCart();

            fillCBSong_1();
            fillCBPayment();
            loadDg_product();
            loadDG_ShoppingCart();
        }

        private void fillForm()
        {
            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            MySqlCommand cmd = new MySqlCommand("SELECT id, name from member where username = @username", koneksi.getConn());
            cmd.Parameters.AddWithValue("@username", member_username);

            koneksi.openConn();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                member_id = dr.GetString(0);
                member_name = dr.GetString(1);
            }

            koneksi.closeConn();

            label4.Text = "Selamat Datang, " + member_name;
        }

        private void fillBiodata()
        {
            labelNama_Biodata.Text = "Nama : " + member_name;
            labelUsername_Biodata.Text = "Username : " + member_username;

            MySqlCommand cmdBiodata = new MySqlCommand("select gender, address, date_format(date_of_birth,'%d %M %Y') from member where id = @id", koneksi.getConn());
            cmdBiodata.Parameters.AddWithValue("@id", member_id);

            koneksi.openConn();
            MySqlDataReader dr = cmdBiodata.ExecuteReader();

            while (dr.Read())
            {
                labelJK_Biodata.Text = dr.GetString(0);
                labelAlamat_Biodata.Text = "Alamat : " + dr.GetString(1);
                labelTanggalLahir_Biodata.Text = "Tanggal Lahir : " +  dr.GetString(2);
            }
            koneksi.closeConn();

            if (labelJK_Biodata.Text == "L") labelJK_Biodata.Text = "Jenis Kelamin : Laki-Laki";
            else labelJK_Biodata.Text = "Jenis Kelamin : Perempuan";
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

        private void loadDG_ShoppingCart()
        {
            dg_Cart.DataSource = null;
            dtInternalCart.Rows.Clear();

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT p.`NAME` as 'Produk', f.name as 'Format' ,sc.`QUANTITY` as 'Jumlah', fp.price as 'Harga', fp.price*sc.quantity as 'Subtotal' FROM format_product fp, product p, member m, shopping_cart sc, format f WHERE fp.`PRODUCT_ID` = p.`ID` AND fp.format_id = f.id AND sc.`PRODUCT_ID` = fp.`ID` AND sc.`MEMBER_ID` = m.`ID` AND m.`ID` = @id;", koneksi.getConn());
            cmd.Parameters.AddWithValue("@id", member_id);
            MySqlDataAdapter da = new MySqlDataAdapter();

            koneksi.openConn();
            cmd.ExecuteReader();
            koneksi.closeConn();

            da.SelectCommand = cmd;
            da.Fill(dt);

            dg_Cart.DataSource = dt;

            MySqlCommand cmdTable = new MySqlCommand("SELECT sc.`PRODUCT_ID`, sc.`QUANTITY`, sc.`QUANTITY`*fp.`PRICE` FROM shopping_cart sc, format_product fp WHERE sc.`PRODUCT_ID` = fp.`ID` AND sc.`MEMBER_ID` = @member;", koneksi.getConn());
            cmdTable.Parameters.AddWithValue("@member", member_id);

            koneksi.openConn();
            MySqlDataReader dr = cmdTable.ExecuteReader();

            while (dr.Read())
            {
                dtInternalCart.Rows.Add(dr.GetString(0), dr.GetString(1), dr.GetString(2));
            }
            koneksi.closeConn();
        }

        private void loadDG_Review()
        {
            dg_review.DataSource = null;

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT s.`NAME`, s.`RATING`, 'Song' FROM songs s WHERE s.`ID` NOT IN (SELECT rs.`SONG_ID` FROM review_song rs WHERE rs.`MEMBER_ID` = @member) UNION SELECT p.name, p.rating, 'Product' FROM product p WHERE p.`ID` NOT IN (SELECT rp.`PRODUCT_ID` FROM review_product rp WHERE rp.`MEMBER_ID` = @member);", koneksi.getConn());
            cmd.Parameters.AddWithValue("@member", member_id);
            MySqlDataAdapter da = new MySqlDataAdapter();

            koneksi.openConn();
            cmd.ExecuteReader();
            koneksi.closeConn();

            da.SelectCommand = cmd;
            da.Fill(dt);

            dg_review.DataSource = dt;
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

            MySqlCommand cmd = new MySqlCommand("SELECT fp.`ID`, concat(f.name, ' - ', fp.price) FROM FORMAT f, format_product fp, product p WHERE f.`ID` = fp.`format_id` AND fp.`PRODUCT_ID` = p.`ID` AND p.`ID` = @id ORDER BY CAST(f.id AS UNSIGNED);", koneksi.getConn());
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

        private void fillCBPayment()
        {
            cb_payment_beliMember.Items.Clear();

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            MySqlCommand cmd = new MySqlCommand("SELECT id, name from payment_method ORDER BY CAST(id AS UNSIGNED);", koneksi.getConn());
            koneksi.openConn();
            MySqlDataReader dr = cmd.ExecuteReader();

            cb_payment_beliMember.DisplayMember = "Text";
            cb_payment_beliMember.ValueMember = "Value";

            while (dr.Read())
            {
                cb_payment_beliMember.Items.Add(new { Text = dr.GetString(1), Value = dr.GetString(0) });
            }

            koneksi.closeConn();
            cb_payment_beliMember.SelectedIndex = -1;
        }

        private Boolean checkCond_cart()
        {
            if (cb_Format.SelectedIndex == -1)
            {
                MessageBox.Show("Format produk harus dipilih terlebih dahulu !");
                return false;
            }
            else if (nud_Jumlah.Value == 0)
            {
                MessageBox.Show("Jumlah produk yang dibeli harus lebih dari 0 !");
                return false;
            }
            else return true;
        }

        private void prepareDTInternalCart()
        {
            dtInternalCart.Columns.Add("product_id");
            dtInternalCart.Columns.Add("quantity");
            dtInternalCart.Columns.Add("subtotal");
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

        private void BeliBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panelBiodata.Visible = false;
            panelReview.Visible = false;
            panelHistory.Visible = false;

            if (dtInternalCart.Columns.Count == 0) prepareDTInternalCart();

            fillCBSong_1();
            fillCBPayment();
            loadDg_product();
            loadDG_ShoppingCart();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
           if (checkCond_cart())
            {
                String quantity = nud_Jumlah.Value.ToString();
                String product = (cb_Format.SelectedItem as dynamic).Value;

                MySqlCommand cmdCount = new MySqlCommand();
                cmdCount.CommandText = "select count(*) from shopping_cart where member_id = @member and product_id = @product";
                cmdCount.Parameters.AddWithValue("@member", member_id);
                cmdCount.Parameters.AddWithValue("@product", product);
                cmdCount.Connection = koneksi.getConn();

                koneksi.openConn();
                int count = Convert.ToInt32(cmdCount.ExecuteScalar().ToString());
                koneksi.closeConn();

                if (count==0)
                {
                    MySqlCommand cmdID = new MySqlCommand();
                    cmdID.CommandText = "SELECT cast(id as unsigned)+1 FROM shopping_cart ORDER BY CAST(id AS UNSIGNED) DESC LIMIT 1;";
                    cmdID.Connection = koneksi.getConn();

                    koneksi.openConn();
                    String newID = "";
                    if (Convert.ToInt32(cmdID.ExecuteScalar()).ToString().Equals("0"))
                    {
                        newID = "1";
                    }
                    else newID = cmdID.ExecuteScalar().ToString();
                    koneksi.closeConn();

                    try
                    {
                        MySqlCommand cmdInsert = new MySqlCommand("insert into shopping_cart (id,product_id, member_id, quantity) values (@id,@product,@member,@quantity);", koneksi.getConn());

                        cmdInsert.Parameters.AddWithValue("@id", newID);
                        cmdInsert.Parameters.AddWithValue("@product", product);
                        cmdInsert.Parameters.AddWithValue("@member", member_id);
                        cmdInsert.Parameters.AddWithValue("@quantity", quantity);

                        koneksi.openConn();
                        cmdInsert.ExecuteNonQuery();
                        koneksi.closeConn();

                        loadDG_ShoppingCart();
                        MessageBox.Show("Shopping cart berhasil diupdate !");
                    }
                    catch (MySqlException ex)
                    {
                        loadDG_ShoppingCart();
                        MessageBox.Show(ex.Message);
                    }
                } else
                {
                    try
                    {
                        MySqlCommand cmdUpdate = new MySqlCommand("update shopping_cart set quantity = quantity + @new where member_id = @member and product_id = @product;", koneksi.getConn());
                        cmdUpdate.Parameters.AddWithValue("@new", quantity);
                        cmdUpdate.Parameters.AddWithValue("@member", member_id);
                        cmdUpdate.Parameters.AddWithValue("@product", product);

                        koneksi.openConn();
                        cmdUpdate.ExecuteNonQuery();
                        koneksi.closeConn();

                        loadDG_ShoppingCart();
                        MessageBox.Show("Shopping cart berhasil diupdate !");
                    } catch (Exception ex)
                    {
                        loadDG_ShoppingCart();
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmdNote = new MySqlCommand();
                cmdNote.CommandType = CommandType.StoredProcedure;
                cmdNote.CommandText = "Function_createNote";
                cmdNote.Parameters.Add("@return", MySqlDbType.VarChar);
                cmdNote.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
                cmdNote.Connection = koneksi.getConn();

                koneksi.openConn();
                cmdNote.ExecuteScalar();
                String note = cmdNote.Parameters["@return"].Value.ToString();
                koneksi.closeConn();

                koneksi.openConn();
                using (MySqlTransaction trans = koneksi.getConn().BeginTransaction())
                {
                    try
                    {
                        int sumTotal = 0;
                        for (int i=0; i<dtInternalCart.Rows.Count; i++)
                        {
                            sumTotal += Convert.ToInt32(dtInternalCart.Rows[i][2].ToString());
                        }

                        String date = DateTime.Today.ToString("yyyy-MM-dd");
                        String payment = (cb_payment_beliMember.SelectedItem as dynamic).Value;

                        MySqlCommand cmdOrder = new MySqlCommand("insert into orders (note_number, order_date, member_id,status, payment_method, total) values (@note, @date, @member, 'PENDING', @payment, @total)", koneksi.getConn());
                        cmdOrder.Parameters.AddWithValue("@note", note);
                        cmdOrder.Parameters.AddWithValue("@date", date);
                        cmdOrder.Parameters.AddWithValue("@member", member_id);
                        cmdOrder.Parameters.AddWithValue("@payment", payment);
                        cmdOrder.Parameters.AddWithValue("@total", sumTotal);

                        cmdOrder.ExecuteNonQuery();

                        for (int i=0; i<dtInternalCart.Rows.Count; i++)
                        {
                            MySqlCommand cmdID = new MySqlCommand();
                            cmdID.CommandText = "SELECT cast(detail_id as unsigned)+1 FROM orderdetails ORDER BY CAST(detail_id AS UNSIGNED) DESC LIMIT 1;";
                            cmdID.Connection = koneksi.getConn();

                            String newID = cmdID.ExecuteScalar().ToString();

                            MySqlCommand cmdDetail = new MySqlCommand("insert into orderdetails (detail_id, note_number, product_id, quantity, subtotal) values (@id, @note, @product, @quantity, @subtotal)", koneksi.getConn());
                            cmdDetail.Parameters.AddWithValue("@id", newID);
                            cmdDetail.Parameters.AddWithValue("@note", note);
                            cmdDetail.Parameters.AddWithValue("@product", dtInternalCart.Rows[i][0].ToString());
                            cmdDetail.Parameters.AddWithValue("@quantity", dtInternalCart.Rows[i][1].ToString());
                            cmdDetail.Parameters.AddWithValue("@subtotal", dtInternalCart.Rows[i][2].ToString());

                            cmdDetail.ExecuteNonQuery();
                        }

                        dtInternalCart.Rows.Clear();
                        MySqlCommand cmdDelete = new MySqlCommand("delete from shopping_cart where member_id = @id", koneksi.getConn());
                        cmdDelete.Parameters.AddWithValue("@id", member_id);

                        cmdDelete.ExecuteNonQuery();

                        trans.Commit();

                        MessageBox.Show("Order berhasil !");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        trans.Rollback();
                    }
                }
                koneksi.closeConn();
                loadDG_ShoppingCart();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            String produk = dg_Cart.Rows[cartRowIndex].Cells[0].Value.ToString();
            String format = dg_Cart.Rows[cartRowIndex].Cells[1].Value.ToString();

            try
            {
                MySqlCommand cmdID = new MySqlCommand();
                cmdID.CommandText = "SELECT fp.`ID` FROM format_product fp, product p, FORMAT f WHERE fp.`FORMAT_ID` = f.id AND fp.`PRODUCT_ID` = p.`ID` AND f.name = @format AND p.`NAME` = @product;";
                cmdID.Parameters.AddWithValue("@format", format);
                cmdID.Parameters.AddWithValue("@product", produk);
                cmdID.Connection = koneksi.getConn();

                koneksi.openConn();
                String newID = cmdID.ExecuteScalar().ToString();
                koneksi.closeConn();

                MySqlCommand cmdDelete = new MySqlCommand();
                cmdDelete.CommandText = "DELETE sc FROM shopping_cart sc WHERE sc.`MEMBER_ID` = @member AND sc.`PRODUCT_ID` = @product;";
                cmdDelete.Parameters.AddWithValue("@member", member_id);
                cmdDelete.Parameters.AddWithValue("@product", newID);
                cmdDelete.Connection = koneksi.getConn();

                koneksi.openConn();
                cmdDelete.ExecuteNonQuery();
                koneksi.closeConn();

                loadDG_ShoppingCart();
                MessageBox.Show("Shopping cart berhasil diupdate !");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_GantiJumlah_Click(object sender, EventArgs e)
        {
            String produk = dg_Cart.Rows[cartRowIndex].Cells[0].Value.ToString();
            String format = dg_Cart.Rows[cartRowIndex].Cells[1].Value.ToString();
            String quantity = dg_Cart.Rows[cartRowIndex].Cells[2].Value.ToString();

            using (FormGantiJumlah form = new FormGantiJumlah(produk, format, quantity, member_id))
            {
                form.ShowDialog();
            }
            loadDG_ShoppingCart();
        }

        private void dg_Cart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cartRowIndex = e.RowIndex;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_Nama.Text == "" && cb_Genre.SelectedIndex == -1 && tb_Lagu.Text == "") loadDg_product();
            else if (tb_Nama.Text != "" && cb_Genre.SelectedIndex == -1 && tb_Lagu.Text == "") searchProductNameOnly();
            else if (tb_Nama.Text == "" && cb_Genre.SelectedIndex != -1 && tb_Lagu.Text == "") searchProductGenreOnly();
            else if (tb_Nama.Text != "" && cb_Genre.SelectedIndex != -1 && tb_Lagu.Text == "") searchProduct();
            else if (tb_Nama.Text == "" && cb_Genre.SelectedIndex == -1 && tb_Lagu.Text != "") searchProductLaguOnly();
            else if (tb_Nama.Text != "" && cb_Genre.SelectedIndex == -1 && tb_Lagu.Text != "") searchProductLaguNamaOnly();
            else if (tb_Nama.Text == "" && cb_Genre.SelectedIndex != -1 && tb_Lagu.Text != "") searchProductLaguGenreOnly();
            else if (tb_Nama.Text != "" && cb_Genre.SelectedIndex != -1 && tb_Lagu.Text != "") searchProductAll();
        }

        private void searchProductNameOnly()
        {
            dg_Produk.DataSource = null;

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT(p.`NAME`), DATE_FORMAT(p.`RELEASE_DATE`,'%d %M %Y') AS 'Release Date' , p.`DESCRIPTION`, tp.`TYPE_NAME`, p.`RATING` FROM product p ,product_song ps, songs s, genre g, type_product tp WHERE p.`ID` = ps.`PRODUCT_ID` AND ps.`SONG_ID` = s.`ID` AND s.`GENRE_ID` = g.`ID` AND p.`TYPE_ID` = tp.`ID` and p.name like @name;", koneksi.getConn());
            cmd.Parameters.AddWithValue("@name", "%" + tb_Nama.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();

            koneksi.openConn();
            cmd.ExecuteReader();
            koneksi.closeConn();

            da.SelectCommand = cmd;
            da.Fill(dt);

            dg_Produk.DataSource = dt;
        }

        private void searchProductGenreOnly()
        {
            dg_Produk.DataSource = null;

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT(p.`NAME`), DATE_FORMAT(p.`RELEASE_DATE`,'%d %M %Y') AS 'Release Date' , p.`DESCRIPTION`, tp.`TYPE_NAME`, p.`RATING` FROM product p ,product_song ps, songs s, genre g, type_product tp WHERE p.`ID` = ps.`PRODUCT_ID` AND ps.`SONG_ID` = s.`ID` AND s.`GENRE_ID` = g.`ID` AND p.`TYPE_ID` = tp.`ID` and g.id = @genre;", koneksi.getConn());
            cmd.Parameters.AddWithValue("@genre", (cb_Genre.SelectedItem as dynamic).Value);
            MySqlDataAdapter da = new MySqlDataAdapter();

            koneksi.openConn();
            cmd.ExecuteReader();
            koneksi.closeConn();

            da.SelectCommand = cmd;
            da.Fill(dt);

            dg_Produk.DataSource = dt;
        }
        
        private void searchProduct()
        {
            dg_Produk.DataSource = null;

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT(p.`NAME`), DATE_FORMAT(p.`RELEASE_DATE`,'%d %M %Y') AS 'Release Date' , p.`DESCRIPTION`, tp.`TYPE_NAME`, p.`RATING` FROM product p ,product_song ps, songs s, genre g, type_product tp WHERE p.`ID` = ps.`PRODUCT_ID` AND ps.`SONG_ID` = s.`ID` AND s.`GENRE_ID` = g.`ID` AND p.`TYPE_ID` = tp.`ID` and g.id = @genre and p.name like @name;", koneksi.getConn());
            cmd.Parameters.AddWithValue("@genre", (cb_Genre.SelectedItem as dynamic).Value);
            cmd.Parameters.AddWithValue("@name", "%" + tb_Nama.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();

            koneksi.openConn();
            cmd.ExecuteReader();
            koneksi.closeConn();

            da.SelectCommand = cmd;
            da.Fill(dt);

            dg_Produk.DataSource = dt;
        }

        private void searchProductLaguOnly()
        {
            dg_Produk.DataSource = null;

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT(p.`NAME`), DATE_FORMAT(p.`RELEASE_DATE`,'%d %M %Y') AS 'Release Date' , p.`DESCRIPTION`, tp.`TYPE_NAME`, p.`RATING` FROM product p ,product_song ps, songs s, genre g, type_product tp WHERE p.`ID` = ps.`PRODUCT_ID` AND ps.`SONG_ID` = s.`ID` AND s.`GENRE_ID` = g.`ID` AND p.`TYPE_ID` = tp.`ID` AND s.`NAME` LIKE @name;", koneksi.getConn());
            cmd.Parameters.AddWithValue("@name", "%" + tb_Lagu.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();

            koneksi.openConn();
            cmd.ExecuteReader();
            koneksi.closeConn();

            da.SelectCommand = cmd;
            da.Fill(dt);

            dg_Produk.DataSource = dt;
        }

        private void searchProductLaguNamaOnly()
        {
            dg_Produk.DataSource = null;

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT(p.`NAME`), DATE_FORMAT(p.`RELEASE_DATE`,'%d %M %Y') AS 'Release Date' , p.`DESCRIPTION`, tp.`TYPE_NAME`, p.`RATING` FROM product p ,product_song ps, songs s, genre g, type_product tp WHERE p.`ID` = ps.`PRODUCT_ID` AND ps.`SONG_ID` = s.`ID` AND s.`GENRE_ID` = g.`ID` AND p.`TYPE_ID` = tp.`ID` AND s.`NAME` LIKE @name and p.name like @name2;", koneksi.getConn());
            cmd.Parameters.AddWithValue("@name", "%" + tb_Lagu.Text + "%");
            cmd.Parameters.AddWithValue("@name2", "%" + tb_Nama.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();

            koneksi.openConn();
            cmd.ExecuteReader();
            koneksi.closeConn();

            da.SelectCommand = cmd;
            da.Fill(dt);

            dg_Produk.DataSource = dt;
        }

        private void searchProductLaguGenreOnly()
        {
            dg_Produk.DataSource = null;

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT(p.`NAME`), DATE_FORMAT(p.`RELEASE_DATE`,'%d %M %Y') AS 'Release Date' , p.`DESCRIPTION`, tp.`TYPE_NAME`, p.`RATING` FROM product p ,product_song ps, songs s, genre g, type_product tp WHERE p.`ID` = ps.`PRODUCT_ID` AND ps.`SONG_ID` = s.`ID` AND s.`GENRE_ID` = g.`ID` AND p.`TYPE_ID` = tp.`ID` and g.id = @genre and s.name like @name;", koneksi.getConn());
            cmd.Parameters.AddWithValue("@name", "%" + tb_Lagu.Text + "%");
            cmd.Parameters.AddWithValue("@genre", (cb_Genre.SelectedItem as dynamic).Value);
            MySqlDataAdapter da = new MySqlDataAdapter();

            koneksi.openConn();
            cmd.ExecuteReader();
            koneksi.closeConn();

            da.SelectCommand = cmd;
            da.Fill(dt);

            dg_Produk.DataSource = dt;
        }

        private void searchProductAll()
        {
            dg_Produk.DataSource = null;

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT(p.`NAME`), DATE_FORMAT(p.`RELEASE_DATE`,'%d %M %Y') AS 'Release Date' , p.`DESCRIPTION`, tp.`TYPE_NAME`, p.`RATING` FROM product p ,product_song ps, songs s, genre g, type_product tp WHERE p.`ID` = ps.`PRODUCT_ID` AND ps.`SONG_ID` = s.`ID` AND s.`GENRE_ID` = g.`ID` AND p.`TYPE_ID` = tp.`ID` and g.id = @genre and s.name like @name and p.name like @name2;", koneksi.getConn());
            cmd.Parameters.AddWithValue("@name", "%" + tb_Lagu.Text + "%");
            cmd.Parameters.AddWithValue("@name2", "%" + tb_Nama.Text + "%");
            cmd.Parameters.AddWithValue("@genre", (cb_Genre.SelectedItem as dynamic).Value);
            MySqlDataAdapter da = new MySqlDataAdapter();

            koneksi.openConn();
            cmd.ExecuteReader();
            koneksi.closeConn();

            da.SelectCommand = cmd;
            da.Fill(dt);

            dg_Produk.DataSource = dt;
        }

        private void updateBiodataToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panelBiodata.Visible = true;
            panelReview.Visible = false;
            panelHistory.Visible = false;

            fillBiodata();
        }

        private void btn_update_biodata_Click(object sender, EventArgs e)
        {
            using (FormGantiPassword form = new FormGantiPassword(member_id))
            {
                form.ShowDialog();
            }
        }

        private void ReviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panelBiodata.Visible = false;
            panelReview.Visible = true;
            panelHistory.Visible = false;

            loadDG_Review();
        }

        private void dg_review_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                reviewRowIndex = e.RowIndex;

                tb_name_review.Text = dg_review.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_type_review.Text = dg_review.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btn_review_Click(object sender, EventArgs e)
        {
            if (tb_name_review.Text == "") MessageBox.Show("Produk/Song yang direview harus dipilih !");
            else if (nud_review.Value == 0) MessageBox.Show("Rating harus diisi !");
            else
            {
                if (tb_type_review.Text=="Song")
                {
                    String rating = nud_review.Value.ToString();
                    String date = DateTime.Today.ToString("yyyy-MM-dd");

                    MySqlCommand cmdSong = new MySqlCommand("select id from songs where name = @name", koneksi.getConn());
                    cmdSong.Parameters.AddWithValue("@name", tb_name_review.Text);

                    koneksi.openConn();
                    String Songid = cmdSong.ExecuteScalar().ToString();
                    koneksi.closeConn();

                    MySqlCommand cmdID = new MySqlCommand("select cast(id as unsigned)+1 from review_song order by cast(id as unsigned) desc limit 1", koneksi.getConn());

                    koneksi.openConn();
                    String id = cmdID.ExecuteScalar().ToString();
                    koneksi.closeConn();

                    try
                    {
                        MySqlCommand cmdReview = new MySqlCommand("insert into review_song (id, song_id, member_id, review_date, rating) values (@id, @product, @member, @date, @rating)", koneksi.getConn());
                        cmdReview.Parameters.AddWithValue("@id", id);
                        cmdReview.Parameters.AddWithValue("@product", Songid);
                        cmdReview.Parameters.AddWithValue("@member", member_id);
                        cmdReview.Parameters.AddWithValue("@date", date);
                        cmdReview.Parameters.AddWithValue("@rating", rating);

                        koneksi.openConn();
                        cmdReview.ExecuteNonQuery();
                        koneksi.closeConn();

                        tb_name_review.Text = "";
                        tb_type_review.Text = "";
                        nud_Jumlah.Value = 0;
                        MessageBox.Show("Review berhasil !");
                        loadDG_Review();
                    } catch (MySqlException ex)
                    {
                        loadDG_Review();
                        MessageBox.Show(ex.Message);
                    }
                } else
                {
                    String rating = nud_review.Value.ToString();
                    String date = DateTime.Today.ToString("yyyy-MM-dd");

                    MySqlCommand cmdSong = new MySqlCommand("select id from product where name = @name", koneksi.getConn());
                    cmdSong.Parameters.AddWithValue("@name", tb_name_review.Text);

                    koneksi.openConn();
                    String Songid = cmdSong.ExecuteScalar().ToString();
                    koneksi.closeConn();

                    MySqlCommand cmdID = new MySqlCommand("select cast(id as unsigned)+1 from review_product order by cast(id as unsigned) desc limit 1", koneksi.getConn());

                    koneksi.openConn();
                    String id = cmdID.ExecuteScalar().ToString();
                    koneksi.closeConn();

                    try
                    {
                        MySqlCommand cmdReview = new MySqlCommand("insert into review_product (id, product_id, member_id, review_date, rating) values (@id, @product, @member, @date, @rating)", koneksi.getConn());
                        cmdReview.Parameters.AddWithValue("@id", id);
                        cmdReview.Parameters.AddWithValue("@product", Songid);
                        cmdReview.Parameters.AddWithValue("@member", member_id);
                        cmdReview.Parameters.AddWithValue("@date", date);
                        cmdReview.Parameters.AddWithValue("@rating", rating);

                        koneksi.openConn();
                        cmdReview.ExecuteNonQuery();
                        koneksi.closeConn();

                        MessageBox.Show("Review berhasil !");
                        loadDG_Review();
                    }
                    catch (MySqlException ex)
                    {
                        loadDG_Review();
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void historyPembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panelBiodata.Visible = false;
            panelReview.Visible = false;
            panelHistory.Visible = true;

            CrystalReport_History report = new CrystalReport_History();
            report.SetDatabaseLogon("root", "", "localhost", "db_projek_pcs");
            report.SetParameterValue("param_member", member_id);

            crv_history.ReportSource = report;
        }

        private void btn_clear_search_Click(object sender, EventArgs e)
        {
            tb_Lagu.Text = "";
            tb_Nama.Text = "";
            cb_Genre.SelectedIndex = -1;

            loadDg_product();
        }

        private void btn_lihatLagu_Click(object sender, EventArgs e)
        {
            if (tb_Nama2.Text!="")
            {
                String product = tb_Nama2.Text;

                using (FormDetailProduct form = new FormDetailProduct(product))
                {
                    form.ShowDialog();
                }
            }
        }
    }
}
