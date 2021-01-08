using Microsoft.EntityFrameworkCore;
using TravelAssist.Core.Models;

namespace TravelAssist.Data._Context
{
    public class TravelDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Spot> Spots { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        public TravelDbContext(DbContextOptions<TravelDbContext> options) : base(options) { }

        public TravelDbContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            //modelBuilder.Entity<Feedback>().HasOne(p => p.User)
            //    .WithMany(b => b.UserFeedBacks)
            //    .HasForeignKey(p => p.UserId)
            //    .OnDelete(DeleteBehavior.Cascade);


            base.OnModelCreating(modelBuilder);
        }
    }
}

