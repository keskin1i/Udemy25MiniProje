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

namespace MesajTest
{
    public partial class Form2 : Form
    {
        public string numara;
        public string adSoyad;

        
        public Form2()
        {
            
            InitializeComponent();
            
        }
        SqlConnection _connection = new SqlConnection(@"Data Source=DESKTOP-2KELP5G;Initial Catalog=Test;User ID=sa;Password=123456;Encrypt=False");
      
        void gelenKutusu()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from TBLMESAJLAR WHERE ALICI="+numara,_connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;   

            
        }
        void gidenKutusu()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from TBLMESAJLAR WHERE GONDEREN=" + numara, _connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;


        }



        private void Form2_Load(object sender, EventArgs e)
        {
            lblNumara.Text = numara;

            gelenKutusu();
            gidenKutusu();

            //Ad soyad çekme

            _connection.Open();
            SqlCommand cmd = new SqlCommand("select Ad,Soyad from TBLKISILER WHERE numara="+numara,_connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) 
            {
                lblAdSoyad.Text = reader[0] + " " + reader[1];
            }
            _connection.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO TBLMESAJLAR (GONDEREN,ALICI,BASLIK,ICERIK) VALUES (@P1,@P2,@P3,@P4)",_connection);
            sqlCommand.Parameters.AddWithValue("@P1",numara);
            sqlCommand.Parameters.AddWithValue("@P2",mskAlici.Text);
            sqlCommand.Parameters.AddWithValue("@P3", txBaslik.Text);
            sqlCommand.Parameters.AddWithValue("@P4",richTextBox1.Text);
            sqlCommand.ExecuteNonQuery();
            _connection.Close();
            MessageBox.Show("Mesaj verileri kaydedildi.");
          
            gidenKutusu();

            txBaslik.Text = "";
            mskAlici.Text = "";
            richTextBox1.Text = "";



        }
    }
}
