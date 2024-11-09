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

namespace SifreliVeriler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection _connection = new SqlConnection(@"Data Source=DESKTOP-2KELP5G;Initial Catalog=Test;User ID=sa;Password=123456;Encrypt=False");
        private void button1_Click(object sender, EventArgs e)
        {
            string ad = txAd.Text;
            byte[] adDizi = ASCIIEncoding.ASCII.GetBytes(ad);
            string adSifre = Convert.ToBase64String(adDizi);
            
            string soyad = txSoyad.Text; 
            byte[] soyadDizi = Encoding.ASCII.GetBytes(soyad);
            string soyadSifre = Convert.ToBase64String(soyadDizi);

            string mail = txMail.Text;
            byte[] mailDizi = Encoding.ASCII.GetBytes(mail);
            string mailSifre = Convert.ToBase64String(mailDizi);

            string sifre = txSifre.Text;
            byte[] sifreDizi = Encoding.ASCII.GetBytes(sifre);
            string sSifre = Convert.ToBase64String(sifreDizi);

            string hesapNo = txHesapNo.Text;
            byte[] hesapNoDizi = Encoding.ASCII.GetBytes(hesapNo);
            string hesapNoSifre = Convert.ToBase64String(hesapNoDizi);

            

            _connection.Open();
            SqlCommand sql = new SqlCommand("INSERT INTO TBLVERILER (AD,SOYAD,MAIL,SIFRESI,HESAPNO) VALUES (@P1,@P2,@P3,@P4,@P5)",_connection);
            sql.Parameters.AddWithValue("@P1",adSifre);
            sql.Parameters.AddWithValue("@P2", soyadSifre);
            sql.Parameters.AddWithValue("@P3",mailSifre);
            sql.Parameters.AddWithValue("@P4",sSifre);
            sql.Parameters.AddWithValue("@P5", hesapNoSifre);
            sql.ExecuteNonQuery();
           
            _connection.Close();
            MessageBox.Show("Veriler eklendi");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from TBLVERILER", _connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string adCozum = txAd.Text;
            byte[] adcozumdizi = Convert.FromBase64String(adCozum);
            string adverisi = ASCIIEncoding.ASCII.GetString(adcozumdizi);
            label6.Text = adverisi;


        }
    }
}
