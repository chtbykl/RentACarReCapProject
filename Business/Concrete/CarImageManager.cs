using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        private readonly ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(CarImage carImage)
        {
            var businessRule = BusinessRules.Run(
                CheckIfMaxCarImageCount(carImage.CarId)
                );

            if (businessRule != null)
            {
                return businessRule;
            }
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.CarImageAdded);

        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(), "araç resimlerinin tümü listelendi");
        }


        public IDataResult<List<CarImage>> GetByCarId(int carId)
        {
            var businessRule = BusinessRules.Run(
               CheckIfAnyImageOfCar(carId)
               );

            if (businessRule != null)
            {
                return new ErrorDataResult<List<CarImage>>(GetDefaultImage(carId).Data ,businessRule.Message);
            }

            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(p => p.CarId == carId), "araç resmi listelendi");
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Delete(CarImage carImage)
        {
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.CarImageDeleted);
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Update(CarImage carImage)
        {
            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.CarImageUpdated);
        }

        private IResult CheckIfMaxCarImageCount(int carId)
        {
            var result = _carImageDal.GetAll(p => p.CarId == carId);
            if (result.Count > 5)
            {
                return new ErrorResult(Messages.MaxCarImageCount);
            }
            return new SuccessResult();
        }
        private IResult CheckIfAnyImageOfCar(int id)
        {
            var result = _carImageDal.GetAll(p => p.CarId == id);
            if (!result.Any())
            {
                return new ErrorResult(Messages.NoCarImage);

            }
            return new SuccessResult();
        }

        private IDataResult<List<CarImage>> GetDefaultImage(int carId)
        {
            var defaultImages = new List<CarImage>() {
                new CarImage() {Id = 0 ,CarId = carId, AddDate = DateTime.Now, ImagePath = "DefaulImagePath.jpg"}
            };
            return new SuccessDataResult<List<CarImage>>(defaultImages);
        }
    }
}
