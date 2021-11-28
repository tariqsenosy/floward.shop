
using Floward.Shop.Task.Services.CardService.Domain.Entites;
using Floward.Shop.Task.Services.CardService.Domain.Repositories.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Floward.Shop.Task.Services.CardService.Domain.Repositories.Implementation
{
    public class CardRepository : ICardRepository
    {
       
        
        public async Task<Cart> GetCart(string userName)
        {
            Cart _cart = new Cart()
            {
                UserName = userName,
                Items = new List<CardItem>()
                {
                    new CardItem()
                    {
                        ProductName="Shampo",
                        ProductId="123",
                        Price=20,
                        Quantity=5,
                        ImageUrl="https://cdn-icons-png.flaticon.com/512/2553/2553628.png"
                    },
                    new CardItem()
                    {
                        ProductName="IceCream",
                        ProductId="678",
                        Price=2,
                        Quantity=12,
                        ImageUrl="https://cdn-icons-png.flaticon.com/512/686/686407.png"
                    },
                }
            };
            return _cart;
        }

        public async Task<Cart> UpdateCart(Cart cart)
        {
           //calling update logic
            return cart;
        }

      

        public async Task<bool> DeleteCart(string userName)
        {

            Cart _cart = await GetCart(userName);
            if (_cart == null)
                return true;
            _cart.Items.Clear();
            return _cart.Items.Count()<=0;
        }
    }
}
