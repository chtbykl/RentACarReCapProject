using Core.Utilities.Results;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IVehicleService
    {
        IDataResult<List<Vehicle>> GetAll();
        IResult Add(Vehicle entity);
        IResult Update(Vehicle entity);
        IResult Delete(Vehicle entity);
    }
}
