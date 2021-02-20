using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidation:AbstractValidator<Customer>
    {
        public CustomerValidation()
        {
            RuleFor(c => c.CompanyName).MinimumLength(2);
            RuleFor(c => c.UserId).GreaterThan(0);

        }
    }
}
