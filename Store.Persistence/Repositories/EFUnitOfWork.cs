using Store.Application.Common.Persistence;
using System;

namespace Store.Persistence.Repositories
{
    internal class EFUnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        public IGenericRepository<T> collection => throw new NotImplementedException();

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
