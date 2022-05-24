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
                MySqlCommand cmd = new MySqlCommand("delete from staff where id = @id", koneksi.getConn());
                cmd.Parameters.AddWithValue("@id", idStaff);

                koneksi.openConn();
                cmd.ExecuteNonQuery();
                koneksi.closeConn();

                clearStaff();
                refreshDGStaff();

                MessageBox.Show("Delete successfull !");
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
                MySqlCommand cmd = new MySqlCommand("delete from membership where id = @id", koneksi.getConn());
                cmd.Parameters.AddWithValue("@id", idMembership);

                koneksi.openConn();
                cmd.ExecuteNonQuery();
                koneksi.closeConn();

                clearMembership();
                refreshDGMembership();

                MessageBox.Show("Delete successfull !");
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
                MySqlCommand cmd = new MySqlCommand("delete from payment_method where id = @id", koneksi.getConn());
                cmd.Parameters.AddWithValue("@id", idPayment);

                koneksi.openConn();
                cmd.ExecuteNonQuery();
                koneksi.closeConn();

                clearPayment();
                refreshDGPayment();

                MessageBox.Show("Delete successfull !");
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
                MySqlCommand cmd = new MySqlCommand("delete from occupation where id = @id", koneksi.getConn());
                cmd.Parameters.AddWithValue("@id", idOccupation);

                koneksi.openConn();
                cmd.ExecuteNonQuery();
                koneksi.closeConn();

                clearOccupation();
                refreshDGOccupation();

                MessageBox.Show("Delete successfull !");
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
                MySqlCommand cmd = new MySqlCommand("delete from genre where id = @id", koneksi.getConn());
                cmd.Parameters.AddWithValue("@id", idGenre);

                koneksi.openConn();
                cmd.ExecuteNonQuery();
                koneksi.closeConn();

                clearGenre();
                refreshDGGenre();

                MessageBox.Show("Delete successfull !");
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
                MySqlCommand cmd = new MySqlCommand("delete from format where id = @id", koneksi.getConn());
                cmd.Parameters.AddWithValue("@id", idFormat);

                koneksi.openConn();
                cmd.ExecuteNonQuery();
                koneksi.closeConn();

                clearFormat();
                refreshDGFormat();

                MessageBox.Show("Delete successfull !");
            }
        }
    }
}
