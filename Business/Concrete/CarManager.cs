using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _carDal;
        
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
            
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car entity)
        {
            var businessRule = BusinessRules.Run(

                );
            if (businessRule != null)
            {
                return businessRule;
            }
            _carDal.Add(entity);
            return new SuccessResult(Messages.CarAdded);
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Delete(Car entity)
        {
            _carDal.Delete(entity);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarsListed);
        }

        public IDataResult<Car> GetById(int Id)
        {
            var businessRule = BusinessRules.Run(
                CheckHaveTheVehicle(Id)
                );
            if (businessRule != null)
            {
                return new ErrorDataResult<Car>(businessRule.Message);
            }
            return new SuccessDataResult<Car>(_carDal.Get(p => p.Id == Id),"Araç bulundu");
        }

        public IDataResult<List<VehicleDetailDto>> GetVehicleDetails()
        {
            return new SuccessDataResult<List<VehicleDetailDto>>(_carDal.GetVehicleDetails(),Messages.CarsListedWithDetails);
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Update(Car entity)
        {
            _carDal.Update(entity);
            return new SuccessResult(Messages.CarUpdated);
        }
        private IDataResult<Car> CheckHaveTheVehicle(int carId)
        {
            if (_carDal.Get(p=>p.Id == carId) == null)
            {
                return new ErrorDataResult<Car>(Messages.NoCar);
            }
            return new SuccessDataResult<Car>();
        }

    }
}
