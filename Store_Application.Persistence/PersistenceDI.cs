using Microsoft.Extensions.DependencyInjection;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Persistence.Contexts;

namespace Store_Application.Persistence
{
    public static class PersistenceDI
    {
        public static void ConfigurePersistenceServices(this IServiceCollection services)
        {
            services.AddScoped<IDataBaseContext, DataBaseContext>();
        }
    }
}
