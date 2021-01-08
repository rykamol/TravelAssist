using System;
using System.Threading.Tasks;
using TravelAssist.Core.Repository_Interface;

namespace TravelAssist.Core.UnitOfWork_Inferface
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        IFeedBackRepository FeedBackRepository { get; }
        ISpotRepository SpotRepository { get; }
        Task<int> SaveAllAsync();
    }
}
