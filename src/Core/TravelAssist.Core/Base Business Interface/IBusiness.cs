using System.Collections.Generic;

namespace TravelAssist.Core.Base_Business_Interface
{
    public interface IBusiness<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        ICollection<T> GetAll();
        T GetById(int id);
    }
}
