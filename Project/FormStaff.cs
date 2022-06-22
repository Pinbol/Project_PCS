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
        public FormStaff()
        {
            InitializeComponent();
        }

        private void FormStaff_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDaftarMember_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (checkBoxMale.Checked) gender = "L";
            if (checkBox_Female.Checked) gender = "P";
            koneksi.openConn();
            try
            {
                MySqlCommand cmdInsert = new MySqlCommand("insert into member (id,name, username, password, gender, address,date_of_birth, membership_id,membership_exp) values (@id,@name, @username, @password, @gender, @address, @date_of_birth, @membership_id, @membership_exp);", koneksi.getConn());

                cmdInsert.Parameters.AddWithValue("@id", TB_ID.Text);
                cmdInsert.Parameters.AddWithValue("@name", TB_NAME.Text);
                cmdInsert.Parameters.AddWithValue("@username", TB_USERNAME.Text);
                cmdInsert.Parameters.AddWithValue("@password", TB_PASSWORD.Text);
                cmdInsert.Parameters.AddWithValue("@gender", gender);
                cmdInsert.Parameters.AddWithValue("@address", TB_ADDRESS.Text);
                cmdInsert.Parameters.AddWithValue("@date_of_birth", dateTimePicker_DateOfBirth.Value.ToString("yyyy-MM-dd"));
                cmdInsert.Parameters.AddWithValue("@membership_id", TB_MEMBERSHIP_ID.Text);
                cmdInsert.Parameters.AddWithValue("@date_of_exp", dateTimePicker_MembershippEXP.Value.ToString("yyyy-MM-dd"));

                cmdInsert.ExecuteNonQuery();
                koneksi.closeConn();
                MessageBox.Show("Insert successful !");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        
        
        }

        private void button_insertProduct_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmdInsert = new MySqlCommand("update format_product set stock=stock + @stock where id = @id;", koneksi.getConn());

                cmdInsert.Parameters.AddWithValue("@id", textBox_ID_RESTOK_PRODUK.Text);
                cmdInsert.Parameters.AddWithValue("@stock", TB_QUANTITY.Text);

                koneksi.openConn();
                cmdInsert.ExecuteNonQuery();
                koneksi.closeConn();
                MessageBox.Show("Stok Berhasil Ditambahkan !");
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
