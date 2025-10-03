using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace not
{
    public class NotYonetimSistemi
    {
        List<Ogrenci> ogrenciler = new List<Ogrenci>();
        public void OgrenciEkle(Ogrenci ogrenci)
        {
            ogrenciler.Add(ogrenci);
        }
        public void OgrenciListele()
        {
            foreach(var ogr in ogrenciler)
            {
                Console.WriteLine(ogr);
            }
        }
        public void NotGuncelle(int id,int yeniNot)
        {
            var ogrenci = ogrenciler.FirstOrDefault(o => o.Id == id);
            if(ogrenci != null)
            {
                ogrenci.Not = yeniNot;
                Console.WriteLine($"{ogrenci.Ad} {ogrenci.Soyad} notu guncellendi: {yeniNot}");
            }
        }
    }
}
