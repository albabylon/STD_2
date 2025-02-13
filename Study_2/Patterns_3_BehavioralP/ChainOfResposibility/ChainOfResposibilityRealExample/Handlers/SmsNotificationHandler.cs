using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_3_BehavioralP.ChainOfResposibility.ChainOfResposibilityRealExample
{
    /// <summary>
    /// Обработчик SMS-уведомлений
    /// </summary>
    class SmsNotificationHandler : NotificationHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.SmsNotification == true)
                Console.WriteLine("Выполнено уведомление по SMS");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}
