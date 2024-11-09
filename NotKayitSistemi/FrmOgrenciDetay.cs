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
    public partial class FrmOgrenciDetay : Form
    {
        public FrmOgrenciDetay()
        {
            InitializeComponent();
        }

        SqlConnection _connection = new SqlConnection(@"Data Source=DESKTOP-2KELP5G;Initial Catalog=DbNotKayıt;User ID=sa;Password=123456;Encrypt=False");
        public string numara;
        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
            Getir();
        }

        public void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {

                _connection.Open();
            }
        }

        public void Getir()
        {
            lblNumara.Text = numara;
            ConnectionControl();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBLDERS WHERE OGRNUMARA=@P1",_connection);
            cmd.Parameters.AddWithValue("@P1",numara);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) 
            {
                lblAdSoyad.Text = reader[2].ToString()+" "+ reader[3].ToString();
                lBLSinav1.Text = reader[4].ToString();
                lblSinav2.Text = reader[5].ToString();  
                lblSinav3.Text = reader[6].ToString();
                lblOrtalama.Text = reader[7].ToString();
                lblDurum.Text = reader[8].ToString();
                
            }
            _connection.Close();
            

        }
    }
}
