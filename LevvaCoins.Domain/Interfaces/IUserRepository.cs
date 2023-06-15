using LevvaCoins.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevvaCoins.Domain.Interfaces
{
    public interface IUserRepository
    {
        User Create(User usuario);
        User? Get(int id);
        List<User> GetAll();
        void Update(User usuario);
        void Delete(int id);
        User GetByEmailAndPassword(string email, string password);
    }
}
