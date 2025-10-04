using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Data.Interfaces.Factory
{
    public interface IDbEngineConfigurator
    {
        void Configure(IServiceCollection services, IConfiguration configuration, string connectionName);
    }
}
