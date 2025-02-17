using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class OpenClosedPrinciple
    {
        // Принцип открытости/закрытости - сущности программы должны быть открыты для расширения, но закрыты для модификации
    }

    class BoardComputerBad
    {
        public void GroundLanding()
        {
            Console.WriteLine("Сбрасываем скорость");
            Console.WriteLine("Опускаем руль высоты");
            Console.WriteLine("Сбрасываем скорость");
            Console.WriteLine("Выпускаем шасси");
            Console.WriteLine("Поднимаем руль высоты");
            Console.WriteLine("Сбрасываем скорость");
            Console.WriteLine("--Посадка--");
            Console.WriteLine("Выпускаем тормозной парашют");

        }
    }


    // Допустим, часть наших легкомоторных самолетов имеет также возможность посадки на воду

    /// <summary>
    /// Общий интерфейс для профилей посадки
    /// </summary>
    public interface ILandingProfile
    {
        void Execute();
    }

    /// <summary>
    /// Профиль для посадки на землю
    /// </summary>
    public class GroundLandingProfile : ILandingProfile
    {
        public void Execute()
        {
            Console.WriteLine(">> Загружен профиль: ПОСАДКА НА ЗЕМЛЮ <<");

            Console.WriteLine("Сбрасываем скорость");
            Console.WriteLine("Опускаем руль высоты");
            Console.WriteLine("Сбрасываем скорость");
            Console.WriteLine("Выпускаем шасси");
            Console.WriteLine("Поднимаем руль высоты");
            Console.WriteLine("Сбрасываем скорость");
            Console.WriteLine("--ПОСАДКА--");
            Console.WriteLine("Выпускаем тормозной парашют");
        }
    }

    /// <summary>
    /// Профиль для посадки на воду
    /// </summary>
    public class WaterLandingProfile : ILandingProfile
    {
        public void Execute()
        {
            Console.WriteLine(">> Загружен профиль: ПОСАДКА НА ВОДУ <<");

            Console.WriteLine("Сбрасываем скорость");
            Console.WriteLine("Опускаем руль высоты");
            Console.WriteLine("Сбрасываем скорость");
            Console.WriteLine("Поднимаем руль высоты");
            Console.WriteLine("Сбрасываем скорость");
            Console.WriteLine("--ПОСАДКА--");
        }
    }

    class BoardComputerGood
    {
        /// <summary>
        /// Запускает посадку
        /// Загружает профиль в виде аргумента
        /// </summary>
        public void PerformLanding(ILandingProfile landingProfile)
        {
            landingProfile.Execute();
        }
    }
}
