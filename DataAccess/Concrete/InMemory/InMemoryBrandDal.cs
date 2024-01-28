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
                new Brand{BrandId = 1, Name = "BMW"},
                new Brand{BrandId = 2, Name = "Ford"},
                new Brand{BrandId = 3, Name = "Mercedes-Benz"},
                new Brand{BrandId = 4, Name = "Renault"},
                new Brand{BrandId = 5, Name = "Mithsubishi"},
                new Brand{BrandId = 6, Name = "Toyota"},
                new Brand{BrandId = 7, Name = "Fiat"},
                new Brand{BrandId = 8, Name = "Massey Ferguson"},
                new Brand{BrandId = 9, Name = "Jhon Deer"},
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
