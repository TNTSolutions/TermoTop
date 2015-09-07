namespace TermoTop.Data.UnitOfWork
{
    using TermoTop.Data.Common.Repository;
    using TermoTop.Data.Models;

    public interface ITermoTopData
    {
        IApplicationDbContext Context { get; }

        IRepository<NavigationItem> NavigationItems { get; }

        int SaveChanges();
    }
}
