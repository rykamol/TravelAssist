using TravelAssist.Core.Models;

namespace TravelAssist.Core.Business_Interface
{
    public interface IUserBusiness
    {
        void Register(User user);

        bool Login(User user);
    }
}
