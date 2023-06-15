using LevvaCoins.Domain.Interfaces;
using LevvaCoins.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevvaCoins.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly Context _context;



        public UserRepository(Context context)
        {
            _context = context;
        }



        public User Create(User usuario)
        {
            _context.Usuario.Add(usuario);
            _context.SaveChanges();
            return usuario;
        }



        public void Delete(int id)
        {
            var user = _context.Usuario.Find(id);
            _context.Usuario.Remove(user);
            _context.SaveChanges();
        }



        public User? Get(int id)
        {
            return _context.Usuario.Find(id);
        }



        public List<User> GetAll()
        {
            return _context.Usuario.AsNoTracking().ToList();
        }



        public User GetByEmailAndPassword(string email, string password)
        {
            return _context.Usuario.FirstOrDefault(x => x.Email.Equals(email) && x.Password.Equals(password));
        }



        public void Update(User usuario)
        {
            _context.Usuario.Update(usuario);
            _context.SaveChanges();
        }
    }
}
