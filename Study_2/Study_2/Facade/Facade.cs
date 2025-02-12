using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_2.Facade
{
    internal class FacadeEx
    {
        // ФАСАД (FACADE) - Скрывает сложность системы от клиентского кода с помощью предоставления универсального упрощенного интерфейса для взаимодействия с ней.
        // Применение:
        // 1 Система сложна, необходимо упростить с ней работу. Фасад позволит определить одну упрощенную точку взаимодействия с ней.
        // 2 В коде может возникнуть слишком много зависимостей между клиентом и сложной системой.
        // Реализация фасада позволит отделить (изолировать) части и компоненты сложной системы от клиента и работать с ними независимо.
        // 3 Если нам нужно определить подсистемы компонентов в сложной системе. Создание фасадов для компонентов каждой отдельной подсистемы упрощает взаимодействие между ними.
    }

    public class SystemOne
    {
        public void S1Method()
        { }
    }

    public class SystemTwo
    {
        public void S2Method()
        { }
    }

    public class SystemThree
    {
        public void S3Method()
        { }
    }

    /// <summary>
    /// Фасад, скрывающий от клиентского кода взаимодействие с системами
    /// </summary>
    public class Facade
    {
        private SystemOne _systemOne;
        private SystemTwo _systemTwo;
        private SystemThree _systemThree;

        /// <summary>
        ///  Метод-конструктор принимает системы на вход
        /// </summary>
        public Facade(SystemOne systemOne, SystemTwo systemTwo, SystemThree systemThree)
        {
            _systemOne = systemOne;
            _systemTwo = systemTwo;
            _systemThree = systemThree;
        }

        // методы для клиента, через которые он взаимодействует с системами
        public void OperationOne()
        {
            _systemOne.S1Method();
            _systemTwo.S2Method();
            _systemThree.S3Method();
        }
        public void OperationTwo()
        {
            _systemTwo.S2Method();
            _systemThree.S3Method();
        }
    }

    /// <summary>
    /// Клиентский код
    /// </summary>
    class Client
    {
        public void Main()
        {
            // Создание фасада
            Facade facade = new Facade(new SystemOne(), new SystemTwo(), new SystemThree());

            // Вызовы
            facade.OperationOne();
            facade.OperationTwo();
        }
    }
}
