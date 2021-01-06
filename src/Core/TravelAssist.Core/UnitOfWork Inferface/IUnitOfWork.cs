using TravelAssist.Core.Base_Repository_Interface;

namespace TravelAssist.Core.UnitOfWork_Inferface
{
    public interface IUnitOfWork<T> where T : class
    {
        IRepository<T> Repository { get; }
        int Save();
    }
}
