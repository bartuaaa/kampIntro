

string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
string kurs2 = "Proglamaya başlangıç için temel kurs";
string kurs3 = "java";

string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Proglamaya başlangıç için temel kurs", "java" };



for (int i = 0; i <kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}

Console.WriteLine("for bitti");

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}


Console.WriteLine("sayfa sonu - footer");
