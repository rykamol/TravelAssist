using TravelAssist.Core.Models;

namespace TravelAssist.Core.Business_Interface
{
    public interface IFeedBackBusiness
    {
        Feedback PostFeedBack(Feedback feedback);
    }
}
