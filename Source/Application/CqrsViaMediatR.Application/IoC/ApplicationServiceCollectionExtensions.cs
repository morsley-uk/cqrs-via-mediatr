using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CqrsViaMediatR.Application.IoC
{
    public static class ApplicationServiceCollectionExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var executingAssembly = Assembly.GetExecutingAssembly();
            services.AddMediatR(executingAssembly);

            return services;
        }
    }
}