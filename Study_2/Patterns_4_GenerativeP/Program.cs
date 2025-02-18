using Patterns_4_GenerativeP.Builder.BuilderRealExample;
using Patterns_4_GenerativeP.Prototype.PrototypeRealExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_4_GenerativeP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // СТРОИТЕЛЬ (BUILDER) - он позволяет создавать объекты пошагово, используя один и тот же код для получения разных представлений объекта. 
            // Применение:
            // 1 Если процесс создания не должен зависеть от составных частей, из которых будет создан объект. А также от связей этих частей между собой.
            // 2 Если нам в процессе создания может понадобиться получить различные вариации объекта.

            // создаем движок шаблонизатора
            TemplateEngine templateEngine = new TemplateEngine();

            // создаем шаблонизатор для приветственной рассылки
            TemplateBuilder builder = new WelcomeTemplateBuilder();
            // генерируем  приветственное письо с текстом
            Template greetingsTemplate = templateEngine.GenerateTemplate(builder);
            Console.WriteLine(greetingsTemplate.ToString());


            // переопределяем шаблонизатор для рассылки с номером заказа
            builder = new OrderTemplateBuilder();
            // генерируем  письмо  с номером заказа
            Template orderTemplate = templateEngine.GenerateTemplate(builder);
            Console.WriteLine(orderTemplate.ToString());

            // Иногда реализация паттерна может неоправданно усложнить код, введя слишком большое количество классов.




            // ПРОТОТИП (PROTOTYPE) - этот паттерн позволяет копировать уже имеющиеся объекты, а если точнее, позволяет это делать самим объектам.

            // Применение:
            // 1 Если нам надо динамически определять тип создаваемого объекта во время выполнения и убрать его зависимость от копируемого объекта
            // 2 Если клонирование объекта для нас предпочтительнее, чем его создание и инициализация в конструкторе.
            // Особенно удобно, когда мы знаем, что объект способен принимать небольшое ограниченное количество возможных состояний.

            // создаем точку
            ILocation location = new Point(30.245, 40.954);
            // клонируем точку (получаем новую точку с теми же координатами)
            ILocation clonedLocation = location.Clone();

            location.GetInfo();
            clonedLocation.GetInfo();

            Console.WriteLine();

            // создаем место
            location = new Place("Улица Пушкина, дом Колотушкина");
            // клонируем место (получаем новое место по тому же адресу)
            // пример использования - нам надо обозначить новый магазин в том же самом торговом центре
            clonedLocation = location.Clone();

            location.GetInfo();
            clonedLocation.GetInfo();

            // Минус: сложно клонировать составные объекты, которые уже имеют ссылки на другие.
        }
    }
}
