using Microsoft.EntityFrameworkCore;
using BlazorApp1.Models;

namespace BlazorApp1
{
    public class MedicalImplantsContext : DbContext
    {
        public MedicalImplantsContext(DbContextOptions<MedicalImplantsContext> options)
            : base(options)
        {
        }

        public DbSet<Implant> Implants { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Client> Client { get; set; }
    }
}
