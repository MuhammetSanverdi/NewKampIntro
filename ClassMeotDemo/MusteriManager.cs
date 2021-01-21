using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMeotDemo
{
    class MusteriManager
    {
        public string Ekle(Musteri musteri)
        {
            string text = $"{musteri.Adi} adlı müşteri başarıyla eklendi.";
            return text;
        }

        public string Liste(Musteri musteri)
        {
            
            string text = musteri.Adi + musteri.KimlikNo + musteri.TelNo;
            return text;
        }

        public string Sil(Musteri musteri)
        {
            string text = $"{musteri.Adi} adlı müşteri başarıyla silindi.";
            return text;
        }
    }
}
