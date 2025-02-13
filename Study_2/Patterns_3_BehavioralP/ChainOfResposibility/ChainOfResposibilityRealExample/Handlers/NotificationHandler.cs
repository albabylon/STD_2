using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_3_BehavioralP.ChainOfResposibility.ChainOfResposibilityRealExample
{
    /// <summary>
    /// Абстрактный класс для всех обработчиков событий
    /// </summary>
    abstract class NotificationHandler
    {
        public NotificationHandler Successor { get; set; }
        public abstract void Handle(Receiver receiver);
    }
}
