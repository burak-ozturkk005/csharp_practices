using not;
public class Program
{
    public static void KonsolaYaz(List<Ogrenci> ogrenciler)
    {
        Console.WriteLine("=== Ogrenci Listesi ===");
        foreach(var o in ogrenciler)
        {
            Console.WriteLine(o);
        }
    }
    public static void Ortalama(List<Ogrenci> ogrenciler)
    {
        double ort = ogrenciler.Average(o => o.Not);
        Console.WriteLine($"Sınıf Ortalaması: {ort}");
    }
    static void Main(string[] args)
    {
        NotYonetimSistemi sistem = new NotYonetimSistemi();
        sistem.OgrenciEkle(new Ogrenci { Id = 1, Ad = "Burak", Soyad = "Öztürk", Not = 85 });
        sistem.OgrenciEkle(new Ogrenci { Id = 2, Ad = "Ali", Soyad = "Yılmaz", Not = 72 });
        sistem.OgrenciEkle(new Ogrenci { Id = 3, Ad = "Ayşe", Soyad = "Demir", Not = 90 });

        Console.WriteLine("İlk Listeleme:");
        sistem.OgrenciListele();

        sistem.NotGuncelle(2, 95);

        Console.WriteLine("\nGüncellenmiş Liste:");
        sistem.OgrenciListele();

       
    }
}