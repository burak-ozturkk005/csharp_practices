using ktphane_yonetim;

Kutuphane kutuphane = new Kutuphane();
kutuphane.KitapEkle(new Kitap { Id = 1, Ad = "Sefiller", Yazar = "Victor Hugo", SayfaSayisi = 500 });
kutuphane.KitapEkle(new Kitap { Id = 2, Ad = "Suç ve Ceza", Yazar = "Dostoyevski", SayfaSayisi = 600 });
kutuphane.KitapEkle(new Kitap { Id = 3, Ad = "1984", Yazar = "George Orwell", SayfaSayisi = 350 });

kutuphane.KitapListele();

kutuphane.KitapSil(2);
kutuphane.KitapListele();

