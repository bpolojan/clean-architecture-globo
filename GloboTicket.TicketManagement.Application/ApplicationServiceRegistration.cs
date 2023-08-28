using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace GloboTicket.TicketManagement.Application
{
    // Extension Method - Add used libraries to ServiceCollection 
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            return services;
        }
    }
}