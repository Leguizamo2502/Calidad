using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation.Internal;
using System.Reflection;


namespace Utilities.Helpers.Validations.implemets
{
    public class GenericHelpers : IGenericHerlpers
    {
            private readonly IServiceProvider _provider;

            public GenericHelpers(IServiceProvider provider)
            {
                _provider = provider;
            }

            public Task<ValidationResult> Validate<T>(T dto, bool validateAllProperties = true)
            {
                var validator = _provider.GetService<IValidator<T>>();
                if (validator == null)
                    throw new Exception($"No se encontró un validador para {typeof(T).Name}");

                ValidationContext<T> context;

                if (validateAllProperties)
                {
                    // ✅ Validación completa: no pasamos selector
                    context = new ValidationContext<T>(dto);
                }
                else
                {
                    // ✅ Validación parcial: solo propiedades no nulas
                    var nonNullProps = GetNonNullPropertyNames(dto);
                    var selector = new MemberNameValidatorSelector(nonNullProps);
                    context = new ValidationContext<T>(dto, new PropertyChain(), selector);
                }

                return validator.ValidateAsync(context);
            }

            private IEnumerable<string> GetNonNullPropertyNames<T>(T instance)
            {
                return typeof(T)
                    .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                    .Where(p => p.CanRead && p.GetValue(instance) != null)
                    .Select(p => p.Name);
            }
        


    }
}
