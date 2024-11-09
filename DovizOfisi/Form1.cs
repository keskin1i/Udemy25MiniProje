using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DovizOfisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string Bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDosya = new XmlDocument();
            xmlDosya.Load(Bugun);

            string dolarAlis = xmlDosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lblDolarAlis.Text = dolarAlis;


            string dolarSatis = xmlDosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lblDolarSatis.Text = dolarSatis;

            string euroAlis = xmlDosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lblEuroAlis.Text = euroAlis;

            string euroSatis = xmlDosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lblEuroSatis.Text = euroSatis;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = lblDolarAlis.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = lblDolarSatis.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = lblEuroAlis.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = lblEuroSatis.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Double kur, Miktar, Tutar,Kalan;
            kur = Double.Parse(textBox1.Text);
            Miktar = Double.Parse(textBox2.Text);
            Tutar = kur * Miktar;
            textBox3.Text = Tutar.ToString();

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Replace(".",",");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double kur =Convert.ToDouble( textBox1.Text);
            int miktar = Convert.ToInt32( textBox2.Text);
            int tutar = Convert.ToInt32( miktar/kur);
            textBox3.Text = tutar.ToString();
            double kalan;
            kalan = miktar % kur;
            textBox4.Text = kalan.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}

