using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidator:AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MinimumLength(1);
            RuleFor(p => p.Name).MaximumLength(10);

            RuleFor(p => p.ColorCode).NotEmpty();
            RuleFor(p => p.ColorCode).Must(StartWith)
                .WithMessage("Renk kodları '#' ile başlamalı, örneğin: '#5f5f5f'.");
            RuleFor(p => p.ColorCode).MinimumLength(1);
            RuleFor(p => p.ColorCode).MaximumLength(10);

        }

        private bool StartWith(string arg)
        {
            return arg.StartsWith("#");
        }
    }
}
