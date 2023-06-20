using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int OTutar = 0;
        List<string> sepet = new List<string>();
        public void sepetY()
        {
            comboBox3.Items.Clear();
            foreach (string s in sepet)
            {
                comboBox3.Items.Add(s);
            }
        }
        public void sepetS()
        {
            comboBox3.Items.Clear();
            sepetY();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sepet.Add(".  Futbol Topu , 100tl   .");
            sepetY();
            OTutar += 100;
            label9.Text =  "Ödenecek Tutar : " + OTutar;
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sepet.Add(".  Bülbülü Öldürmek(kitap) , 60tl , 358 Sayfa  .");
            sepetY();
            OTutar += 60;
            label9.Text = "Ödenecek Tutar : " + OTutar;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show(" Lütfen sepete eklemek için bir Numara giriniz ");
            }
            else
            {
                sepet.Add(".  Ayakkabı , 1000tl , " + comboBox1.SelectedItem.ToString() + " Numara  .");
                sepetY();
                OTutar += 1000;
                label9.Text = "Ödenecek Tutar : " + OTutar;
            }
           
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (OTutar == 0) { MessageBox.Show(" Sepetinizde bir ürün bulunmamaktadır "); }
            else { MessageBox.Show("Borcunuz : " + OTutar); }           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem == null)
            {
                MessageBox.Show(" Lütfen sepetten silmek için bir ürün seçin ");
            }
            else 
            {
                foreach (string s in sepet)
                {
                    if (s == comboBox3.SelectedItem.ToString())
                    {
                        if (s == ".  Futbol Topu , 100tl   .") { OTutar -= 100; label9.Text = "Ödenecek Tutar : " + OTutar; }
                        else if (s == ".  Bülbülü Öldürmek(kitap) , 60tl , 358 Sayfa  .") { OTutar -= 60; label9.Text = "Ödenecek Tutar : " + OTutar; }
                        else if (s == ".  Ayakkabı , 1000tl , " + comboBox1.SelectedItem.ToString() + " Numara  .") { OTutar -= 1000; label9.Text = "Ödenecek Tutar : " + OTutar; }
                        sepet.Remove(s);
                        break;
                    }
                }
                sepetS();
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sepet.Clear();
            comboBox3.Items.Clear();
            OTutar = 0;
            label9.Text = "Ödenecek Tutar : " + OTutar;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            label9.Text = "Ödenecek Tutar : " + OTutar;
        }
    }
}
