using CabManagementSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CabManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Booking> Bookings { get; set; }


        public DbSet<DriverDetails> DriverDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Booking>()
                .HasOne(m => m.User)
                .WithMany(m => m.BookingCabs)
                .OnDelete(DeleteBehavior.NoAction);
        }

    }

}