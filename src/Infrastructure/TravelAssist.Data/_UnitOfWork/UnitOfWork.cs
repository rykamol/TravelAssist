using System.Threading.Tasks;
using TravelAssist.Core.Repository_Interface;
using TravelAssist.Core.UnitOfWork_Inferface;
using TravelAssist.Data._Context;
using TravelAssist.Data.Repository;

namespace TravelAssist.Data._UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private TravelDbContext context;
        public UnitOfWork(TravelDbContext _context)
        {
            context = _context;

            this.UserRepository = new UserRepository(context);
            this.SpotRepository = new SpotRepository(context);
            this.FeedBackRepository = new FeedBackRepository(context);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IUserRepository UserRepository { get; }
        public IFeedBackRepository FeedBackRepository { get; }
        public ISpotRepository SpotRepository { get; }


        public Task<int> SaveAllAsync()
        {
            return context.SaveChangesAsync();
        }
    }
}
