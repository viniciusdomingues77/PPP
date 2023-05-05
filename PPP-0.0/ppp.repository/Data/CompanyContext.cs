using Company.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Company.Domain.Shared;

namespace Ordering.Infrastructure.Data;

public class CompanyContext : DbContext
{
    public CompanyContext(DbContextOptions<CompanyContext>options):base(options)
    {
        
    }

    public DbSet<Company.Domain.Entities.Company> Companies { get; set; }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entry in ChangeTracker.Entries<EntityBase>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedDate = DateTime.Now;
                    entry.Entity.CreatedBy = "vini"; //TODO: This will be replaced Identity Server
                    break;
                case EntityState.Modified:
                    entry.Entity.LastModifiedDate = DateTime.Now;
                    entry.Entity.LastModifiedBy = "vini"; //TODO: This will be replaced Identity Server
                    break;
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }
}