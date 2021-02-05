using System;
using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemeoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Model Yılı:"+car.ModelYear + "   Otomobil Özellikleri:"+car.Description+"   Günlük Kiralam Fiyatı:"+car.DailyPrice);
            }
        }
    }
}
