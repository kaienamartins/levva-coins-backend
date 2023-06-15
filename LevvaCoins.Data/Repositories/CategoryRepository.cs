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
    public class CategoryRepository: ICategoryRepository
    {
        private readonly Context _context;
        public CategoryRepository(Context context)
        {
            _context = context;
        }
        public Category Create(Category categoria)
        {
            _context.Categoria.Add(categoria);
            _context.SaveChanges();
            return categoria;
        }



        public void Delete(int id)
        {
            var category = _context.Categoria.Find(id);
            _context.Categoria.Remove(category);
            _context.SaveChanges();
        }



        public Category? Get(int id)
        {
            return _context.Categoria.Find(id);
        }



        public List<Category> GetAll()
        {
            return _context.Categoria.AsNoTracking().ToList();
        }



        public void Update(Category categoria)
        {
            _context.Categoria.Update(categoria);
            _context.SaveChanges();
        }
    }
}
