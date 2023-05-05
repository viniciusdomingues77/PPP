using Company.Domain.Entities;
using Microsoft.Extensions.Logging;


namespace Ordering.Infrastructure.Data;

public class CompanyContextSeed
{
    public static async Task SeedAsync(CompanyContext companyContext, ILogger<CompanyContextSeed> logger)
    {
        if (!companyContext.Companies.Any())
        {
            companyContext.Companies.Add(GetCompany());
            await companyContext.SaveChangesAsync();
            //logger.LogInformation($"Ordering Database: {typeof(CompanyContext).Name} seeded.");
        }
    }

    private static Company.Domain.Entities.Company GetCompany()
    {
        return new Company.Domain.Entities.Company()
        {
                    Name = "YogaSoft",
                    WelcomeMessage = "Welcome to YogaSoft. The Realm of software. Do you wanna join us?",
                    LastModifiedBy = "Vini",
                    LastModifiedDate = new DateTime(),
        };
    }
}