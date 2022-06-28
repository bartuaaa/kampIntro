
string kategoriEtiketi = "kategori";
bool sistemeGirisyapmisMi = false;
double dolarDun = 7.55;
double dolarBugun = 7.45;
if (dolarDun>dolarBugun)
{
   Console.WriteLine("azalış butonu");
}

 else if (dolarDun<dolarBugun)
{
    Console.WriteLine("artış butonu");

}

else
{
    
    Console.WriteLine("değişmedi butonu");
}

if (sistemeGirisyapmisMi == true)
{
    Console.WriteLine("kullanıcı ayarları butonu");
}
else
{
    Console.WriteLine("giriş yap butonu");
}

