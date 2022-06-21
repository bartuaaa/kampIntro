urun urun1 = new urun();
urun1.urunAdi = "protein tozu";
urun1.urunsaticisi = "bartu";
urun1.urunnumara = 503;

urun urun2 = new urun();
urun2.urunAdi = "bilgisayar";
urun2.urunsaticisi = "emre";
urun2.urunnumara = 3249;

urun urun3 = new urun();
urun3.urunAdi = "klavye";
urun3.urunsaticisi = "deniz";
urun3.urunnumara = 1342;

urun[] urunler = new urun[] {urun1,urun2,urun3 };

foreach (var urun in urunler)
{
    Console.WriteLine(urun.urunAdi + ": "+ urun.urunsaticisi + urun.urunnumara );
}

Console.WriteLine("---------------Metotlar-----------");




class urun
{
    public string urunAdi  { get; set; }
    public string urunsaticisi { get; set; }
    public int urunnumara { get; set; }
}
