using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Common
{
    public class Oda
    { 
        public OdaRezervasyon OdaRezervasyons { get; set; }
        public byte YatakSayisi { get; set; }
        public int Numarasi { get; set; }
        public double Fiyat { get; set; }
        public OdaDurumu OdaDurumu { get; set; }
        public override string ToString()
        {
            return OdaRezervasyons.Musteri.AdSoyad;
        }
    }
}
