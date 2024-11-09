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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection _connection = new SqlConnection(@"Data Source=DESKTOP-2KELP5G;Initial Catalog=DbBankaTest;
User ID=sa;Password=123456;Encrypt=False");
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnKydet_Click(object sender, EventArgs e)
        {
            try
            {
                _connection.Open();
                SqlCommand cmd = new SqlCommand("insert into TBLKİSİLER (AD, SOYAD, TC, TELEFeON, HESAPNO, SİFRE) values (@p1, @p2, @p3, @p4, @p5, @p6)", _connection);
                cmd.Parameters.AddWithValue("@p1", txAd.Text);
                cmd.Parameters.AddWithValue("@p2", txSoyad.Text);
                cmd.Parameters.AddWithValue("@p3", mskTc.Text);
                cmd.Parameters.AddWithValue("@p4", mskTelefon.Text);
                cmd.Parameters.AddWithValue("@p5", mskHesap.Text);
                cmd.Parameters.AddWithValue("@p6", txSifre.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Müşteri Bilgileri Kaydedilmiştir.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        private void btnHesapGetir_Click(object sender, EventArgs e)
        {
            Random random = new Random();   
            int sayi = random.Next(100000,1000000);
            mskHesap.Text = sayi.ToString();
        }
    }
}
