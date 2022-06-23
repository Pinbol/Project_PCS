using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;

namespace Project
{
    public partial class Form2 : Form
    {
        public String idStaff;
        public String idMembership;
        public String idPayment;
        public String idOccupation;
        public String idGenre;
        public String idFormat;
        public String idPersonel;
        public String idGroupMusic;
        public String idSong;
        public String idProductSong;
        public String idProductFormat;

        DataTable dtInternalGroupMusic = new DataTable();
        DataTable dtInternalProductSong = new DataTable();

        DataTable dtTempUpdateGroupMusic = new DataTable();
        DataTable dtTempUpdateProductSong = new DataTable();

        public int PersonelGroupMusicIndex;
        public int SongProductSongIndex;

        public String Format_ProductFormat;

        public Form2()
        {
            InitializeComponent();
        }

        private void masterStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelStaff.Visible = true;
            panelMembership.Visible = false;
            panelPayment.Visible = false;
            panelOccupation.Visible = false;
            panelGenre.Visible = false;
            panelFormat.Visible = false;
            panelPersonel.Visible = false;
            panelSong.Visible = false;
            panelProductSong.Visible = false;
            panelProductFormat.Visible = false;
            panelReportLagu.Visible = false;
            panelReportProduct.Visible = false;
            panelReportPenjualan.Visible = false;
            
            refreshDGStaff();
            clearStaff();
        }

        private void masterMembershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelStaff.Visible = false;
            panelMembership.Visible = true;
            panelPayment.Visible = false;
            panelOccupation.Visible = false;
            panelGenre.Visible = false;
            panelFormat.Visible = false;
            panelPersonel.Visible = false;
            panelGroupMusic.Visible = false;
            panelSong.Visible = false;
            panelProductSong.Visible = false;
            panelProductFormat.Visible = false;
            panelReportLagu.Visible = false;
            panelReportProduct.Visible = false;
            panelReportPenjualan.Visible = false;

            refreshDGMembership();
            clearMembership();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panelStaff.Visible = true;
            panelMembership.Visible = false;
            panelPayment.Visible = false;
            panelOccupation.Visible = false;
            panelGenre.Visible = false;
            panelFormat.Visible = false;
            panelPersonel.Visible = false;
            panelGroupMusic.Visible = false;
            panelSong.Visible = false;
            panelProductSong.Visible = false;
            panelProductFormat.Visible = false;
            panelReportLagu.Visible = false;
            panelReportProduct.Visible = false;
            panelReportPenjualan.Visible = false;

            refreshDGStaff();
            clearStaff();
        }

        private void refreshDGMembership()
        {
            dg_membership.DataSource = null;

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT ID, Name, CONCAT(discount,'%') AS 'Harga', CONCAT(exp_length,' bulan') AS 'Waktu Expired' FROM membership ORDER BY CAST(ID AS UNSIGNED) ASC;", koneksi.getConn());
            MySqlDataAdapter da = new MySqlDataAdapter();

            koneksi.openConn();
            cmd.ExecuteReader();
            koneksi.closeConn();

            da.SelectCommand = cmd;
            da.Fill(dt);

            dg_membership.DataSource = dt;
        }

        private void refreshDGStaff()
        {
            dg_staff.DataSource = null;

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT ID, Name, Username, Password, Address, CASE WHEN gender = 'L' THEN 'Laki-Laki' ELSE 'Perempuan' END as 'Jenis Kelamin', date_of_birth, CASE WHEN STATUS = 1 THEN 'Aktif' ELSE 'Tidak Aktif' END as 'Status' FROM staff order by cast(id as unsigned) asc;", koneksi.getConn());
            MySqlDataAdapter da = new MySqlDataAdapter();

            koneksi.openConn();
            cmd.ExecuteReader();
            koneksi.closeConn();
            
            da.SelectCommand = cmd;
            da.Fill(dt);

            dg_staff.DataSource = dt;
        }

        private void refreshDGPayment()
        {
            dg_payment.DataSource = null;

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT ID, Name FROM payment_method order by cast(id as unsigned) asc;", koneksi.getConn());
            MySqlDataAdapter da = new MySqlDataAdapter();

            koneksi.openConn();
            cmd.ExecuteReader();
            koneksi.closeConn();

            da.SelectCommand = cmd;
            da.Fill(dt);

            dg_payment.DataSource = dt;
        }

        private void refreshDGOccupation()
        {
            dg_occupation.DataSource = null;

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT ID, Name FROM occupation order by cast(id as unsigned) asc;", koneksi.getConn());
            MySqlDataAdapter da = new MySqlDataAdapter();

            koneksi.openConn();
            cmd.ExecuteReader();
            koneksi.closeConn();

            da.SelectCommand = cmd;
            da.Fill(dt);

            dg_occupation.DataSource = dt;
        }

        private void refreshDGGenre()
        {
            dg_genre.DataSource = null;

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT ID, Name FROM genre order by cast(id as unsigned) asc;", koneksi.getConn());
            MySqlDataAdapter da = new MySqlDataAdapter();

            koneksi.openConn();
            cmd.ExecuteReader();
            koneksi.closeConn();

            da.SelectCommand = cmd;
            da.Fill(dt);

            dg_genre.DataSource = dt;
        }

        private void refreshDGFormat()
        {
            dg_format.DataSource = null;

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT ID, Name FROM format order by cast(id as unsigned) asc;", koneksi.getConn());
            MySqlDataAdapter da = new MySqlDataAdapter();

            koneksi.openConn();
            cmd.ExecuteReader();
            koneksi.closeConn();

            da.SelectCommand = cmd;
            da.Fill(dt);

            dg_format.DataSource = dt;
        }

        private void refreshDGPersonel()
        {
            dg_personel.DataSource = null;

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT P.ID AS 'ID', P.NAME AS 'Name', P.COUNTRY AS 'Country', P.GENDER AS 'Gender', O.`NAME` AS 'Occupation' FROM PERSONEL P, OCCUPATION O WHERE p.`OCCUPATION_ID` = o.`ID` ORDER BY CAST(p.`ID` AS UNSIGNED) ASC;", koneksi.getConn());
            MySqlDataAdapter da = new MySqlDataAdapter();

            koneksi.openConn();
            cmd.ExecuteReader();
            koneksi.closeConn();

            da.SelectCommand = cmd;
            da.Fill(dt);

            dg_personel.DataSource = dt;
        }

        private void refreshDGGroupMusic()
        {
            dg_groupMusic.DataSource = null;

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT ID, Name FROM group_music order by cast(id as unsigned) asc;", koneksi.getConn());
            MySqlDataAdapter da = new MySqlDataAdapter();

            koneksi.openConn();
            cmd.ExecuteReader();
            koneksi.closeConn();

            da.SelectCommand = cmd;
            da.Fill(dt);

            dg_groupMusic.DataSource = dt;
        }

        private void refreshDGSong()
        {
            dg_song.DataSource = null;

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT s.`ID` AS 'ID', s.`NAME` AS 'Name', DATE_FORMAT(s.`RELEASE_DATE`, '%d %M %Y') AS 'Release Date', gm.`name` AS 'Group', g.`NAME` AS 'Genre', CONCAT(LPAD(s.`LENGTH` DIV 60,2,'0'), ':', LPAD(s.`LENGTH` MOD 60,2,'0')) AS 'Length', s.`DESCRIPTION` AS 'Description' FROM songs s, group_music gm, genre g WHERE s.`GENRE_ID` = g.`ID` AND s.`GROUP_ID` = gm.`id` order by cast(s.id as unsigned) asc;", koneksi.getConn());
            MySqlDataAdapter da = new MySqlDataAdapter();

            koneksi.openConn();
            cmd.ExecuteReader();
            koneksi.closeConn();

            da.SelectCommand = cmd;
            da.Fill(dt);

            dg_song.DataSource = dt;
        }

        private void refreshDGProductSong()
        {
            dg_productSong.DataSource = null;

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT p.`ID` AS 'ID', p.`NAME` AS 'Name', DATE_FORMAT(p.`RELEASE_DATE`,'%d %M %Y') AS 'Release Date', p.`DESCRIPTION` AS 'Description', tp.`TYPE_NAME` AS 'Tipe'  FROM product p, type_product tp WHERE tp.`ID` = p.`TYPE_ID` order by cast(p.id as unsigned) asc;", koneksi.getConn());
            MySqlDataAdapter da = new MySqlDataAdapter();

            koneksi.openConn();
            cmd.ExecuteReader();
            koneksi.closeConn();

            da.SelectCommand = cmd;
            da.Fill(dt);

            dg_productSong.DataSource = dt;
        }

        private void refreshDGProductFormat()
        {
            dg_productFormat.DataSource = null;

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT p.`ID` AS 'ID', p.`NAME` AS 'Name'  FROM product p order by cast(p.id as unsigned) asc;", koneksi.getConn());
            MySqlDataAdapter da = new MySqlDataAdapter();

            koneksi.openConn();
            cmd.ExecuteReader();
            koneksi.closeConn();

            da.SelectCommand = cmd;
            da.Fill(dt);

            dg_productFormat.DataSource = dt;
        }

        private void fillCBPersonel()
        {
            cb_occupation_personel.Items.Clear();

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            MySqlCommand cmd = new MySqlCommand("select * from occupation;", koneksi.getConn());

            koneksi.openConn();
            MySqlDataReader dr = cmd.ExecuteReader();

            cb_occupation_personel.DisplayMember = "Text";
            cb_occupation_personel.ValueMember = "Value";

            while (dr.Read())
            {
                cb_occupation_personel.Items.Add(new { Text = dr.GetString(1), Value = dr.GetString(0) });
            }

            koneksi.closeConn();
            cb_occupation_personel.SelectedIndex = -1;
        }

        private void fillCBGroupMusic()
        {
            cb_personel_groupMusic.Items.Clear();

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            MySqlCommand cmd = new MySqlCommand("SELECT p.ID, CONCAT(p.Name, ' - ', o.`NAME`), p.Name, o.Name FROM personel p, occupation o WHERE p.`OCCUPATION_ID` = o.`ID` ORDER BY CAST(p.`ID` AS UNSIGNED) ASC;", koneksi.getConn());

            koneksi.openConn();
            MySqlDataReader dr = cmd.ExecuteReader();

            cb_personel_groupMusic.DisplayMember = "Text";
            cb_personel_groupMusic.ValueMember = "Value";

            while (dr.Read())
            {
                cb_personel_groupMusic.Items.Add(new { Text = dr.GetString(1), Value = dr.GetString(0), Personel = dr.GetString(2), Occupation = dr.GetString(3) });
            }

            koneksi.closeConn();
            cb_personel_groupMusic.SelectedIndex = -1;
        }

        private void fillCBSong_1()
        {
            cb_genre_song.Items.Clear();

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            MySqlCommand cmd = new MySqlCommand("SELECT id, NAME FROM genre ORDER BY CAST(id AS UNSIGNED) ASC;", koneksi.getConn());

            koneksi.openConn();
            MySqlDataReader dr = cmd.ExecuteReader();

            cb_genre_song.DisplayMember = "Text";
            cb_genre_song.ValueMember = "Value";

            while (dr.Read())
            {
                cb_genre_song.Items.Add(new { Text = dr.GetString(1), Value = dr.GetString(0) });
            }

            koneksi.closeConn();
            cb_genre_song.SelectedIndex = -1;
        }

        private void fillCBSong_2()
        {
            cb_group_song.Items.Clear();

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            MySqlCommand cmd = new MySqlCommand("SELECT id, NAME FROM group_music ORDER BY CAST(id AS UNSIGNED) ASC;", koneksi.getConn());

            koneksi.openConn();
            MySqlDataReader dr = cmd.ExecuteReader();

            cb_group_song.DisplayMember = "Text";
            cb_group_song.ValueMember = "Value";

            while (dr.Read())
            {
                cb_group_song.Items.Add(new { Text = dr.GetString(1), Value = dr.GetString(0) });
            }

            koneksi.closeConn();
            cb_group_song.SelectedIndex = -1;
        }

        private void fillCBProductSong_Song()
        {
            cb_song_productSong.Items.Clear();

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            MySqlCommand cmd = new MySqlCommand("SELECT id, NAME, CONCAT(LENGTH DIV 60, ':', LENGTH MOD 60) FROM songs ORDER BY CAST(id AS UNSIGNED) ASC;", koneksi.getConn());

            koneksi.openConn();
            MySqlDataReader dr = cmd.ExecuteReader();

            cb_song_productSong.DisplayMember = "Text";
            cb_song_productSong.ValueMember = "Value";

            while (dr.Read())
            {
                cb_song_productSong.Items.Add(new { Text = dr.GetString(1), Value = dr.GetString(0), Length = dr.GetString(2) }) ;
            }

            koneksi.closeConn();
            cb_song_productSong.SelectedIndex = -1;
        }

        private void fillCBProductSong_Type()
        {
            cb_type_productSong.Items.Clear();

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            MySqlCommand cmd = new MySqlCommand("SELECT id, type_NAME FROM type_product ORDER BY CAST(id AS UNSIGNED) ASC;", koneksi.getConn());

            koneksi.openConn();
            MySqlDataReader dr = cmd.ExecuteReader();

            cb_type_productSong.DisplayMember = "Text";
            cb_type_productSong.ValueMember = "Value";

            while (dr.Read())
            {
                cb_type_productSong.Items.Add(new { Text = dr.GetString(1), Value = dr.GetString(0)});
            }

            koneksi.closeConn();
            cb_type_productSong.SelectedIndex = -1;
        }

        private void fillCBProductFormat()
        {
            cb_format_productFormat.Items.Clear();

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            MySqlCommand cmd = new MySqlCommand("SELECT id, name FROM format ORDER BY CAST(id AS UNSIGNED) ASC;", koneksi.getConn());

            koneksi.openConn();
            MySqlDataReader dr = cmd.ExecuteReader();

            cb_format_productFormat.DisplayMember = "Text";
            cb_format_productFormat.ValueMember = "Value";

            while (dr.Read())
            {
                cb_format_productFormat.Items.Add(new { Text = dr.GetString(1), Value = dr.GetString(0) });
            }

            koneksi.closeConn();
            cb_format_productFormat.SelectedIndex = -1;
        }

        private Boolean checkCond_personel()
        {
            if (tb_name_personel.Text=="")
            {
                MessageBox.Show("Please fill the name !");
                return false;
            } else if (tb_country_personel.Text=="")
            {
                MessageBox.Show("Please fill the country !");
                return false;
            } else if (!rb_l_personel.Checked && !rb_p_personel.Checked)
            {
                MessageBox.Show("Please choose the gender !");
                return false;
            } else if (cb_occupation_personel.SelectedIndex==-1)
            {
                MessageBox.Show("Please choose the occupation !");
                return false;
            }
            return true;
        }

        private Boolean checkCond_groupMusic()
        {
            if (tb_name_groupMusic.Text=="")
            {
                MessageBox.Show("Please fill the name !");
                return false;
            } else if (dg_personel_groupMusic.Rows.Count==0)
            {
                MessageBox.Show("A group must consist at least 1 personel !");
                return false;
            }
            return true;
        }

        private Boolean checkCond_song()
        {
            if (tb_name_song.Text=="")
            {
                MessageBox.Show("Please fill the name !");
                return false;
            } else if (rtb_deskripsi_song.Text=="")
            {
                MessageBox.Show("Please fill the description !");
                return false;
            } else if (tb_length_song.Text=="")
            {
                MessageBox.Show("Please fill the length !");
                return false;
            } else if (!tb_length_song.Text.All(char.IsDigit))
            {
                MessageBox.Show("Length must be in digits !");
                return false;
            } else if (dtp_releaseDate_song.Value==DateTime.Now)
            {
                MessageBox.Show("Release date must not be today !");
                return false;
            } else if (cb_genre_song.SelectedIndex==-1)
            {
                MessageBox.Show("Genre must be chosen !");
                return false;
            } else if (cb_group_song.SelectedIndex==-1)
            {
                MessageBox.Show("Group must be chosen !");
                return false;
            }
            return true;
        }

        private Boolean checkCond_productSong()
        {
            if (tb_name_productSong.Text=="")
            {
                MessageBox.Show("Please fill the name !");
                return false;
            } else if (rtb_description_productSong.Text=="")
            {
                MessageBox.Show("Please fill the description !");
                return false;
            } else if (cb_type_productSong.SelectedIndex==-1)
            {
                MessageBox.Show("Please choose the type !");
                return false;
            } else if (dg_song_productSong.Rows.Count==0)
            {
                MessageBox.Show("A product must consist at least 1 song !");
                return false;
            }
            return true;
        }

        private void prepareDTInternalGroupMusic()
        {
            dtInternalGroupMusic.Columns.Add("Personel_ID");
            dtTempUpdateGroupMusic.Columns.Add("Personel_ID");
        }

        private void prepareDTInternalProductSong()
        {
            dtInternalProductSong.Columns.Add("Song_ID");
            dtTempUpdateProductSong.Columns.Add("Song_ID");
        }

        private void fillDGPersonelGroupMusic()
        {
            dg_personel_groupMusic.Rows.Clear();

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            MySqlCommand cmd = new MySqlCommand("SELECT p.`NAME`, o.`NAME`, p.ID FROM personel p, group_music gm, occupation o,group_personel gp WHERE o.`ID` = p.`OCCUPATION_ID` AND gp.`GROUP_ID` = gm.`id` AND gp.`PERSONEL_ID` = p.`ID` AND gm.`id` = @id ORDER BY CAST(gp.`ID` AS UNSIGNED) ASC;", koneksi.getConn());
            cmd.Parameters.AddWithValue("@id", idGroupMusic);

            koneksi.openConn();

            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int rowID = dg_personel_groupMusic.Rows.Add();

                DataGridViewRow row = dg_personel_groupMusic.Rows[rowID];

                row.Cells["Personel"].Value = dr.GetString(0);
                row.Cells["Occupation"].Value = dr.GetString(1);

                dtInternalGroupMusic.Rows.Add(dr.GetString(2));
            }

            koneksi.closeConn();
        }

        private void fillDGSongProductSong()
        {
            dg_song_productSong.Rows.Clear();

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            MySqlCommand cmd = new MySqlCommand("SELECT s.id, s.NAME, CONCAT(s.LENGTH DIV 60, ':', s.LENGTH MOD 60) FROM songs s, product_song ps, product p where p.id = @id and p.id = ps.product_id and ps.song_id = s.id ORDER BY CAST(ps.id AS UNSIGNED) ASC;", koneksi.getConn());
            cmd.Parameters.AddWithValue("@id", idProductSong);

            koneksi.openConn();

            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int rowID = dg_song_productSong.Rows.Add();

                DataGridViewRow row = dg_song_productSong.Rows[rowID];

                row.Cells["Song"].Value = dr.GetString(1);
                row.Cells["Length"].Value = dr.GetString(2);

                dtInternalProductSong.Rows.Add(dr.GetString(0));
            }

            koneksi.closeConn();
        }

        private void fillDGFormatProductFormat()
        {
            dg_format_productFormat.Rows.Clear();

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            MySqlCommand cmd = new MySqlCommand("SELECT f.name, fp.price FROM format_product fp, format f  where fp.product_id = @id and fp.format_id = f.id  ORDER BY CAST(fp.id AS UNSIGNED) ASC;", koneksi.getConn());
            cmd.Parameters.AddWithValue("@id", idProductFormat);

            koneksi.openConn();

            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int rowID = dg_format_productFormat.Rows.Add();

                DataGridViewRow row = dg_format_productFormat.Rows[rowID];

                row.Cells["Format"].Value = dr.GetString(0);
                row.Cells["Harga"].Value = dr.GetString(1);
            }

            koneksi.closeConn();
        }

        private void btn_clear_staff_Click(object sender, EventArgs e)
        {
            clearStaff();
        }

        private void clearStaff()
        {
            tb_alamat_staff.Text = "";
            tb_name_staff.Text = "";
            tb_password_staff.Text = "";
            tb_username_staff.Text = "";

            rb_l.Checked = false;
            rb_p.Checked = false;

            btn_delete_staff.Enabled = false;
            btn_insert_staff.Enabled = true;
            btn_update_staff.Enabled = false;

            lbl_status_staff.Visible = false;
            gb_status.Visible = false;

            dtp_dob_staff.Value = DateTime.Today;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_insert_staff_Click(object sender, EventArgs e)
        {
            if (tb_name_staff.Text == "" || tb_password_staff.Text == "" || tb_username_staff.Text == "" || tb_alamat_staff.Text == "" || (rb_l.Checked == false && rb_p.Checked == false) || dtp_dob_staff.Value == DateTime.Today)
            {
                MessageBox.Show("Please fill all input !");
            }
            else
            {
                MySqlCommand cmdID = new MySqlCommand();
                cmdID.CommandText = "SELECT cast(id as unsigned)+1 FROM staff ORDER BY CAST(id AS UNSIGNED) DESC LIMIT 1;";
                cmdID.Connection = koneksi.getConn();

                koneksi.openConn();
                String newID = cmdID.ExecuteScalar().ToString();
                koneksi.closeConn();

                String name = tb_name_staff.Text;
                String alamat = tb_alamat_staff.Text;
                String username = tb_username_staff.Text;
                String password = tb_password_staff.Text;

                String staffDOB = dtp_dob_staff.Value.ToString("yyyy-MM-dd");

                String staffJK;
                if (rb_l.Checked) staffJK = "L";
                else staffJK = "P";

                try
                {
                    MySqlCommand cmdInsert = new MySqlCommand("insert into staff (id,name,username,password,address,gender,date_of_birth,status) values (@id,@name,@username,@password,@address,@gender,@date,@status);", koneksi.getConn());

                    cmdInsert.Parameters.AddWithValue("@id", newID);
                    cmdInsert.Parameters.AddWithValue("@name", name);
                    cmdInsert.Parameters.AddWithValue("@username", username);
                    cmdInsert.Parameters.AddWithValue("@password", password);
                    cmdInsert.Parameters.AddWithValue("@address", alamat);
                    cmdInsert.Parameters.AddWithValue("@gender", staffJK);
                    cmdInsert.Parameters.AddWithValue("@date", staffDOB);
                    cmdInsert.Parameters.AddWithValue("@status", 1);

                    koneksi.openConn();
                    cmdInsert.ExecuteNonQuery();
                    koneksi.closeConn();

                    clearStaff();
                    refreshDGStaff();
                    MessageBox.Show("Insert successful !");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
        }

        private void btn_update_staff_Click(object sender, EventArgs e)
        {
            if (tb_name_staff.Text == "" || tb_password_staff.Text == "" || tb_username_staff.Text == "" || tb_alamat_staff.Text == "" || (rb_l.Checked == false && rb_p.Checked == false) || dtp_dob_staff.Value == DateTime.Today)
            {
                MessageBox.Show("Please fill all input !");
            }
            else
            {
                String name = tb_name_staff.Text;
                String alamat = tb_alamat_staff.Text;
                String username = tb_username_staff.Text;
                String password = tb_password_staff.Text;

                String staffDOB = dtp_dob_staff.Value.ToString("yyyy-MM-dd");

                String staffJK;
                if (rb_l.Checked) staffJK = "L";
                else staffJK = "P";

                String staffStatus;
                if (rb_aktif.Checked) staffStatus = "1";
                else staffStatus = "0";

                try
                {
                    MySqlCommand cmdInsert = new MySqlCommand("update staff set name = @name, username = @username, password= @password, address = @address, gender = @gender, date_of_birth = @date, status=@status where id = @id;", koneksi.getConn());

                    cmdInsert.Parameters.AddWithValue("@id", idStaff);
                    cmdInsert.Parameters.AddWithValue("@name", name);
                    cmdInsert.Parameters.AddWithValue("@username", username);
                    cmdInsert.Parameters.AddWithValue("@password", password);
                    cmdInsert.Parameters.AddWithValue("@address", alamat);
                    cmdInsert.Parameters.AddWithValue("@gender", staffJK);
                    cmdInsert.Parameters.AddWithValue("@date", staffDOB);
                    cmdInsert.Parameters.AddWithValue("@status", staffStatus);

                    koneksi.openConn();
                    cmdInsert.ExecuteNonQuery();
                    koneksi.closeConn();

                    clearStaff();
                    idStaff = "";
                    refreshDGStaff();
                    MessageBox.Show("Update successful !");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
        }

        private void btn_delete_staff_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this staff ?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("delete from staff where id = @id", koneksi.getConn());
                    cmd.Parameters.AddWithValue("@id", idStaff);

                    koneksi.openConn();
                    cmd.ExecuteNonQuery();
                    koneksi.closeConn();

                    clearStaff();
                    refreshDGStaff();

                    MessageBox.Show("Delete successfull !");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    clearStaff();
                }
            }
        }

        private void dg_staff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_delete_staff.Enabled = true;
            btn_update_staff.Enabled = true;

            btn_insert_staff.Enabled = false;

            idStaff = dg_staff.Rows[e.RowIndex].Cells[0].Value.ToString();

            lbl_status_staff.Visible = true;
            gb_status.Visible = true;

            tb_name_staff.Text = dg_staff.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_username_staff.Text = dg_staff.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb_password_staff.Text = dg_staff.Rows[e.RowIndex].Cells[3].Value.ToString();
            tb_alamat_staff.Text = dg_staff.Rows[e.RowIndex].Cells[4].Value.ToString();

            String jk = dg_staff.Rows[e.RowIndex].Cells[5].Value.ToString();

            if (jk == "Laki-Laki")
            {
                rb_l.Checked = true;
                rb_p.Checked = false;
            }
            else
            {
                rb_p.Checked = true;
                rb_l.Checked = false;
            }

            String status = dg_staff.Rows[e.RowIndex].Cells[7].Value.ToString();
            if (status == "Aktif")
            {
                rb_aktif.Checked = true;
                rb_tdk_aktif.Checked = false;
            }
            else
            {
                rb_aktif.Checked = false;
                rb_tdk_aktif.Checked = true;
            }

            dtp_dob_staff.Value = Convert.ToDateTime(dg_staff.Rows[e.RowIndex].Cells[6].Value.ToString());
        }

        private void dg_membership_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_update_membership.Enabled = true;
            btn_delete_membership.Enabled = true;
            btn_insert_membership.Enabled = false;

            idMembership = dg_membership.Rows[e.RowIndex].Cells[0].Value.ToString();

            tb_name_membership.Text = dg_membership.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_harga_membership.Text = dg_membership.Rows[e.RowIndex].Cells[2].Value.ToString().Substring(0, dg_membership.Rows[e.RowIndex].Cells[2].Value.ToString().Length-1);

            nud_wkt_membership.Value = Convert.ToInt32(dg_membership.Rows[e.RowIndex].Cells[3].Value.ToString().Split(' ')[0]);
        }

        private void btn_clear_membership_Click(object sender, EventArgs e)
        {
            clearMembership();
        }

        private void clearMembership()
        {
            btn_update_membership.Enabled = false;
            btn_delete_membership.Enabled = false;
            btn_insert_membership.Enabled = true;

            tb_name_membership.Text = "";
            tb_harga_membership.Text = "";

            nud_wkt_membership.Value = 0;
        }

        private void btn_insert_membership_Click(object sender, EventArgs e)
        {
            if (tb_harga_membership.Text == "" || tb_name_membership.Text == "" || nud_wkt_membership.Value==0) MessageBox.Show("Please fill all input !");
            else if (!tb_harga_membership.Text.All(Char.IsDigit)) MessageBox.Show("Harga harus berupa digit !");
            else
            {
                MySqlCommand cmdID = new MySqlCommand();
                cmdID.CommandText = "SELECT cast(id as unsigned)+1 FROM membership ORDER BY CAST(id AS UNSIGNED) DESC LIMIT 1;";
                cmdID.Connection = koneksi.getConn();

                koneksi.openConn();
                String newID = cmdID.ExecuteScalar().ToString();
                koneksi.closeConn();

                String name = tb_name_membership.Text;
                String harga = tb_harga_membership.Text;
                String wkt = nud_wkt_membership.Value.ToString();

                try
                {
                    MySqlCommand cmdInsert = new MySqlCommand("insert into membership (id,name,discount,exp_length) values (@id,@name,@discount,@time);", koneksi.getConn());

                    cmdInsert.Parameters.AddWithValue("@id", newID);
                    cmdInsert.Parameters.AddWithValue("@name", name);
                    cmdInsert.Parameters.AddWithValue("@discount", harga);
                    cmdInsert.Parameters.AddWithValue("@time", wkt);

                    koneksi.openConn();
                    cmdInsert.ExecuteNonQuery();
                    koneksi.closeConn();

                    clearMembership();
                    refreshDGMembership();
                    MessageBox.Show("Insert successful !");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
        }

        private void btn_update_membership_Click(object sender, EventArgs e)
        {
            if (tb_harga_membership.Text == "" || tb_name_membership.Text == "" || nud_wkt_membership.Value == 0) MessageBox.Show("Please fill all input !");
            else if (!tb_harga_membership.Text.All(Char.IsDigit)) MessageBox.Show("Harga harus berupa digit !");
            else
            {
                String name = tb_name_membership.Text;
                String harga = tb_harga_membership.Text;
                String wkt = nud_wkt_membership.Value.ToString();

                try
                {
                    MySqlCommand cmdInsert = new MySqlCommand("update membership set name = @name, discount = @discount, exp_length=@time where id = @id;", koneksi.getConn());

                    cmdInsert.Parameters.AddWithValue("@id", idMembership);
                    cmdInsert.Parameters.AddWithValue("@name", name);
                    cmdInsert.Parameters.AddWithValue("@discount", harga);
                    cmdInsert.Parameters.AddWithValue("@time", wkt);

                    koneksi.openConn();
                    cmdInsert.ExecuteNonQuery();
                    koneksi.closeConn();

                    clearMembership();
                    refreshDGMembership();
                    MessageBox.Show("Update successful !");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
        }

        private void btn_delete_membership_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this membership ?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("delete from membership where id = @id", koneksi.getConn());
                    cmd.Parameters.AddWithValue("@id", idMembership);

                    koneksi.openConn();
                    cmd.ExecuteNonQuery();
                    koneksi.closeConn();

                    clearMembership();
                    refreshDGMembership();

                    MessageBox.Show("Delete successfull !");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    clearMembership();
                }
            }
        }

        private void masterPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelStaff.Visible = false;
            panelMembership.Visible = false;
            panelPayment.Visible = true;
            panelOccupation.Visible = false;
            panelGenre.Visible = false;
            panelFormat.Visible = false;
            panelPersonel.Visible = false;
            panelGroupMusic.Visible = false;
            panelSong.Visible = false;
            panelProductSong.Visible = false;
            panelProductFormat.Visible = false;
            panelReportLagu.Visible = false;
            panelReportProduct.Visible = false;
            panelReportPenjualan.Visible = false;

            clearPayment();
            refreshDGPayment();
        }

        private void btn_clear_payment_Click(object sender, EventArgs e)
        {
            clearPayment();
        }

        private void clearPayment()
        {
            tb_name_payment.Text = "";

            btn_insert_payment.Enabled = true;
            btn_update_payment.Enabled = false;
            btn_delete_payment.Enabled = false;
        }

        private void btn_insert_payment_Click(object sender, EventArgs e)
        {
            if (tb_name_payment.Text == "") MessageBox.Show("Please fill all inputs !");
            else
            {
                MySqlCommand cmdID = new MySqlCommand();
                cmdID.CommandText = "SELECT cast(id as unsigned)+1 FROM payment_method ORDER BY CAST(id AS UNSIGNED) DESC LIMIT 1;";
                cmdID.Connection = koneksi.getConn();

                koneksi.openConn();
                String newID = cmdID.ExecuteScalar().ToString();
                koneksi.closeConn();

                String name = tb_name_payment.Text;

                try
                {
                    MySqlCommand cmdInsert = new MySqlCommand("insert into payment_method (id,name) values (@id,@name);", koneksi.getConn());

                    cmdInsert.Parameters.AddWithValue("@id", newID);
                    cmdInsert.Parameters.AddWithValue("@name", name);

                    koneksi.openConn();
                    cmdInsert.ExecuteNonQuery();
                    koneksi.closeConn();

                    clearPayment();
                    refreshDGPayment();
                    MessageBox.Show("Insert successful !");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
        }

        private void dg_payment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idPayment = dg_payment.Rows[e.RowIndex].Cells[0].Value.ToString();

            tb_name_payment.Text = dg_payment.Rows[e.RowIndex].Cells[1].Value.ToString();

            btn_insert_payment.Enabled = false;
            btn_delete_payment.Enabled = true;
            btn_update_payment.Enabled = true;
        }

        private void btn_update_payment_Click(object sender, EventArgs e)
        {
            if (tb_name_payment.Text == "") MessageBox.Show("Please fill all inputs !");
            else
            {
                String name = tb_name_payment.Text;

                try
                {
                    MySqlCommand cmdInsert = new MySqlCommand("update payment_method set name = @name where id = @id;", koneksi.getConn());

                    cmdInsert.Parameters.AddWithValue("@id", idPayment);
                    cmdInsert.Parameters.AddWithValue("@name", name);

                    koneksi.openConn();
                    cmdInsert.ExecuteNonQuery();
                    koneksi.closeConn();

                    clearPayment();
                    refreshDGPayment();
                    idPayment = "";
                    MessageBox.Show("Update successful !");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
        }

        private void btn_delete_payment_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this payment method ?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("delete from payment_method where id = @id", koneksi.getConn());
                    cmd.Parameters.AddWithValue("@id", idPayment);

                    koneksi.openConn();
                    cmd.ExecuteNonQuery();
                    koneksi.closeConn();

                    clearPayment();
                    refreshDGPayment();

                    MessageBox.Show("Delete successfull !");
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    clearPayment();
                }
            }
        }

        private void masterOccupationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelStaff.Visible = false;
            panelMembership.Visible = false;
            panelPayment.Visible = false;
            panelOccupation.Visible = true;
            panelGenre.Visible = false;
            panelFormat.Visible = false;
            panelPersonel.Visible = false;
            panelGroupMusic.Visible = false;
            panelSong.Visible = false;
            panelProductSong.Visible = false;
            panelProductFormat.Visible = false;
            panelReportLagu.Visible = false;
            panelReportProduct.Visible = false;
            panelReportPenjualan.Visible = false;

            clearOccupation();
            refreshDGOccupation();
        }

        private void btn_clear_occupation_Click(object sender, EventArgs e)
        {
            clearOccupation();
        }

        private void clearOccupation()
        {
            tb_name_occupation.Text = "";

            btn_insert_occupation.Enabled = true;
            btn_update_occupation.Enabled = false;
            btn_delete_occupation.Enabled = false;
        }

        private void btn_insert_occupation_Click(object sender, EventArgs e)
        {
            if (tb_name_occupation.Text == "") MessageBox.Show("Please fill all inputs !");
            else
            {
                MySqlCommand cmdID = new MySqlCommand();
                cmdID.CommandText = "SELECT cast(id as unsigned)+1 FROM occupation ORDER BY CAST(id AS UNSIGNED) DESC LIMIT 1;";
                cmdID.Connection = koneksi.getConn();

                koneksi.openConn();
                String newID = cmdID.ExecuteScalar().ToString();
                koneksi.closeConn();

                String name = tb_name_occupation.Text;

                try
                {
                    MySqlCommand cmdInsert = new MySqlCommand("insert into occupation (id,name) values (@id,@name);", koneksi.getConn());

                    cmdInsert.Parameters.AddWithValue("@id", newID);
                    cmdInsert.Parameters.AddWithValue("@name", name);

                    koneksi.openConn();
                    cmdInsert.ExecuteNonQuery();
                    koneksi.closeConn();

                    clearOccupation();
                    refreshDGOccupation();
                    MessageBox.Show("Insert successful !");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
        }

        private void btn_update_occupation_Click(object sender, EventArgs e)
        {
            if (tb_name_occupation.Text == "") MessageBox.Show("Please fill all inputs !");
            else
            {
                String name = tb_name_occupation.Text;

                try
                {
                    MySqlCommand cmdInsert = new MySqlCommand("update occupation set name = @name where id = @id;", koneksi.getConn());

                    cmdInsert.Parameters.AddWithValue("@id", idOccupation);
                    cmdInsert.Parameters.AddWithValue("@name", name);

                    koneksi.openConn();
                    cmdInsert.ExecuteNonQuery();
                    koneksi.closeConn();

                    clearOccupation();
                    refreshDGOccupation();
                    idOccupation = "";
                    MessageBox.Show("Update successful !");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
        }

        private void dg_occupation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idOccupation = dg_occupation.Rows[e.RowIndex].Cells[0].Value.ToString();

            tb_name_occupation.Text = dg_occupation.Rows[e.RowIndex].Cells[1].Value.ToString();

            btn_insert_occupation.Enabled = false;
            btn_delete_occupation.Enabled = true;
            btn_update_occupation.Enabled = true;
        }

        private void btn_delete_occupation_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this occupation ?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("delete from occupation where id = @id", koneksi.getConn());
                    cmd.Parameters.AddWithValue("@id", idOccupation);

                    koneksi.openConn();
                    cmd.ExecuteNonQuery();
                    koneksi.closeConn();

                    clearOccupation();
                    refreshDGOccupation();

                    MessageBox.Show("Delete successfull !");
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    clearOccupation();
                }
            }
        }

        private void masterGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelStaff.Visible = false;
            panelMembership.Visible = false;
            panelPayment.Visible = false;
            panelOccupation.Visible = false;
            panelGenre.Visible = true;
            panelFormat.Visible = false;
            panelPersonel.Visible = false;
            panelGroupMusic.Visible = false;
            panelSong.Visible = false;
            panelProductSong.Visible = false;
            panelProductFormat.Visible = false;
            panelReportLagu.Visible = false;
            panelReportProduct.Visible = false;
            panelReportPenjualan.Visible = false;

            clearGenre();
            refreshDGGenre();
        }

        private void clearGenre()
        {
            tb_name_genre.Text = "";

            btn_insert_genre.Enabled = true;
            btn_update_genre.Enabled = false;
            btn_delete_genre.Enabled = false;
        }

        private void dg_genre_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idGenre = dg_genre.Rows[e.RowIndex].Cells[0].Value.ToString();

            tb_name_genre.Text = dg_genre.Rows[e.RowIndex].Cells[1].Value.ToString();

            btn_insert_genre.Enabled = false;
            btn_delete_genre.Enabled = true;
            btn_update_genre.Enabled = true;
        }

        private void btn_insert_genre_Click(object sender, EventArgs e)
        {
            if (tb_name_genre.Text == "") MessageBox.Show("Please fill all inputs !");
            else
            {
                MySqlCommand cmdID = new MySqlCommand();
                cmdID.CommandText = "SELECT cast(id as unsigned)+1 FROM genre ORDER BY CAST(id AS UNSIGNED) DESC LIMIT 1;";
                cmdID.Connection = koneksi.getConn();

                koneksi.openConn();
                String newID = cmdID.ExecuteScalar().ToString();
                koneksi.closeConn();

                String name = tb_name_genre.Text;

                try
                {
                    MySqlCommand cmdInsert = new MySqlCommand("insert into genre (id,name) values (@id,@name);", koneksi.getConn());

                    cmdInsert.Parameters.AddWithValue("@id", newID);
                    cmdInsert.Parameters.AddWithValue("@name", name);

                    koneksi.openConn();
                    cmdInsert.ExecuteNonQuery();
                    koneksi.closeConn();

                    clearGenre();
                    refreshDGGenre();
                    MessageBox.Show("Insert successful !");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
        }

        private void btn_update_genre_Click(object sender, EventArgs e)
        {
            if (tb_name_genre.Text == "") MessageBox.Show("Please fill all inputs !");
            else
            {
                String name = tb_name_genre.Text;

                try
                {
                    MySqlCommand cmdInsert = new MySqlCommand("update genre set name = @name where id = @id;", koneksi.getConn());

                    cmdInsert.Parameters.AddWithValue("@id", idGenre);
                    cmdInsert.Parameters.AddWithValue("@name", name);

                    koneksi.openConn();
                    cmdInsert.ExecuteNonQuery();
                    koneksi.closeConn();

                    clearGenre();
                    refreshDGGenre();
                    idGenre = "";
                    MessageBox.Show("Update successful !");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
        }

        private void btn_delete_genre_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this genre ?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("delete from genre where id = @id", koneksi.getConn());
                    cmd.Parameters.AddWithValue("@id", idGenre);

                    koneksi.openConn();
                    cmd.ExecuteNonQuery();
                    koneksi.closeConn();

                    clearGenre();
                    refreshDGGenre();

                    MessageBox.Show("Delete successfull !");
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    clearGenre();
                }
            }
        }

        private void btn_clear_genre_Click(object sender, EventArgs e)
        {
            clearGenre();
        }

        private void masterFormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelStaff.Visible = false;
            panelMembership.Visible = false;
            panelPayment.Visible = false;
            panelOccupation.Visible = false;
            panelGenre.Visible = false;
            panelFormat.Visible = true;
            panelPersonel.Visible = false;
            panelGroupMusic.Visible = false;
            panelSong.Visible = false;
            panelProductSong.Visible = false;
            panelProductFormat.Visible = false;
            panelReportLagu.Visible = false;
            panelReportProduct.Visible = false;
            panelReportPenjualan.Visible = false;

            clearFormat();
            refreshDGFormat();
        }

        private void clearFormat()
        {
            tb_name_format.Text = "";

            btn_insert_format.Enabled = true;
            btn_update_format.Enabled = false;
            btn_delete_format.Enabled = false;
        }

        private void dg_format_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idFormat = dg_format.Rows[e.RowIndex].Cells[0].Value.ToString();

            tb_name_format.Text = dg_format.Rows[e.RowIndex].Cells[1].Value.ToString();

            btn_insert_format.Enabled = false;
            btn_delete_format.Enabled = true;
            btn_update_format.Enabled = true;
        }

        private void btn_insert_format_Click(object sender, EventArgs e)
        {
            if (tb_name_format.Text == "") MessageBox.Show("Please fill all inputs !");
            else
            {
                MySqlCommand cmdID = new MySqlCommand();
                cmdID.CommandText = "SELECT cast(id as unsigned)+1 FROM format ORDER BY CAST(id AS UNSIGNED) DESC LIMIT 1;";
                cmdID.Connection = koneksi.getConn();

                koneksi.openConn();
                String newID = cmdID.ExecuteScalar().ToString();
                koneksi.closeConn();

                String name = tb_name_format.Text;

                try
                {
                    MySqlCommand cmdInsert = new MySqlCommand("insert into format (id,name) values (@id,@name);", koneksi.getConn());

                    cmdInsert.Parameters.AddWithValue("@id", newID);
                    cmdInsert.Parameters.AddWithValue("@name", name);

                    koneksi.openConn();
                    cmdInsert.ExecuteNonQuery();
                    koneksi.closeConn();

                    clearFormat();
                    refreshDGFormat();
                    MessageBox.Show("Insert successful !");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
        }

        private void btn_update_format_Click(object sender, EventArgs e)
        {
            if (tb_name_format.Text == "") MessageBox.Show("Please fill all inputs !");
            else
            {
                String name = tb_name_format.Text;

                try
                {
                    MySqlCommand cmdInsert = new MySqlCommand("update format set name = @name where id = @id;", koneksi.getConn());

                    cmdInsert.Parameters.AddWithValue("@id", idFormat);
                    cmdInsert.Parameters.AddWithValue("@name", name);

                    koneksi.openConn();
                    cmdInsert.ExecuteNonQuery();
                    koneksi.closeConn();

                    clearFormat();
                    refreshDGFormat();
                    idFormat = "";
                    MessageBox.Show("Update successful !");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
        }

        private void btn_delete_format_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this format ?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("delete from format where id = @id", koneksi.getConn());
                    cmd.Parameters.AddWithValue("@id", idFormat);

                    koneksi.openConn();
                    cmd.ExecuteNonQuery();
                    koneksi.closeConn();

                    clearFormat();
                    refreshDGFormat();

                    MessageBox.Show("Delete successfull !");
                } catch (Exception ex)
                {
                    clearFormat();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void masterPersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelStaff.Visible = false;
            panelMembership.Visible = false;
            panelPayment.Visible = false;
            panelOccupation.Visible = false;
            panelGenre.Visible = false;
            panelFormat.Visible = false;
            panelPersonel.Visible = true;
            panelGroupMusic.Visible = false;
            panelSong.Visible = false;
            panelProductSong.Visible = false;
            panelProductFormat.Visible = false;
            panelReportLagu.Visible = false;
            panelReportProduct.Visible = false;
            panelReportPenjualan.Visible = false;

            clearPersonel();
            refreshDGPersonel();
            fillCBPersonel();
        }

        private void clearPersonel()
        {
            tb_name_personel.Text = "";
            tb_country_personel.Text = "";

            rb_l_personel.Checked = false;
            rb_p_personel.Checked = false;

            cb_occupation_personel.SelectedIndex = -1;

            btn_insert_personel.Enabled = true;
            btn_update_personel.Enabled = false;
            btn_delete_personel.Enabled = false;
        }

        private void btn_insert_personel_Click(object sender, EventArgs e)
        {
            if (checkCond_personel())
            {
                MySqlCommand cmdID = new MySqlCommand();
                cmdID.CommandText = "SELECT cast(id as unsigned)+1 FROM personel ORDER BY CAST(id AS UNSIGNED) DESC LIMIT 1;";
                cmdID.Connection = koneksi.getConn();

                koneksi.openConn();
                String newID = cmdID.ExecuteScalar().ToString();
                koneksi.closeConn();

                String name = tb_name_personel.Text;
                String country = tb_country_personel.Text;

                String gender = "";
                if (rb_l_personel.Checked) gender = "L";
                else gender = "P";

                String occupation = (cb_occupation_personel.SelectedItem as dynamic).Value;

                try
                {
                    MySqlCommand cmdInsert = new MySqlCommand("insert into personel (id,name,country,gender,occupation_id) values (@id,@name,@country,@gender,@occupation_id);", koneksi.getConn());

                    cmdInsert.Parameters.AddWithValue("@id", newID);
                    cmdInsert.Parameters.AddWithValue("@name", name);
                    cmdInsert.Parameters.AddWithValue("@country", country);
                    cmdInsert.Parameters.AddWithValue("@gender", gender);
                    cmdInsert.Parameters.AddWithValue("@occupation_id", occupation);

                    koneksi.openConn();
                    cmdInsert.ExecuteNonQuery();
                    koneksi.closeConn();

                    clearPersonel();
                    refreshDGPersonel();
                    MessageBox.Show("Insert successful !");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
        }

        private void dg_personel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idPersonel = dg_personel.Rows[e.RowIndex].Cells[0].Value.ToString();

            tb_name_personel.Text = dg_personel.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_country_personel.Text = dg_personel.Rows[e.RowIndex].Cells[2].Value.ToString();

            String gender = dg_personel.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (gender == "L") rb_l_personel.Checked = true;
            else rb_p_personel.Checked = true;

            cb_occupation_personel.Text = dg_personel.Rows[e.RowIndex].Cells[4].Value.ToString();

            btn_insert_personel.Enabled = false;
            btn_delete_personel.Enabled = true;
            btn_update_personel.Enabled = true;
        }

        private void btn_clear_personel_Click(object sender, EventArgs e)
        {
            clearPersonel();
        }

        private void btn_update_personel_Click(object sender, EventArgs e)
        {
            if (checkCond_personel())
            {
                String name = tb_name_personel.Text;
                String country = tb_country_personel.Text;

                String gender = "";
                if (rb_l_personel.Checked) gender = "L";
                else gender = "P";

                String occupation = (cb_occupation_personel.SelectedItem as dynamic).Value;

                try
                {
                    MySqlCommand cmdInsert = new MySqlCommand("update personel set name = @name, country = @country, gender = @gender, occupation_id = @occupation_id where id = @id;", koneksi.getConn());

                    cmdInsert.Parameters.AddWithValue("@id", idPersonel);
                    cmdInsert.Parameters.AddWithValue("@name", name);
                    cmdInsert.Parameters.AddWithValue("@country", country);
                    cmdInsert.Parameters.AddWithValue("@gender", gender);
                    cmdInsert.Parameters.AddWithValue("@occupation_id", occupation);

                    koneksi.openConn();
                    cmdInsert.ExecuteNonQuery();
                    koneksi.closeConn();

                    clearPersonel();
                    refreshDGPersonel();
                    MessageBox.Show("Update successful !");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
        }

        private void btn_delete_personel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this personel ?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("delete from personel where id = @id", koneksi.getConn());
                    cmd.Parameters.AddWithValue("@id", idPersonel);

                    koneksi.openConn();
                    cmd.ExecuteNonQuery();
                    koneksi.closeConn();

                    clearPersonel();
                    refreshDGPersonel();

                    MessageBox.Show("Delete successfull !");
                } catch (MySqlException ex)
                {
                    clearPersonel();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void masterGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelStaff.Visible = false;
            panelMembership.Visible = false;
            panelPayment.Visible = false;
            panelOccupation.Visible = false;
            panelGenre.Visible = false;
            panelFormat.Visible = false;
            panelPersonel.Visible = false;
            panelGroupMusic.Visible = true;
            panelSong.Visible = false;
            panelProductSong.Visible = false;
            panelProductFormat.Visible = false;
            panelReportLagu.Visible = false;
            panelReportProduct.Visible = false;
            panelReportPenjualan.Visible = false;

            clearGroupMusic();
            refreshDGGroupMusic();
            fillCBGroupMusic();
            
            if (dtInternalGroupMusic.Columns.Count==0) prepareDTInternalGroupMusic();
        }

        private void clearGroupMusic()
        {
            tb_name_groupMusic.Text = "";

            cb_personel_groupMusic.SelectedIndex = -1;

            btn_insert_groupMusic.Enabled = true;
            btn_update_groupMusic.Enabled = false;
            btn_delete_groupMusic.Enabled = false;

            dg_personel_groupMusic.Rows.Clear();

            dtInternalGroupMusic.Rows.Clear();
            dtTempUpdateGroupMusic.Rows.Clear();
        }

        private void btn_clear_groupMusic_Click(object sender, EventArgs e)
        {
            clearGroupMusic();
        }

        private void dg_groupMusic_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idGroupMusic = dg_groupMusic.Rows[e.RowIndex].Cells[0].Value.ToString();

            tb_name_groupMusic.Text = dg_groupMusic.Rows[e.RowIndex].Cells[1].Value.ToString();

            fillDGPersonelGroupMusic();

            btn_insert_groupMusic.Enabled = false;
            btn_update_groupMusic.Enabled = true;
            btn_delete_groupMusic.Enabled = true;
        }

        private void btn_clear_personel_group_Click(object sender, EventArgs e)
        {
            dg_personel_groupMusic.Rows.Clear();
            dtInternalGroupMusic.Rows.Clear();
        }

        private void btn_enter_group_personel_Click(object sender, EventArgs e)
        {
            String personel = (cb_personel_groupMusic.SelectedItem as dynamic).Personel;
            String occupation = (cb_personel_groupMusic.SelectedItem as dynamic).Occupation;

            dg_personel_groupMusic.Rows.Add(personel, occupation);

            dtInternalGroupMusic.Rows.Add((cb_personel_groupMusic.SelectedItem as dynamic).Value);
        }

        private void btn_delete_group_personel_Click(object sender, EventArgs e)
        {
            dg_personel_groupMusic.Rows.RemoveAt(PersonelGroupMusicIndex);
            dtInternalGroupMusic.Rows.RemoveAt(PersonelGroupMusicIndex);
        }

        private void dg_personel_groupMusic_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PersonelGroupMusicIndex = e.RowIndex;
        }

        private void btn_insert_groupMusic_Click(object sender, EventArgs e)
        {
            if (checkCond_groupMusic())
            {
                MySqlCommand cmdID = new MySqlCommand();
                cmdID.CommandText = "SELECT cast(id as unsigned)+1 FROM group_music ORDER BY CAST(id AS UNSIGNED) DESC LIMIT 1;";
                cmdID.Connection = koneksi.getConn();

                koneksi.openConn();
                String newID = cmdID.ExecuteScalar().ToString();
                koneksi.closeConn();

                String name = tb_name_groupMusic.Text;

                koneksi.openConn();
                using (MySqlTransaction trans = koneksi.getConn().BeginTransaction())
                {
                    try
                    {
                        MySqlCommand cmdInsert = new MySqlCommand("insert into group_music (id,name) values (@id,@name);", koneksi.getConn());

                        cmdInsert.Parameters.AddWithValue("@id", newID);
                        cmdInsert.Parameters.AddWithValue("@name", name);

                        cmdInsert.ExecuteNonQuery();

                        for (int i=0; i<dtInternalGroupMusic.Rows.Count; i++)
                        {
                            MySqlCommand cmdIDGroupPersonel = new MySqlCommand();
                            cmdIDGroupPersonel.CommandText = "SELECT cast(id as unsigned)+1 FROM group_personel ORDER BY CAST(id AS UNSIGNED) DESC LIMIT 1;";
                            cmdIDGroupPersonel.Connection = koneksi.getConn();

                            String newIDGroupPersonel = cmdIDGroupPersonel.ExecuteScalar().ToString();

                            MySqlCommand cmdInsertGroupPersonel = new MySqlCommand();
                            cmdInsertGroupPersonel.CommandText = "insert into group_personel (id, group_id, personel_id) values (@id, @group_id, @personel_id);";
                            cmdInsertGroupPersonel.Parameters.AddWithValue("@id", newIDGroupPersonel);
                            cmdInsertGroupPersonel.Parameters.AddWithValue("@group_id", newID);
                            cmdInsertGroupPersonel.Parameters.AddWithValue("@personel_id", dtInternalGroupMusic.Rows[i][0].ToString());
                            cmdInsertGroupPersonel.Connection = koneksi.getConn();

                            cmdInsertGroupPersonel.ExecuteNonQuery();
                        }

                        trans.Commit();

                        clearGroupMusic();
                        refreshDGGroupMusic();

                        MessageBox.Show("Insert successful !");
                    } catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        trans.Rollback();
                    }
                }
                koneksi.closeConn();
            }
        }

        private void btn_delete_groupMusic_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this group ?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("delete from group_personel where group_id = @id", koneksi.getConn());
                    cmd.Parameters.AddWithValue("@id", idGroupMusic);

                    koneksi.openConn();
                    cmd.ExecuteNonQuery();
                    koneksi.closeConn();

                    MySqlCommand cmd2 = new MySqlCommand("delete from group_music where id = @id", koneksi.getConn());
                    cmd2.Parameters.AddWithValue("@id", idGroupMusic);

                    koneksi.openConn();
                    cmd2.ExecuteNonQuery();
                    koneksi.closeConn();

                    clearGroupMusic();
                    refreshDGGroupMusic();

                    MessageBox.Show("Delete successfull !");
                }
                catch (MySqlException ex)
                {
                    clearGroupMusic();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_update_groupMusic_Click(object sender, EventArgs e)
        {
            if (checkCond_groupMusic())
            {
                String name = tb_name_groupMusic.Text;

                koneksi.openConn();
                using (MySqlTransaction trans = koneksi.getConn().BeginTransaction())
                {
                    try
                    {
                        MySqlCommand cmdUpdate = new MySqlCommand("update group_music set name = @name where id = @id", koneksi.getConn());
                        cmdUpdate.Parameters.AddWithValue("@name", name);
                        cmdUpdate.Parameters.AddWithValue("@id", idGroupMusic);

                        cmdUpdate.ExecuteNonQuery();

                        for (int i=0; i<dtInternalGroupMusic.Rows.Count; i++)
                        {
                            MySqlCommand cmdCount = new MySqlCommand("select count(*) from group_personel where group_id=@group and personel_id=@personel", koneksi.getConn());
                            cmdCount.Parameters.AddWithValue("@group", idGroupMusic);
                            cmdCount.Parameters.AddWithValue("@personel", dtInternalGroupMusic.Rows[i][0].ToString());

                            String count = cmdCount.ExecuteScalar().ToString();

                            if (count=="0")
                            {
                                MySqlCommand cmdID = new MySqlCommand();
                                cmdID.CommandText = "SELECT cast(id as unsigned)+1 FROM group_personel ORDER BY CAST(id AS UNSIGNED) DESC LIMIT 1;";
                                cmdID.Connection = koneksi.getConn();

                                String newID = cmdID.ExecuteScalar().ToString();

                                MySqlCommand cmdNewInsert = new MySqlCommand("insert into group_personel (id, group_id, personel_id) values (@id, @group, @personel)",koneksi.getConn());
                                cmdNewInsert.Parameters.AddWithValue("@id", newID);
                                cmdNewInsert.Parameters.AddWithValue("@group", idGroupMusic);
                                cmdNewInsert.Parameters.AddWithValue("@personel", dtInternalGroupMusic.Rows[i][0].ToString());

                                cmdNewInsert.ExecuteNonQuery();
                            }
                        }

                        MySqlCommand cmdTemp = new MySqlCommand("select personel_id from group_personel where group_id = @group",koneksi.getConn());
                        cmdTemp.Parameters.AddWithValue("@group", idGroupMusic);

                        MySqlDataReader dr = cmdTemp.ExecuteReader();
                        while (dr.Read())
                        {
                            dtTempUpdateGroupMusic.Rows.Add(dr.GetString(0));
                        }
                        dr.Close();

                        for (int i=0; i<dtTempUpdateGroupMusic.Rows.Count;i++)
                        {
                            Boolean isThere = false;
                            for (int j=0; j<dtInternalGroupMusic.Rows.Count; j++)
                            {
                                if (dtInternalGroupMusic.Rows[j][0].ToString()==dtTempUpdateGroupMusic.Rows[i][0].ToString())
                                {
                                    isThere = true;
                                    break;
                                }
                            }

                            if (!isThere)
                            {
                                MySqlCommand cmdNewDelete = new MySqlCommand("delete from group_personel where group_id = @group and personel_id = @personel", koneksi.getConn());
                                cmdNewDelete.Parameters.AddWithValue("@group", idGroupMusic);
                                cmdNewDelete.Parameters.AddWithValue("@personel", dtTempUpdateGroupMusic.Rows[i][0].ToString());

                                cmdNewDelete.ExecuteNonQuery();
                            }
                        }

                        trans.Commit();

                        clearGroupMusic();
                        refreshDGGroupMusic();

                        MessageBox.Show("Update successful !");
                    } catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        trans.Rollback();
                    }
                }
                koneksi.closeConn();
            }
        }

        private void masterSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelStaff.Visible = false;
            panelMembership.Visible = false;
            panelPayment.Visible = false;
            panelOccupation.Visible = false;
            panelGenre.Visible = false;
            panelFormat.Visible = false;
            panelPersonel.Visible = false;
            panelGroupMusic.Visible = false;
            panelSong.Visible = true;
            panelProductSong.Visible = false;
            panelProductFormat.Visible = false;
            panelReportLagu.Visible = false;
            panelReportProduct.Visible = false;
            panelReportPenjualan.Visible = false;

            clearSong();
            refreshDGSong();
            fillCBSong_1();
            fillCBSong_2();
        }

        private void clearSong()
        {
            tb_name_song.Text = "";
            tb_length_song.Text = "";

            rtb_deskripsi_song.Text = "";

            cb_group_song.SelectedIndex = -1;
            cb_genre_song.SelectedIndex = -1;

            dtp_releaseDate_song.Value = DateTime.Today;

            btn_insert_song.Enabled = true;
            btn_update_song.Enabled = false;
            btn_delete_song.Enabled = false;
        }

        private void btn_clear_song_Click(object sender, EventArgs e)
        {
            clearSong();
        }

        private void btn_insert_song_Click(object sender, EventArgs e)
        {
            if (checkCond_song())
            {
                MySqlCommand cmdID = new MySqlCommand();
                cmdID.CommandText = "SELECT cast(id as unsigned)+1 FROM songs ORDER BY CAST(id AS UNSIGNED) DESC LIMIT 1;";
                cmdID.Connection = koneksi.getConn();

                koneksi.openConn();
                String newID = cmdID.ExecuteScalar().ToString();
                koneksi.closeConn();

                String name = tb_name_song.Text;
                String description = rtb_deskripsi_song.Text;
                String length = tb_length_song.Text;

                String releaseDate = dtp_releaseDate_song.Value.ToString("yyyy-MM-dd");

                String genre = (cb_genre_song.SelectedItem as dynamic).Value;
                String group = (cb_group_song.SelectedItem as dynamic).Value;

                try
                {
                    MySqlCommand cmdInsert = new MySqlCommand("insert into songs (id,name,release_date,group_id, genre_id, description, length, rating) values (@id,@name,@date,@group,@genre, @desc, @length, 0);", koneksi.getConn());

                    cmdInsert.Parameters.AddWithValue("@id", newID);
                    cmdInsert.Parameters.AddWithValue("@name", name);
                    cmdInsert.Parameters.AddWithValue("@date", releaseDate);
                    cmdInsert.Parameters.AddWithValue("@genre", genre);
                    cmdInsert.Parameters.AddWithValue("@group", group);
                    cmdInsert.Parameters.AddWithValue("@desc", description);
                    cmdInsert.Parameters.AddWithValue("@length", length);

                    koneksi.openConn();
                    cmdInsert.ExecuteNonQuery();
                    koneksi.closeConn();

                    clearSong();
                    refreshDGSong();
                    MessageBox.Show("Insert successful !");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dg_song_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idSong = dg_song.Rows[e.RowIndex].Cells[0].Value.ToString();

            tb_name_song.Text = dg_song.Rows[e.RowIndex].Cells[1].Value.ToString();
            rtb_deskripsi_song.Text = dg_song.Rows[e.RowIndex].Cells[6].Value.ToString();

            dtp_releaseDate_song.Value = DateTime.Parse(dg_song.Rows[e.RowIndex].Cells[2].Value.ToString());

            tb_length_song.Text = (Convert.ToInt32(dg_song.Rows[e.RowIndex].Cells[5].Value.ToString().Substring(0,2))*60 + Convert.ToInt32(dg_song.Rows[e.RowIndex].Cells[5].Value.ToString().Substring(3, 2))).ToString() ;

            cb_group_song.Text = dg_song.Rows[e.RowIndex].Cells[3].Value.ToString();
            cb_genre_song.Text = dg_song.Rows[e.RowIndex].Cells[4].Value.ToString();

            btn_insert_song.Enabled = false;
            btn_delete_song.Enabled = true;
            btn_update_song.Enabled = true;
        }

        private void btn_delete_song_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this song ?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("delete from songs where id = @id", koneksi.getConn());
                    cmd.Parameters.AddWithValue("@id", idSong);

                    koneksi.openConn();
                    cmd.ExecuteNonQuery();
                    koneksi.closeConn();

                    clearSong();
                    refreshDGSong();

                    MessageBox.Show("Delete successfull !");
                }
                catch (MySqlException ex)
                {
                    clearSong();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_update_song_Click(object sender, EventArgs e)
        {
            if (checkCond_song())
            {
                String name = tb_name_song.Text;
                String description = rtb_deskripsi_song.Text;
                String length = tb_length_song.Text;

                String releaseDate = dtp_releaseDate_song.Value.ToString("yyyy-MM-dd");

                String genre = (cb_genre_song.SelectedItem as dynamic).Value;
                String group = (cb_group_song.SelectedItem as dynamic).Value;

                try
                {
                    MySqlCommand cmdInsert = new MySqlCommand("update songs set name = @name, release_date = @date, genre_id = @genre, group_id = @group, length = @length, description = @desc where id = @id;", koneksi.getConn());

                    cmdInsert.Parameters.AddWithValue("@id", idSong);
                    cmdInsert.Parameters.AddWithValue("@name", name);
                    cmdInsert.Parameters.AddWithValue("@date", releaseDate);
                    cmdInsert.Parameters.AddWithValue("@genre", genre);
                    cmdInsert.Parameters.AddWithValue("@group", group);
                    cmdInsert.Parameters.AddWithValue("@desc", description);
                    cmdInsert.Parameters.AddWithValue("@length", length);

                    koneksi.openConn();
                    cmdInsert.ExecuteNonQuery();
                    koneksi.closeConn();

                    clearSong();
                    refreshDGSong();
                    MessageBox.Show("Update successful !");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void masterProductSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelStaff.Visible = false;
            panelMembership.Visible = false;
            panelPayment.Visible = false;
            panelOccupation.Visible = false;
            panelGenre.Visible = false;
            panelFormat.Visible = false;
            panelPersonel.Visible = false;
            panelGroupMusic.Visible = false;
            panelSong.Visible = false;
            panelProductSong.Visible = true;
            panelProductFormat.Visible = false;
            panelReportLagu.Visible = false;
            panelReportProduct.Visible = false;
            panelReportPenjualan.Visible = false;

            clearProductSong();
            refreshDGProductSong();
            fillCBProductSong_Type();
            fillCBProductSong_Song();

            if (dtInternalProductSong.Columns.Count == 0) prepareDTInternalProductSong();
        }

        private void clearProductSong()
        {
            tb_name_productSong.Text = "";

            rtb_description_productSong.Text = "";

            cb_type_productSong.SelectedIndex = -1;
            cb_song_productSong.SelectedIndex = -1;

            btn_insert_productSong.Enabled = true;
            btn_update_productSong.Enabled = false;
            btn_delete_productSong.Enabled = false;

            dg_song_productSong.Rows.Clear();

            dtInternalProductSong.Rows.Clear();
            dtTempUpdateProductSong.Rows.Clear();
        }

        private void btn_clear_groupSong_Click(object sender, EventArgs e)
        {
            clearProductSong();
        }

        private void dg_productSong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idProductSong = dg_productSong.Rows[e.RowIndex].Cells[0].Value.ToString();

            tb_name_productSong.Text = dg_productSong.Rows[e.RowIndex].Cells[1].Value.ToString();

            rtb_description_productSong.Text = dg_productSong.Rows[e.RowIndex].Cells[3].Value.ToString();

            cb_type_productSong.Text = dg_productSong.Rows[e.RowIndex].Cells[4].Value.ToString();

            fillDGSongProductSong();

            btn_insert_productSong.Enabled = false;
            btn_update_productSong.Enabled = true;
            btn_delete_productSong.Enabled = true;
        }

        private void btn_clear_song_productSong_Click(object sender, EventArgs e)
        {
            dg_song_productSong.Rows.Clear();
            dtInternalProductSong.Rows.Clear();
        }

        private void btn_enter_song_productSong_Click(object sender, EventArgs e)
        {
            if (cb_song_productSong.SelectedIndex != -1)
            {
                String song = (cb_song_productSong.SelectedItem as dynamic).Text;
                String length = (cb_song_productSong.SelectedItem as dynamic).Length;

                dg_song_productSong.Rows.Add(song, length);

                dtInternalProductSong.Rows.Add((cb_song_productSong.SelectedItem as dynamic).Value);
            }
            else MessageBox.Show("Pilih lagu terlebih dahulu !");
        }

        private void btn_delete_song_productSong_Click(object sender, EventArgs e)
        {
            dg_song_productSong.Rows.RemoveAt(SongProductSongIndex);
            dtInternalProductSong.Rows.RemoveAt(SongProductSongIndex);
        }

        private void dg_song_productSong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SongProductSongIndex = e.RowIndex;
        }

        private void btn_insert_productSong_Click(object sender, EventArgs e)
        {
            if (checkCond_productSong())
            {
                MySqlCommand cmdID = new MySqlCommand();
                cmdID.CommandText = "SELECT cast(id as unsigned)+1 FROM product ORDER BY CAST(id AS UNSIGNED) DESC LIMIT 1;";
                cmdID.Connection = koneksi.getConn();

                koneksi.openConn();
                String newID = cmdID.ExecuteScalar().ToString();
                koneksi.closeConn();

                String name = tb_name_productSong.Text;
                String desc = rtb_description_productSong.Text;
                String type = (cb_type_productSong.SelectedItem as dynamic).Value;

                koneksi.openConn();
                using (MySqlTransaction trans = koneksi.getConn().BeginTransaction())
                {
                    try
                    {
                        MySqlCommand cmdInsert = new MySqlCommand("insert into product (id,name, release_date, rating, description, type_id) values (@id,@name,@date,0,@desc,@type);", koneksi.getConn());

                        cmdInsert.Parameters.AddWithValue("@id", newID);
                        cmdInsert.Parameters.AddWithValue("@name", name);
                        cmdInsert.Parameters.AddWithValue("@desc", desc);
                        cmdInsert.Parameters.AddWithValue("@type", type);
                        cmdInsert.Parameters.AddWithValue("@date", DateTime.Today.ToString("yyyy-MM-dd"));

                        cmdInsert.ExecuteNonQuery();

                        for (int i = 0; i < dtInternalProductSong.Rows.Count; i++)
                        {
                            MySqlCommand cmdIDProductSong = new MySqlCommand();
                            cmdIDProductSong.CommandText = "SELECT cast(id as unsigned)+1 FROM product_song ORDER BY CAST(id AS UNSIGNED) DESC LIMIT 1;";
                            cmdIDProductSong.Connection = koneksi.getConn();

                            String newIDProductSong = cmdIDProductSong.ExecuteScalar().ToString();

                            MySqlCommand cmdInsertGroupPersonel = new MySqlCommand();
                            cmdInsertGroupPersonel.CommandText = "insert into product_song (id, product_id, song_id) values (@id, @product_id, @song_id);";
                            cmdInsertGroupPersonel.Parameters.AddWithValue("@id", newIDProductSong);
                            cmdInsertGroupPersonel.Parameters.AddWithValue("@product_id", newID);
                            cmdInsertGroupPersonel.Parameters.AddWithValue("@song_id", dtInternalProductSong.Rows[i][0].ToString());
                            cmdInsertGroupPersonel.Connection = koneksi.getConn();

                            cmdInsertGroupPersonel.ExecuteNonQuery();
                        }

                        trans.Commit();

                        clearProductSong();
                        refreshDGProductSong();

                        MessageBox.Show("Insert successful !");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        trans.Rollback();
                    }
                }
                koneksi.closeConn();
            }
        }

        private void btn_delete_productSong_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this product ?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("delete from product_song where product_id = @id", koneksi.getConn());
                    cmd.Parameters.AddWithValue("@id", idProductSong);

                    koneksi.openConn();
                    cmd.ExecuteNonQuery();
                    koneksi.closeConn();

                    MySqlCommand cmd2 = new MySqlCommand("delete from product where id = @id", koneksi.getConn());
                    cmd2.Parameters.AddWithValue("@id", idProductSong);

                    koneksi.openConn();
                    cmd2.ExecuteNonQuery();
                    koneksi.closeConn();

                    clearProductSong();
                    refreshDGProductSong();

                    MessageBox.Show("Delete successfull !");
                }
                catch (MySqlException ex)
                {
                    clearProductSong();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_update_productSong_Click(object sender, EventArgs e)
        {
            if (checkCond_productSong())
            {
                String name = tb_name_productSong.Text;
                String desc = rtb_description_productSong.Text;
                String type = (cb_type_productSong.SelectedItem as dynamic).Value;

                koneksi.openConn();
                using (MySqlTransaction trans = koneksi.getConn().BeginTransaction())
                {
                    try
                    {
                        MySqlCommand cmdUpdate = new MySqlCommand("update product set name = @name, description = @desc, type_id = @type where id = @id", koneksi.getConn());
                        cmdUpdate.Parameters.AddWithValue("@name", name);
                        cmdUpdate.Parameters.AddWithValue("@desc", desc);
                        cmdUpdate.Parameters.AddWithValue("@type", type);
                        cmdUpdate.Parameters.AddWithValue("@id", idProductSong);

                        cmdUpdate.ExecuteNonQuery();

                        for (int i = 0; i < dtInternalProductSong.Rows.Count; i++)
                        {
                            MySqlCommand cmdCount = new MySqlCommand("select count(*) from product_song where product_id=@product and song_id=@song", koneksi.getConn());
                            cmdCount.Parameters.AddWithValue("@product", idProductSong);
                            cmdCount.Parameters.AddWithValue("@song", dtInternalProductSong.Rows[i][0].ToString());

                            String count = cmdCount.ExecuteScalar().ToString();

                            if (count == "0")
                            {
                                MySqlCommand cmdID = new MySqlCommand();
                                cmdID.CommandText = "SELECT cast(id as unsigned)+1 FROM product_song ORDER BY CAST(id AS UNSIGNED) DESC LIMIT 1;";
                                cmdID.Connection = koneksi.getConn();

                                String newID = cmdID.ExecuteScalar().ToString();

                                MySqlCommand cmdNewInsert = new MySqlCommand("insert into product_song (id, product_id, song_id) values (@id, @product, @song)", koneksi.getConn());
                                cmdNewInsert.Parameters.AddWithValue("@id", newID);
                                cmdNewInsert.Parameters.AddWithValue("@product", idProductSong);
                                cmdNewInsert.Parameters.AddWithValue("@song", dtInternalProductSong.Rows[i][0].ToString());

                                cmdNewInsert.ExecuteNonQuery();
                            }
                        }

                        MySqlCommand cmdTemp = new MySqlCommand("select song_id from product_song where product_id = @product", koneksi.getConn());
                        cmdTemp.Parameters.AddWithValue("@product", idProductSong);

                        MySqlDataReader dr = cmdTemp.ExecuteReader();
                        while (dr.Read())
                        {
                            dtTempUpdateProductSong.Rows.Add(dr.GetString(0));
                        }
                        dr.Close();

                        for (int i = 0; i < dtTempUpdateProductSong.Rows.Count; i++)
                        {
                            Boolean isThere = false;
                            for (int j = 0; j < dtInternalProductSong.Rows.Count; j++)
                            {
                                if (dtInternalProductSong.Rows[j][0].ToString() == dtTempUpdateProductSong.Rows[i][0].ToString())
                                {
                                    isThere = true;
                                    break;
                                }
                            }

                            if (!isThere)
                            {
                                MySqlCommand cmdNewDelete = new MySqlCommand("delete from product_song where product_id = @product and song_id = @song", koneksi.getConn());
                                cmdNewDelete.Parameters.AddWithValue("@product", idProductSong);
                                cmdNewDelete.Parameters.AddWithValue("@song", dtTempUpdateProductSong.Rows[i][0].ToString());

                                cmdNewDelete.ExecuteNonQuery();
                            }
                        }

                        trans.Commit();

                        clearProductSong();
                        refreshDGProductSong();

                        MessageBox.Show("Update successful !");
                    }
                    catch (MySqlException ex)
                    {
                        clearProductSong();
                        MessageBox.Show(ex.Message);
                        trans.Rollback();
                    }
                }
                koneksi.closeConn();
            }
        }

        private void masterProductSellingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelStaff.Visible = false;
            panelMembership.Visible = false;
            panelPayment.Visible = false;
            panelOccupation.Visible = false;
            panelGenre.Visible = false;
            panelFormat.Visible = false;
            panelPersonel.Visible = false;
            panelGroupMusic.Visible = false;
            panelSong.Visible = false;
            panelProductSong.Visible = false;
            panelProductFormat.Visible = true;
            panelReportLagu.Visible = false;
            panelReportProduct.Visible = false;
            panelReportPenjualan.Visible = false;

            clearProductFormat();
            refreshDGProductFormat();
            fillCBProductFormat();
        }

        private void clearProductFormat()
        {
            cb_format_productFormat.SelectedIndex = -1;
            tb_harga_productFormat.Text = "";

            btn_enter_format_productFormat.Enabled = false;
            btn_delete_format_productFormat.Enabled = false;

            dg_format_productFormat.Rows.Clear();
        }

        private void dg_productFormat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                idProductFormat = dg_productFormat.Rows[e.RowIndex].Cells[0].Value.ToString();

                fillDGFormatProductFormat();

                btn_enter_format_productFormat.Enabled = true;
                btn_delete_format_productFormat.Enabled = true;
            }
        }

        private void btn_enter_format_productFormat_Click(object sender, EventArgs e)
        {
            if (cb_format_productFormat.SelectedIndex == -1) MessageBox.Show("Pilih format produk terlebih dahulu !");
            else if (tb_harga_productFormat.Text == "") MessageBox.Show("Isi harga produk terlebih dahulu !");
            else if (!tb_harga_productFormat.Text.All(char.IsDigit)) MessageBox.Show("Harga harus berupa digit !");
            else
            {
                MySqlCommand cmdID = new MySqlCommand();
                cmdID.CommandText = "SELECT cast(id as unsigned)+1 FROM format_product ORDER BY CAST(id AS UNSIGNED) DESC LIMIT 1;";
                cmdID.Connection = koneksi.getConn();

                koneksi.openConn();
                String newID = cmdID.ExecuteScalar().ToString();
                koneksi.closeConn();

                String format = (cb_format_productFormat.SelectedItem as dynamic).Value;
                String price = tb_harga_productFormat.Text;

                try
                {
                    MySqlCommand cmdInsert = new MySqlCommand("insert into format_product (id,product_id, format_id,stock,price) values (@id,@product,@format,100,@price);", koneksi.getConn());

                    cmdInsert.Parameters.AddWithValue("@id", newID);
                    cmdInsert.Parameters.AddWithValue("@product", idProductFormat);
                    cmdInsert.Parameters.AddWithValue("@format", format);
                    cmdInsert.Parameters.AddWithValue("@price", price);

                    koneksi.openConn();
                    cmdInsert.ExecuteNonQuery();
                    koneksi.closeConn();

                    clearProductFormat();
                    refreshDGProductFormat();
                    MessageBox.Show("Insert successful !");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dg_format_productFormat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                Format_ProductFormat = dg_format_productFormat.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void btn_delete_format_productFormat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this ?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("DELETE fp FROM format_product fp, FORMAT f, product p WHERE f.id = fp.`FORMAT_ID` AND fp.`PRODUCT_ID` = p.`ID` AND p.`ID` = @product AND f.Name = @format;", koneksi.getConn());
                    cmd.Parameters.AddWithValue("@product", idProductFormat);
                    cmd.Parameters.AddWithValue("@format", Format_ProductFormat);

                    koneksi.openConn();
                    cmd.ExecuteNonQuery();
                    koneksi.closeConn();

                    clearProductFormat();
                    refreshDGProductFormat();

                    MessageBox.Show("Delete successfull !");
                }
                catch (MySqlException ex)
                {
                    clearProductFormat();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void reportLaguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelStaff.Visible = false;
            panelMembership.Visible = false;
            panelPayment.Visible = false;
            panelOccupation.Visible = false;
            panelGenre.Visible = false;
            panelFormat.Visible = false;
            panelPersonel.Visible = false;
            panelGroupMusic.Visible = false;
            panelSong.Visible = false;
            panelProductSong.Visible = false;
            panelProductFormat.Visible = false;
            panelReportLagu.Visible = true;
            panelReportProduct.Visible = false;
            panelReportPenjualan.Visible = false;

            CrystalReport1 report = new CrystalReport1();
            report.SetDatabaseLogon("root", "", "localhost", "db_projek_pcs");

            crv_reportLagu.ReportSource = report;
        }

        private void reportProdukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelStaff.Visible = false;
            panelMembership.Visible = false;
            panelPayment.Visible = false;
            panelOccupation.Visible = false;
            panelGenre.Visible = false;
            panelFormat.Visible = false;
            panelPersonel.Visible = false;
            panelGroupMusic.Visible = false;
            panelSong.Visible = false;
            panelProductSong.Visible = false;
            panelProductFormat.Visible = false;
            panelReportLagu.Visible = false;
            panelReportProduct.Visible = true;
            panelReportPenjualan.Visible = false;

            CrystalReport_reportProduct report = new CrystalReport_reportProduct();
            report.SetDatabaseLogon("root", "", "localhost", "db_projek_pcs");

            crv_reportProduct.ReportSource = report;
        }

        private void rb_sort_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_sort.Checked) dtp_reportPenjualan.Enabled = true;
            else dtp_reportPenjualan.Enabled = false;
        }

        private void reportPenjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelStaff.Visible = false;
            panelMembership.Visible = false;
            panelPayment.Visible = false;
            panelOccupation.Visible = false;
            panelGenre.Visible = false;
            panelFormat.Visible = false;
            panelPersonel.Visible = false;
            panelGroupMusic.Visible = false;
            panelSong.Visible = false;
            panelProductSong.Visible = false;
            panelProductFormat.Visible = false;
            panelReportLagu.Visible = false;
            panelReportProduct.Visible = false;
            panelReportPenjualan.Visible = true;

            dtp_reportPenjualan.Format = DateTimePickerFormat.Custom;
            dtp_reportPenjualan.CustomFormat = "MM-yyyy";
            dtp_reportPenjualan.ShowUpDown = true;
        }

        private void btn_reportPenjualan_Click(object sender, EventArgs e)
        {
            if (rb_sort.Checked)
            {
                CrystalReport_reportPenjualan report = new CrystalReport_reportPenjualan();
                report.SetDatabaseLogon("root", "", "localhost", "db_projek_pcs");
                report.SetParameterValue("param_month", dtp_reportPenjualan.Value.ToString("MM"));
                report.SetParameterValue("param_year", dtp_reportPenjualan.Value.ToString("yyyy"));

                crv_reportPenjualan.ReportSource = report;
            } else
            {
                CrystalReport_reportPenjualan report = new CrystalReport_reportPenjualan();
                report.SetDatabaseLogon("root", "", "localhost", "db_projek_pcs");
                report.SetParameterValue("param_month", "0");
                report.SetParameterValue("param_year", "0");

                crv_reportPenjualan.ReportSource = report;
            }
        }
    }
}
