using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TravelAssist.Core.Base_Repository_Interface;
using TravelAssist.Data._Context;

namespace TravelAssist.Data.Base_Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext Context;
        protected DbSet<T> Entities;

        public Repository(DbContext context)
        {
            Context = context;
            Entities = context.Set<T>();
        }

        public Repository()
        {
            Entities = new TravelDbContext().Set<T>();
        }

        public void Add(T entity)
        {
            Entities.Add(entity);
        }

        public void Delete(T entity)
        {
            Entities.Remove(entity);
        }

        public ICollection<T> GetAll()
        {
            return Entities.ToList();
        }

        public T GetById(int id)
        {
            return Entities.Find(id);
        }

        public void Update(T entity)
        {
            Entities.Update(entity);
        }
    }
}
