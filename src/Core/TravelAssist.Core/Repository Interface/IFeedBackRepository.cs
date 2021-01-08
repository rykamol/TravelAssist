using TravelAssist.Core.Models;

namespace TravelAssist.Core.Repository_Interface
{
    public interface IFeedBackRepository
    {
        Feedback PostFeedBack(Feedback feedback);
    }
}
