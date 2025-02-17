using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class LiskovSubstitutionPrinciple
    {
        // Принцип подстановки Барбары Лисков - цель в том, чтобы подклассы могли бы служить заменой своих базовых классов.
        // При соблюдении этого принципа мы можем использовать классы-наследники вместо родительских классов, и работа программы не будет нарушена.


        /// <summary>
        /// Метод для подсчёта количества пассажиров
        /// </summary>
        public void FlightPassengerCountBad(List<FlightBad> flights)
        {
            foreach (var flight in flights)
            {
                if (flight is DomesticFlightBad)
                    CountDomesticFlightPassengersBad((DomesticFlightBad)flight);

                if (flight is InternationalFlightBad)
                    CountInternationalFlightPassengersBad((InternationalFlightBad)flight);

                // Тут возможно считаем ещё и на других типов рейсов
            }
        }

        // Считаем пассажиров домашнего рейса
        public void CountDomesticFlightPassengersBad(DomesticFlightBad domesticFlight)
        {
            Console.WriteLine($"На рейсе {domesticFlight.Name} {domesticFlight.PassengerList.Count} пассажиров");
        }

        // Считаем пассажиров международного рейса
        public void CountInternationalFlightPassengersBad(InternationalFlightBad internationalFlight)
        {
            Console.WriteLine($"На рейсе {internationalFlight.Name} {internationalFlight.PassengerList.Count} пассажиров");
        }

    }


    /// <summary>
    /// Базовый класс для всех полетов
    /// </summary>
    public abstract class FlightBad
    {
        public string Name;
        public List<string> PassengerList;

        public FlightBad(string name, List<string> passengers = null)
        {
            Name = name;
            PassengerList = passengers ?? new List<string>();
        }
    }

    /// <summary>
    /// Внутренние рейсы
    /// </summary>
    public class DomesticFlightBad : FlightBad
    {
        public DomesticFlightBad(string name, List<string> passengers = null) : base(name, passengers)
        {
        }

        // Какой-то специфичный для внутренних рейсов функционал
    }

    /// <summary>
    /// Международные рейсы
    /// </summary>
    public class InternationalFlightBad : FlightBad
    {
        public InternationalFlightBad(string name, List<string> passengers = null) : base(name, passengers)
        {
        }

        // Какой-то специфичный для международных рейсов функционал
    }



    /// <summary>
    /// Базовый класс для всех полетов
    /// </summary>
    public abstract class FlightGood
    {
        public string Name;
        public List<string> PassengerList;

        public FlightGood(string name, List<string> passengers = null)
        {
            Name = name;
            PassengerList = passengers ?? new List<string>();
        }

        // Подсчет количества пассажиров
        public void CountPassengers()
        {
            Console.WriteLine($"На рейсе {Name} {PassengerList.Count} пассажиров");
        }
    }
    
    /// <summary>
    /// Внутренние рейсы
    /// </summary>
    public class DomesticFlightGood : FlightGood
    {
        public DomesticFlightGood(string name, List<string> passengers = null) : base(name, passengers)
        {
        }

        // Какой-то специфичный для внутренних рейсов функционал
    }

    /// <summary>
    /// Международные рейсы
    /// </summary>
    public class InternationalFlightGood : FlightGood
    {
        public InternationalFlightGood(string name, List<string> passengers = null) : base(name, passengers)
        {
        }

        // Какой-то специфичный для международных рейсов функционал
    }
}
