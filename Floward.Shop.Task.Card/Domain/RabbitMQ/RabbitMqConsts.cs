using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Floward.Shop.Task.Services.CardService.Domain.RabbitMQ
{
    public class RabbitMqConsts
    {
        public const string RabbitMqRootUri = "rabbitmq://localhost";
        public const string RabbitMqUri = "rabbitmq://localhost/vhost1/exchange1?bind=true&queue=checkoutQueue";
        public const string UserName = "guest";
        public const string Password = "guest";
        public const string NotificationServiceQueue = "notification.service";
    }
}
