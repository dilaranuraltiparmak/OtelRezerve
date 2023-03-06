using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Common
{
    public class Musteri
    {
        public OdaRezervasyon OdaRezervasyon { get; set; }
        public string TC { get; set; }
        public string AdSoyad{ get; set; }
        public string Tel { get; set; }
        public string DogumTarihi{ get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public override string ToString()
        {
            return AdSoyad;
        }
    }
}
