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

namespace TestTrigger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection _connection = new SqlConnection(@"Data Source=DESKTOP-2KELP5G;
Initial Catalog=Test;User ID=sa;Password=123456;Encrypt=False");

        void listele()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from TBLKİTAPLAR",_connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        void sayac()
        {
            _connection.Open();
            SqlCommand cmd = new SqlCommand("Select * From TBLSAYAC",_connection);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                label8.Text=rdr[0].ToString();
            }
            _connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            sayac();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand cmd = new SqlCommand("Insert into TBLKİTAPLAR (AD,YAZAR,SAYFA,YAYINEVİ,TUR) Values (@p1,@p2,@p3,@p4,@p5)",_connection);
            cmd.Parameters.AddWithValue("@p1",txAd.Text);
            cmd.Parameters.AddWithValue("@p2",txYazar.Text);
            cmd.Parameters.AddWithValue("@p3",txSayfa.Text);
            cmd.Parameters.AddWithValue("@p4",txYayinEvi.Text);
            cmd.Parameters.AddWithValue("@p5",txTür.Text);
            cmd.ExecuteNonQuery();
            _connection.Close();
            MessageBox.Show("Kitap sisteme kaydedilmiştir.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
            sayac() ;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txSayfa.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txYayinEvi.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txTür.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand cmd = new SqlCommand("delete from TBLKİTAPLAR where ID=@p1",_connection);
            cmd.Parameters.AddWithValue("@p1",txId.Text);   
            cmd.ExecuteNonQuery();
            _connection.Close();
            MessageBox.Show("Kitap Sistemden Silindi.");
            listele();
            sayac();
        }
    }
}
