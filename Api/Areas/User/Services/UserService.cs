using System.Threading.Tasks;
using Api.Areas.User.Dtos;
using Api.Areas.User.Models;
using Microsoft.AspNetCore.Identity;

namespace Api.Areas.User.Services
{
    public class UserService
    {
        private readonly SignInManager<Models.User> _signinMan;
        private readonly UserManager<Models.User> _userMan;
        
        public UserService(SignInManager<Models.User> signinMan, UserManager<Models.User> userMan)
        {
            _signinMan = signinMan;
            _userMan = userMan;
        }
        
        public async Task<UserDto> Login(UserLoginDto dto)
        {
            return new UserDto();

        }

        public async Task<UserDto> Register(UserRegisterDto dto)
        {
            var user = new Models.User
            {
                Name = dto.Name,
                Email = dto.Email
            };

            var result = await _userMan.CreateAsync(user, dto.Password);

            if (result.Succeeded)
                return new UserDto
                {
                    Name = user.Name,
                    Email = user.Email
                };

            return null;
        }
    }
}