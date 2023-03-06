using Hotel.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.UI
{
    public partial class FormMusteri : Form
    {   Button tiklanilanButtton = null;
        List<OdaRezervasyon> odarezervasyonları = new List<OdaRezervasyon>();
        List<Oda> odalar = new List<Oda>();
        List<Musteri> musteriler = new List<Musteri>();
        public FormMusteri()
        {
            InitializeComponent();
        }
    /// <summary>
    /// btnGec ile yeni forma geçilir
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
        public void btnGec_Click(object sender, EventArgs e)
        {
         
          
            FormOdeme form2 = new FormOdeme(musteriler,odarezervasyonları);
            form2.Show();
           
        }
     /// <summary>
     /// form1 yüklenildiğinde bize aşağıda verilen atamaları yap odaları buton şeklinde oluştur.
     /// </summary>
     /// <param name="sender"></param>
     /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            Button btnKral = new Button();
            btnKral.Text = "Kral Dairesi";
            btnKral.BackColor = Color.White;
            btnKral.Tag = null;
            btnKral.Width = 315;
            btnKral.Height = 50;
            btnKral.Click += Btn_Click;
            f1Kat4.Controls.Add(btnKral);
            int sayac = 99;
            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.Text = (++sayac).ToString();
                btn.BackColor = Color.White;

                btn.Tag = new OdaRezervasyon()
                {
                    Oda = new Oda()
                    {
                        Fiyat = 100,
                        Numarasi = int.Parse(btn.Text),
                        OdaDurumu = OdaDurumu.Bos


                    },
                    Musteri = new Musteri()
                    {
                        TC = txtTc.Text,
                        AdSoyad = txtAD.Text,
                        Tel = maskedTextBox1.Text,
                        DogumTarihi = txtDt.Text,
                        GirisTarihi = dtGirisTarihi.Value,
                     

                    }
                };
                btn.Click += Btn_Click;
                f1Kat1.Controls.Add(btn);

            }
            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.Text = (++sayac).ToString();
                btn.BackColor = Color.White;
                btn.Tag = new OdaRezervasyon()
                {
                    Oda = new Oda()
                    {
                        Fiyat = 200,
                        Numarasi = int.Parse(btn.Text),
                        OdaDurumu = OdaDurumu.Bos
                    },
                    Musteri = new Musteri()
                    {
                        TC = txtTc.Text,
                        AdSoyad = txtAD.Text,
                        Tel = maskedTextBox1.Text,
                        DogumTarihi = txtDt.Text,
                        GirisTarihi = dtGirisTarihi.Value,
                     
                    }
                };
                btn.Click += Btn_Click;
                f1Kat2.Controls.Add(btn);

            }
            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.Text = (++sayac).ToString();
                btn.BackColor = Color.White;
                btn.Tag = new OdaRezervasyon()
                {
                    Oda = new Oda()
                    {
                        Fiyat = 400,
                        Numarasi = int.Parse(btn.Text),
                        OdaDurumu = OdaDurumu.Bos
                    },
                    Musteri = new Musteri()
                    {
                        TC = txtTc.Text,
                        AdSoyad = txtAD.Text,
                        Tel = maskedTextBox1.Text,
                        DogumTarihi = txtDt.Text,
                        GirisTarihi = dtGirisTarihi.Value,
                    

                    }
                };
                btn.Click += Btn_Click;
                f1Kat3.Controls.Add(btn);

            }
        }

        


        private void Btn_Click(object sender, EventArgs e)
        {
            tiklanilanButtton = sender as Button;
            groupBox2.Enabled = true;

        }

     
        /// <summary>
        /// btnEkle ile gerekli validasyonlar dahilinde ekleme işlemi yapılır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEkle_Click(object sender, EventArgs e)
        {

            string adSoyad = txtAD.Text; string tc = txtTc.Text; string dogumyili = txtDt.Text; string cep = maskedTextBox1.Text;  
            

            if (Validasyon(adSoyad, tc, dogumyili, cep) == true)
            { 
            
               OdaRezervasyon odaRezarvasyon = tiklanilanButtton.Tag as OdaRezervasyon;
                
                if (odaRezarvasyon.Oda.OdaDurumu == OdaDurumu.Bos)
                {
                    odaRezarvasyon.Musteri = new Musteri()
                    {
                        TC = txtTc.Text,
                        AdSoyad = txtAD.Text,
                        Tel = maskedTextBox1.Text,
                        DogumTarihi = txtDt.Text,
                        GirisTarihi = dtGirisTarihi.Value,
                     

                    };

                    odaRezarvasyon.Oda.OdaDurumu = OdaDurumu.Dolu;
                    tiklanilanButtton.BackColor = Color.Red;
                    odarezervasyonları.Add(odaRezarvasyon);
                    musteriler.Add(odaRezarvasyon.Musteri);

             MessageBox.Show("Bilgileriniz kaydedilmiştir.");
                FormuTemizle();
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
                errorProvider4.Clear();

                }
            
                else
                {
                    MessageBox.Show("Oda doludur.");
                }

            }

            else
            {
                MessageBox.Show("Bilgileriniz eksik veya hatalıdır kontrol ediniz");
                errorProvider1.SetError(txtAD, "Kişi adı boş geçilemez. ");
                errorProvider2.SetError(txtTc, "Lütfen boş geçmeyiniz.11 haneli Tc numaranızı giriniz ");
                errorProvider3.SetError(maskedTextBox1, "Alan Boş geçilemez ve başında sıfır olmadan giriniz ");
                errorProvider4.SetError(txtDt, "Lütfen sadece doğum yılınızı giriniz ");
                groupBox2.Enabled = false;
                FormuTemizle();
            }

        }
        /// <summary>
        /// FormuTemizle() metodu ile kullanıcı verileri girdikten sonra değerleri siler
        /// </summary>
        private void FormuTemizle()
        {
            txtDt.Text = string.Empty; txtAD.Text = string.Empty; txtTc.Text = string.Empty; maskedTextBox1.Text = string.Empty;
        }

        /// <summary>
        ///  Validasyon() gerekli validasyonlarımızı yapar
        /// </summary>
        /// <param name="adSoyad"></param>
        /// <param name="tc"></param>
        /// <param name="dogumyili"></param>
        /// <param name="cep"></param>
        /// <returns></returns>


        private bool Validasyon(string adSoyad, string tc, string dogumyili, string cep)
        {
            return (!string.IsNullOrEmpty(adSoyad)
                && !string.IsNullOrEmpty(tc)
                && !string.IsNullOrEmpty(dogumyili) && !string.IsNullOrEmpty(cep)) &&
                (tc.Length == 11 && tc.Substring(0, 1) != "0"
                && tc.Substring(10, 1) != "1" && tc.Substring(10, 1) != "1"
                && tc.Substring(10, 1) != "3" && tc.Substring(10, 1) != "5"
                && tc.Substring(10, 1) != "7" && tc.Substring(10, 1) != "9")
                && !adSoyad.Any(char.IsDigit) && tc.Any(char.IsDigit) && dogumyili.Any(char.IsDigit) && cep.Any(char.IsDigit);

        }

     
        /// <summary>
        /// lblTemizleye tıklanıldığında odda rengi maviye dönüşmektedir.
     
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblTemizlik_Click(object sender, EventArgs e)
        {
            if (tiklanilanButtton != null) { 
                tiklanilanButtton.BackColor = Color.Blue;
    
                MessageBox.Show("Oda Temizlikte."); 
            } else {
                MessageBox.Show("Lütfen Oda Seçiniz."); 
            }
        }

       
    }

}

