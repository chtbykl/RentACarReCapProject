﻿using Business.Abstract;
using Business.Constants;
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
    public class BrandManager : IBrandService
    {
        private IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(Brand entity)
        {
            
            _brandDal.Add(entity);
            return new SuccessResult(Messages.BrandAdded);
        }

        [ValidationAspect(typeof(BrandValidator))]
        public IResult Delete(Brand entity)
        {
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.BrandsListed);
        }

        [ValidationAspect(typeof(BrandValidator))]
        public IResult Update(Brand entity)
        {
            return new SuccessResult(Messages.BrandUpdated);
        }

        
    }
}
