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
    public partial class FormDetailOrder : Form
    {
        String noteNumber;
        public FormDetailOrder()
        {
            InitializeComponent();
        }

        public FormDetailOrder(String note)
        {
            noteNumber = note;

            InitializeComponent();

            label1.Text = "Order Detail " + noteNumber;

            fillDGOrder();
            setLabels();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillDGOrder()
        {
            dataGridView1.DataSource = null;

            if (koneksi.getConn().State == ConnectionState.Open)
            {
                koneksi.closeConn();
            }

            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT p.`NAME` AS 'Product', f.`NAME` AS 'Format', od.`QUANTITY` AS 'Quantity', fp.`PRICE` AS 'Price', od.`SUBTOTAL` AS 'Subtotal' FROM orders o JOIN orderdetails od ON o.`NOTE_NUMBER`=od.`NOTE_NUMBER` JOIN format_product fp ON fp.`ID` = od.`PRODUCT_ID` JOIN product p ON fp.`PRODUCT_ID`=p.`ID` JOIN FORMAT f ON f.`ID` = fp.`FORMAT_ID` where o.note_number=@note;", koneksi.getConn());
            cmd.Parameters.AddWithValue("@note", noteNumber);
            MySqlDataAdapter da = new MySqlDataAdapter();

            koneksi.openConn();
            cmd.ExecuteReader();
            koneksi.closeConn();

            da.SelectCommand = cmd;
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void setLabels()
        {
            MySqlCommand cmdSubtotal = new MySqlCommand("select sum(subtotal) from orderdetails where note_number=@note group by note_number", koneksi.getConn());
            cmdSubtotal.Parameters.AddWithValue("@note", noteNumber);

            koneksi.openConn();
            label2.Text = "Subtotal : " + cmdSubtotal.ExecuteScalar().ToString();
            koneksi.closeConn();

            MySqlCommand cmdTotal = new MySqlCommand("select total from orders where note_number = @note", koneksi.getConn());
            cmdTotal.Parameters.AddWithValue("@note", noteNumber);

            koneksi.openConn();
            label4.Text = "Total : " + cmdTotal.ExecuteScalar().ToString();
            koneksi.closeConn();

            MySqlCommand cmdDiscount = new MySqlCommand("SELECT (SUM(od.`SUBTOTAL`)-o.`TOTAL`) FROM orders o, orderdetails od WHERE od.`NOTE_NUMBER` = o.`NOTE_NUMBER` and o.note_number=@note GROUP BY od.`NOTE_NUMBER`;", koneksi.getConn());
            cmdDiscount.Parameters.AddWithValue("@note", noteNumber);

            MySqlCommand cmdPercentage = new MySqlCommand("SELECT ROUND((SUM(od.`SUBTOTAL`)-o.`TOTAL`)/SUM(od.`SUBTOTAL`)*100) FROM orders o, orderdetails od WHERE od.`NOTE_NUMBER` = o.`NOTE_NUMBER` and o.note_number=@note GROUP BY od.`NOTE_NUMBER`;", koneksi.getConn());
            cmdPercentage.Parameters.AddWithValue("@note", noteNumber);

            MySqlCommand cmdMembeship = new MySqlCommand("select name from membership where discount=@discount", koneksi.getConn());

            koneksi.openConn();
            String discount = cmdDiscount.ExecuteScalar().ToString();
            String percent = cmdPercentage.ExecuteScalar().ToString();
            String membership = "-";

            if (percent!="0")
            {
                cmdMembeship.Parameters.AddWithValue("@discount", percent);

                membership = cmdMembeship.ExecuteScalar().ToString();
            }

            koneksi.closeConn();

            label3.Text = "Diskon : " + discount + " - " + percent + "%";

            if (membership == "-") label3.Text = label3.Text + " - No Membership";
            else label3.Text = label3.Text + " - " + membership;

        }
    }
}
