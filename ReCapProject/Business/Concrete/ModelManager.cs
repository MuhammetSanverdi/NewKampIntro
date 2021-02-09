using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Business.Concrete
{
    public class ModelManager:IModelService
    {
        IModelDal _modelDal;

        public ModelManager(IModelDal modelDal)
        {
            _modelDal = modelDal;
        }
        public List<Model> GetAll()
        {
            return _modelDal.GetAll();
        }

        public List<Model> GetByBrandId(int id)
        {
            return _modelDal.GetAll(m => m.BrandId == id);
        }

        public void Add(Model model)
        {
            if (model.ModelName.Length > 2)
            {
                _modelDal.Add(model);
            }
            else
            {
                Console.WriteLine("Model adı en az iki olmalıdır.");
            }
        }

        public void Update(Model model)
        {
            _modelDal.Update(model);
        }

        public void Delete(Model model)
        {
            _modelDal.Delete(model);
        }
    }
}
