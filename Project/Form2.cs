using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project
{
    public partial class Form2 : Form
    {
        public String idStaff;

        public Form2()
        {
            InitializeComponent();
        }

        private void masterStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelStaff.Visible = true;

            refreshDGStaff();
        }

        private void masterMembershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelStaff.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panelStaff.Visible = true;

            refreshDGStaff();
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

        private void btn_clear_staff_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
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

                    clear();
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

                    clear();
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

                clear();
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
    }
}
