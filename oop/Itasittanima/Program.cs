using Itasittanima;

List<IHareketEdebilir> tasitlar = new List<IHareketEdebilir>();
tasitlar.Add(new Araba());
tasitlar.Add(new Bisiklet());
tasitlar.Add(new Ucak());
foreach(var tasit in tasitlar)
{
    tasit.Dur();
    tasit.Ilerle();
}