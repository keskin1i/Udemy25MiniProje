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

namespace VerTabanlıSecimGrafik
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection _connection = new SqlConnection(@"Data Source=DESKTOP-2KELP5G;Initial Catalog=DBSECİMPROJE;User ID=sa;Password=123456;Encrypt=False");
        private void btnOyGiris_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand cmd = new SqlCommand("Insert into TBLILCE (ILCEAD,APARTI,BPARTİ,CPARTİ,EPARTİ,DPARTİ) values (@p1,@p2,@p3,@p4,@p5,@p6)",_connection);
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtA.Text);
            cmd.Parameters.AddWithValue("@p3",txtB.Text);
            cmd.Parameters.AddWithValue("@p4",txtC.Text);
            cmd.Parameters.AddWithValue("@p5",txtD.Text);
            cmd.Parameters.AddWithValue("@p6", txtE.Text);
            cmd.ExecuteNonQuery();
            _connection.Close();
            MessageBox.Show("Kayıtlar Eklendi.");
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            FrmGrafik frmGrafik = new FrmGrafik();
            frmGrafik.Show();
        }
    }
}
