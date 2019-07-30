using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Clients.Validators
{
    public class AddCommerceRequestValidator : Validator<AddCommerceRequest>
    {
        public AddCommerceRequestValidator()
        {
            RuleFor(x => x.CommerceName).NotNull().WithMessage("El nombre del comercio no puede ser vacío").NotEmpty().WithMessage("El nombre del comercio no puede ser vacío");
            RuleFor(x => x.CommerceNumber).NotNull().WithMessage("El número de comercio no puede ser vacío").NotEmpty().WithMessage("El número de comercio no puede ser vacío");
            RuleFor(x => x.IssuerId).NotNull().WithMessage("El IssuerId no puede ser vacío").NotEmpty().WithMessage("El IssuerId no puede ser vacío");
        }
    }
}
