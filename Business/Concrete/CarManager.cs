using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
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
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public IResult Add(Car entity)
        {
            _carDal.Add(entity);
            return new SuccessResult("araç eklendi");
        }

        public IResult Delete(Car entity)
        {
            _carDal.Delete(entity);
            return new SuccessResult("Araç silindi");
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),"araçlar listelendi");
        }

        public IDataResult<List<VehicleDetailDto>> GetVehicleDetails()
        {
            return new SuccessDataResult<List<VehicleDetailDto>>(_carDal.GetVehicleDetails(),"araçlar detaylarıyla birlikte listelendi");
        }

        public IResult Update(Car entity)
        {
            _carDal.Update(entity);
            return new SuccessResult("araç güncellendi");
        }
    }
}
