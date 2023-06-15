using LevvaCoins.Domain.Interfaces;
using LevvaCoins.Logic.Dtos.UserDtos;
using LevvaCoins.Logic.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace LevvaCoins.Logic.Services
{
    public class LoginService : ILoginService
    {
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _config;



        public LoginService(IUserRepository userRepository, IConfiguration config)
        {
            _userRepository = userRepository;
            _config = config;
        }




        public LoginResponseDto Login(LoginDto loginDto)
        {
            var usuario = _userRepository.GetByEmailAndPassword(loginDto.Email, loginDto.Password);
            if (usuario == null)
                return null;



            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_config.GetSection("Secret").Value);



            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, usuario.Id.ToString()),
                    new Claim(ClaimTypes.Email, usuario.Email)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var loginResponse = new LoginResponseDto { Id = usuario.Id, Email = usuario.Email, Name = usuario.Name };
            loginResponse.Token = $"Bearer {tokenHandler.WriteToken(token)}";



            return loginResponse;
        }
    }
}
