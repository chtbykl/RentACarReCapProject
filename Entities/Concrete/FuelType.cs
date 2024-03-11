using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class FuelType : Entity
    {
        public int FuelTypeId { get; set; }
        public string Name { get; set; }
    }
}
