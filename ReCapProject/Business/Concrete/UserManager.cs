using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager:IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<List<User>> GetByUserId(int id)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(u=>u.UserId==id));
        }

        public IResult Add(User user)
        {
            if (user.FirstName.Length>=2 && user.LastName.Length >= 2 && user.Password.Length >= 6)
            {
                _userDal.Add(user);
                return new SuccessResult();
            }
            else
            {
                return new ErrorResult();
            }
            
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult();
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult();
        }
    }
}
