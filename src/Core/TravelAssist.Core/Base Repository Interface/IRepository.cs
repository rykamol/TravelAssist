using System.Collections.Generic;

namespace TravelAssist.Core.Base_Repository_Interface
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        ICollection<T> GetAll();
        T GetById(int id);
    }
}
