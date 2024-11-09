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
    public partial class FrmMusteri : Form
    {
        public FrmMusteri()
        {
            InitializeComponent();
        }

        SqlConnection _connection = new SqlConnection(@"Data Source=DESKTOP-2KELP5G;Initial Catalog=SatisVT;User ID=sa;Password=123456;Encrypt=False");
        private void button3_Click(object sender, EventArgs e)
        {
            Listele();

        }

        private void Listele()
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from TBLMUSTERI", _connection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmMusteri_Load(object sender, EventArgs e)
        {
            Listele();

            _connection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * from iller",_connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["sehir"]);
            }
            _connection.Close();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO TBLMUSTERI (MUSTERIAD,MUSTERISOYAD,MUSTERISEHIR,MUSTERIBAKIYE) VALUES (@P1,@P2,@P3,@P4)",_connection);
            command.Parameters.AddWithValue("@P1",textBox2.Text);
            command.Parameters.AddWithValue("@P2",textBox3.Text);
            command.Parameters.AddWithValue("@P3",comboBox1.Text);
            command.Parameters.AddWithValue("@P4",textBox4.Text);
            command.ExecuteNonQuery();
            _connection.Close();
            Listele();
            MessageBox.Show("Musterı kaydedildi.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand command = new SqlCommand("Delete from TBLMUSTERI where MUSTERIID=@P1",_connection);
            command.Parameters.AddWithValue("@P1",textBox1.Text);
            command.ExecuteNonQuery ();
            _connection.Close();
            Listele();
            MessageBox.Show("Müsteri bilgileri silindi.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand command = new SqlCommand("UPDATE TBLMUSTERI set MUSTERIAD=@P1,MUSTERISOYAD=@P2,MUSTERISEHIR=@P3,MUSTERIBAKIYE=@P4 WHERE MUSTERIID=@P5 ", _connection);
            command.Parameters.AddWithValue("@P5", textBox1.Text);
            command.Parameters.AddWithValue("@P1", textBox2.Text);
            command.Parameters.AddWithValue("@P2", textBox3.Text);
            command.Parameters.AddWithValue("@P3", (comboBox1.Text).ToUpper());
            command.Parameters.AddWithValue("@P4",decimal.Parse( textBox4.Text));
            command.ExecuteNonQuery();
            _connection.Close();
            Listele();
            MessageBox.Show("Müsteri bilgileri Güncellendi.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from TBLMUSTERI WHERE MUSTERIAD = @P1",_connection);
            command.Parameters.AddWithValue("@P1",textBox2.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource= dt;
        }
    }
}
