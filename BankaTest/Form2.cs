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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string hesap;
        SqlConnection _connection = new SqlConnection(@"Data Source=DESKTOP-2KELP5G;Initial Catalog=DbBankaTest;
User ID=sa;Password=123456;Encrypt=False");
        private void Form2_Load(object sender, EventArgs e)
        {
            _connection.Open();
            lblHesap.Text = hesap;
            SqlCommand cmd = new SqlCommand("Select * from TBLKİSİLER where HESAPNO=@p1",_connection);
            cmd.Parameters.AddWithValue("@p1",hesap);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                lblAdSoyad.Text = dr[1] + " " + dr[2];
                lblTc.Text = dr[3].ToString();
                lblTelefon.Text = dr[4].ToString();
                
            }
            _connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Gönderilen Hesabın Para Artışı
            _connection.Open();
            SqlCommand cmd = new SqlCommand("Update TBLHESAP set BAKİYE=BAKİYE+@p1 where HESAPNO=@p2",_connection);
            cmd.Parameters.AddWithValue("@p1",decimal.Parse( txSifre.Text));
            cmd.Parameters.AddWithValue("@p2",mskHesapNo.Text);
            cmd.ExecuteNonQuery();
            _connection.Close();
            

            //Gönderen Hesabın Para Azalışı
            _connection.Open();
            SqlCommand cmd1 = new SqlCommand("Update TBLHESAP set BAKİYE=BAKİYE-@p1 where HESAPNO=@p2",_connection);
            cmd1.Parameters.AddWithValue("@p1",decimal.Parse( txSifre.Text));
            cmd1.Parameters.AddWithValue("@p2",hesap);
            cmd1.ExecuteNonQuery();
            _connection.Close();

            MessageBox.Show("İşleminiz Gerçekleşti.");

        }
    }
}
