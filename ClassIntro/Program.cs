
kurs kurs1 = new kurs();
kurs1.kursAdi = "c#";
kurs1.Egitmen = "engin demirog";
kurs1.ızlenmeOranı = 68;

kurs kurs2 = new kurs();
kurs2.kursAdi = "java";
kurs2.Egitmen = "kerem varış";
kurs2.ızlenmeOranı = 64;

kurs kurs3 = new kurs();
kurs3.kursAdi = "python";
kurs3.Egitmen = "Berkay";
kurs3.ızlenmeOranı = 80;

kurs kurs4 = new kurs();
kurs4.kursAdi = "c++";
kurs4.Egitmen = "Murat kurtboğan";
kurs4.ızlenmeOranı = 100;



Console.WriteLine(kurs1.kursAdi + " : " +  kurs1.Egitmen);

kurs[] kurslar = new kurs[] {kurs1,kurs2,kurs3,kurs4  };

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.kursAdi + " : " + kurs.Egitmen);    
}






class kurs
{
    public string kursAdi { get; set; }
    public string Egitmen { get; set; }
    public int ızlenmeOranı { get; set; }

}