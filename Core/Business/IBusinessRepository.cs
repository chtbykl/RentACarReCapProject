using Core.Entities;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business
{
    public interface IBusinessRepository<TEntity> 
        where TEntity : class,IEntity,new()
    {
        IDataResult<List<TEntity>> GetAll();
        IResult Add(TEntity entity);
        IResult Update(TEntity entity);
        IResult Delete(TEntity entity);
    }
}
