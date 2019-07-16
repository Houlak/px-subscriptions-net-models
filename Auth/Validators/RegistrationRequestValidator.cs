﻿using FluentValidation;
using System;

namespace Goova.Canal10.Models.Validators
{
    public class RegistrationRequestValidator : Validator<RegistrationRequest>
    {
        public RegistrationRequestValidator()
        {
            RuleFor(x => x.UserName).NotNull().WithMessage("El username no puede ser vacío");
            RuleFor(x => x.Password).NotNull().WithMessage("La contraseña no puede ser vacía");
        }
    }
}
