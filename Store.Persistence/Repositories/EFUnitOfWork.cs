using Store.Application.Common.Persistence;
using Store.Persistence.Context;
using System;

namespace Store.Persistence.Repositories
{
    internal class EFUnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private IGenericRepository<T> _collections;

        private ApplicationContext _context;

        public EFUnitOfWork(ApplicationContext context)
        {
            _context = context;
        }

        public IGenericRepository<T> collection
        {
            get
            {
                if (_collections == null)
                {
                    _collections = new EFGenericRepository<T>(_context);
                }

                return _collections;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
