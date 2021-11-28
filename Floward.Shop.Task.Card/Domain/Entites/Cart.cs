using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Floward.Shop.Task.Services.CardService.Domain.Entites
{
    public class Cart
    {
        public string UserName { get; set; }
        public List<CardItem> Items { get; set; } = new List<CardItem>();

        public Cart()
        {

        }

        public Cart(string userName)
        {
            UserName = userName;
        }

        public decimal TotalPrice
        {
            get
            {
                decimal totalprice = 0;
                foreach (var item in Items)
                {
                    totalprice += item.Price * item.Quantity;
                }

                return totalprice;
            }
        }
    }
}
