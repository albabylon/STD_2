using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SOLID

            // 1 Single Responsibility Principle (Принцип единственной обязанности):

            // У класса должна быть только одна причина для изменения.
            // Под обязанностью мы тут подразумеваем те функции, которые решает ваш класс, или задачу вашего класса.
            // Суть в том, что задача у класса должна быть одна. Вы не должны пытаться добавить в ваш класс то, для чего он изначально не создавался просто потому, что так удобно.
            // Лучше в этом случае создать отдельный класс.
            // Если же вам понадобилось расширить функционал класса дополнительными функциями(но они всё равно выполняют ту цель, для которой класс создавался),
            // то проблем нет, принцип в данном случае не нарушается

            IExporter exporter = new PdfExporter();
            DocumentGood doc = new DocumentGood();
            doc.Text = "Hello World";
            doc.Export(exporter);


            // 2 Open/Closed Principle (Принцип открытости/закрытости):

            // Сущности программы должны быть открыты для расширения, но закрыты для модификации.
            // Иначе говоря, вы должны проектировать классы так, чтобы при необходимости их можно было легко дополнить (то есть оставлять задел на будущее,
            // возможности для масштабирования и роста функционала).
            // При разработке стоит по возможности закладывать необходимый минимум функционала, и иметь в виду,
            // что в дальнейшем он будет расширен, а то, что уже работает не сломается.

            var boardComputer = new BoardComputerGood();
            // посадка на землю
            boardComputer.PerformLanding(new GroundLandingProfile());
            // посадка на воду
            boardComputer.PerformLanding(new WaterLandingProfile());


            // 3 Liskov Substitution Principle (Принцип подстановки Барбары Лисков):

            // Цель в том, чтобы подклассы могли бы служить заменой своих базовых классов.
            // При соблюдении этого принципа мы можем использовать классы-наследники вместо родительских классов, и работа программы не будет нарушена.
            // Если мы видим, что в коде идёт проверка на тип класса, то данный принцип нарушен. Код в этом случае стоит переписать так, чтобы не завязываться на конкретный тип.

            // Новый список полётов
            var flightsList = new List<FlightGood>()
            {
                new DomesticFlightGood("Mow-32", new List<string>() {"Вася", "Петя"}),
                new DomesticFlightGood("SPB-14", new List<string>() {"Андрей"})
            };
            // Считаем пассажиров
            FlightPassengerCount(flightsList);


            // 4 Interface Segregation Principle (Принцип разделения интерфейсов):

            // Рекомендуется по возможности создавать узко-специализированные интерфейсы,
            // чтобы не тащить в классы излишний функционал, который, вероятнее всего, реализован не будет.
            // Стоит по возможности разделять интерфейс класса на отдельные части. Позже вы сможете применять и изменять их независимо друг от друга.
            // Следование этому принципу делает систему слабо связанной, и её проще поддерживать и обновлять.
            
            // наш водитель
            var driver = new Driver();
            // водителю всё равно, на чём ехать
            Console.WriteLine("Садимся в седан");
            driver.Drive(new SedaneGood());
            Console.WriteLine("Садимся в джип");
            driver.Drive(new SuvGood());


            // 5 Dependency Inversion Principle (Принцип инверсии зависимостей):

            // Объектом зависимости должна быть абстракция, а не что-то конкретное.
            // Абстракция(интерфейс — самый распространенный пример) не должна зависеть от деталей реализации. Наоборот, реализация должна зависеть от абстракции.

            //  выводим на монитор
            var connectedMonitor = new VideoAdapter(new MonitorGood());
            connectedMonitor.Display();
            //  выводим на телевизор
            var connectedTv = new VideoAdapter(new TvGood());
            connectedTv.Display();
        }



        /// <summary>
        /// Метод для подсчёта количества пассажиров
        /// </summary>
        public static void FlightPassengerCount(List<FlightGood> flights)
        {
            foreach (var flight in flights)
                flight.CountPassengers();
        }
    }
}
