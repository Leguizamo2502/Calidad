using Data.Infrastructure.DataBase;

namespace Web.Extendes
{
    public static class AddFactoryDb
    {
        public static IServiceCollection AddDb(this IServiceCollection services, string dbEngine, IConfiguration configuration)
        {
            var configurator = DbEngineFactory.GetConfigurator(dbEngine);

            configurator.Configure(services, configuration, dbEngine);

            return services;

        }
    }
}
