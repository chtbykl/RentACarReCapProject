using Business.Abstract;
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

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental entity)
        {
            if (_rentalDal.Get(r => r.CarId == entity.CarId) != null)
            {
                if (_rentalDal.Get(r => r.CarId == entity.CarId).ReturnDate == null)
                {
                    return new ErrorResult("araç zaten kiralanmış, başka bir araç deneyin");
                }

            }

            _rentalDal.Add(entity);
            return new SuccessResult("yeni kiralanmış araç eklendi");

        }

        public IResult Delete(Rental entity)
        {
            _rentalDal.Delete(entity);
            return new SuccessResult("kiralanmış araç silindi");
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), "kiralanmış araçlar listelendi");
        }

        public IResult Update(Rental entity)
        {
            _rentalDal.Update(entity);
            return new SuccessResult("kiralanmış araç güncellendi");
        }
    }
}
