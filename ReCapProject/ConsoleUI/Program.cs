using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            
            
            var result = carManager.GetAll();

            if (result.Success==true)
            {
                Console.WriteLine(result.Message);
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Description);
                }

            }
            //foreach (var car in carManager.GetCarDetails().Data)
            //{
            //    Console.WriteLine("Marka: " + car.BrandName + "Model: " + car.ModelName + "Renk: " + car.ColorName
            //                       +"Model Yılı: "+car.ModelYear + "Özellikleri: "+car.Description);
            //}


            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("Model Yılı: "+car.ModelYear + "   Otomobil Özellikleri: "+car.Description+"   Günlük Kiralam Fiyatı: "+car.DailyPrice);
            //}

            //foreach (var car in carManager.GetByDailyPrice(150,200))
            //{
            //    Console.WriteLine(car.Description);
            //}
        }
    }
}
