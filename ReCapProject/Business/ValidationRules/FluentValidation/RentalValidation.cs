using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidation:AbstractValidator<Rental>
    {
        public RentalValidation()
        {
            RuleFor(r => r.RentDate).NotEmpty();
            RuleFor(r => r.CarId).GreaterThan(0);
            RuleFor(r => r.CustomerId).GreaterThan(0);
        }

    }
}
