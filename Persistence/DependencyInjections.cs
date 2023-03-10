using Microsoft.Extensions.DependencyInjection;

namespace Persistence
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            services.AddSingleton<ISQLDataAccess, SQLDataAccess>();
            services.AddScoped<IReservationRepository, ReservationRepository>();
            return services;
        }
    }
}
