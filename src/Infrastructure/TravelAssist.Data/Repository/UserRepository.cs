using Microsoft.EntityFrameworkCore;
using System;
using TravelAssist.Core.Models;
using TravelAssist.Core.Repository_Interface;
using TravelAssist.Data._Context;
using TravelAssist.Data.Base_Repository;

namespace TravelAssist.Data.Repository
{
    class UserRepository : Repository<User>, IUserRepository
    {

        public UserRepository(DbContext context) : base(context) { }

        private TravelDbContext dbContext { get { return Context as TravelDbContext; } }


        public void Register(User user)
        {
            try
            {
                var existingUser = GetByUserName(user.Username);
                if (existingUser != null)
                {
                    throw new Exception("User Already Exists !");
                }

                dbContext.Users.Add(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool Login(User user)
        {
            try
            {
                var toLoginUser = GetByUserName(user.Username);

                if (toLoginUser == null)
                {
                    throw new Exception("User doesn't exists !");
                }

                if (toLoginUser.Username == user.Username && toLoginUser.Password == user.Password)
                {
                    return true;
                }
                else
                {
                    throw new Exception("username password incorrect !!");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public User GetByUserName(string userName)
        {
            return dbContext.Users.Find(userName);
        }
    }
}
