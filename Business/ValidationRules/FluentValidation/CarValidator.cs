using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.DailyPrice).NotEmpty();
            RuleFor(p => p.Description).NotEmpty();
            RuleFor(p => p.Description).Must(StartWithW).WithMessage("Description A ile Başlamalı");
            RuleFor(p => p.DailyPrice).GreaterThanOrEqualTo(100);
        }

        private bool StartWithW(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
