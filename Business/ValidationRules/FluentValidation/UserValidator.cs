using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.FirstName).MinimumLength(1);
            RuleFor(p => p.FirstName).MaximumLength(20);

            RuleFor(p => p.LastName).NotEmpty();
            RuleFor(p => p.LastName).MinimumLength(1);
            RuleFor(p => p.LastName).MaximumLength(10);

            RuleFor(p => p.Email).NotEmpty();
            RuleFor(p => p.Email).EmailAddress();
            RuleFor(p => p.Email).MinimumLength(1);
            RuleFor(p => p.Email).MaximumLength(30);
            RuleFor(p => p.Email).Must(Includethis)
                .WithMessage("Email adresi '@' karakterini içermeli.");

            RuleFor(p => p.Password).NotEmpty();
            RuleFor(p => p.Password).MinimumLength(6);
            RuleFor(p => p.Password).MaximumLength(20);
            
        }

        private bool Includethis(string arg)
        {
            return arg.Contains("@");
        }
    }
}
