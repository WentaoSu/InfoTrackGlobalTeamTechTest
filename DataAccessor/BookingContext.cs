using EntityModel;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccessor
{
    public class BookingContext : DbContext
    {
        public BookingContext(DbContextOptions<BookingContext> options) : base(options)
        {
        }

        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
            {
                throw new ArgumentNullException(nameof(modelBuilder));
            }

            base.OnModelCreating(modelBuilder);
            // ensure uniqueness for the primary key constraint
            modelBuilder.Entity<Booking>().HasKey(entity => entity.Id);
            // auto generates key on insert
            //modelBuilder.Entity<Booking>().Property(b => b.Id).ValueGeneratedOnAdd();

            // configure From as clustered index for fast index seek on From
            modelBuilder.Entity<Booking>().HasIndex(entity => entity.From).IsClustered();
            // configure To as non-clustered index for fast key lookup on To
            modelBuilder.Entity<Booking>().HasIndex(entity => entity.To).IsClustered(false);
        }
    }
}
