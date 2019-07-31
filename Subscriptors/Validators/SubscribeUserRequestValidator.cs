using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Subscriptors.Validators
{
    public class SubscribeUserRequestValidator : Validator<SubscribeUserRequest>
    {
        public SubscribeUserRequestValidator()
        {
            RuleFor(x => x.ExternalId).NotNull().WithMessage("El consumidor debe tener un externalId").NotEmpty().WithMessage("El consumidor debe tener un externalId");
            RuleFor(x => x.InstrumentId).NotNull().WithMessage("La request debe tener un instrumento de pago asociado").NotEmpty().WithMessage("La request debe tener un instrumento de pago asociado");
            RuleFor(x => x.SubscriptionTypeId).NotNull().WithMessage("La request debe tener un tipo de subscipción asociado").NotEmpty().WithMessage("La request debe tener un tipo de subscipción asociado");
        }
    }
}
