using LevvaCoins.Logic.Dtos.CategoryDtos;
using LevvaCoins.Logic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LevvaCoins.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;



        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }



        [HttpPost]
        public ActionResult<CategoryDto> Create([FromBody] CreateCategoryDto categoria)
        {
            var category = _categoryService.Create(categoria);
            return Created("", category);
        }



        [HttpGet("{id}")]
        public ActionResult<CategoryDto> Get([FromRoute] int id)
        {
            var category = _categoryService.Get(id);
            return Ok(category);
        }




        [HttpGet]
        public ActionResult<List<CategoryDto>> GetAll()
        {
            var categories = _categoryService.GetAll();



            return Ok(categories);
        }




        [HttpPut("{id}")]
        public ActionResult Update([FromRoute] int id, [FromBody] UpdateCategoryDto categoria)
        {
            _categoryService.Update(id, categoria);
            return NoContent();
        }



        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _categoryService.Delete(id);
            return NoContent();
        }
    }
}
