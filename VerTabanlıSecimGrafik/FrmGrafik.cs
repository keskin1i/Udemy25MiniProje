using DevExpress.Utils.Menu;
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
    public partial class FrmGrafik : Form
    {
        public FrmGrafik()
        {
            InitializeComponent();
        }

        SqlConnection _connection = new SqlConnection(@"Data Source=DESKTOP-2KELP5G;Initial Catalog=DBSECİMPROJE;User ID=sa;Password=123456;Encrypt=False");
        private void FrmGrafik_Load(object sender, EventArgs e)
        {
            //Combobox a ilce adalarını çektik
            _connection.Open();
            SqlCommand cmd = new SqlCommand("select ILCEAD from TBLILCE ",_connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            _connection.Close();

            //Grafiğe Toplam Sonuçları Getirme
            _connection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select sum(APARTI),SUM(BPARTİ),SUM(CPARTİ),SUM(DPARTİ),SUM(EPARTİ) FROM TBLILCE",_connection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {

                chart1.Series["Partiler"].Points.AddXY("A PARTİ", sqlDataReader[0]);
                chart1.Series["Partiler"].Points.AddXY("B PARTİ", sqlDataReader[1]);
                chart1.Series["Partiler"].Points.AddXY("C PARTİ", sqlDataReader[2]);
                chart1.Series["Partiler"].Points.AddXY("D PARTİ", sqlDataReader[4]);
                chart1.Series["Partiler"].Points.AddXY("E PARTİ", sqlDataReader[3]);

            }
            _connection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _connection.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM TBLILCE WHERE ILCEAD=@P1",_connection);
            sqlCommand.Parameters.AddWithValue("@P1",comboBox1.Text);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            while (dr.Read())
            {
                progressBar1.Value = int.Parse(dr[2].ToString());
                progressBar2.Value = int.Parse(dr[3].ToString());
                progressBar3.Value = int.Parse(dr[4].ToString());
                progressBar4.Value = int.Parse(dr[5].ToString());
                progressBar5.Value = int.Parse(dr[6].ToString());

                lblA.Text = dr[2].ToString();
                lblB.Text = dr[3].ToString();
                lblC.Text = dr[4].ToString();
                lblE.Text = dr[5].ToString();
                lblD.Text = dr[6].ToString();
               
            }

            _connection.Close();

            }
    }
}
