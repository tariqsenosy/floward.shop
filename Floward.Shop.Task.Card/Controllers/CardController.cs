using Floward.Shop.Task.Services.CardService.Domain.Entites;
using Floward.Shop.Task.Services.CardService.Domain.Events;
using Floward.Shop.Task.Services.CardService.Domain.RabbitMQ;
using Floward.Shop.Task.Services.CardService.Domain.Repositories.Interfaces;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Floward.Shop.Task.Services.CardService.Controllers
{
    [Route("api/v1/card")]
    [ApiController]
    public class CardController : Controller
    {
        private readonly ICardRepository _repository;
        private readonly IBus _bus;
        public CardController(ICardRepository repository, IBus bus) {
            _repository = repository;
            _bus = bus;
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


        //Service as a publisher for RabbitMQ 
        [HttpPost]
        [Route("checkout")]
        public async Task<ActionResult> Checkout()
        {
            Uri uri = new Uri(RabbitMqConsts.RabbitMqUri);
            var endPoint = await _bus.GetSendEndpoint(uri);
            CheckoutEvent _event=new CheckoutEvent();
            _event.Description = "Chckout From Card ";
            _event.Id = new Guid().ToString();
            _event.IsCompleted = false;
            
            await endPoint.Send(_event);
            return Ok();
        }



    }
}
