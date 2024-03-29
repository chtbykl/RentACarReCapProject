﻿using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
       private IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(User entity)
        {
            _userDal.Add(entity);
            return new SuccessResult("kullanıcı eklendi");
        }

        [ValidationAspect(typeof(UserValidator))]
        public IResult Delete(User entity)
        {
            _userDal.Delete(entity);
            return new SuccessResult("kullanıcı silindi");
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(),"kullanıcılar listelendi");
        }

        [ValidationAspect(typeof(UserValidator))]
        public IResult Update(User entity)
        {
            _userDal.Update(entity);
            return new SuccessResult("kullanıcı güncellendi");
        }
    }
}
