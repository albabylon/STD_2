using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_3_BehavioralP.State
{
    internal class StateEx
    {
        // СОСТОЯНИЕ (STATE) - наши объекты получают возможность менять своё поведение в зависимости от внутреннего состояния.
        // Применение:
        // Когда поведение некоторых объектов в нашей программе может динамически изменяться в зависимости от состояния.
        // Когда вы обнаружили в коде слишком много условных конструкций, которые обрабатывают различные состояния одного объекта.
    }

    /// <summary>
    /// Общий интерфейс, определяющий состояния
    /// </summary>
    abstract class State
    {
        public abstract void Handle(ContextObject contextObject);
    }

    /// <summary>
    /// Сам объект, поведение которого должно изменяться
    /// </summary>
    class ContextObject
    {
        public State State { get; set; }
        public ContextObject(State state)
        {
            State = state;
        }

        public void Switch()
        {
            State.Handle(this);
        }
    }

    /// <summary>
    /// Первое состояние
    /// </summary>
    class StateOne : State
    {
        public override void Handle(ContextObject contextObject)
        {
            contextObject.State = new StateTwo();
        }
    }

    /// <summary>
    /// Второе состояние
    /// </summary>
    class StateTwo : State
    {
        public override void Handle(ContextObject contextObject)
        {
            contextObject.State = new StateOne();
        }
    }

    class Program
    {
        static void MainShow()
        {
            // создаем объет сразу в каким-то состоянии
            var contextObject = new ContextObject(new StateOne());

            contextObject.Switch(); // Переход в состояние StateTwo
            contextObject.Switch(); // Переход в состояние StateOne
        }
    }
}
