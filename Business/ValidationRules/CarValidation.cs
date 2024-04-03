using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class CarValidation : AbstractValidator<Car>
    {
        public CarValidation()
        {
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c => c.CarName).MinimumLength(2);
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.ModelYear).GreaterThanOrEqualTo(2010).When(c => c.BrandId == 1);
            //RuleFor(c => c.CarName).Must(StartsWithE);

           
        }
    }
}
