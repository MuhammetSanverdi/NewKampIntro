using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IModelService
    {
        IDataResult<List<Model>> GetAll();
        IDataResult<List<Model>> GetByBrandId(int id);
        IResult Add(Model model);
        IResult Update(Model model);
        IResult Delete(Model model);
    }
}
