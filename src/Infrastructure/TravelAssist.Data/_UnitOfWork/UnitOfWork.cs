using System;
using TravelAssist.Core.Base_Repository_Interface;
using TravelAssist.Core.UnitOfWork_Inferface;
using TravelAssist.Data._Context;
using TravelAssist.Data.Base_Repository;

namespace TravelAssist.Data._UnitOfWork
{
    public class UnitOfWork<TEntity> : IUnitOfWork<TEntity>, IDisposable where TEntity : class
    {

        private readonly TravelDbContext _context;
        public UnitOfWork(TravelDbContext context)
        {
            _context = context;
        }
        public IRepository<TEntity> Repository => new Repository<TEntity>(_context);

        public void Dispose()
        {
            _context?.Dispose();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
