using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Museum.Model.Models.User;

namespace Museum.Data.Context
{
    class MuseumContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public MuseumContext()
            : base("Name=MuseumStelmahaContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
