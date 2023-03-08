using entityframework_.net_lab3.Repository.Abstractions;

namespace entityframework_.net_lab3.Repository.Implementations
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddRepositoryLayer(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<ICargoRepository,CargoRepository>();
            services.AddScoped<IFactoryRepository,FactoryRepository>();
            services.AddScoped<IProductRepository,ProductRepository>();
            services.AddScoped<ICategoryRepository,CategoryRepository>();


            return services;
        }
    }
}
