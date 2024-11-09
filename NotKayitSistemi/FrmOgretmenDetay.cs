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

namespace NotKayitSistemi
{
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }
        SqlConnection _connection = new SqlConnection(@"Data Source=DESKTOP-2KELP5G;Initial Catalog=DbNotKayıt;User ID=sa;Password=123456;Encrypt=False");
       
        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            DurumGuncel();
            this.tBLDERSTableAdapter.Fill(this.dbNotKayıtDataSet.TBLDERS);

        }

      
        private void btnOgrenciKaydet_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand sqlCommand = new SqlCommand("Insert Into TBLDERS (OGRNUMARA,OGRAD,OGRSOYAD) Values (@p1,@p2,@p3)",_connection);
            sqlCommand.Parameters.AddWithValue("@p1",mskNumara.Text);   
            sqlCommand.Parameters.AddWithValue("@p2",txAd.Text);
            sqlCommand.Parameters.AddWithValue("@p3",txSoyad.Text);
            sqlCommand.ExecuteNonQuery();
            _connection.Close();
            MessageBox.Show("Öğrenci sisteme eklendi.");
            this.tBLDERSTableAdapter.Fill(this.dbNotKayıtDataSet.TBLDERS);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            string durum;
            int gecen = 0, kalan = 0;

            s1 = Convert.ToDouble(txSinav1.Text);
            s2 = Convert.ToDouble(txSinav2.Text);
            s3 = Convert.ToDouble(txSinav3.Text);

            ortalama = (s1 + s2 + s3) / 3;
            lblOrtalama.Text = ortalama.ToString();

            if (ortalama >= 50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }


            _connection.Open();
            SqlCommand sqlCommand = new SqlCommand("Update TBLDERS set  OGRS1=@p1,OGRS2=@p2,OGRS3=@p3,ORTALAMA=@p4,DURUM=@p5 WHERE OGRNUMARA=@p6", _connection);
            sqlCommand.Parameters.AddWithValue("@p1", txSinav1.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txSinav2.Text);
            sqlCommand.Parameters.AddWithValue("@p3", txSinav3.Text);
            sqlCommand.Parameters.AddWithValue("@p4", decimal.Parse( lblOrtalama.Text));
            sqlCommand.Parameters.AddWithValue("@p5", durum);
            sqlCommand.Parameters.AddWithValue("@p6", mskNumara.Text);
            sqlCommand.ExecuteNonQuery();
            _connection.Close();
            MessageBox.Show("Öğrenci Notları sisteme eklendi.");
           
           
            this.tBLDERSTableAdapter.Fill(this.dbNotKayıtDataSet.TBLDERS);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            mskNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txSinav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txSinav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txSinav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

            this.tBLDERSTableAdapter.Fill(this.dbNotKayıtDataSet.TBLDERS);
        }

        private void DurumGuncel()
        {
            try
            {
                _connection.Open();

                // Geçen öğrenci sayısını (True durumunda olanlar) al
                SqlCommand gecenCmd = new SqlCommand("SELECT COUNT(*) FROM TBLDERS WHERE Durum = 'True'", _connection);
                int gecenSayisi = (int)gecenCmd.ExecuteScalar();

                // Kalan öğrenci sayısını (False durumunda olanlar) al
                SqlCommand kalanCmd = new SqlCommand("SELECT COUNT(*) FROM TBLDERS WHERE Durum = 'False'", _connection);
                int kalanSayisi = (int)kalanCmd.ExecuteScalar();

                // Geçen ve kalan sayısını label'lara yazdır
                lblGecenSayisi.Text = gecenSayisi.ToString();
                lblKalanSayisi.Text = kalanSayisi.ToString();
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


    }
}
