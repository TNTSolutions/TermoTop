namespace TermoTop.Data.UnitOfWork
{
    public interface ITermoTopData
    {
        //IApplicationDbContext Context { get; }

        //IRepository<Menu> Menus { get; }

        int SaveChanges();
    }
}
