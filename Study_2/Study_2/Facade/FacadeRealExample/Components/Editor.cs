using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_2.Facade.FacadeRealExample.Components
{
    /// <summary>
    /// Класс для работы с текстовым редактором
    /// </summary>
    class Editor
    {
        // Функция написания кода
        public void Write(string sourceCode)
        {
            Console.WriteLine($"Пишем код:  {sourceCode}");
        }

        // Функция сохранения кода
        public void Save()
        {
            Console.WriteLine("Сохраняем код");
        }
    }
}
