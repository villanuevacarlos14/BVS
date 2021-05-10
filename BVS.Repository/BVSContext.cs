using BVS.Repository.Configuration;
using BVS.Repository.Model;
using Microsoft.EntityFrameworkCore;

namespace BVS.Repository
{
    public class BVSContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Video> Videos { get; set; }

        public DbSet<CustomerVideo> CustomerVideos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new VideoConfiguration());

            modelBuilder.Entity<CustomerVideo>()
                .HasKey(bc => bc.Id);

            modelBuilder.Entity<CustomerVideo>()
                .HasOne(bc => bc.Customers)
                .WithMany(b => b.CustomerVideos)
                .HasForeignKey(bc => bc.CustomerId);

            modelBuilder.Entity<CustomerVideo>()
                .HasOne(bc => bc.Video)
                .WithMany(c => c.CustomerVideos)
                .HasForeignKey(bc => bc.VideoId);


        }
    }
}