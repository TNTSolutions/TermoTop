namespace TermoTop.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;
    using TermoTop.Data.Migrations;
    using TermoTop.Data.Models;

    public class ApplicationDbContext : IdentityDbContext<User>, IApplicationDbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public virtual IDbSet<NavigationItem> NavigationItems { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
