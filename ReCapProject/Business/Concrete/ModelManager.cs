using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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
        public IDataResult<List<Model>> GetAll()
        {
            return new SuccessDataResult<List<Model>>(_modelDal.GetAll(),Messages.ModelsListed);
        }

        public IDataResult<List<Model>> GetByBrandId(int id)
        {
            return new SuccessDataResult<List<Model>>(_modelDal.GetAll(m => m.BrandId == id));
        }

        public IResult Add(Model model)
        {
            if (model.ModelName.Length > 2)
            {
                _modelDal.Add(model);
                return new SuccessResult(Messages.ModelAdded);
            }
            else
            {
                return new SuccessResult(Messages.ModelNameInvalid);
            }
        }

        public IResult Update(Model model)
        {
            _modelDal.Update(model);
            return new SuccessResult(Messages.ModelUpdated);
        }

        public IResult Delete(Model model)
        {
            _modelDal.Delete(model);
            return new SuccessResult(Messages.ModelDeleted);
        }
    }
}
