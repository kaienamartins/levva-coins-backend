using LevvaCoins.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevvaCoins.Data
{
    public class Context : DbContext
    {
        public DbSet<User> Usuario
        {
            get; set;
        }
        public DbSet<Transaction> Transacao
        {
            get; set;
        }
        public DbSet<Category> Categoria
        {
            get; set;
        }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
    }
}
