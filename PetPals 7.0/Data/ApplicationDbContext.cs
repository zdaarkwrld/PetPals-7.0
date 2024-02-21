using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetPals_7._0.Models;

namespace PetPals_7._0.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PetPals_7._0.Models.Admin> Admin { get; set; } = default!;
        public DbSet<PetPals_7._0.Models.Customers> Customers { get; set; } = default!;
        public DbSet<PetPals_7._0.Models.Messages> Messages { get; set; } = default!;
        public DbSet<PetPals_7._0.Models.Schedules> Schedules { get; set; } = default!;
        public DbSet<PetPals_7._0.Models.Services> Services { get; set; } = default!;
    }
}
