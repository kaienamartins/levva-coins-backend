using LevvaCoins.Logic.Dtos.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevvaCoins.Logic.Interfaces
{
    public interface ILoginService
    {
        LoginResponseDto Login(LoginDto login);
    }
}
