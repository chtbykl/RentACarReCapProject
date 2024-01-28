using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryVehicleTypeDal : IVehicleTypeDal
    {
        List<VehicleType> _vehicleTypes;
        public InMemoryVehicleTypeDal()
        {
            _vehicleTypes = new List<VehicleType>()
            {
                new VehicleType() {VehicleTypeId = 1, Name = "Micro"},
                new VehicleType() {VehicleTypeId = 2, Name = "Sedan"},
                new VehicleType() {VehicleTypeId = 3, Name = "Hatcback"},
                new VehicleType() {VehicleTypeId = 4, Name = "Universal"},
                new VehicleType() {VehicleTypeId = 5, Name = "Liftback"},
                new VehicleType() {VehicleTypeId = 6, Name = "Coupe"},
                new VehicleType() {VehicleTypeId = 7, Name = "Cabriolet"},
                new VehicleType() {VehicleTypeId = 8, Name = "Roadster"},
                new VehicleType() {VehicleTypeId = 9, Name = "Targa"},
                new VehicleType() {VehicleTypeId = 10, Name = "Limousine"},
                new VehicleType() {VehicleTypeId = 11, Name = "Muscle Car"},
                new VehicleType() {VehicleTypeId = 12, Name = "Sport Car"},
                new VehicleType() {VehicleTypeId = 13, Name = "Super Car"},
                new VehicleType() {VehicleTypeId = 14, Name = "SUV"},
                new VehicleType() {VehicleTypeId = 15, Name = "Crossover"},
                new VehicleType() {VehicleTypeId = 16, Name = "Pickup"},
                new VehicleType() {VehicleTypeId = 17, Name = "Van"},
                new VehicleType() {VehicleTypeId = 18, Name = "Minivan"},
                new VehicleType() {VehicleTypeId = 19, Name = "Minibus"},
                new VehicleType() {VehicleTypeId = 20, Name = "Bus"},
                new VehicleType() {VehicleTypeId = 21, Name = "Campervan"},
            };
        }
        public void Add(VehicleType entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(VehicleType entity)
        {
            throw new NotImplementedException();
        }

        public VehicleType Get(Expression<Func<VehicleType, bool>> filter)
        {
            throw new NotImplementedException();
        }

      

        public List<VehicleType> GetAll(Expression<Func<VehicleType, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(VehicleType entity)
        {
            throw new NotImplementedException();
        }
    }
}
