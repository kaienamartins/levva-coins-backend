using AutoMapper;
using LevvaCoins.Domain.Interfaces;
using LevvaCoins.Domain.Models;
using LevvaCoins.Logic.Dtos.CategoryDtos;
using LevvaCoins.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevvaCoins.Logic.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;



        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }



        public CategoryDto Create(CreateCategoryDto categoria)
        {
            var categoryCreate = _mapper.Map<Category>(categoria);
            var category = _categoryRepository.Create(categoryCreate);



            return _mapper.Map<CategoryDto>(category);
        }



        public void Delete(int Id)
        {
            _categoryRepository.Delete(Id);
        }



        public CategoryDto Get(int Id)
        {
            var category = _categoryRepository.Get(Id);



            return _mapper.Map<CategoryDto>(category);
        }



        public List<CategoryDto> GetAll()
        {
            var categories = _categoryRepository.GetAll();
            return _mapper.Map<List<CategoryDto>>(categories);
        }



        public void Update(int id, UpdateCategoryDto categoria)
        {
            throw new NotImplementedException();
        }
    }
}
