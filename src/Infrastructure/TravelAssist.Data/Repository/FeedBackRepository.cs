using Microsoft.EntityFrameworkCore;
using System;
using TravelAssist.Core.Models;
using TravelAssist.Core.Repository_Interface;
using TravelAssist.Data._Context;
using TravelAssist.Data.Base_Repository;

namespace TravelAssist.Data.Repository
{
    public class FeedBackRepository : Repository<Feedback>, IFeedBackRepository
    {
        public FeedBackRepository(DbContext context) : base(context) { }

        private TravelDbContext dbContext { get { return Context as TravelDbContext; } }


        public Feedback PostFeedBack(Feedback feedback)
        {
            try
            {
                dbContext.Feedbacks.Add(feedback);
                return feedback;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
