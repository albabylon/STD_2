using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class DependencyInversionPrinciple
    {
        // Принцип инверсии зависимостей - объектом зависимости должна быть абстракция, а не что-то конкретное.

        // Система должна быть организована от общего к частному. Верхние модули не должны зависеть от нижних
    }


    // Пусть у нас есть класс для работы с видео-картой, и он умеет выводить текст на монитор
    class VideoAdapterBad
    {
        public string Text { get; set; }
        public MonitorBad Monitor { get; set; }

        public void Display()
        {
            Monitor.Display(Text);
        }
    }

    class MonitorBad
    {
        public void Display(string text)
        {
            Console.WriteLine(text);
        }
    }


    // VideoAdapter использует для вывода класс Monitor, и получается, что он от этого низкоуровневого класса зависит.
    // Кроме того, мы жестко зашили возможность вывода только через монитор.

    /// <summary>
    /// Универсальный интерфейс для вывода изображения
    /// </summary>
    public interface IHdmiInterface
    {
        void Display(string text);
    }

    class MonitorGood : IHdmiInterface
    {
        public void Display(string text)
        {
            Console.WriteLine("Вывод на монитор");
        }
    }

    class TvGood : IHdmiInterface
    {
        public void Display(string text)
        {
            Console.WriteLine("Вывод на телевизор");
        }
    }

    /// <summary>
    /// Адаптер для вывода изображений
    /// </summary>
    class VideoAdapter
    {
        public string Text { get; set; }
        public IHdmiInterface HdmiInterface { get; set; }

        public VideoAdapter(IHdmiInterface hdmiInterface)
        {
            HdmiInterface = hdmiInterface;
        }

        /// <summary>
        /// Метод вывода
        /// </summary>
        public void Display()
        {
            HdmiInterface.Display(Text);
        }
    }
}
