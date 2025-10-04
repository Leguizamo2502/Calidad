using Data.Implements.Db;
using Data.Interfaces.Factory;

namespace Data.Infrastructure.DataBase
{
    public static class DbEngineFactory
    {
        public static IDbEngineConfigurator GetConfigurator(string engine)
        {
            return engine switch
            {
                "PgAdmin" => new PostgresConfigurator(),
                _ => throw new InvalidOperationException($"Motor no soportado: {engine}")
            };
        }
    }
}
