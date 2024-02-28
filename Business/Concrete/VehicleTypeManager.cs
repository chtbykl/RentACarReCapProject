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
    public class VehicleTypeManager : IVehicleTypeService
    {
        private IVehicleTypeDal _vehicleTypeDal;

        public VehicleTypeManager(IVehicleTypeDal vehicleTypeDal)
        {
            _vehicleTypeDal = vehicleTypeDal;
        }

        [ValidationAspect(typeof(VehicleTypeValidator))]
        public IResult Add(VehicleType entity)
        {
            _vehicleTypeDal.Add(entity);
            return new SuccessResult(Messages.VehicleTypeAdded);
        }

        [ValidationAspect(typeof(VehicleTypeValidator))]
        public IResult Delete(VehicleType entity)
        {
            _vehicleTypeDal.Delete(entity);
            return new SuccessResult(Messages.VehicleTypeDeleted);
        }

        public IDataResult<List<VehicleType>> GetAll()
        {
            return new SuccessDataResult<List<VehicleType>>(_vehicleTypeDal.GetAll(),Messages.VehicleTypesListed);
        }

        [ValidationAspect(typeof(VehicleTypeValidator))]
        public IResult Update(VehicleType entity)
        {
            _vehicleTypeDal.Update(entity);
            return new SuccessResult(Messages.VehicleTypeUpdated);
        }
    }
}
