namespace Authentication.Application.Common.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        void Commit();
        void BeginTransaction();
        void Rollback();
        int SaveChanges();
        Task<int> SaveAsync();
    }

    public interface IUnitOfWork<TContext> : IUnitOfWork
    {

    }
}
