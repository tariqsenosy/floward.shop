using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Floward.Shop.Task.Services.CardService.Domain.Entites
{
    public class CardItem
    {

        public int Quantity { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }



    }
}
