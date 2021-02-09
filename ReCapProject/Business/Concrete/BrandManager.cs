﻿using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager:IBrandService
    {
        IBrandDal _brandDal;
            public BrandManager(IBrandDal brandDal)
            {
                _brandDal = brandDal;
            }

            public List<Brand> GetById(int id)
            {
                return _brandDal.GetAll(b => b.BrandId == id);
            }

            public void Add(Brand brand)
            {
                _brandDal.Add(brand);
            }

            public void Delete(Brand brand)
            {
                _brandDal.Delete(brand);
            }

            public List<Brand> GetAll()
            {
                return _brandDal.GetAll();
            }

            public void Update(Brand brand)
            {
                _brandDal.Update(brand);
            }
        }
}
