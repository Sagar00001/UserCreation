using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserCreation.project.Models;

namespace UserCreation.project.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<City> City { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .HasOne<State>(c => c.State)
                .WithMany(s => s.City)
                .HasForeignKey(s => s.StateID);

        }

    }
}
