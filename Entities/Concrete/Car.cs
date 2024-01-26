using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car:Vehicle, IEntity
    {
        public int FuelTypeId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }

        
    }
}
