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
    public class UserController : ControllerBase
    {
        private readonly IUserBusiness _userBusiness;

        public UserController(IUserBusiness userBusiness)
        {
            _userBusiness = userBusiness;
        }


        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterDto model)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            try
            {
                var user = new User()
                {
                    Username = model.Username,
                    Password = model.Password,
                    Name = model.Name
                };

                _userBusiness.Register(user);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); // return BadRequest(ex.Message);
            }
        }


        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDto model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                var user = new User()
                {
                    Username = model.UserName,
                    Password = model.Password
                };
                return Ok(_userBusiness.Login(user));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); // return BadRequest(ex.Message);
            }
        }
    }
}
