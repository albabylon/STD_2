using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_2.Composite.CompositeRealExample
{
    /// <summary>
    /// Представляет папку - компонент, который может содержать другие компоненты
    /// Здесь реализован механизм для добавления / удаления новых компонентов
    /// </summary>
    class Folder : Component
    {
        List<Component> subFolders = new List<Component>();
        
        public Folder(string name) : base(name)
        { }

        // Метод для добавления новых подкомпонентов
        public override void Add(Component component)
        {
            subFolders.Add(component);
            Console.WriteLine($"В {this.Name} добавлено: {component.Name} ");
        }

        // Метод для удаления
        public override void Remove(Component component)
        {
            subFolders.Remove(component);
            Console.WriteLine($"Из {this.Name} удалено: {component.Name} ");
        }

        // Метод для отображения нижестоящих компонентов
        public override void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"{Name} содержит:");
            foreach (Component component in subFolders)
                component.Display();
        }
    }
}
