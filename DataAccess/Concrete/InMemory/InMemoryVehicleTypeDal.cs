using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new VehicleType() {Id = 1, Name = "Micro"},
                new VehicleType() {Id = 2, Name = "Sedan"},
                new VehicleType() {Id = 3, Name = "Hatcback"},
                new VehicleType() {Id = 4, Name = "Universal"},
                new VehicleType() {Id = 5, Name = "Liftback"},
                new VehicleType() {Id = 6, Name = "Coupe"},
                new VehicleType() {Id = 7, Name = "Cabriolet"},
                new VehicleType() {Id = 8, Name = "Roadster"},
                new VehicleType() {Id = 9, Name = "Targa"},
                new VehicleType() {Id = 10, Name = "Limousine"},
                new VehicleType() {Id = 11, Name = "Muscle Car"},
                new VehicleType() {Id = 12, Name = "Sport Car"},
                new VehicleType() {Id = 13, Name = "Super Car"},
                new VehicleType() {Id = 14, Name = "SUV"},
                new VehicleType() {Id = 15, Name = "Crossover"},
                new VehicleType() {Id = 16, Name = "Pickup"},
                new VehicleType() {Id = 17, Name = "Van"},
                new VehicleType() {Id = 18, Name = "Minivan"},
                new VehicleType() {Id = 19, Name = "Minibus"},
                new VehicleType() {Id = 20, Name = "Bus"},
                new VehicleType() {Id = 21, Name = "Campervan"},
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

        public List<VehicleType> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(VehicleType entity)
        {
            throw new NotImplementedException();
        }
    }
}
