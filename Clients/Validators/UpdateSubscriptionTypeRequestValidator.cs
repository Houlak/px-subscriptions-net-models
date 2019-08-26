using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Clients.Validators
{
    public class UpdateSubscriptionTypeRequestValidator : Validator<UpdateSubscriptionTypeRequest>
    {
        public UpdateSubscriptionTypeRequestValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("El nombre no puede ser vacío").NotEmpty().WithMessage("El nombre no puede ser vacío");
            RuleFor(x => x.SubscriptionCost).NotNull().WithMessage("El costo no puede ser vacío").GreaterThanOrEqualTo(0).WithMessage("El costo no puede ser negativo");
        }
    }
}
