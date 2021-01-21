using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = "845641253";
            musteri1.Adi = "Mehmet Varlı";
            musteri1.TelNo = "5854875216";
            musteri1.yasi = "25";

            Musteri musteri2 = new Musteri();
            musteri2.Id = "823467825";
            musteri2.Adi = "Mehmet Varlı";
            musteri2.TelNo = "5567732434";
            musteri2.yasi = "42";

            Musteri musteri3 = new Musteri();
            musteri3.Id = "834667482";
            musteri3.Adi = "Mehmet Varlı";
            musteri3.TelNo = "5415297603";
            musteri3.yasi = "42";
        }
    }
}
