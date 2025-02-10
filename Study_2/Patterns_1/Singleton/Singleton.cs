using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1.Singleton
{
    internal class Singleton
    {
        // SINGLETON - Имеет смысл, когда нам необходимо наличие только одного объекта определенного типа в коде.
        // Реализация Singleton позволяет нам получить такой объект и точку доступа к нему.
        // При этом создаётся он только тогда, когда необходим

        // Статическая переменная - ссылка на конкретный экземпляр объекта
        private static Singleton Instance;

        // Приватный конструктор
        private Singleton()
        { }

        // Конструктор вызывается для создания объекта, если он отсутствует 
        public static Singleton GetInstance()
        {
            if (Instance == null)
                Instance = new Singleton();

            return Instance;
        }
    }
}
