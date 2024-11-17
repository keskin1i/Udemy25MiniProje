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

namespace TestSeferSeyahat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection _connection = new SqlConnection(@"Data Source=DESKTOP-2KELP5G;Initial Catalog=TestYolcuBilet;User ID=sa;Password=123456;Encrypt=False");

        void SeferListesi()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from TblSeferbilgi",_connection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand cmd = new SqlCommand("insert into TBLYOLCUBİLGİ (AD,SOYAD,TELEFON,TC,CINSIYET,MAIL) values (@p1,@p2,@p3,@p4,@p5,@p6)",_connection);
            cmd.Parameters.AddWithValue("@p1",txAd.Text);
            cmd.Parameters.AddWithValue("@p2", txSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", msktxTelefon.Text);
            cmd.Parameters.AddWithValue("@p4", msktxTc.Text);
            cmd.Parameters.AddWithValue("@p5", cmbCinsiyet.Text == "ERKEK" ? 1 : 0);
            cmd.Parameters.AddWithValue("@p6", msktxMail.Text);
            cmd.ExecuteNonQuery();
            _connection.Close();
            MessageBox.Show("Kişi sisteme kaydedildi.");

            txAd.Text = "";
            txSoyad.Text = "";
            msktxTelefon.Text = "";
            msktxTc.Text = "";
            cmbCinsiyet.Text = "";
            msktxMail.Text = "";
            SeferListesi();

        }

        private void btnKaptan_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand cmd = new SqlCommand("insert into TBLKAPTAN (KAPTANNO,ADSOYAD,TELEFON) values (@p1,@p2,@p3)",_connection);
            cmd.Parameters.AddWithValue("@p1", txKaptanNo.Text);
            cmd.Parameters.AddWithValue("@p2", txAdSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", mskKaptanTel.Text);
            cmd.ExecuteNonQuery();
            _connection.Close();
            MessageBox.Show("Kaptan biilgileri kaydedilmiştir.");

            txKaptanNo.Text = "";
            txAdSoyad.Text = "";
            mskKaptanTel.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand cmd = new SqlCommand("insert into TBLSEFERBİLGİ (KALKIS,VARIS,TARIH,SAAT,KAPTAN,FIYAT) values (@p1,@p2,@p3,@p4,@p5,@p6)", _connection);
            cmd.Parameters.AddWithValue("@p1", txFiyat.Text);
            cmd.Parameters.AddWithValue("@p2", txKalkis.Text);
            cmd.Parameters.AddWithValue("@p3", txVaris.Text);
            cmd.Parameters.AddWithValue("@p4", mskTarih.Text);
            cmd.Parameters.AddWithValue("@p5", mskSaat.Text);
            cmd.Parameters.AddWithValue("@p6", mskKaptan.Text);
           
            cmd.ExecuteNonQuery();
            _connection.Close();
            MessageBox.Show("Sefer bilgileri kaydedilmiştir.","Bilgi",MessageBoxButtons.OK);

            txFiyat.Text = "";
            txKalkis.Text = "";
            txVaris.Text = "";
            mskTarih.Text = "";
            mskSaat.Text = "";
            mskKaptan.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SeferListesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            textBox4.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
           
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txKoltukNo.Text = "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txKoltukNo.Text = "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txKoltukNo.Text = "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txKoltukNo.Text = "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txKoltukNo.Text = "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txKoltukNo.Text = "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txKoltukNo.Text = "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txKoltukNo.Text = "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txKoltukNo.Text = "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txKoltukNo.Text = "9";
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand cmd = new SqlCommand("insert into TBLSEFERDETAY (SEFERNO,YOLCUTC,KOLTUK) values (@p1,@p2,@p3)",_connection);
            cmd.Parameters.AddWithValue("@p1",textBox4.Text);
            cmd.Parameters.AddWithValue("@p2", MSKtC.Text);
            cmd.Parameters.AddWithValue("@p3",txKoltukNo.Text);

            cmd.ExecuteNonQuery();
            _connection.Close();
            MessageBox.Show("sefer dtayları kaydedilmiştir.");
        }
    }
}
