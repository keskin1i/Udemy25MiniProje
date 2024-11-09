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

namespace BankaTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection _connection = new SqlConnection(@"Data Source=DESKTOP-2KELP5G;Initial Catalog=DbBankaTest;
User ID=sa;Password=123456;Encrypt=False");

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand cmd = new SqlCommand("Select * From TBLKİSİLER where HESAPNO=@p1 and SİFRE=@p2",_connection);
            cmd.Parameters.AddWithValue("@p1",mskHesapNo.Text);
            cmd.Parameters.AddWithValue("@p2",txSifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Form2 form2 = new Form2();
                form2.hesap = mskHesapNo.Text;
                form2.Show();
            }
            else 
            {
                MessageBox.Show("Bilgilerinizi Tekrar giriniz.");
            }
           
            _connection.Close();

        }
    }
}
