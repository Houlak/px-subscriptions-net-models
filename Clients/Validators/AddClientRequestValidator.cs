using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Clients.Validators
{
    public class AddClientRequestValidator : Validator<AddClientRequest>
    {
        public AddClientRequestValidator()
        {
            RuleFor(x => x.AdminUserId).NotNull().WithMessage("El admin no puede ser vacío").NotEmpty().WithMessage("El admin no puede ser vacío");
            RuleFor(x => x.ClientName).NotNull().WithMessage("El nombre del cliente no puede ser vacío").NotEmpty().WithMessage("El nombre del cliente no puede ser vacío");
            RuleFor(x => x.ClientSecret).NotNull().WithMessage("El client secret no puede ser vacío").NotEmpty().WithMessage("El client secret no puede ser vacío");
            RuleFor(x => x.ClientLegalName).NotNull().WithMessage("El nombre legal del cliente no puede ser vacío").NotEmpty().WithMessage("El nombre legal del cliente no puede ser vacío");
            RuleFor(x => x.ClientRFC).NotNull().WithMessage("El RFC del cliente no puede ser vacío").NotEmpty().WithMessage("El RFC del cliente no puede ser vacío").Length(12,13).WithMessage("El RFC ingresado no es válido");
        }
    }
}
