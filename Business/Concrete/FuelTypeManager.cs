using Business.Abstract;
using Business.Constants;
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
    public class FuelTypeManager : IFuelTypeService
    {
        private IFuelTypeDal _fuelTypeDal;

        public FuelTypeManager(IFuelTypeDal fuelTypeDal)
        {
            _fuelTypeDal = fuelTypeDal;
        }

        public IResult Add(FuelType entity)
        {
            _fuelTypeDal.Add(entity);
            return new SuccessResult(Messages.FuelTypeAdded);
        }

        public IResult Delete(FuelType entity)
        {
            _fuelTypeDal.Delete(entity);
            return new SuccessResult(Messages.FuelTypeDeleted);
        }

        public IDataResult<List<FuelType>> GetAll()
        {
           return new SuccessDataResult<List<FuelType>>(_fuelTypeDal.GetAll(),Messages.FuelTypesListed);
        }

        public IResult Update(FuelType entity)
        {
            _fuelTypeDal.Update(entity);
            return new SuccessResult(Messages.FuelTypeUpdated);
        }
    }
}
