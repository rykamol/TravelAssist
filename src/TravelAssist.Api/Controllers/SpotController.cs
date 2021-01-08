using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TravelAssist.Api.Dtos;
using TravelAssist.Core.Business_Interface;
using TravelAssist.Core.Models;

namespace TravelAssist.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpotController : ControllerBase
    {
        private readonly ISpotBusiness _spotBusiness;
        private readonly IHostingEnvironment _webHostb;

        public SpotController(ISpotBusiness spotBusiness, IHostingEnvironment webhost)
        {
            _spotBusiness = spotBusiness;
            _webHostb = webhost;
        }

        [HttpGet("GetAllSpots")]
        public async Task<IActionResult> GetAllSpots()
        {
            return Ok(_spotBusiness.GetAll());
        }

        [HttpGet("GetSpotById")]
        public async Task<IActionResult> GetSpotById(int id)
        {
            return Ok(_spotBusiness.GetById(id));
        }


        [HttpPost("SaveSpot")]
        public async Task<IActionResult> SaveSpot([FromForm]SpotDto spot)
        {
            try
            {
                var imagePath =  SaveImage(spot.Image);

                var spotToSave = new Spot()
                {
                    Title = spot.Title,
                    Description = spot.Description,
                    PhotoUrl = imagePath.ToString(),
                    UserId = spot.UserId
                };

                _spotBusiness.Add(spotToSave);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        private string SaveImage(IFormFile image)
        {
            try
            {
                string imageName = new string(Path.GetFileNameWithoutExtension(image.FileName).Take(10).ToArray()).Replace(' ', '-');
                imageName = imageName + DateTime.Now.ToString("yymmssfff") + Path.GetExtension(image.FileName);
                var imagepath = Path.Combine(_webHostb.ContentRootPath, "Images", imageName);
                using (var file = new FileStream(imagepath, FileMode.Create))
                {
                    image.CopyTo(file);
                }

                return imageName;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
