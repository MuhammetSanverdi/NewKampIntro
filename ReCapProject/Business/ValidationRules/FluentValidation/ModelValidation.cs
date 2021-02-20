using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ModelValidation:AbstractValidator<Model>
    {
        public ModelValidation()
        {
            RuleFor(m => m.ModelName).MinimumLength(2);
            RuleFor(m => m.BrandId).GreaterThan(0);
        }
    }
}
