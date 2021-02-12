using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetBrandId(int id);
        IDataResult<List<Car>> GetColorId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<Car> GetByCarId(int id);
        IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);

    }
}
