using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proje6
{
    public partial class FrmSatis : Form
    {
        public FrmSatis()
        {
            InitializeComponent();
        }

        OleDbConnection _connecton = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\User\Downloads\dbSozluk.mdb;Persist Security Info=False;");
        Random rast = new Random();
        int sure = 90;
        int kelime = 0;
        private void FrmSatis_Load(object sender, EventArgs e)
        {
            yenile();
        }

        private void yenile()
        {
            int sayi = rast.Next(1, 2490);
            lblCevap.Text = sayi.ToString();
            _connecton.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from sozluk where id=@p1", _connecton);
            cmd.Parameters.AddWithValue("@p1", sayi);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr[1].ToString();
                lblCevap.Text = dr[2].ToString();
                //if (textBox2.Text == lblCevap.Text) 
                //{
                //    lblKelime.Text += 1;
                //}
            }
            _connecton.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == lblCevap.Text)
            {
                kelime++;
                lblKelime.Text = kelime.ToString();
                yenile();
            }
            textBox2.Text = "";
        }
    }
}
