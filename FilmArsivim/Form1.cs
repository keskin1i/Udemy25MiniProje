using Proje6;
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

namespace FilmArsivim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection _connection = new SqlConnection(@"Data Source=DESKTOP-2KELP5G;Initial Catalog=FilmArsivim;User ID=sa;Password=123456;Encrypt=False");

        void Filmler()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select AD,LINK From TBLFILMLER",_connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Filmler();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO TBLFILMLER (AD,KATEGORI,LINK) values (@P1,@P2,@P3)", _connection);
            sqlCommand.Parameters.AddWithValue("@P1", txFilmAd.Text);
            sqlCommand.Parameters.AddWithValue("@P2",txKategori.Text);
            sqlCommand.Parameters.AddWithValue("@P3",txLink.Text);
            sqlCommand.ExecuteNonQuery();
            _connection.Close();
            Filmler();
            MessageBox.Show("Film listenize eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            webBrowser1.Navigate(link);
        }

        private void btnTamEkran_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Şuanda çalışmaktadır.");
            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRenkDegis_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            FrmSatis frm = new FrmSatis();
            frm.Show();
        }
    }
}
