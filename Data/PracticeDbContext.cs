using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class PracticeDbContext : DbContext
    {
        public PracticeDbContext() : base("name=PracticeBaseEntities")
        {
            Database.SetInitializer<PracticeDbContext>(null);
        }

        public DbSet<CollectedData> CollectedData { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CollectedData>().ToTable("CollectedData");
            modelBuilder.Entity<User>().ToTable("Users");
        }
    }
}
