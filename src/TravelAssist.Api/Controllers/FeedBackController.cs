using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TravelAssist.Api.Dtos;
using TravelAssist.Core.Business_Interface;
using TravelAssist.Core.Models;

namespace TravelAssist.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedBackController : ControllerBase
    {
        private readonly IFeedBackBusiness _feedBackBusiness;

        public FeedBackController(IFeedBackBusiness feedBackBusiness)
        {
            _feedBackBusiness = feedBackBusiness;
        }

        [HttpPost("PostFeedBack")]
        public async Task<IActionResult> PostFeedBack(FeedbackDto model)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            try
            {
                var feedback = new Feedback()
                {
                    Comment = model.Comment,
                    UserId = model.UserId,
                    SpotId = model.SpotId
                };

                return Ok(_feedBackBusiness.PostFeedBack(feedback));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); // return BadRequest(ex.Message);
            }
        }

    }
}