using FluentValidation.Results;

namespace Utilities.Helpers.Validations
{
    public interface IGenericHerlpers
    {
        Task<ValidationResult> Validate<T>(T dto, bool validateAllProperties = true);
    }
}
