using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Subscriptions.Models.Issuers.Validators
{
    public class IssuerRequestValidator : Validator<IssuerRequest>
    {
        public IssuerRequestValidator()
        {
            RuleFor(x => x.PlexoId).NotNull().WithMessage("El plexoId no puede ser vacío").NotEmpty().WithMessage("El plexoId no puede ser vacío");
            RuleFor(x => x.Name).NotNull().WithMessage("El nombre no puede ser vacío").NotEmpty().WithMessage("El nombre no puede ser vacío");
        }
    }
}
