using LevvaCoins.Logic.Dtos.UserDtos;
using LevvaCoins.Logic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LevvaCoins.Api.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;



        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }



        [HttpPost]
        public ActionResult<LoginResponseDto> Auth([FromBody] LoginDto login)
        {
            var response = _loginService.Login(login);



            return Ok(response);
        }
    }
}
