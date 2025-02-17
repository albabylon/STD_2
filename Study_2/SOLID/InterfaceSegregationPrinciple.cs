using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class InterfaceSegregationPrinciple
    {
        // Принцип разделения интерфейсов - рекомендуется по возможности создавать узко-специализированные интерфейсы,
        // чтобы не тащить в классы излишний функционал, который вероятнее всего реализован не будет.
    }

    // 1 Представим, что вы производите софт для управления электронными системами автомобиля, и у вас сразу несколько серийных моделей: седан, внедорожник и премиум-внедорожник.
    
    public interface ICarPackBad
    {
        /// <summary>
        /// Ехать
        /// </summary>
        void Drive();

        /// <summary>
        /// Включить понижающую передачу
        /// </summary>
        void DriveDown();

        /// <summary>
        /// Заблокировать центральный дифференциал
        /// </summary>
        void LockDifferential();

        /// <summary>
        /// Включить систему помощи при спуске
        /// </summary>
        void DescentAssist();

        /// <summary>
        /// Включить круиз - контроль
        /// </summary>
        void CruiseControl();

        /// <summary>
        /// Включить полный привод
        /// </summary>
        void FourWheelDrive();
    }

    public class SedaneBad : ICarPackBad
    {
        public void Drive()
        {
            Console.WriteLine("Просто едем");
        }

        public void CruiseControl()
        {
            Console.WriteLine("Включаем круиз-контроль");
        }

        public void DriveDown()
        {
            // Понижающая передача в седане не используется
            throw new System.NotImplementedException();
        }

        public void LockDifferential()
        {
            // Блокировки дифференциала тоже нет
            throw new System.NotImplementedException();
        }

        public void DescentAssist()
        {
            // И системы помощи при спуске
            throw new System.NotImplementedException();
        }


        public void FourWheelDrive()
        {
            // Полного привода в седане тоже нет
            throw new System.NotImplementedException();
        }
    }


    // 2 Переделаем это в соответствии с Принципом разделения интерфейсов

    /// <summary>
    /// Интерфейс с общим функционалом
    /// </summary>
    public interface IGeneralPack
    {
        void Drive();
    }

    /// <summary>
    ///  Интерфейс подключения офф-роуд систем для внедорожников
    /// </summary>
    public interface IOffRoadPack
    {
        void DriveDown();
        void LockDifferential();
        void DescentAssist();
    }

    /// <summary>
    /// Интерфейс подключения систем повышенного комфорта
    /// </summary>
    public interface IPremiumPack
    {
        void CruiseControl();
    }

    /// <summary>
    /// Интерфейс подключения спортивных систем
    /// </summary>
    public interface ISportPack
    {
        void FourWheelDrive();
    }

    /// <summary>
    /// У нас премиум-седан, поэтому кроме обычных систем подключаем системы комфорта
    /// </summary>
    public class SedaneGood : IGeneralPack, IPremiumPack
    {
        public void Drive()
        {
            Console.WriteLine("Едем");
        }

        public void CruiseControl()
        {
            Console.WriteLine("Включаем круиз-контроль");
        }
    }

    /// <summary>
    ///  Премиум - внедорожник
    /// </summary>
    public class SuvGood : IGeneralPack, IPremiumPack, ISportPack, IOffRoadPack
    {
        public void Drive()
        {
            Console.WriteLine("Едем");
        }

        public void CruiseControl()
        {
            Console.WriteLine("Включаем круиз-контроль");
        }

        public void FourWheelDrive()
        {
            Console.WriteLine("Включаем полный привод");
        }

        public void DriveDown()
        {
            Console.WriteLine("Включаем систему помощи при спуске");
        }

        public void LockDifferential()
        {
            Console.WriteLine("Включаем блокировку центрального дифференциала");
        }

        public void DescentAssist()
        {
            Console.WriteLine("Включаем систему помощи при спуске");
        }
    }

    public class Driver
    {
        public void Drive(IGeneralPack car)
        {
            car.Drive();
        }
    }
}
