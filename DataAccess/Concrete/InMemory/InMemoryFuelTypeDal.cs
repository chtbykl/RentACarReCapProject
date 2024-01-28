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
    public class InMemoryFuelTypeDal : IFuelTypeDal
    {
        List<FuelType> _fuelTypes;
        public InMemoryFuelTypeDal()
        {
            _fuelTypes = new List<FuelType>
            {
                new FuelType{FuelTypeId = 1, Name = "Gasoline"},
                new FuelType{FuelTypeId = 2, Name = "Diesel"},
                new FuelType{FuelTypeId = 3, Name = "LPG"},
                new FuelType{FuelTypeId = 4, Name = "Hybrid"},
                new FuelType{FuelTypeId = 5, Name = "Electric"}
            };
        }
        public void Add(FuelType entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(FuelType entity)
        {
            throw new NotImplementedException();
        }

        public FuelType Get(Expression<Func<FuelType, bool>> filter)
        {
            throw new NotImplementedException();
        }

   

        public List<FuelType> GetAll(Expression<Func<FuelType, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(FuelType entity)
        {
            throw new NotImplementedException();
        }
    }
}
