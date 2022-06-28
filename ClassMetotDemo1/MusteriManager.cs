using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo1
{
    internal class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi");
        }
        public void Musterisil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi");
        }
        public void MusteriListele(Musteri musteri, Musteri musteri3)
        {
            Console.WriteLine(musteri.Id);
            Console.WriteLine(musteri.Ad);
            Console.WriteLine(musteri.Soyad);
            Console.WriteLine(musteri.Yas);

        }
        
        
        
    }
    
}