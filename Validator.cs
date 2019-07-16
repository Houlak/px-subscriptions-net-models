using FluentValidation;
using Goova.Subscriptions.Models.Error;
using System.Linq;

namespace Goova.Subscriptions.Models
{
    public class Validator<T> : AbstractValidator<T>
    {
        protected Validator()
        {
        }

        protected Validator(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        private string ErrorMessage { get; set; }

        public ModelValidationResult Valid(T instance)
        {
            if (Equals(instance, default(T)))
            {
                return new ModelValidationResult
                {
                    Data = new ErrorResponse
                    {
                        Message = ErrorMessage,
                        Code = System.Net.HttpStatusCode.BadRequest,
                        SubCode = ErrorSubCode.ArgumentError,
                        Type = "Model validation error"
                    },
                    Success = false
                };
            }

            var result = Validate(instance);

            if (result.IsValid)
            {
                return new ModelValidationResult
                {
                    Success = true
                };
            }

            ErrorMessage = ErrorMessage ?? string.Join(" ", result.Errors.Select(x => x.ErrorMessage));

            return new ModelValidationResult
            {
                Data = new ErrorResponse
                {
                    Message = ErrorMessage,
                    Code = System.Net.HttpStatusCode.BadRequest,
                    SubCode = ErrorSubCode.ArgumentError,
                    Type = "Model validation error"
                },
                Success = false
            };
        }
    }

    public class ModelValidationResult
    {
        public object Data { get; set; }
        public bool Success { get; set; }
    }
}
