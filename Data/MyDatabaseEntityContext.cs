using Models;
using System.Data.Entity;

namespace Mydatabase
{
    public class MyDatabaseEntityContext : DbContext
    {
        public MyDatabaseEntityContext() : base("name=PracticeBaseEntities")
        {
            Database.SetInitializer<MyDatabaseEntityContext>(null);
        }

        public DbSet<Sensors> Sensors { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sensors>().ToTable("Sensors");
            modelBuilder.Entity<User>().ToTable("Users");
        }
    }
}
