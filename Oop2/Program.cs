using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Engin Demiroğ
            GercekMüsteri musteri1 = new GercekMüsteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "23423";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "4234234234";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "32423425";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "234256244523";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            Musteri musteri3 = new GercekMüsteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);

        }
    }
}
