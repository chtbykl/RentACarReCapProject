using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator: AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.ModelYear).GreaterThanOrEqualTo(1700);
            RuleFor(p => p.ModelYear).NotEmpty();

            RuleFor(p => p.Description).MaximumLength(50);
   
            RuleFor(p => p.DailyPrice).GreaterThanOrEqualTo(100);
            RuleFor(p => p.DailyPrice).NotEmpty();

            RuleFor(p => p.VehicleTypeId).NotEmpty();

            RuleFor(p => p.FuelTypeId).NotEmpty();

            RuleFor(p => p.ModelId).NotEmpty();

            RuleFor(p => p.ColorId).NotEmpty();

            

        }
    }
}
