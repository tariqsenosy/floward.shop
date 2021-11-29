using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Floward.Shop.Task.Services.CardService.Domain.Events
{
    public class CheckoutEvent
    {
            public string Id { get; set; }
            public DateTime CreatedTime { get; set; } = DateTime.UtcNow;
            public string Description { get; set; }
            public bool IsCompleted { get; set; }
        

    }
}
