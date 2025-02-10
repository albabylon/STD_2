using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1.FactoryMethod.FactoryMethodRealExample
{
    class EmailMessage : Message
    {
        public EmailMessage()
        {
            Console.WriteLine("e-mail отправлен");
        }
    }
}
