using LevvaCoins.Logic.Dtos.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevvaCoins.Logic.Interfaces
{
    public interface ICategoryService
    {
        CategoryDto Create(CreateCategoryDto categoria);
        CategoryDto Get(int Id);
        List<CategoryDto> GetAll();
        void Update(int id, UpdateCategoryDto categoria);
        void Delete(int Id);
    }
}
