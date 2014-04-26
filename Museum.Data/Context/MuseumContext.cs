using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.AspNet.Identity.EntityFramework;
using Museum.Model.Models.Gallery;
using Museum.Model.Models.User;

namespace Museum.Data.Context
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationDbContext.ApplicationUser>
    {
        public class ApplicationUser : IdentityUser
        {

        }

        public ApplicationDbContext()
            : base("MuseumStelmahaContext")
        {

        }
        //public DbSet<User> Users { get; set; }
        //public DbSet<Role> Roles { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<ImageCategory> ImageCategories { get; set; }
    }


    //protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //{
    //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    //}

}
