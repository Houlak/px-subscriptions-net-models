using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Clients.Validators
{
    public class UpdateClientRequestValidator : Validator<UpdateClientRequest>
    {
        public UpdateClientRequestValidator()
        {
            RuleFor(x => x.ClientName).NotNull().WithMessage("El nombre del cliente no puede ser vacío").NotEmpty().WithMessage("El nombre del cliente no puede ser vacío");
            RuleFor(x => x.ClientSecret).NotNull().WithMessage("El client secret no puede ser vacío").NotEmpty().WithMessage("El client secret no puede ser vacío");
        }
    }
}
