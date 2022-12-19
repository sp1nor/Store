using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Store.Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection service)
        {
            // add mediatR
            service.AddMediatR(Assembly.GetExecutingAssembly());

            //// add validation
            //service.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            //service.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            //// add cache
            //service.AddDistributedMemoryCache();
            //service.AddTransient(typeof(IPipelineBehavior<,>), typeof(CachingBehavior<,>));
        }
    }
}
