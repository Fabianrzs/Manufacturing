using Aplication.Product;
using Aplication.Product.Main;
using Domain.Interface;
using Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extensions
{
    public static class ServicesExtension
    {
        public static IServiceCollection AddServiceScope(this IServiceCollection services)
        {
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IProductService, ProductService>();
            return services;
        }
    }
}
