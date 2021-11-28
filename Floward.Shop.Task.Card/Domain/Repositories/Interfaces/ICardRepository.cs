using Floward.Shop.Task.Services.CardService.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Floward.Shop.Task.Services.CardService.Domain.Repositories.Interfaces
{
    public interface ICardRepository
    {
        Task<Cart> GetCart(string userName);
        Task<Cart> UpdateCart(Cart cart);
     
        Task<bool> DeleteCart(string userName);

    }
}
