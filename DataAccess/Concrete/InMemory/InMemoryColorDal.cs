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
    public class InMemoryColorDal : IColorDal
    {
        List<Color> _colors;
        public InMemoryColorDal()
        {
            _colors = new List<Color>()
            {
                new Color{ColorId = 1 , Name = "Blue", ColorCode = "#0a32ff"},
                new Color{ColorId = 2 , Name = "Red", ColorCode = "#ff0a0a"},
                new Color{ColorId = 3 , Name = "Green", ColorCode = "#2aff0a"},
                new Color{ColorId = 4 , Name = "Yellow", ColorCode = "#ffee0a"},
                new Color{ColorId = 5 , Name = "White", ColorCode = "#ffffff"},
                new Color{ColorId = 6 , Name = "Black", ColorCode = "#000000"},
            };
        }
        public void Add(Color entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Color entity)
        {
            throw new NotImplementedException();
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            throw new NotImplementedException();
        }

    

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Color entity)
        {
            throw new NotImplementedException();
        }
    }
}
