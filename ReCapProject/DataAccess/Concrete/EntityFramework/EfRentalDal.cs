using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal:EfEntityRepositoryBase<Rental,ReCapProjectDemoDatabaseContext>,IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (ReCapProjectDemoDatabaseContext context = new ReCapProjectDemoDatabaseContext())
            {
                var result = from rent in filter ==null ? context.Rentals : context.Rentals.Where(filter)
                    join cu in context.Customers
                        on rent.CustomerId equals cu.CustomerId
                    join ca in context.Cars
                        on rent.CarId equals ca.CarId
                    join user in context.Users
                        on cu.UserId equals user.UserId
                    join mo in context.Models
                        on ca.ModelId equals mo.ModelId
                    join br in context.Brands
                        on ca.BrandId equals br.BrandId 
                    select new RentalDetailDto
                    { 
                        CarBrand = br.BrandName,
                        CarModel = mo.ModelName,
                        UserName = user.FirstName+" "+ user.LastName,
                        RentDate = rent.RentDate,
                        ReturnDate = rent.ReturnDate
                    };
                return result.ToList();
            }
        }

        
    }
}
