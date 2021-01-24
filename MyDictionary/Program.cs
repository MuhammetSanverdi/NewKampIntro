using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryManager<int, string> sehirler = new DictionaryManager<int, string>();
            sehirler.Add(1, "Adana");
            sehirler.Add(2, "Adıyaman");
            sehirler.Add(3, "Afyon");
            sehirler.Add(4, "Ağrı");
            sehirler.Add(5, "Amasya");
            sehirler.Add(6, "Ankara");
            sehirler.Add(7, "Antalya");
            sehirler.Add(8, "Artvin");
            sehirler.Add(9, "Aydın");


            for (int i = 0; i < sehirler.Item1.Length; i++)
            {
                Console.WriteLine(sehirler.Item1[i] + " : " + sehirler.Item2[i]);

            }

        }
    }
}
