using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Clients.Validators
{
    public class AddSubscriptionTypeRequestValidator : Validator<AddSubscriptionTypeRequest>
    {
        public AddSubscriptionTypeRequestValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("El nombre no puede ser vacío").NotEmpty().WithMessage("El nombre no puede ser vacío");
            RuleFor(x => x.Frequence).NotNull().WithMessage("La frecuencia no puede ser vacía").GreaterThan(0).WithMessage("La frecuencia debe ser mayor a 0").LessThanOrEqualTo(365).WithMessage("La frecuencia debe ser a lo sumo 1 año (365 días)");
            RuleFor(x => x.SubscriptionCost).NotNull().WithMessage("El costo no puede ser vacío").GreaterThanOrEqualTo(1).WithMessage("El costo no puede ser negativo");
        }
    }
}
