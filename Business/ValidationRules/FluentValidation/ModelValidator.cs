﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ModelValidator: AbstractValidator<Model>
    {
        public ModelValidator()
        {
            RuleFor(p => p.BrandId).NotEmpty();

            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MinimumLength(1);
            RuleFor(p => p.Name).MaximumLength(10);
        }
    }
}
