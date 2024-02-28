using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Vehicle : IEntity
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public int VehicleTypeId { get; set; }
        public int ColorId { get; set; }
        public string Description { get; set; }


    }
}
