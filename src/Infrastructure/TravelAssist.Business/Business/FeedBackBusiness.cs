using TravelAssist.Core.Business_Interface;
using TravelAssist.Core.Models;
using TravelAssist.Core.Repository_Interface;

namespace TravelAssist.Business.Business
{
    public class FeedBackBusiness : IFeedBackBusiness
    {
        private readonly IFeedBackRepository _feedBackRepository;
        public FeedBackBusiness(IFeedBackRepository _feedBackRepository)
        {
            this._feedBackRepository = _feedBackRepository;
        }

        public void PostFeedBack(Feedback feedback)
        {
            _feedBackRepository.PostFeedBack(feedback);
        }
    }
}
