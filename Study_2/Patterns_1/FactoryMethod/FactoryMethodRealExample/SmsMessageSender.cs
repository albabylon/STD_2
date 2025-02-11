using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1.FactoryMethod.FactoryMethodRealExample
{
    /// <summary>
    /// Класс для рассылки SMS
    /// </summary>
    class SmsMessageSender : MessageSender
    {
        public SmsMessageSender(string @from) : base(@from)
        { }

        public override Message Send(string text) //фабричный метод
        {
            return new SmsMessage();
        }
    }
}
