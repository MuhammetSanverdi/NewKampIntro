using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal:EfEntityRepositoryBase<Car,ReCapProjectDemoDatabaseContext>,ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapProjectDemoDatabaseContext contex = new ReCapProjectDemoDatabaseContext())
            {
                var result = from ca in contex.Cars
                            join co in contex.Colors
                    on ca.ColorId equals co.ColorId
                        join br in contex.Brands 
                        on ca.BrandId equals br.BrandId
                            join mo in contex.Models 
                            on ca.ModelId equals mo.ModelId
                    
                    select new CarDetailDto
                    {
                        BrandName = br.BrandName,
                        ColorName = co.ColorName,
                        Description = ca.Description,
                        DailyPrice = ca.DailyPrice,
                        ModelYear = ca.ModelYear,
                        ModelName = mo.ModelName
                        
                        
                    };
                return result.ToList();
            }
        }
    }
}
