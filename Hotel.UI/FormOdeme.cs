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
    public partial class FormOdeme : Form
    {
        private List<OdaRezervasyon> odarezervasyonları;
        private List<Musteri> musteriler;
        DateTime girisTarihi = DateTime.Now;
        double odaFiyati = 0;
        double extratop = 0;
        double totalTop = 0;
        int gunFarki = 0;

        public FormOdeme()
        {
            InitializeComponent();
        }


       
        public FormOdeme(List<Musteri> musteriler, List<OdaRezervasyon> odarezervasyonları) : this()
        {
            this.musteriler = musteriler;
            this.odarezervasyonları = odarezervasyonları;
        }
        /// <summary>
        /// form2 yüklendiğinde bana kayıtlı müşteri bilgisini getirir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Load(object sender, EventArgs e)

        {

            foreach (OdaRezervasyon item in odarezervasyonları)
            {
                cmbMusteri.Items.Add(item.Musteri);
            }

        }

        OdaRezervasyon rezerve = null;

        DateTime cikisTarih;
        /// <summary>
        /// müşteri seçildiğinde bana kayıtları getirir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void cmbMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {


            rezerve = new OdaRezervasyon();
            foreach (OdaRezervasyon item in odarezervasyonları)
            {
                if (cmbMusteri.SelectedItem == item.Musteri)
                {
                    rezerve = item;
                    lblBilgi.Text = "Bilgileri- AD Soyad:" + item.Musteri.AdSoyad + "TC:" + item.Musteri.TC + " Otel giriş bilgileri: " + item.Musteri.GirisTarihi/*+" "+"Fiyat: "+item.Oda.Fiyat*/;
                    girisTarihi = item.Musteri.GirisTarihi;
                    lblUcret.Text = "Oda: " + item.Oda.Numarasi + " " + " Odanın Günlük Fiyatı: " + item.Oda.Fiyat;

                }


            }
        }


        

        /// <summary>
        /// btnExtraEkle ile bana extra fiyatlarını belirle 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExtraEkle_Click(object sender, EventArgs e)
        {

            foreach (CheckBox item in this.Controls.OfType<CheckBox>())
            {
     
                if (item.Checked) {
                    
                    double fiyat = double.Parse(checkBox1.Tag.ToString());
                    extratop += (double)numericUpDown1.Value * fiyat;
                   
                }
               

            }

            lblYeniUcret.Text = extratop.ToString();

        }
        /// <summary>
        /// kullanıcı cikistarihinibelirlediginde gunfarkini alarak bana güne göre yeni ücreti belirlememi sağlar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtCikisTarihi_ValueChanged(object sender, EventArgs e)
        {

            foreach (var item in odarezervasyonları)
            {
                if (item.Equals(rezerve))
                {
                    item.Musteri.CikisTarihi = dtCikisTarihi.Value;
                
                   gunFarki = ((dtCikisTarihi.Value.Date) - (girisTarihi.Date)).Days;
                    odaFiyati = rezerve.Oda.Fiyat;
                   
                    totalTop = (gunFarki * odaFiyati);
                    lblYeniUcret.Text =( gunFarki*odaFiyati).ToString();
                    

                }
            }

        }
        /// <summary>
        /// btnTutar ile bana en sonda extra ve günsayısına göre ücretin son halini hesaplatır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTutar_Click(object sender, EventArgs e)
        {
            foreach (var item in odarezervasyonları)
            {
                if (item.Equals(rezerve))
                {
                   
                    totalTop += extratop;
                    lblYeniUcret.Text =totalTop.ToString(); 
                    item.RezerveFiyat = totalTop;
                }
            }

        }



        private void btnGec_Click(object sender, EventArgs e)
        {
            FormRapor frmRapor = new FormRapor(odarezervasyonları);
            frmRapor.Show();
        }

        private void btnUcretOde_Click(object sender, EventArgs e)
        {
            foreach (var item in odarezervasyonları)
            {
                if (item.Equals(rezerve))
                {
                    item.RezerveFiyat = totalTop;
                }
            }
            MessageBox.Show("Ödeme tamamlanmıştır");
        }

        private void btnOnceki_Click(object sender, EventArgs e)
        {
            FormMusteri nefrm = new FormMusteri();
            nefrm.Show();
        }
    }
}
