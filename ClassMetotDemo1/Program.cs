using ClassMetotDemo1;

Musteri musteri1 = new Musteri();
musteri1.Id = 12;
musteri1.Ad = "bartu";
musteri1.Soyad = "odabaşı";
musteri1.Yas = "15";

Musteri musteri2 = new Musteri();
musteri2.Id = 13;
musteri2.Ad = "emre";
musteri2.Soyad = "yıldırım";
musteri2.Yas = "15";

 Musteri musteri3 = new Musteri();
musteri3.Id = 12;
musteri3.Ad = "selim";
musteri3.Soyad = "yonbak";
musteri3.Yas = "15";

Musteri[] musteri = new Musteri[] {musteri1,musteri2,musteri3};

foreach (var Musteri in musteri)
{
    Console.WriteLine(Musteri.Id);
    Console.WriteLine(Musteri.Ad);
    Console.WriteLine(Musteri.Soyad);
    Console.WriteLine(Musteri.Yas);
}
MusteriManager musteriManager = new MusteriManager();
musteriManager.MusteriEkle(musteri3);
musteriManager.Musterisil(musteri2);
musteriManager.MusteriListele(musteri2,musteri3);