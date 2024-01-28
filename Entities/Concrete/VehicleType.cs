using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class VehicleType : IEntity
    {
        public int VehicleTypeId { get; set; }
        public string Name { get; set; }
    }
}
