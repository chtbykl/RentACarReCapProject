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
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;
        public InMemoryBrandDal()
        {
            _brands = new List<Brand>()
            {
                new Brand{Id = 1, Name = "BMW"},
                new Brand{Id = 2, Name = "Ford"},
                new Brand{Id = 3, Name = "Mercedes-Benz"},
                new Brand{Id = 4, Name = "Renault"},
                new Brand{Id = 5, Name = "Mithsubishi"},
                new Brand{Id = 6, Name = "Toyota"},
                new Brand{Id = 7, Name = "Fiat"},
                new Brand{Id = 8, Name = "Massey Ferguson"},
                new Brand{Id = 9, Name = "Jhon Deer"},
            };
        }
        public void Add(Brand entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Brand entity)
        {
            throw new NotImplementedException();
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }


        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Brand entity)
        {
            throw new NotImplementedException();
        }
    }
}
