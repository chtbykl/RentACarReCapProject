using Business.Abstract;
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
    public class ModelManager : IModelService
    {
        private IModelDal _modelDal;

        public ModelManager(IModelDal modelDal)
        {
            _modelDal = modelDal;
        }

        [ValidationAspect(typeof(ModelValidator))]
        public IResult Add(Model entity)
        {
            _modelDal.Add(entity);
            return new SuccessResult(Messages.ModelAdded);
        }

        [ValidationAspect(typeof(ModelValidator))]
        public IResult Delete(Model entity)
        {
            _modelDal?.Delete(entity);
            return new SuccessResult(Messages.ModelDeleted);
        }

        public IDataResult<List<Model>> GetAll()
        {
            return new SuccessDataResult<List<Model>>(_modelDal.GetAll(),Messages.CustomersListed);
        }

        [ValidationAspect(typeof(ModelValidator))]
        public IResult Update(Model entity)
        {
            _modelDal.Update(entity);
            return new SuccessResult(Messages.ModelUpdated);
        }
    }
}
