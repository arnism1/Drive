using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Drive.Data.Entity;

namespace Drive.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<Car> Cars { get; set; }
        public DbSet<Tours> Tours { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Configure Entry to ApplicationUser relationship
            builder.Entity<Tours>()
                .HasOne(e => e.Employee)
                .WithMany(u => u.Tours)
                .HasForeignKey(e => e.EmployeeId);

            // Configure Entry to CompanyCar relationship
            builder.Entity<Tours>()
                .HasOne(e => e.Car)
                .WithMany(p => p.Tours)
                .HasForeignKey(e => e.CardId);
        }
    }
}

