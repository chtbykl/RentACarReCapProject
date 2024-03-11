
using Core.Entities;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car:Vehicle
    {
        
        public int FuelTypeId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }

        
    }
}
