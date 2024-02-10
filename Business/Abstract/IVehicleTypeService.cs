using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IVehicleTypeService
    {
        IDataResult<List<VehicleType>> GetAll();
        IResult Add(VehicleType entity);
        IResult Update(VehicleType entity);
        IResult Delete(VehicleType entity);
    }
}
