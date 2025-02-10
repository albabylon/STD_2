using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1.FactoryMethod
{
    internal class FactoryMethod
    {
        // ФАБРИЧНЫЙ МЕТОД - Даёт нам возможность определить некую универсальную конструкцию для создания объектов в основном классе.
        // Далее в классах-наследниках будет приниматься решение о том, какой именно тип объекта будет создан

        // Применение:
        // - Когда заранее неизвестен тип создаваемых объектов.
        // - Когда в системе нужно заранее предусмотреть независимость от процесса создания новых объектов и расширяемость.
        // При этом легко можно будет добавлять поддержку создания объектов нового класса.
        // - Когда создание объектов необходимо делегировать от основного класса классам-наследникам

        
        /// <summary>
        /// Базовый абстрактный класс
        /// </summary>
        abstract class BaseClass
        { }

        /// <summary>
        /// Конкретная реализация A
        /// </summary>
        class ConcreteClassA : BaseClass
        { }

        /// <summary>
        /// Конкретная реализация B
        /// </summary>
        class ConcreteClassB : BaseClass
        { }

        /// <summary>
        /// Абстрактный класс, от которого наследуются конкретные реализации
        /// </summary>
        abstract class Creator
        {
            /// Фабричный метод, который будет переопределен в классах-наследниках
            public abstract BaseClass FactoryMethod();
        }

        /// <summary>
        /// Конкретная реализация A
        /// </summary>
        class ConcreteCreatorA : Creator
        {
            //  Переопределенный Фабричный метод здесь возвращает конкретную реализацию
            public override BaseClass FactoryMethod()
            {
                return new ConcreteClassA();
            }
        }
        /// <summary>
        /// Конкретная реализация B
        /// </summary>
        class ConcreteCreatorB : Creator
        {
            //  Переопределенный Фабричный метод здесь возвращает конкретную реализацию
            public override BaseClass FactoryMethod()
            {
                return new ConcreteClassB();
            }
        }
    }
}
