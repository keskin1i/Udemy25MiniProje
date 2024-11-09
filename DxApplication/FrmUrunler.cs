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

namespace DxApplication
{
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }

        SqlConnection _connection = new SqlConnection(@"Data Source=DESKTOP-2KELP5G;Initial Catalog=SatisVT;User ID=sa;Password=123456;Encrypt=False");
        private void button3_Click(object sender, EventArgs e)
        {
            //_connection.Open();
            //SqlDataAdapter adapter = new SqlDataAdapter("select * from TBLKATEGORI",_connection);  
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //dataGridView1.DataSource = dt;
            //_connection.Close();

            SqlCommand sqlCommand = new SqlCommand("select * from TBLKATEGORI",_connection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);  
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO TBLKATEGORI (KATEGORIAD) VALUES (@P1)",_connection);
            sqlCommand.Parameters.AddWithValue("@P1",textBox2.Text);
            sqlCommand.ExecuteNonQuery();
            _connection.Close();
            MessageBox.Show("Kategori kaydedildi.");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM TBLKATEGORI WHERE KATEGORIID=@p1",_connection);
            sqlCommand.Parameters.AddWithValue("@p1",textBox1.Text);
            sqlCommand.ExecuteNonQuery();
            _connection.Close();
            MessageBox.Show("Kategori silindi.");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand sqlCommand = new SqlCommand("UPDATE TBLKATEGORI set KATEGORIAD=@P1 WHERE KATEGORIID=@P2", _connection);
            sqlCommand.Parameters.AddWithValue("@P2", textBox1.Text);
            sqlCommand.Parameters.AddWithValue("@P1",textBox2.Text);
            sqlCommand.ExecuteNonQuery();
            _connection.Close();
            MessageBox.Show("Kategori Güncellendi.");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

        }
    }
}
