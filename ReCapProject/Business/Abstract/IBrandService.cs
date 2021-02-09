using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        List<Brand> GetById(int Id);
        void Add(Brand brand);
        void Delete(Brand brand);
        void Update(Brand brand);
    }
}
