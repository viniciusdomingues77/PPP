using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Ordering.Infrastructure.Data;

public class CompanyContextFactory : IDesignTimeDbContextFactory<CompanyContext>
{
    public CompanyContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<CompanyContext>();
        optionsBuilder.UseNpgsql(@"Host=host.docker.internal; Database=company; Username=postgres; Password=iniv140177",
                    b => b.MigrationsAssembly(typeof(CompanyContext)
                            .Assembly.FullName));
        return new CompanyContext(optionsBuilder.Options);
    }
}