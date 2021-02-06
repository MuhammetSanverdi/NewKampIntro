using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Runtime.CompilerServices;

namespace DataAccess.Concrete.InMemory
{
    public class InMemeoryCarDal:ICarDal
    {
        List<Car> cars;
        public InMemeoryCarDal()
        {
            cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=1,ModelYear=2007,DailyPrice=235,Description="AUDİ  BEYAZ  DİZEL  OTOMATİK"},
                new Car{CarId=2,BrandId=2,ColorId=2,ModelYear=2020,DailyPrice=120,Description="BMW  KIRMIZI  DİZEL  OTOMATİK  320i"},
                new Car{CarId=3,BrandId=3,ColorId=3,ModelYear=1995,DailyPrice=250,Description="VOLVO  MAVİ  BENZİNLİ  MANUEL  S80"},
                new Car{CarId=4,BrandId=4,ColorId=4,ModelYear=2021,DailyPrice=170,Description=" MERCEDES BENZ  SİYAH  BENZİNLİ OTOMATİK E220d"},
                new Car{CarId=5,BrandId=2,ColorId=2,ModelYear=1990,DailyPrice=110,Description="BMW  KIRMIZI  DİZEL  OTOMATİK  318i"},
            };

        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return cars;
        }

        public void Add(Car car)
        {
            cars.Add(car);
        }

        public void Update(Car car)
        {
            Car updatedCar = cars.SingleOrDefault(c => c.CarId == car.CarId);
            updatedCar.BrandId = car.BrandId;
            updatedCar.ColorId = car.ColorId;
            updatedCar.ModelYear = car.ModelYear;
            updatedCar.DailyPrice = car.DailyPrice;
            updatedCar.Description = car.Description;
            
        }

        public void Delete(Car car)
        {
            Car deletedCar = cars.SingleOrDefault(c => c.CarId == car.CarId);
            cars.Remove(deletedCar);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            return null;
        }
    }
       
    
}
