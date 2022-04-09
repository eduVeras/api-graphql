namespace Marketplace.Sneakers.Api.Extensions
{
    public static class DependenciesExtensions
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {

            services.AddScoped<IProductService, ProductService>();

            //We are using a singleton in this case because we are save data in a statis property in the repository;
            services.AddSingleton<IProductRepository, IProductRepository>();

            return services;
        }

    }
}
