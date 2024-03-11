using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public abstract class Vehicle : Entity
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public int VehicleTypeId { get; set; }
        public int ColorId { get; set; }
        public string Description { get; set; }


    }
}
