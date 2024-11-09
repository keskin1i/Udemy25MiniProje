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

namespace EtütTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        SqlConnection _connection = new SqlConnection(@"Data Source=DESKTOP-2KELP5G;
Initial Catalog=EtütTest;User ID=sa;Password=123456;Encrypt=False");

        void DersListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLDERSLER",_connection);  
            DataTable dt = new DataTable(); 
            da.Fill(dt);
            cmbDers.ValueMember = "DERSID"; 
            cmbDers.DisplayMember = "DERSAD";
            cmbDers.DataSource = dt;
        }
        //etüt listesi
        void EtutListesi()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("execute Etut",_connection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            EtutListesi();
            DersListesi();
        }

        private void cmbDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // burada sadece ad bilgisini çekiyoruz.

            //    SqlDataAdapter d = new SqlDataAdapter("Select * from TBLOGRETMEN where BRANS="
            //        +cmbDers.SelectedValue,_connection);
            //    DataTable dataTable = new DataTable();  
            //    d.Fill(dataTable);
            //    cmbOgretmen.ValueMember = "OGRTID";
            //    cmbOgretmen.DisplayMember = "AD";
            //    cmbOgretmen.DataSource = dataTable;

            //---------------------------------------------------------------------

            //burada hem ad hemde soyadı bilgisini çekiyoruz.

            SqlDataAdapter d = new SqlDataAdapter(
       "SELECT OGRTID, AD + ' ' + SOYAD AS FullName FROM TBLOGRETMEN WHERE BRANS="+ cmbDers.SelectedValue,
       _connection);

            DataTable dataTable = new DataTable();
            d.Fill(dataTable);
            cmbOgretmen.ValueMember = "OGRTID";
            cmbOgretmen.DisplayMember = "FullName";
            cmbOgretmen.DataSource = dataTable;
        }

        private void btnEtüt_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand cmd = new SqlCommand("Insert into TBLETUT(DERSID,OGRETMENID,TARİH,SAAT) VALUES (@P1,@P2,@P3,@P4)",_connection);
            cmd.Parameters.AddWithValue("@P1",cmbDers.SelectedValue);
            cmd.Parameters.AddWithValue("@P2",cmbOgretmen.SelectedValue);
            cmd.Parameters.AddWithValue("@P3",mskTarih.Text);
            cmd.Parameters.AddWithValue("@P4",mskSaat.Text);
            cmd.ExecuteNonQuery();
            _connection.Close();
            MessageBox.Show("Bilgiler Sisteme Kaydedilmiştir.");
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textEdit2.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

        }

        private void btnEtutVer_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand cmd = new SqlCommand("Update TBLETUT set OGRENCİID=@P1,DURUM=@P2 WHERE ID=@P3",_connection);
            cmd.Parameters.AddWithValue("@P1", textEdit1.Text);
            cmd.Parameters.AddWithValue("@p2","True");
            cmd.Parameters.AddWithValue("@P3",textEdit2.Text);
            cmd.ExecuteNonQuery();
            _connection.Close();

            MessageBox.Show("Etut Öğrenciye verildi");
        }
    }
}
