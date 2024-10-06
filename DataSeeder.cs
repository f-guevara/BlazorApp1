using Microsoft.EntityFrameworkCore;
using BlazorApp1.Models; // Adjust this namespace if necessary

namespace BlazorApp1.Data
{
    public static class DataSeeder
    {
        public static async Task SeedData(IServiceProvider serviceProvider)
        {
            using (var context = new MedicalImplantsContext(
                serviceProvider.GetRequiredService<DbContextOptions<MedicalImplantsContext>>()))
            {
                // Check if the database is already seeded
                if (await context.Implants.AnyAsync())
                {
                    return; // Database has been seeded
                }

                // Seed Implants
                context.Implants.AddRange(
                    new Implant { Name = "Dental Implant", Type = "Dental", Price = 1000.00M },
                    new Implant { Name = "Hip Replacement", Type = "Orthopedic", Price = 5000.00M },
                    new Implant { Name = "Pacemaker", Type = "Cardiac", Price = 8000.00M }
                );

                // Seed Customers
                context.Client.AddRange(
                    new Client { Name = "John Doe", Email = "john@example.com" },
                    new Client { Name = "Jane Smith", Email = "jane@example.com" }
                );

                await context.SaveChangesAsync();
            }
        }
    }
}