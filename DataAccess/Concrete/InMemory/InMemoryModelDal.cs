using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Model(){Id = 1, Name = "E series"},
                new Model(){Id = 2, Name = "6 series"},
                new Model(){Id = 3, Name = "Egea"},
                new Model(){Id = 4, Name = "Focus"},
                new Model(){Id = 5, Name = "Golf"},
                new Model(){Id = 6, Name = "200"},
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

        public List<Model> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Model entity)
        {
            throw new NotImplementedException();
        }
    }
}
