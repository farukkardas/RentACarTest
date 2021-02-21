using DataAccess.Concrete;
using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{

    class ColorValidator : AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(p => p.ColorName).NotEmpty();
            RuleFor(p => p.ColorName).MinimumLength(2);
            RuleFor(p => p.ColorName).Must(IsUnique).WithMessage("Bu renk mevcut!");
        }

        private bool IsUnique(string arg)
        {
            CarRentContext context = new CarRentContext();

            var result = context.Colors.Where(p => p.ColorName.ToLower() == arg.ToLower()).SingleOrDefault();

            if (result == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
