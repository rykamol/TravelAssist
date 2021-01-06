using System.Collections.Generic;
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

        public void Add(User entity)
        {
            _userRepository.Add(entity);
        }

        public void Update(User entity)
        {
            _userRepository.Update(entity);
        }

        public void Delete(User entity)
        {
            _userRepository.Delete(entity);
        }

        public ICollection<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }
    }
}
