using Core.DataAccess;
using Core.Entities;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business
{
    public class BusinessRepository<TEntity, TDal> : IBusinessRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TDal : class, IEntityRepository<TEntity>, new()
    {
        public IResult Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<TEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
