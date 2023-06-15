using LevvaCoins.Logic.Dtos.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevvaCoins.Logic.Interfaces
{
    public interface IUserService
    {
        UserDto Create(CreateUserDto categoria);
        UserDto Get(int Id);
        List<UserDto> GetAll();
        void Update(int id, UpdateUserDto categoria);
        void Delete(int Id);
    }
}
