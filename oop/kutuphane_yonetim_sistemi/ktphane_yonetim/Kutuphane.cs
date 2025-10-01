using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktphane_yonetim
{
    internal class Kutuphane
    {
       
        List<Kitap> kitaplar = new List<Kitap>();
        public void KitapEkle(Kitap kitap)
        {
            kitaplar.Add(kitap);
        }
        public void KitapSil(int id)
        {
            var kitap = kitaplar.FirstOrDefault(k => k.Id == id);
            kitaplar.Remove(kitap);
        }
        public void KitapListele()
        {
            foreach(var kitap in kitaplar)
            {
                Console.WriteLine(kitap);
            }
        }
        
    }
}
