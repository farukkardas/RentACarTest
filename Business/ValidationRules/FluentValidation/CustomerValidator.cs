using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(p => p.CustomerName).NotEmpty();
            RuleFor(p => p.CustomerName).MinimumLength(2);
            RuleFor(p => p.CustomerName).MaximumLength(50);
            RuleFor(p => p.UserId).NotEmpty();
        }
    }
}
