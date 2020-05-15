using System.Threading.Tasks;
using Api.Areas.User.Dtos;
using Api.Areas.User.Services;
using Api.Controllers;
using Api.Data.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.User.Controllers
{
    public class UserController : ApiController
    {
        private readonly MysqlDbContext _ctx;
        private readonly UserService _userService;
        
        public UserController(MysqlDbContext ctx, UserService userService)
        {
            _ctx = ctx;
            _userService = userService;
        }
        // GET
        public IActionResult Index()
        {
            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLoginDto dto)
        {
            var user = await _userService.Login(dto);
            return Ok(user);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegisterDto dto)
        {
            return Ok();
        }
    }
}