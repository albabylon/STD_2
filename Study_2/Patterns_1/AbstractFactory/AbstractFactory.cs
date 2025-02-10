using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1.AbstractFactory
{
    internal class AbstractFactory
    {
        // АБСТРАКТНАЯ ФАБРИКА - Позволяет нам создавать группы связанных объектов без привязки к конкретным классам.
        // Применение:
        // - Ваша система не должна зависеть от способа компоновки объектов
        // - Объекты в вашей системе должны использоваться вместе и быть взаимосвязанными
    }

    abstract class AbstractProductA
    { }

    abstract class AbstractProductB
    { }

    class ProductA1 : AbstractProductA
    { }

    class ProductB1 : AbstractProductB
    { }

    class ProductA2 : AbstractProductA
    { }

    class ProductB2 : AbstractProductB
    { }



    /// <summary>
    /// Базовый интерфейс абстрактной фабрики
    /// </summary>
    interface IAbstractFactory
    {
        // Абстрактный метод для создания продукта  A
        AbstractProductA CreateProductA();

        // Абстрактный метод для создания продукта  B
        AbstractProductB CreateProductB();
    }

    /// <summary>
    ///  Первая конкретная реализация фабрики
    /// </summary>
    class ConcreteFactory1 : IAbstractFactory
    {
        // Конкретная реализация метода для создания продукта  A
        public AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        // Конкретная реализация метода для создания продукта  A
        public AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    /// <summary>
    ///  Вторая конкретная реализация фабрики
    /// </summary>
    class ConcreteFactory2 : IAbstractFactory
    {
        // Конкретная реализация метода для создания продукта  A
        public AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        // Конкретная реализация метода для создания продукта  B
        public AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }


    /// <summary>
    /// Класс, в котором нам нужно предусмотреть создание объектов фабрикой
    /// </summary>
    class Client
    {
        private AbstractProductA _abstractProductA;
        private AbstractProductB _abstractProductB;

        /// <summary>
        ///  Конструктор класса, в котором происходит создание объектов фабрики
        /// </summary>
        public Client(IAbstractFactory factory)
        {
            _abstractProductB = factory.CreateProductB();
            _abstractProductA = factory.CreateProductA();
        }

        /// <summary>
        ///  Метод с нашей бизнес-логикой, где будут использоваться создаваемые фабрикой объекты
        /// </summary>
        public void Run()
        { }
    }
}
