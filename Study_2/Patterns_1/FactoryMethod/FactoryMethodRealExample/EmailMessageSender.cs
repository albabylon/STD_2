﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1.FactoryMethod.FactoryMethodRealExample
{
    /// <summary>
    /// Класс для рассылки e-mail
    /// </summary>
    class EmailMessageSender : MessageSender
    {
        public EmailMessageSender(string @from) : base(@from)
        { }
        public override Message Send(string text)
        {
            return new EmailMessage();
        }
    }
}
