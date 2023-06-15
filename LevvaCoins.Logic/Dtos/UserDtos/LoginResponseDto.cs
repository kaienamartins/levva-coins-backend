using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevvaCoins.Logic.Dtos.UserDtos
{
    public class LoginResponseDto
    {
        public int Id
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public string Email
        {
            get; set;
        }
        public string Token
        {
            get; set;
        }
    }
}
