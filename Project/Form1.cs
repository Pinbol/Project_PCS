using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class Form1 : Form
    {  
        Form2 frm2;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if(tbUsername.Text == "Admin" && tbPassword.Text == "Admin")
            {
                frm2 = new Form2();
                this.Hide();
                frm2.ShowDialog();
                this.Show();

                tbUsername.Clear();
                tbPassword.Clear();
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT CASE WHEN @username IN (SELECT username FROM staff) THEN 1 WHEN @username IN(SELECT username FROM member) THEN 2 ELSE 3 END; ";

                cmd.Parameters.AddWithValue("@username", tbUsername.Text);
                cmd.Connection = koneksi.getConn();

                koneksi.openConn();
                string type = cmd.ExecuteScalar().ToString();
                koneksi.closeConn();

                if (type.Equals("1"))
                {
                    cmd = new MySqlCommand();
                    cmd.CommandText = "SELECT PASSWORD FROM staff WHERE username = @username; ";

                    cmd.Parameters.AddWithValue("@username", tbUsername.Text);
                    cmd.Connection = koneksi.getConn();

                    koneksi.openConn();
                    string password = cmd.ExecuteScalar().ToString();
                    koneksi.closeConn();

                    if (password.Equals(tbPassword.Text))
                    {
                        this.Hide();
                        using (FormStaff form = new FormStaff())
                        {
                            form.ShowDialog();
                        }
                        this.Show();

                        tbUsername.Text = "";
                        tbPassword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password");
                    }
                }
                else if (type.Equals("2"))
                {
                    cmd = new MySqlCommand();
                    cmd.CommandText = "SELECT PASSWORD FROM member WHERE username = @username; ";

                    cmd.Parameters.AddWithValue("@username", tbUsername.Text);
                    cmd.Connection = koneksi.getConn();

                    koneksi.openConn();
                    string password = cmd.ExecuteScalar().ToString();
                    koneksi.closeConn();

                    if (password.Equals(tbPassword.Text))
                    {
                        this.Hide();
                        using (FormMember form = new FormMember(tbUsername.Text))
                        {
                            form.ShowDialog();
                        }
                        this.Show();

                        tbUsername.Text = "";
                        tbPassword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password");
                    }
                }
                else if (type.Equals("3"))
                {
                    MessageBox.Show("Username Not Found");
                }
            }
        }

        private void tbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) tbPassword.Focus();
        }
    }
}
