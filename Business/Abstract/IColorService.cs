using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        void Add(Color entity);
        void Update(Color entity);
        void Delete(Color entity);
    }
}
