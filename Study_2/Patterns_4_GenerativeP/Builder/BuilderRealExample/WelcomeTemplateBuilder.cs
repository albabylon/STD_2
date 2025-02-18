using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_4_GenerativeP.Builder.BuilderRealExample
{
    /// <summary>
    /// Строитель для создания приветственной рассылки
    /// </summary>
    class WelcomeTemplateBuilder : TemplateBuilder
    {
        public override void BuildHeader()
        {
            Template.Header = new Header { Text = "Здравствуйте!" };
        }

        public override void BuildBody()
        {
            Template.Body = new Body { Text = "Спасибо за регистрацию в нашем приложении" };
        }

        public override void BuildFooter()
        {
            // не используется
        }
    }
}
