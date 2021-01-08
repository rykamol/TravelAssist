using TravelAssist.Core.Models;

namespace TravelAssist.Core.Repository_Interface
{
    public interface IUserRepository
    {
        void Register(User user);

        bool Login(User user);

        User GetByUserName(string userName);

    }
}
