using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageValidation:AbstractValidator<CarImage>
    {
        public CarImageValidation()
        {
            RuleFor(c => c.CarId).NotNull();
        }
    }
}
