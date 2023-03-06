using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Common
{
    public class OdaRezervasyon
    {
        public OdaRezervasyon()
        {
            Odalar = new List<Oda>();
        }
        public Oda Oda { get; set; }
        public Musteri Musteri { get; set; }
        public double RezerveFiyat { get; set; }
        public List<Oda> Odalar { get; set; }
        public override string ToString()
        {
            return Musteri.AdSoyad;
        }
    }
}
