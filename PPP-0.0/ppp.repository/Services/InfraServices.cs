using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Ordering.Infrastructure.Data;


namespace Company.Repository.Extensions;

public static class InfraServices
{
    public static IServiceCollection AddInfraServices(this IServiceCollection serviceCollection,
        IConfiguration configuration)
    {
        serviceCollection.AddDbContext<CompanyContext>(options => options.UseNpgsql(
            configuration.GetConnectionString("WebCompanyApiDatabase")));
        //serviceCollection.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
        //serviceCollection.AddScoped<IOrderRepository, OrderRepository>();
        return serviceCollection;
    }
}