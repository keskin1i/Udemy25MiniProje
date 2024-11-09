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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection _connection = new SqlConnection(@"Data Source=DESKTOP-2KELP5G;Initial Catalog=SatisVT;User ID=sa;Password=123456;Encrypt=False");

        private void Form1_Load(object sender, EventArgs e)
        {
            //Ürünlerin durum seviyesi
            SqlCommand command = new SqlCommand("Execute Test4",_connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            //Grafiğe veri çekme işlemi
            _connection.Open();

            SqlCommand cmd = new SqlCommand(
                "Select KATEGORIAD , count(*) FROM TBLKATEGORI INNER JOIN TBLURUNLER ON TBLKATEGORI.KATEGORIID = TBLURUNLER.KATEGORI GROUP BY KATEGORIAD",_connection);
           
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                chart1.Series["Kategoriler"].Points.AddXY(reader[0], reader[1]);
            }
            _connection.Close();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmUrunler frmUrunler = new FrmUrunler();
            frmUrunler.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMusteri frmMusteri = new FrmMusteri();
            frmMusteri.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
