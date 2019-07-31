using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Subscriptors.Validators
{
    public class UserDataValidator : Validator<UserData>
    {
        public UserDataValidator()
        {
            RuleFor(x => x.ExternalId).NotNull().WithMessage("El consumidor debe tener un externalId").NotEmpty().WithMessage("El consumidor debe tener un externalId");
            RuleFor(x => x.Name).NotNull().WithMessage("El nombre del cliente no puede ser vacío").NotEmpty().WithMessage("El nombre del cliente no puede ser vacío");
            RuleFor(x => x.Email).EmailAddress().WithMessage("El email debe ser válido");
        }
    }
}
