using Business.Implements.Bases;
using Business.Implements.CQRS.Cards.Distribucion;
using Business.Implements.CQRS.Cards.Querys; // <-- importa tu Business concreto
using Business.Interfaces.Commands;
using Business.Interfaces.Distribution;
using Business.Interfaces.DistributionService;
using Business.Interfaces.Querys;
using Data.Implements.Commands;
using Data.Implements.CQRS.Card;
using Data.Implements.Pizza;
using Data.Implements.Querys;
using Data.Interfaces.Group.Commands;
using Data.Interfaces.Group.Querys;
using Entity.Model.Colegio;
using Utilities.Helpers.Validations;
using Utilities.Helpers.Validations.implemets;

namespace Web.Extendes
{
    public static class AddInjectController
    {
        public static IServiceCollection AddInject(this IServiceCollection services)
        {
            // Data genérico
            services.AddScoped(
                  typeof(IQuerys<>),
                  typeof(BaseGenericQuerysData<>)
            );

            services.AddScoped(
                typeof(ICommands<>),
                typeof(BaseGenericCommandsData<>)
            );

            // Business genérico
            services.AddScoped(
                  typeof(IQueryServices<,>),
                  typeof(BaseQueryBusiness<,>)
            );
            services.AddScoped(
                typeof(ICommandService<,>),
                typeof(BaseCommandsBusiness<,>)
            );

            // ======================================= Extends específicos =================================================

            // Data específico
            services.AddScoped<IQueryCursoAsignatura, CursoAsignaturaData>();

            // Business específico
            services.AddScoped<IQueryCursoAsignaturaServices, CursoAsignaturaBusiness>();

            // Otros servicios
            services.AddScoped<IGenericHerlpers, GenericHelpers>();
            services.AddScoped<LoginData>();

            services.AddScoped<IDistributionService, DistributionService>();

            services.AddScoped<ICursoRepository, CursoRepository>();

            return services;
        }
    }
}
