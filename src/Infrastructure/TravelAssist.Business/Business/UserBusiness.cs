using TravelAssist.Core.Business_Interface;
using TravelAssist.Core.Models;
using TravelAssist.Core.Repository_Interface;

namespace TravelAssist.Business.Business
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IUserRepository _userRepository;

        public UserBusiness(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Register(User user)
        {
            _userRepository.Register(user);
        }

        public bool Login(User user)
        {
            return _userRepository.Login(user);
        }
    }
}
