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
            RuleFor(x => x.Frequence).NotNull().WithMessage("La frecuencia no puede ser vacía");
            RuleFor(x => x.SubscriptionCost).NotNull().WithMessage("El costo no puede ser vacío").GreaterThanOrEqualTo(0).WithMessage("El costo no puede ser negativo");
            RuleFor(x => x.Currency).NotNull().WithMessage("Se debe asignar una moneda").Must(c => c == Payments.Currency.UruguayanPeso || c == Payments.Currency.Dolar);
        }
    }
}
