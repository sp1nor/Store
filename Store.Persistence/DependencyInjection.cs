using Microsoft.Extensions.DependencyInjection;
using Store.Application.Common.Persistence;
using Store.Domain.Entities;
using Store.Persistence.Context;
using Store.Persistence.Repositories;

using Microsoft.EntityFrameworkCore;

namespace Store.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection service)
        {
            service.AddDbContext<ApplicationContext>(opt => opt.UseInMemoryDatabase("InMem"));

            service.AddTransient<IGenericRepository<Product>, EFGenericRepository<Product>>();

            IServiceCollection serviceCollection = service.AddTransient<IUnitOfWork<Product>, EFUnitOfWork<Product>>();
            return serviceCollection;
        }
    }
}
