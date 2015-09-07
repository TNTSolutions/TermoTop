namespace TermoTop.Data
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using TermoTop.Data.Models;

    public interface IApplicationDbContext
    {
        IDbSet<NavigationItem> NavigationItems { get; set; }

        int SaveChanges();

        void Dispose();

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        IDbSet<T> Set<T>() where T : class;
    }
}
