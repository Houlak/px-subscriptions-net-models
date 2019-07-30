using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Clients.Validators
{
    public class ClientAdminValidator : Validator<ClientAdmin>
    {
        public ClientAdminValidator()
        {
            RuleFor(x => x.ClientId).NotNull().WithMessage("El id del cliente no puede ser vacío");
            RuleFor(x => x.UserName).NotNull().WithMessage("El username no puede ser vacío").NotEmpty().WithMessage("El username no puede ser vacío");
            RuleFor(x => x.UserId).NotNull().WithMessage("El userId no puede ser vacío").NotEmpty().WithMessage("El userId no puede ser vacío");
        }
    }
}
