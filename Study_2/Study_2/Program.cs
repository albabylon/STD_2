using Study_2.Adapter.AdapterRealExample.Devices;
using Study_2.Adapter.AdapterRealExample;
using System;
using Study_2.Composite.CompositeRealExample;
using Study_2.Facade.FacadeRealExample.Components;
using Study_2.Facade.FacadeRealExample;

namespace Study_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // СТРКУТУРНЫЕ ПАТТЕРНЫ - для удобства поддержки иерархии классов

            /*------------------------------------------------------------------------------------------------------------------------------*/

            // АДАПТЕР(ADAPTER) - Очень распространенный паттерн, позволяющий работать вместе объектам с несовместимыми интерфейсами.

            // Нам надо отрисовать изображение на бумаге и холсте
            // Запускаем класс для отрисовки
            var imageDrawer = new ImageDrawer();

            // Создаем класс для работы с бумажным принтером
            PaperPrinter paperPrinter = new PaperPrinter();
            // Запускаем отрисовку на бумаге
            imageDrawer.DrawWith(paperPrinter);

            // Теперь нужна печать на холсте
            CanvasPainter canvasPainter = new CanvasPainter();

            // используем адаптер
            IPrinter imagePrinter = new CanvasPainterToPrinterAdapter(canvasPainter);
            // Запускаем печать на холсте
            imageDrawer.DrawWith(imagePrinter);
            Console.Read();



            /*------------------------------------------------------------------------------------------------------------------------------*/

            // КОМПОНОВЩИК (COMPOSITE) - Паттерн, позволяющий нам соединить группу объектов в древовидную структуру, а впоследствии работать с ними как с единичным объектом.
            
            // Создание корневой папки
            Component rootFolder = new Folder("Root");

            // Создание файла - компонента низшего уровня
            Component myFile = new File("MyFile.txt");

            // Создание папки с документами
            Folder documentsFolder = new Folder("MyDocuments");

            // Добавляем файл в корневую папки
            rootFolder.Add(myFile);

            // Добавляем подпапку для документов в корневую папку
            rootFolder.Add(documentsFolder);

            // показываем контент корневой папки
            rootFolder.Display();

            //Получилась довольно гибкая система: для добавления нового вида компонентов нам достаточно унаследовать новый класс от Component. 
            //К примеру, наряду с папками мы можем добавить архивы, которые тоже будут содержать папки и файлы



            /*------------------------------------------------------------------------------------------------------------------------------*/

            // ФАСАД (FACADE) - Скрывает сложность системы от клиентского кода с помощью предоставления универсального упрощенного интерфейса для взаимодействия с ней.

            // при запуске IDE инициализирует объекты для работы с компонентами
            Editor textEditor = new Editor();
            Compiller compiller = new Compiller();
            Runtime runtime = new Runtime();

            // Наша модель IDE запущена и готова к использованию
            IdeFacade ide = new IdeFacade(textEditor, compiller, runtime);

            // Начинаем писать код и нажимаем кнопку Start
            ide.Start("Console.WriteLine(\"Hello World!\");"); // запускается выполнение нашей программы
            ide.Stop();


            /*------------------------------------------------------------------------------------------------------------------------------*/
        }
    }
}
