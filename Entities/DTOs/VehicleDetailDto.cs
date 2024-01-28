using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class VehicleDetailDto:IDto
    {
        public int VehicleId { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string VehicleTypeName { get; set; }
        public string FuelTypeName { get; set; }
        public string ColorName { get; set; }
        public string ColorCode { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
