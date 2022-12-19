namespace Store.Application.Common.Persistence
{
    public interface IUnitOfWork<T> where T : class
    {
        IGenericRepository<T> collection { get; }

        void Save();
    }
}
