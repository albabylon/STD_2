using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_4_GenerativeP.Builder.BuilderRealExample
{
    /// <summary>
    /// Абстрактный класс шаблонизатора (здесь он является строителем)
    /// </summary>
    abstract class TemplateBuilder
    {
        public Template Template { get; private set; }
        public void CreateTemplate()
        {
            Template = new Template();
        }

        // Метод для создания заголовка
        public abstract void BuildHeader();

        // Для тела письма
        public abstract void BuildBody();

        // Для подписи в нижней части рассылки
        public abstract void BuildFooter();
    }
}
