using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_5_BehavioralP.Command
{
    internal class CommandEx
    {
        // КОМАНДА (COMMAND) - позволяет нам превратить запросы в объекты и передавать их потом как аргументы при вызове методов.
        // Применение:
        // 1 Нам надо передать в виде параметров какие-то действия, и в ответ мы должны получить другие действия. То есть нам нужно получить обратный ответ.
        // 2 Нам нужна очередь запросов, а также возможность их отмены.
        // 3 Нам нужно контролировать изменения в логах и отслеживать поведение нашей системы. Это нам также поможет восстановить систему в случае сбоев.
    }

    /// <summary>
    /// Базовый класс команды
    /// </summary>
    abstract class Command
    {
        public abstract void Run();
        public abstract void Cancel();
    }

    /// <summary>
    /// Отправитель команды
    /// </summary>
    class Sender
    {
        Command _command;

        public void SetCommand(Command command)
        {
            _command = command;
        }

        // Выполнить
        public void Run()
        {
            _command.Run();
        }

        // Отменить
        public void Cancel()
        {
            _command.Cancel();
        }
    }


    /// <summary>
    /// Адресат команды
    /// </summary>
    class Receiver
    {
        public void Operation()
        {
            Console.WriteLine("Процесс запущен");
        }
    }


    /// <summary>
    /// Конкретная реализация команды.
    /// </summary>
    class CommandOne : Command
    {
        Receiver receiver;

        public CommandOne(Receiver receiver)
        {
            this.receiver = receiver;
        }

        // Выполнить
        public override void Run()
        {
            Console.WriteLine("Команда отправлена");
            receiver.Operation();
        }

        // Отменить
        public override void Cancel()
        { }
    }

    /// <summary>
    /// Клиентский код
    /// </summary>
    class Client
    {
        static void Main()
        {
            // создадим отправителя
            var sender = new Sender();

            // создадим получателя
            var receiver = new Receiver();

            // создадим команду
            var commandOne = new CommandOne(receiver);

            // инициализация команды
            sender.SetCommand(commandOne);

            //  выполнение
            sender.Run();
        }
    }

    // Плюсы:
    // 1 Тот, кто отправляет команду (в нашем случае это класс Sender) ничего не знает о получателе Receiver, выполняющем команду.
    // Мы также с легкостью можем добавить новые команды, унаследовав базовый класс Command.
    
    // 2 Этот паттерн на C# имеет очень широкое применение в масштабных приложениях уровня enterprise.
    // В будущем вы наверняка столкнетесь с ним при разработке API-сервисов и других .NET Core-приложений. 
    
    // 3 Очень часто они имеют структуру из нескольких слоев,
    // один из которых может отвечать за пользовательский интерфейс, другой — за бизнес-логику, а третий — за взаимодействие с данными.
    
    // 4 Общаться между собой при этом слои могут как раз с помощью команд.
}
