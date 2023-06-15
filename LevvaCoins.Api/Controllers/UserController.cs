using LevvaCoins.Logic.Dtos.UserDtos;
using LevvaCoins.Logic.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LevvaCoins.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;



        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Create(CreateUserDto usuario)
        {
            var user = _userService.Create(usuario);
            return Created("", user);
        }



        [HttpGet("{id}")]
        public ActionResult<UserDto> Get([FromRoute] int id)
        {
            return Ok(_userService.Get(id));
        }



        [HttpGet]
        public ActionResult<List<UserDto>> GetAll()
        {
            return Ok(_userService.GetAll());
        }



        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] UpdateUserDto usuario)
        {
            _userService.Update(id, usuario);
            return NoContent();
        }



        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _userService.Delete(id);
            return NoContent();
        }
    }
}
