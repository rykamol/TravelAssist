using TravelAssist.Core.Business_Interface;
using TravelAssist.Core.Models;
using TravelAssist.Core.UnitOfWork_Inferface;

namespace TravelAssist.Business.Business
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserBusiness(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Register(User user)
        {
            _unitOfWork.UserRepository.Register(user);
            _unitOfWork.SaveAllAsync();
        }

        public bool Login(User user)
        {
            return _unitOfWork.UserRepository.Login(user);
        }
    }
}
