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
	public partial class FormRapor : Form
	{
		private List<OdaRezervasyon> odarezervasyonları;

		public FormRapor()
		{
			InitializeComponent();
		}
		/// <summary>
		/// formrapor this bu metodla basla
		/// </summary>
		/// <param name="odarezervasyonları"></param>
		public FormRapor(List<OdaRezervasyon> odarezervasyonları):this()
		{
			this.odarezervasyonları = odarezervasyonları;
		}
		/// <summary>
		/// form3 yuklendiginde bana rezerve edilen oda için bilgileri listviewde göster
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form3_Load(object sender, EventArgs e)
		{
			int sayac = 0;
		
			foreach (var item in odarezervasyonları)
			{
				ListViewItem list = new ListViewItem();
				list.Text = (sayac++).ToString();
				list.SubItems.Add(item.Oda.Numarasi.ToString());
              	list.Tag = item;
                list.SubItems.Add(item.Musteri.AdSoyad);
				list.SubItems.Add(item.Musteri.TC);
				list.SubItems.Add(item.Musteri.DogumTarihi);
				list.SubItems.Add(item.Musteri.GirisTarihi.ToString());
				list.SubItems.Add(item.Musteri.CikisTarihi.ToString());
				list.SubItems.Add(item.RezerveFiyat.ToString());
				listView1.Items.Add(list);
			

			}

		}
		/// <summary>
		/// string kelime dahilinde musteriyi arar
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void btnMusteriBul_Click(object sender, EventArgs e)
        {
			listView1.Items.Clear();
			int sayac = 0;
			string kelime = "";
			
			foreach (var item in odarezervasyonları)
			{
				if (item.Musteri.AdSoyad.Contains(textBox1.Text.ToString()))
				{
					ListViewItem list = new ListViewItem();
					list.Text = (sayac++).ToString();
					list.SubItems.Add(item.Oda.Numarasi.ToString());
					list.SubItems.Add(item.Musteri.AdSoyad);
					list.SubItems.Add(item.Musteri.TC);
					list.SubItems.Add(item.Musteri.DogumTarihi);
					list.SubItems.Add(item.Musteri.GirisTarihi.ToString());
					list.SubItems.Add(item.Musteri.CikisTarihi.ToString());
                    list.SubItems.Add(item.RezerveFiyat.ToString());
                    list.Tag = item;
					list.SubItems.Add(kelime);
					listView1.Items.Add(list);
				}
			}

        }
		/// <summary>
		/// linkYeni ye tıklanıldıgında yeni musteri kaydı oluşturma sayfasına götürür
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void linkYeni_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
			FormMusteri frmyenikayit = new FormMusteri();
			frmyenikayit.Show();
        }

       
    }
}
