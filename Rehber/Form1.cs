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

namespace Rehber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection _connection = new SqlConnection(@"Data Source=DESKTOP-2KELP5G;Initial Catalog=REHBER;User ID=sa;Password=123456;Encrypt=False");

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From KISILER",_connection);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        void temizle()
        {
            txAd.Text = "";
            txMail.Text = "";
            txSoyad.Text = "";
            tXId.Text = "";
            mskTelefon.Text = "";
            txAd.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO KISILER (AD,SOYAD,TELEFON,MAIL) VALUES (@P1,@P2,@P3,@P4)",_connection);
            cmd.Parameters.AddWithValue("@P1",txAd.Text);
            cmd.Parameters.AddWithValue("@P2",txSoyad.Text);
            cmd.Parameters.AddWithValue("@P3", mskTelefon.Text);
            cmd.Parameters.AddWithValue("@P4",txMail.Text);
            cmd.ExecuteNonQuery();
            _connection.Close();
            MessageBox.Show("Veri Kayıt İşlemi Gerçekleşti");
            listele();
            temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            tXId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txSoyad.Text = dataGridView1.Rows[secilen ].Cells[2].Value.ToString();  
            mskTelefon.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txMail.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM KISILER WHERE ID="+tXId.Text,_connection);
            cmd.ExecuteNonQuery();
            _connection.Close();
            MessageBox.Show("Kişi Rehberden Silindi.");
            listele();
            temizle();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand cmd = new SqlCommand("UPDATE KISILER SET AD=@P1,SOYAD=@P2,TELEFON=@P3,MAIL=@P4 WHERE ID=@P5 ",_connection);
            cmd.Parameters.AddWithValue("@P1",txAd.Text);
            cmd.Parameters.AddWithValue("@P2",txSoyad.Text);
            cmd.Parameters.AddWithValue("@P3",mskTelefon.Text);
            cmd.Parameters.AddWithValue("@P4",txMail.Text);
            cmd.Parameters.AddWithValue("@P5",tXId.Text);
            cmd.ExecuteNonQuery();
            _connection.Close();
            MessageBox.Show("Veriler güncellendi.");
            listele();
            temizle();

        }
    }
}
