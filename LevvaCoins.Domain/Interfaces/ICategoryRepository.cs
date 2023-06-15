using LevvaCoins.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevvaCoins.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        Category Create(Category categoria);
        Category? Get(int id);
        List<Category> GetAll();
        void Update(Category categoria);
        void Delete(int id);
    }
}
