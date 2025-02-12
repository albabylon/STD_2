using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_2.Facade.FacadeRealExample.Components
{
    /// <summary>
    /// Класс для вызовов среды выполнения CLR
    /// </summary>
    class Runtime
    {
        public void Execute()
        {
            Console.WriteLine("Выполнение приложения");
        }
        public void Finish()
        {
            Console.WriteLine("Завершение работы приложения");
        }
    }
}
