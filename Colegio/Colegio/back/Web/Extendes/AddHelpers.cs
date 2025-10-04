using FluentValidation;
using FluentValidation.AspNetCore;
using Utilities.Helpers.Validations;
using Utilities.Helpers.Validations.Card;
using Utilities.Helpers.Validations.implemets;

namespace Web.Extendes
{
    public static class AddHelpers
    {
        public static IServiceCollection AddHelpersValidation(this IServiceCollection services)
        {
            services.AddScoped<IGenericHerlpers, GenericHelpers>();
            services.AddValidatorsFromAssemblyContaining<AsignaturaValidation>();
            services.AddFluentValidationAutoValidation();

            return services;

        }
    }
}
