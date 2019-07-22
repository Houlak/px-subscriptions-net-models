using FluentValidation;

namespace Goova.Subscriptions.Models.Validators
{
    public class ChangePasswordValidator : Validator<ChangePasswordRequest>
    {
        public ChangePasswordValidator()
        {
            //RuleFor(x => x.Email).EmailAddress().WithMessage("El email no es válido").NotNull().WithMessage("El email no puede ser vacío");
            RuleFor(x => x.OldPassword).NotNull().WithMessage("La contraseña no puede ser vacía").MinimumLength(6).WithMessage("La contraseña debe tener al menos 6 caracteres");
            RuleFor(x => x.NewPassword).NotNull().WithMessage("La contraseña no puede ser vacía").MinimumLength(6).WithMessage("La contraseña debe tener al menos 6 caracteres");
        }
    }
}
