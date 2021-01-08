using Microsoft.AspNetCore.Http;

namespace TravelAssist.Api.Dtos
{
    public class SpotDto
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public IFormFile Image { get; set; }

        public int UserId { get; set; }

    }
}
