using LevvaCoins.Logic.Dtos.TransactionDtos;
using LevvaCoins.Logic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LevvaCoins.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;
        private readonly ICategoryService _categoryService;


        public TransactionController(ITransactionService transactionService, ICategoryService categoryService)
        {
            _transactionService = transactionService;
            _categoryService = categoryService;
        }



        [HttpPost]
        public ActionResult<TransactionDto> Create([FromBody] CreateTransactionDto transacao)
        {
            var userId = User.Identity.Name;

            var transaction = _transactionService.Create(Convert.ToInt32(userId),transacao);
            var category = _categoryService.Get(transacao.CategoryId);

            transaction.Category = category;    
            return Created("", transaction);
        }



        [HttpGet("{id}")]
        public ActionResult<TransactionDto> Get([FromRoute] int id)
        {
            return Ok(_transactionService.Get(id));
        }



        [HttpGet]
        public ActionResult<List<TransactionDto>> GetAll()
        {
            return Ok(_transactionService.GetAll());
        }



        [HttpGet("search")]
        public ActionResult<List<TransactionDto>> Search([FromQuery] string query)
        {
            return Ok(_transactionService.SearchByDescription(query));
        }



        [HttpPut("{id}")]
        public ActionResult Update([FromRoute] int id, [FromBody] UpdateTransactionDto usuario)
        {
            _transactionService.Update(id, usuario);
            return NoContent();
        }



        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            _transactionService.Delete(id);
            return NoContent();
        }
    }
}
