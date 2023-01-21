using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extensions
{
    public static class SwaggerExtension
    {
        public static IServiceCollection AddSwaggerScope(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new() { Title = "ManuFacturing Api", Version = "v1" });
            });
            return services;
        }
    }
}
