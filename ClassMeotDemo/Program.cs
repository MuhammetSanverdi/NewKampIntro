using System;

namespace ClassMeotDemo
{
    class Program
    {
        public static object Musterimanager { get; private set; }

        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri { Id = 1, Adi = "Mehmet Varlı", KimlikNo = "57682386435", TelNo = "4678642734" };
            Musteri musteri2 = new Musteri { Id = 2, Adi = "Ahmet Kömür",  KimlikNo = "48595832174", TelNo = "3825671827" };
            Musteri musteri3 = new Musteri { Id = 3, Adi = "Can Yılmaz",   KimlikNo = "49127856238", TelNo = "7791586236" };
            Musteri musteri4 = new Musteri { Id = 4, Adi = "Ali Türkoğlu", KimlikNo = "75183269547", TelNo = "4894656734" };

            
            MusteriManager musteri = new MusteriManager();

            Console.WriteLine(musteri.Ekle(musteri1));
            Console.WriteLine("Müşteriler listeleniyor");
            Console.WriteLine(musteri.Liste(musteri1));
            Console.WriteLine(musteri.Liste(musteri2));
            Console.WriteLine(musteri.Liste(musteri3));
            Console.WriteLine(musteri.Liste(musteri4));
            Console.WriteLine(musteri.Sil(musteri4));



        }
        
    }
}
