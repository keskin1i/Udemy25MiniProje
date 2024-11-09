using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesajTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection _connection = new SqlConnection(@"Data Source=DESKTOP-2KELP5G;Initial Catalog=Test;User ID=sa;Password=123456;Encrypt=False");

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from TBLKISILER WHERE NUMARA=@P1 AND SIFRE=@P2", _connection);
            cmd.Parameters.AddWithValue("@P1", mskNumara.Text);
            cmd.Parameters.AddWithValue("@P2", txSıfre.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Form2 frm = new Form2();
                frm.numara = mskNumara.Text;
                
                frm.Show();
                
            }
            else
            {
                MessageBox.Show("Hatalı Bilgi");
            }
            _connection.Close();
        }
    }
}
