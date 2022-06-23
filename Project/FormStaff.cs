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
    public partial class FormStaff : Form
    {
        public String staff_username;
        public String staff_id;
        public String staff_nama;

        public String idUpdate;

        public FormStaff()
        {
            InitializeComponent();
        }

        public FormStaff(String username)
        {
            InitializeComponent();

            staff_username = username;
        }

        private void fillForm()
        {
            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            MySqlCommand cmd = new MySqlCommand("SELECT id, name from staff where username = @staff", koneksi.getConn());
            cmd.Parameters.AddWithValue("@staff", staff_username);

            koneksi.openConn();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                staff_id = dr.GetString(0);
                staff_nama = dr.GetString(1);
            }

            koneksi.closeConn();

            label_staff.Text = "Selamat Datang, " + staff_nama;
        }

        private void fillCBRegister()
        {
            cb_membership_register.Items.Clear();

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            MySqlCommand cmd = new MySqlCommand("select id, name, exp_length from membership;", koneksi.getConn());

            koneksi.openConn();
            MySqlDataReader dr = cmd.ExecuteReader();

            cb_membership_register.DisplayMember = "Text";
            cb_membership_register.ValueMember = "Value";

            while (dr.Read())
            {
                cb_membership_register.Items.Add(new { Text = dr.GetString(1), Value = dr.GetString(0), Exp = dr.GetString(2) });
            }

            koneksi.closeConn();
            cb_membership_register.SelectedIndex = -1;
        }

        private void fillCBRestock()
        {
            cb_produk_restock.Items.Clear();

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            MySqlCommand cmd = new MySqlCommand("SELECT fp.`ID`, CONCAT(p.`NAME`, ' - ', f.`NAME`, ' - ' , fp.`STOCK`) FROM format_product fp, product p, FORMAT f WHERE fp.`PRODUCT_ID` = p.`ID` AND fp.`FORMAT_ID` = f.`ID` ORDER BY CAST(p.`ID` AS UNSIGNED);", koneksi.getConn());

            koneksi.openConn();
            MySqlDataReader dr = cmd.ExecuteReader();

            cb_produk_restock.DisplayMember = "Text";
            cb_produk_restock.ValueMember = "Value";

            while (dr.Read())
            {
                cb_produk_restock.Items.Add(new { Text = dr.GetString(1), Value = dr.GetString(0) });
            }

            koneksi.closeConn();
            cb_produk_restock.SelectedIndex = -1;
        }

        private void fillCBMembership()
        {
            cb_membership_update.Items.Clear();   

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            MySqlCommand cmd = new MySqlCommand("select id, name, exp_length from membership;", koneksi.getConn());

            koneksi.openConn();
            MySqlDataReader dr = cmd.ExecuteReader();

            cb_membership_update.DisplayMember = "Text";
            cb_membership_update.ValueMember = "Value";

            cb_membership_update.Items.Add(new { Text = "-", Value = "-", Exp = "-" });
            while (dr.Read())
            {
                cb_membership_update.Items.Add(new { Text = dr.GetString(1), Value = dr.GetString(0), Exp = dr.GetString(2) });
            }

            koneksi.closeConn();
            cb_membership_update.SelectedIndex = -1;
        }

        private Boolean checkCond_Register()
        {
            if (TB_NAME.Text=="")
            {
                MessageBox.Show("Isi nama member terlebih dahulu !");
                return false;
            } else if (TB_ADDRESS.Text=="")
            {
                MessageBox.Show("Isi alamat member terlebih dahulu !");
                return false;
            } else if (TB_USERNAME.Text=="")
            {
                MessageBox.Show("Isi username member terlebih dahulu !");
                return false;
            } else if (TB_PASSWORD.Text=="")
            {
                MessageBox.Show("Isi password member terlebih dahulu !");
                return false;
            } else if (!checkBox_Female.Checked && !checkBoxMale.Checked)
            {
                MessageBox.Show("Pilih jenis kelamin member terlebih dahulu !");
                return false;
            } else if (dateTimePicker_DateOfBirth.Value==DateTime.Today)
            {
                MessageBox.Show("Pilih tanggal lahir member terlebih dahulu !");
                return false;
            } else
            {
                MySqlCommand cmdCount = new MySqlCommand("select count(*) from member where username = @username", koneksi.getConn());
                cmdCount.Parameters.AddWithValue("@username", TB_USERNAME.Text);

                koneksi.openConn();
                int count = Convert.ToInt32(cmdCount.ExecuteScalar().ToString());
                koneksi.closeConn();

                if (count != 0)
                {
                    MessageBox.Show("Username sudah terdaftar !");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void clearRegister()
        {
            TB_NAME.Text = "";
            TB_PASSWORD.Text = "";
            TB_USERNAME.Text = "";
            TB_ADDRESS.Text = "";

            checkBox_Female.Checked = false;
            checkBoxMale.Checked = false;

            cb_membership_register.SelectedIndex = -1;

            dateTimePicker_DateOfBirth.Value = DateTime.Today;
        }

        private void clearRestock()
        {
            cb_produk_restock.SelectedIndex = -1;
            TB_QUANTITY.Text = "";
        }

        private void fillDGMembership()
        {
            dg_membership.DataSource = null;

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT m.`ID`, m.`NAME` as 'Member', IFNULL(mm.`NAME`,'-') as 'Membership', ifnull(date_format(m.membership_exp,'%d %M %Y'), '-') as 'Expire Date' FROM member m LEFT JOIN membership mm ON m.`MEMBERSHIP_ID` = mm.`ID`;", koneksi.getConn());
            MySqlDataAdapter da = new MySqlDataAdapter();

            koneksi.openConn();
            cmd.ExecuteReader();
            koneksi.closeConn();

            da.SelectCommand = cmd;
            da.Fill(dt);

            dg_membership.DataSource = dt;
        }

        private void fillDGOrder()
        {
            dg_order.DataSource = null;

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT o.note_number AS 'Note Number', m.`NAME` AS 'Member', o.`TOTAL` AS 'Total', o.`STATUS` AS 'Status' FROM orders o, member m WHERE o.`MEMBER_ID` = m.`ID` AND STATUS='PENDING';", koneksi.getConn());
            MySqlDataAdapter da = new MySqlDataAdapter();

            koneksi.openConn();
            cmd.ExecuteReader();
            koneksi.closeConn();

            da.SelectCommand = cmd;
            da.Fill(dt);

            dg_order.DataSource = dt;
        }

        private void FormStaff_Load(object sender, EventArgs e)
        {
            panelRegister.Visible = true;
            panelRestock.Visible = false;
            panelMembership.Visible = false;
            panelOrder.Visible = false;

            fillForm();
            fillCBRegister();
        }

        private void btnDaftarMember_Click(object sender, EventArgs e)
        {
            if (checkCond_Register())
            {
                string gender = "";
                if (checkBoxMale.Checked) gender = "L";
                if (checkBox_Female.Checked) gender = "P";

                String membership_exp = "";
                if (cb_membership_register.SelectedIndex != -1)
                {
                    int month = Convert.ToInt32((cb_membership_register.SelectedItem as dynamic).Exp);
                    membership_exp = DateTime.Today.AddMonths(month).ToString("yyyy-MM-dd");
                }

                MySqlCommand cmdID = new MySqlCommand("select cast(id as unsigned)+1 from member order by cast(id as unsigned) desc limit 1", koneksi.getConn());

                koneksi.openConn();
                String newID = cmdID.ExecuteScalar().ToString();
                koneksi.closeConn();

                if (cb_membership_register.SelectedIndex == -1)
                {
                    try
                    {
                        MySqlCommand cmdInsert = new MySqlCommand("insert into member (id,name, username, password, gender, address,date_of_birth) values (@id,@name, @username, @password, @gender, @address, @date_of_birth);", koneksi.getConn());

                        cmdInsert.Parameters.AddWithValue("@id", newID);
                        cmdInsert.Parameters.AddWithValue("@name", TB_NAME.Text);
                        cmdInsert.Parameters.AddWithValue("@username", TB_USERNAME.Text);
                        cmdInsert.Parameters.AddWithValue("@password", TB_PASSWORD.Text);
                        cmdInsert.Parameters.AddWithValue("@gender", gender);
                        cmdInsert.Parameters.AddWithValue("@address", TB_ADDRESS.Text);
                        cmdInsert.Parameters.AddWithValue("@date_of_birth", dateTimePicker_DateOfBirth.Value.ToString("yyyy-MM-dd"));

                        koneksi.openConn();
                        cmdInsert.ExecuteNonQuery();
                        koneksi.closeConn();

                        clearRegister();
                        MessageBox.Show("Insert successful !");
                    }
                    catch (MySqlException ex)
                    {
                        clearRegister();
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        MySqlCommand cmdInsert = new MySqlCommand("insert into member (id,name, username, password, gender, address,date_of_birth, membership_id,membership_exp) values (@id,@name, @username, @password, @gender, @address, @date_of_birth, @membership_id, @membership_exp);", koneksi.getConn());

                        cmdInsert.Parameters.AddWithValue("@id", newID);
                        cmdInsert.Parameters.AddWithValue("@name", TB_NAME.Text);
                        cmdInsert.Parameters.AddWithValue("@username", TB_USERNAME.Text);
                        cmdInsert.Parameters.AddWithValue("@password", TB_PASSWORD.Text);
                        cmdInsert.Parameters.AddWithValue("@gender", gender);
                        cmdInsert.Parameters.AddWithValue("@address", TB_ADDRESS.Text);
                        cmdInsert.Parameters.AddWithValue("@date_of_birth", dateTimePicker_DateOfBirth.Value.ToString("yyyy-MM-dd"));
                        cmdInsert.Parameters.AddWithValue("@membership_id", (cb_membership_register.SelectedItem as dynamic).Value);
                        cmdInsert.Parameters.AddWithValue("@membership_exp", membership_exp);

                        koneksi.openConn();
                        cmdInsert.ExecuteNonQuery();
                        koneksi.closeConn();

                        clearRegister();
                        MessageBox.Show("Insert successful !");
                    }
                    catch (MySqlException ex)
                    {
                        clearRegister();
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void button_insertProduct_Click(object sender, EventArgs e)
        {
            if (cb_produk_restock.SelectedIndex == -1) MessageBox.Show("Pilih produk untuk restock terlebih dahulu !");
            else if (TB_QUANTITY.Text == "") MessageBox.Show("Isi jumlah restock produk terlebih dahulu !");
            else if (!TB_QUANTITY.Text.All(char.IsDigit)) MessageBox.Show("Jumlah restock produk harus berupa angka !");
            else
            {
                try
                {
                    MySqlCommand cmdInsert = new MySqlCommand("update format_product set stock=stock + @stock where id = @id;", koneksi.getConn());

                    cmdInsert.Parameters.AddWithValue("@id", (cb_produk_restock.SelectedItem as dynamic).Value);
                    cmdInsert.Parameters.AddWithValue("@stock", TB_QUANTITY.Text);

                    koneksi.openConn();
                    cmdInsert.ExecuteNonQuery();
                    koneksi.closeConn();

                    MessageBox.Show("Stok Berhasil Ditambahkan !");
                    fillCBRestock();
                    clearRestock();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    fillCBRestock();
                    clearRestock();
                }
            }
        }

        private void registerMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelRegister.Visible = true;
            panelRestock.Visible = false;
            panelMembership.Visible = false;
            panelOrder.Visible = false;

            fillCBRegister();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void restockProdukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelRegister.Visible = false;
            panelRestock.Visible = true;
            panelMembership.Visible = false;
            panelOrder.Visible = false;

            fillCBRestock();
        }

        private void membershipMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelRegister.Visible = false;
            panelRestock.Visible = false;
            panelMembership.Visible = true;
            panelOrder.Visible = false;

            fillDGMembership();
            fillCBMembership();
        }

        private void dg_membership_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                idUpdate = dg_membership.Rows[e.RowIndex].Cells[0].Value.ToString();

                tb_nama_update.Text = dg_membership.Rows[e.RowIndex].Cells[1].Value.ToString();

                cb_membership_update.Text = dg_membership.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btn_membership_Click(object sender, EventArgs e)
        {
            if (cb_membership_update.SelectedIndex == -1) MessageBox.Show("Pilih member dan membership untuk diupdate terlebih dahulu !");
            else
            {
                if (cb_membership_update.SelectedIndex ==0)
                {
                    try
                    {
                        MySqlCommand cmdUpdate = new MySqlCommand("update member set membership_id = null, membership_exp = null where id = @id", koneksi.getConn());
                        cmdUpdate.Parameters.AddWithValue("@id", idUpdate);

                        koneksi.openConn();
                        cmdUpdate.ExecuteNonQuery();
                        koneksi.closeConn();

                        tb_nama_update.Text = "";
                        cb_membership_update.SelectedIndex = -1;
                        MessageBox.Show("Update berhasil dilakukan !");
                        fillDGMembership();

                    } catch (MySqlException ex)
                    {
                        tb_nama_update.Text = "";
                        cb_membership_update.SelectedIndex = -1;
                        MessageBox.Show(ex.Message);
                    }
                } else
                {
                    String membership = (cb_membership_update.SelectedItem as dynamic).Value;
                    int month = Convert.ToInt32((cb_membership_update.SelectedItem as dynamic).Exp);
                    String exp = DateTime.Today.AddMonths(month).ToString("yyyy-MM-dd");

                    try
                    {
                        MySqlCommand cmdUpdate = new MySqlCommand("update member set membership_id = @membership, membership_exp = @exp where id = @id", koneksi.getConn());
                        cmdUpdate.Parameters.AddWithValue("@membership", membership);
                        cmdUpdate.Parameters.AddWithValue("@exp", exp);
                        cmdUpdate.Parameters.AddWithValue("@id", idUpdate);

                        koneksi.openConn();
                        cmdUpdate.ExecuteNonQuery();
                        koneksi.closeConn();

                        tb_nama_update.Text = "";
                        cb_membership_update.SelectedIndex = -1;
                        MessageBox.Show("Update berhasil dilakukan !");
                        fillDGMembership();

                    }
                    catch (MySqlException ex)
                    {
                        tb_nama_update.Text = "";
                        cb_membership_update.SelectedIndex = -1;
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void orderMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelRegister.Visible = false;
            panelRestock.Visible = false;
            panelMembership.Visible = false;
            panelOrder.Visible = true;

            fillDGOrder();
        }

        private void dg_order_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                tb_noteNumber_order.Text = dg_order.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void btn_deliver_order_Click(object sender, EventArgs e)
        {
            if (tb_noteNumber_order.Text == "") MessageBox.Show("Pilih order terlebih dahulu !");
            else
            {
                try
                {
                    MySqlCommand cmdUpdate = new MySqlCommand("update orders set status = 'DELIVERED', staff_id = @staff where note_number = @note;", koneksi.getConn());
                    cmdUpdate.Parameters.AddWithValue("@staff", staff_id);
                    cmdUpdate.Parameters.AddWithValue("@note", tb_noteNumber_order.Text);

                    koneksi.openConn();
                    cmdUpdate.ExecuteNonQuery();
                    koneksi.closeConn();

                    fillDGOrder();
                    tb_noteNumber_order.Text = "";
                    MessageBox.Show("Order delivered !");
                }
                catch (MySqlException ex)
                {
                    tb_noteNumber_order.Text = "";
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
