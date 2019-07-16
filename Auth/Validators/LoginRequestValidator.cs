
using FluentValidation;

namespace Goova.Suscriptions.Models.Validators
{
    public class LoginRequestValidator : Validator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.UserName).NotNull().WithMessage("El email no puede ser vacío");
            RuleFor(x => x.Password).NotEmpty().WithMessage("La contraseña no puede ser vacía");
        }
    }
}
