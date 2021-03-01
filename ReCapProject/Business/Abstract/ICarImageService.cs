using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(CarImage carImage, IFormFile file);
        IResult Update(CarImage carImage, IFormFile file);
        IResult Delete(CarImage carImage);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetByCarImageId(int id);
        IDataResult<List<CarImage>> BringPicturesWithCarId(int id);
        IResult DeleteByCarId(int carId);
        IDataResult<List<CarImage>> GetAllByCarId(int id);
    }
}
