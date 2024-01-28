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
        List<VehicleType> GetAll();
        void Add(VehicleType entity);
        void Update(VehicleType entity);
        void Delete(VehicleType entity);
    }
}
