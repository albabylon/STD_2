using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_5_BehavioralP.Strategy
{
    internal class Strategy
    {
        // СТРАТЕГИЯ (STRATEGY) - под Стратегией здесь понимается некий набор (или семейство) схожих алгоритмов, которые помещаются (инкапсулируются)
        // в классе, и могут потом взаимозаменяться во время исполнения программы.
        // Применение:
        // 1 У нас есть несколько похожих родственных классов, отличающихся поведением.
        // Тогда мы можем сделать один основной класс, а эти различающиеся варианты поведения вынести в отдельные классы, и применять по мере необходимости.
        // 2 У нас есть несколько вариантов алгоритмов, которые мы можем менять в зависимости от условий
        // 3 Во время выполнения программы нам нужно менять поведение объектов.
        // 4 Класс, в котором определен функционал, не должен ничего знать о реализации.
    }

    /// <summary>
    /// Общий интерфейс некоего алгоритма
    /// </summary>
    public interface IStrategy
    {
        void Algorithm();
    }

    /// <summary>
    /// Первая реализация алгоритма
    /// </summary>
    public class StrategyOne : IStrategy
    {
        public void Algorithm()
        { }
    }

    /// <summary>
    /// Вторая реализация алгоритма
    /// </summary>
    public class StrategyTwo : IStrategy
    {
        public void Algorithm()
        { }
    }

    /// <summary>
    /// Клиентский код
    /// </summary>
    public class Client
    {
        public IStrategy ClientStrategy { get; set; }

        public Client(IStrategy strategy)
        {
            ClientStrategy = strategy;
        }

        // Выполнение стратегии
        public void ExecuteAlgorithm()
        {
            ClientStrategy.Algorithm();
        }
    }

    // Наш клиент получил ссылку на объект IStrategy и может принимать любые конкретные реализации стратегии.
    // В зависимости от этого будут использоваться разные алгоритмы без привязки к конкретной реализации стратегии.
}
