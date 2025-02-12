using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_2.Composite.CompositeRealExample
{
    /// <summary>
    /// Представляет компонент самого низкого уровня
    /// Который не может содержать подкомпонентов
    /// </summary>
    class File : Component
    {
        public File(string name) : base(name)
        { }

        public override void Display()
        {
            Console.WriteLine(Name);
        }

        // Метод для добавления подкомпонентов не поддерживается
        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }

        // Метод для удаления подкомпонентов не поддерживается
        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
