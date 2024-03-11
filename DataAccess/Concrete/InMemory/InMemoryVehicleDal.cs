using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryVehicleDal : IVehicleDal
    {
        List<Vehicle> _vehicles;
        public InMemoryVehicleDal()
        {
            _vehicles = new List<Vehicle>()
            {
                
            };
        }
        public void Add(Vehicle entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Vehicle entity)
        {
            throw new NotImplementedException();
        }

        public Vehicle Get(Expression<Func<Vehicle, bool>> filter)
        {
            throw new NotImplementedException();
        }

    

        public List<Vehicle> GetAll(Expression<Func<Vehicle, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Vehicle entity)
        {
            throw new NotImplementedException();
        }
    }
}
