﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetByUserId(int id);
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
    }
}
