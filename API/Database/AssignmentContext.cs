using API.EntityConfiguration;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Database
{
    public class AssignmentContext : DbContext
    {
        public DbSet<Assignment> Assignments { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Status> Statuses { get; set; }

        public DbSet<Priority> Priorities { get; set; }

        public AssignmentContext(DbContextOptions<AssignmentContext> o):base(o)
        {}
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.ApplyConfiguration(new AssignmentConfiguration());
           modelBuilder.ApplyConfiguration(new StatusConfiguration());
           modelBuilder.ApplyConfiguration(new UserConfiguration());
           modelBuilder.ApplyConfiguration(new PriorityConfiguration());
           base.OnModelCreating(modelBuilder);
        }
    }
}
