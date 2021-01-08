using TravelAssist.Core.Business_Interface;
using TravelAssist.Core.Models;
using TravelAssist.Core.UnitOfWork_Inferface;

namespace TravelAssist.Business.Business
{
    public class FeedBackBusiness : IFeedBackBusiness
    {
        private readonly IUnitOfWork _unitOfWork;

        public FeedBackBusiness(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Feedback PostFeedBack(Feedback feedback)
        {
            var returnFeebBack = _unitOfWork.FeedBackRepository.PostFeedBack(feedback);
            _unitOfWork.SaveAllAsync();
            return returnFeebBack;
        }
    }
}
