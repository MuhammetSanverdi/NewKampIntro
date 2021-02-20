using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidation : AbstractValidator<Color>
    {
        public ColorValidation()
        {
            RuleFor(c => c.ColorName).MinimumLength(2);
        }
    }
}
