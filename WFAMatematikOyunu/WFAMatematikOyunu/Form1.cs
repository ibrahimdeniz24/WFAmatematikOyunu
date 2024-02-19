using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAMatematikOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int sayi1, sayi2, op, soruSayisi, dogruCevapSayisi, sonuc;

        private void Form1_Load(object sender, EventArgs e)
        {

            sayi1 = rnd.Next(1, 11);
            sayi2 = rnd.Next(1, 11);

            lblsayi1.Text = sayi1.ToString();
            lblSayi2.Text = sayi2.ToString();

            op = rnd.Next(1, 3);

            if (op == 1)
            {
                lblOperator.Text = "+";
            }

            else
            {
                lblOperator.Text = "-"; 
            }

            soruSayisi++;

            lblSoruSayisi.Text=soruSayisi.ToString(); 

             
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                int girilenDeger = Convert.ToInt32(txtgirilenDeger.Text);

                if (op == 1)

                {
                    sonuc = sayi1 + sayi2;

                }
                else

                {
                    sonuc = sayi1 - sayi2;
                }

                if (girilenDeger == sonuc)

                {
                    dogruCevapSayisi++;

                    lblDogruCevapSayisi.Text = dogruCevapSayisi.ToString();

                }


                else
                {
                    soruSayisi++;
                    lblSoruSayisi.Text = soruSayisi.ToString();

                }

                {
                    sayi1 = rnd.Next(1, 11);
                    sayi2 = rnd.Next(1, 11);

                    lblsayi1.Text = sayi1.ToString();
                    lblSayi2.Text = sayi2.ToString();

                    op = rnd.Next(1, 3);

                    if (op == 1)
                    {
                        lblOperator.Text = "+";
                    }

                    else
                    {
                        lblOperator.Text = "-";
                    }

                    soruSayisi++;

                    lblSoruSayisi.Text = soruSayisi.ToString();
                }
            }

            catch

            {
                MessageBox.Show(" Lütfen Sayısal bir değer giriniz !!");
            }

        }
    }
}
