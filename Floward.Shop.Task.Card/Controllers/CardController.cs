using Floward.Shop.Task.Services.CardService.Domain.Entites;
using Floward.Shop.Task.Services.CardService.Domain.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Floward.Shop.Task.Services.CardService.Controllers
{
    [Route("api/v1/card")]
    [ApiController]
    public class CardController : Controller
    {
        private readonly ICardRepository _repository;
        public CardController(ICardRepository repository) {
            _repository = repository;
        }

        [HttpGet]
       
        public async Task<ActionResult<Cart>> GetCart(string userName)
        {
            var _cart = await _repository.GetCart(userName);

            return Ok(_cart ?? new Cart(userName));
        }

        [HttpPost]
        public async Task<ActionResult<Cart>> UpdateCart([FromBody] Cart _cart)
        {
            return Ok(await _repository.UpdateCart(_cart));
        }

        [HttpDelete("{userName}")]
       
        public async Task<IActionResult> DeleteBasket(string userName)
        {
            return Ok(await _repository.DeleteCart(userName));
        }

      
    }
}
