using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Entities;
using Core.Utilities.Business;
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
    public class RentalManager : IRentalService
    {
        private IRentalDal _rentalDal;
        private readonly ICarService _carService;

        public RentalManager(IRentalDal rentalDal, ICarService carService)
        {
            _rentalDal = rentalDal;
            _carService = carService;

        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental entity)
        {
            var businessRule = BusinessRules.Run(
                IsVehicleRented(entity.CarId),
                CheckHaveTheVehicle(entity.CarId)
                );
            if (businessRule != null)
            {
                return businessRule;
            }
            _rentalDal.Add(entity);
            return new SuccessResult("yeni kiralanmış araç eklendi");

        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Delete(Rental entity)
        {
            _rentalDal.Delete(entity);
            return new SuccessResult("kiralanmış araç silindi");
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), "kiralanmış araçlar listelendi");
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Update(Rental entity)
        {
            var businessRule = BusinessRules.Run(
                CheckHaveTheVehicle(entity.CarId)
                );
            if (businessRule != null)
            {
                return businessRule;
            }
            _rentalDal.Update(entity);
            return new SuccessResult("kiralanmış araç güncellendi");
        }

        private IResult IsVehicleRented(int carId)
        {
            if (_rentalDal.Get(r => r.CarId == carId) != null)
            {
                if (_rentalDal.Get(r => r.CarId == carId).ReturnDate == null)
                {
                    return new ErrorResult("araç zaten kiralanmış, başka bir araç deneyin");
                }

            }
            return new SuccessResult();
        }

        private IResult CheckHaveTheVehicle(int carId)
        {
            if (_carService.GetById(carId).Data == null)
            {
                return new ErrorResult(Messages.NoCar);
            }
            return new SuccessResult();
        }
    }
}
