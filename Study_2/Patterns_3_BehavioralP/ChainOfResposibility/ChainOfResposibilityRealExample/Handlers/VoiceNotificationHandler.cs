using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_3_BehavioralP.ChainOfResposibility.ChainOfResposibilityRealExample
{
    /// <summary>
    /// Обработчик голосовых уведомлений
    /// </summary>
    class VoiceNotificationHandler : NotificationHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.VoiceNotification == true)
                Console.WriteLine("Выполнено уведомление по телефону");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}
