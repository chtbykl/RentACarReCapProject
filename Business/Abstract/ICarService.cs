using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        void Add(Car entity);
        void Update(Car entity);
        void Delete(Car entity);
        List<VehicleDetailDto> GetVehicleDetails();
    }
}
