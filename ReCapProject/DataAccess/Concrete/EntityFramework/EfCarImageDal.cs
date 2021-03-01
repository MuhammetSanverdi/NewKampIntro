using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage, ReCapProjectDemoDatabaseContext>, ICarImageDal
    {
        public bool IsExit(int id)
        {
            using (ReCapProjectDemoDatabaseContext context = new ReCapProjectDemoDatabaseContext())
            {
                return context.CarImages.Any(c => c.Id == id);
            }
        }
    }
}
