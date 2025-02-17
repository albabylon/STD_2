using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class SingleResponsibilityPrinciple
    {
        //Принцип единственной обязанности - у класса должна быть только одна причина для изменения
    }

    /// <summary>
    /// Класс документа
    /// </summary>
    class DocumentBad
    {
        public string Text { get; set; }

        public void ScrollUp()
        {
            Console.WriteLine($"Прокрутка вверх");
        }

        public void ScrollDown()
        {
            Console.WriteLine($"Прокрутка вниз");
        }

        public void ZoomIn()
        {
            Console.WriteLine("Увелчиваем масштаб");
        }

        public void ExportToPdf()
        {
            Console.WriteLine("Экспортируем текст в PDF");
            Console.WriteLine(Text);
        }
    }


    /// <summary>
    /// Общий интерфейс для классов - экспортеров
    /// </summary>
    interface IExporter
    {
        void Export(string text);
    }

    /// <summary>
    /// Экспорт в PDF
    /// </summary>
    class PdfExporter : IExporter
    {
        public void Export(string text)
        {
            Console.WriteLine($"{text}  => Экспортировано в PDF");
        }
    }

    /// <summary>
    /// Класс документа
    /// </summary>
    class DocumentGood
    {
        public string Text { get; set; }

        public void ScrollUp()
        {
            Console.WriteLine($"Прокрутка вверх");
        }

        public void ScrollDown()
        {
            Console.WriteLine($"Прокрутка вниз");
        }

        public void ZoomIn()
        {
            Console.WriteLine("Увеличиваем масштаб");
        }

        /// <summary>
        ///  Экспорт в любые форматы
        /// </summary>
        public void Export(IExporter exporter)
        {
            exporter.Export(Text);
        }
    }
}
