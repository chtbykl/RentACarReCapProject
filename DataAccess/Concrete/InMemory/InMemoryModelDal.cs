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
    public class InMemoryModelDal : IModelDal
    {
        List<Model> _models;
        public InMemoryModelDal()
        {
            _models = new List<Model>()
            {
                new Model(){ModelId = 1, Name = "E series"},
                new Model(){ModelId = 2, Name = "6 series"},
                new Model(){ModelId = 3, Name = "Egea"},
                new Model(){ModelId = 4, Name = "Focus"},
                new Model(){ModelId = 5, Name = "Golf"},
                new Model(){ModelId = 6, Name = "200"},
            };
        }
        public void Add(Model entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Model entity)
        {
            throw new NotImplementedException();
        }

        public Model Get(Expression<Func<Model, bool>> filter)
        {
            throw new NotImplementedException();
        }

     

        public List<Model> GetAll(Expression<Func<Model, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Model entity)
        {
            throw new NotImplementedException();
        }
    }
}
