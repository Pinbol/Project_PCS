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
    public partial class FormGantiPassword : Form
    {
        public String idMember;

        public FormGantiPassword()
        {
            InitializeComponent();
        }

        public FormGantiPassword(String id)
        {
            InitializeComponent();

            idMember = id;
        }

        private void FormGantiPassword_Load(object sender, EventArgs e)
        {

        }

        private void btn_gantiPassword_Click(object sender, EventArgs e)
        {
            if (tb_passwordLama.Text == "") MessageBox.Show("Password lama harus diisi !");
            else if (tb_passwordBaru.Text == "") MessageBox.Show("Password baru harus diisi !");
            else if (tb_passwordBaru.Text == tb_passwordLama.Text) MessageBox.Show("Password lama dan baru tidak boleh sama !");
            else
            {
                MySqlCommand cmdPassword = new MySqlCommand("select count(*) from member where id = @id and password=@password", koneksi.getConn());
                cmdPassword.Parameters.AddWithValue("@id", idMember);
                cmdPassword.Parameters.AddWithValue("@password", tb_passwordLama.Text);

                koneksi.openConn();
                int count = Convert.ToInt32(cmdPassword.ExecuteScalar().ToString());
                koneksi.closeConn();

                if (count == 0) MessageBox.Show("Password lama salah !");
                else
                {
                    try
                    {
                        MySqlCommand cmdUpdate = new MySqlCommand("update member set password = @password where id = @id", koneksi.getConn());
                        cmdUpdate.Parameters.AddWithValue("@password", tb_passwordBaru.Text);
                        cmdUpdate.Parameters.AddWithValue("@id", idMember);

                        koneksi.openConn();
                        cmdUpdate.ExecuteNonQuery();
                        koneksi.closeConn();

                        MessageBox.Show("Update password berhasil !");
                        this.Close();
                    } catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
