using Microsoft.Extensions.DependencyInjection;

namespace Store.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection service)
        {
            //IServiceCollection serviceCollection = service.AddTransient<IUnitOfWork, EFUnitOfWork>();
            return serviceCollection;
        }
    }
}
