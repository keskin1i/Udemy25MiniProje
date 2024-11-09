using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int soruNo=0, dogru=0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                switch (soruNo)
                {
                    case 1:
                        if (textBox1.Text=="Akdeniz")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text=dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor= Color.Red;
                            yanlis++;
                            lblYnlis.Text=yanlis.ToString();
                        }
                        break;
                        case 2:
                        if (textBox1.Text == "Bursa")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            lblYnlis.Text = yanlis.ToString();
                        }
                        break;
                        case 3:
                        if (textBox1.Text == "Cuma")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            lblYnlis.Text = yanlis.ToString();
                        }
                        break;
                        case 4:
                        if (textBox1.Text == "Diyarbakır")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            lblYnlis.Text = yanlis.ToString();
                        }
                        break;
                        case 5:
                        if (textBox1.Text == "Eski")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            lblYnlis.Text = yanlis.ToString();
                        }
                        break;
                        case 6:
                        if (textBox1.Text == "Ferman")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlis++;
                            lblYnlis.Text = yanlis.ToString();
                        }
                        break;
                        case 7:
                        if (textBox1.Text == "Güneş")
                        {
                            button9.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlis++;
                            lblYnlis.Text = yanlis.ToString();
                        }
                        break;
                        case 8:
                        if (textBox1.Text == "Isparta")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlis++;
                            lblYnlis.Text = yanlis.ToString();
                        }
                        break;
                        case 9:
                        if (textBox1.Text == "Akdenizin incisi")
                        {
                            button12.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlis++;
                            lblYnlis.Text = yanlis.ToString();
                        }
                        break;
                        case 10:
                        if (textBox1.Text == "Jandarma")
                        {
                            button10.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlis++;
                            lblYnlis.Text = yanlis.ToString();
                        }
                        break;
                        case 11:
                        if (textBox1.Text == "22 Şubat")
                        {
                            button24.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button24.BackColor = Color.Red;
                            yanlis++;
                            lblYnlis.Text = yanlis.ToString();
                        }
                        break;
                        case 12:
                        if (textBox1.Text == "1923")
                        {
                            button22.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            yanlis++;
                            lblYnlis.Text = yanlis.ToString();
                        }
                        break;
                        case 13:
                        if (textBox1.Text == "Mart")
                        {
                            button23.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button23.BackColor = Color.Red;
                            yanlis++;
                            lblYnlis.Text = yanlis.ToString();
                        }
                        break;
                        case 14:
                        if (textBox1.Text == "Ney")
                        {
                            button20.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlis++;
                            lblYnlis.Text = yanlis.ToString();
                        }
                        break;
                        case 15:
                        if (textBox1.Text == "725")
                        {
                            button19.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlis++;
                            lblYnlis.Text = yanlis.ToString();
                        }
                        break;
                        case 16:
                        if (textBox1.Text == "7 Temmuz")
                        {
                            button21.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanlis++;
                            lblYnlis.Text = yanlis.ToString();
                        }
                        break;
                        case 17:
                        if (textBox1.Text == "Cahit Sıtkı Tarancı")
                        {
                            button17.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlis++;
                            lblYnlis.Text = yanlis.ToString();
                        }
                        break;
                        case 18:
                        if (textBox1.Text == "Ramazan")
                        {
                            button16.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlis++;
                            lblYnlis.Text = yanlis.ToString();
                        }
                        break;
                        case 19:
                        if (textBox1.Text == "Senaks")
                        {
                            button11.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();


                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlis++;
                            lblYnlis.Text = yanlis.ToString();
                        }
                        break;
                        case 20:
                        if (textBox1.Text == "Umut")
                        {
                            button18.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlis++;
                            lblYnlis.Text = yanlis.ToString();
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "Sezen Aksu")
                        {
                            button14.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlis++;
                            lblYnlis.Text = yanlis.ToString();
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "Tarkan")
                        {
                            button13.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlis++;
                            lblYnlis.Text = yanlis.ToString();
                        }
                        break;
                    case 23:
                        if (textBox1.Text == "Eşek")
                        {
                            button15.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlis++;
                            lblYnlis.Text = yanlis.ToString();
                        }
                        break;
                    case 24:
                        if (textBox1.Text == "2024")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlis++;
                            lblYnlis.Text = yanlis.ToString();
                        }
                        break;

                }
               
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "CEVAPLA";
            soruNo++;
            this.Text = soruNo.ToString();

            if (soruNo == 1) 
            {
                richTextBox1.Text = "Ülkemizin Güney Kısmındaki Kıyı Bölgesi?";
                button1.BackColor = Color.Yellow;
            }

            if (soruNo == 2)
            {
                richTextBox1.Text = "Yeşilliğiyle Ünlü Marmara İlimiz?";
                button3.BackColor = Color.Yellow;
            }

            if (soruNo == 3)
            {
                richTextBox1.Text = "Müslümanların Kutsal Günü??";
                button2.BackColor = Color.Yellow;
            }

            if (soruNo == 4)
            {
                richTextBox1.Text = "Karpuzuyla Ünlü ilimiz?";
                button6.BackColor = Color.Yellow;
            }

            if (soruNo == 5)
            {
                richTextBox1.Text = "Yeni Kelimesinin Zıt Anlamı?";
                button4.BackColor = Color.Yellow;
            }

            if (soruNo == 6)
            {
                richTextBox1.Text = "Padişahın Emirlerinin Yazılı Hali?";
                button5.BackColor = Color.Yellow;
            }

            if (soruNo == 7)
            {
                richTextBox1.Text = "Dünyanın Isı Kaynağı?";
                button9.BackColor = Color.Yellow;
            }

            if (soruNo == 8)
            {
                richTextBox1.Text = "Gülüyle Ünlü İlimiz?";
                button8.BackColor = Color.Yellow;
            }

            if (soruNo == 9)
            {
                richTextBox1.Text = "Mersinin Diğer İsmi?";
                button12.BackColor = Color.Yellow;
            }

            if (soruNo == 10)
            {
                richTextBox1.Text = "Askeri Topluluk?";
                button10.BackColor = Color.Yellow;
            }

            if (soruNo == 11)
            {
                richTextBox1.Text = "Muhammet Keskin in Doğum Günü:) ?";
                button24.BackColor = Color.Yellow;
            }

            if (soruNo == 12)
            {
                richTextBox1.Text = "Cumhuriyetin Kuruluş Yılı?";
                button22.BackColor = Color.Yellow;
            }

            if (soruNo == 13)
            {
                richTextBox1.Text = "Yılın Üçüncü Ayı?";
                button23.BackColor = Color.Yellow;
            }

            if (soruNo == 14)
            {
                richTextBox1.Text = "Üflemeli Bir Müzik Aleti?";
                button20.BackColor = Color.Yellow;
            }

            if (soruNo == 15)
            {
                richTextBox1.Text = "15 in Karesi?";
                button19.BackColor = Color.Yellow;
            }

            if (soruNo == 16)
            {
                richTextBox1.Text = "Nur un Doğum Günü?";
                button21.BackColor = Color.Yellow;
            }

            if (soruNo == 17)
            {
                richTextBox1.Text = "35 Yaş Şiİri Kime Ait?";
                button17.BackColor = Color.Yellow;
            }

            if (soruNo == 18)
            {
                richTextBox1.Text = "11 Ayın Sultanı?";
                button16.BackColor = Color.Yellow;
            }

            if (soruNo == 19)
            {
                richTextBox1.Text = "İngilizce de Yılan?";
                button11.BackColor = Color.Yellow;
            }

            if (soruNo == 20)
            {
                richTextBox1.Text = "Ümit Kelimesinin Eş Anlamlısı?";
                button18.BackColor = Color.Yellow;
            }

            if (soruNo == 21)
            {
                richTextBox1.Text = "Minik Serçe Kimdir?";
                button14.BackColor = Color.Yellow;
            }

            if (soruNo == 22)
            {
                richTextBox1.Text = "Mega Star Kimdir?";
                button13.BackColor = Color.Yellow;
            }

            if (soruNo == 23)
            {
                richTextBox1.Text = "Nasreddin Hocanın En Sevdiği Hayvanı?";
                button15.BackColor = Color.Yellow;
            }

            if (soruNo == 24)
            {
                richTextBox1.Text = "Şuan Hangi Yıldayız?";
                button7.BackColor = Color.Yellow;
            }

        }
    }
}
