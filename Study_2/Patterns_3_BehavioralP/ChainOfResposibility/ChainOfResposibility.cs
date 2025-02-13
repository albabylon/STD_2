using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_3_BehavioralP.ChainOfResposibility
{
    internal class ChainOfResposibility
    {
        // ЦЕПОЧКА ОБЯЗАННОСТЕЙ (CHAIN OF RESPOSIBILITY) - позволяет избежать жесткой привязки отправителя запроса к получателю

        // При реализации данного паттерна у нас имеется некая цепочка обработчиков, по которой последовательно передаются запросы.
        // При этом каждое звено цепочки (каждый обработчик) решает, может ли он обработать запрос сам, или стоит его передать дальше по цепи.

        // Применение:
        // Имеется более одного объекта, который способен обрабатывать запрос
        // Нам нужно, чтобы запрос был обработан одним или несколькими объектами, но точно не определено, кем именно
        // Если у нас динамически задаётся набор объектов
    }


    // Преимущества:
    // 1 Связи между объектами будут ослаблены. Отправитель и получатель запросов не знают друг о друге ничего.
    // Клиенту же неизвестна цепочка объектов, какие объекты её составляют и как запрос в ней передаётся
    // 2 Можно легко добавлять новые объекты, реализующие общий интерфейс

    // Недостаток:
    // Никто не гарантирует, что запрос будет обработан в итоге. Если необходимый обработчик не найден в цепочке,
    // запрос просто покидает цепочку и остается необработанным.

    class Client
    {
        void Main()
        {
            // Первый обработчик
            Handler handlerOne = new HandlerOne();

            // Второй обработчик
            Handler handlerTwo = new HandlerTwo();

            // Передача запроса по цепочке и обработка
            handlerOne.Successor = handlerTwo;
            handlerOne.HandleRequest(2);
        }
    }

    /// <summary>
    /// Базовый интерфейс обработчика
    /// </summary>
    abstract class Handler
    {
        public Handler Successor { get; set; }
        public abstract void HandleRequest(int condition);
    }

    /// <summary>
    /// Реализация первого обработчика
    /// </summary>
    class HandlerOne : Handler
    {
        public override void HandleRequest(int condition)
        {
            if (condition == 1)
            {
                // Завершение обработки при выполненном условии
            }
            else if (Successor != null)
            {
                // Условие не выполнено - передаем дальше по цепи
                Successor.HandleRequest(condition);
            }
        }
    }

    /// <summary>
    /// Реализация второго обработчика
    /// </summary>
    class HandlerTwo : Handler
    {
        public override void HandleRequest(int condition)
        {
            if (condition == 2)
            {
                // Завершение обработки при выполненном условии
            }
            else if (Successor != null)
            {
                // Условие не выполнено - передаем дальше по цепи
                Successor.HandleRequest(condition);
            }
        }
    }
}
