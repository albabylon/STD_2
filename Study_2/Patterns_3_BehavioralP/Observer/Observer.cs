using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_3_BehavioralP.Observer
{
    internal class Observer
    {
        // НАБЛЮДАТЕЛЬ (OBSERVER) (Publisher-Subscriber) - множество объектов могут быть потребителями информации из одного источника (наблюдателями).
        // При изменении наблюдаемого объекта автоматически происходит оповещение всех наблюдателей.

        // Применение:
        // 1 Наша система содержит множество классов, причем состояние объектов должно быть синхронизировано.
        
        // 2 Если есть две стороны: одна из них рассылает сообщения и является главной, другая должна получать и реагировать.
        // При этом логика разделена, а системы могут рассматриваться и использоваться независимо друг от друга.
        
        // 3 Если существует один объект-источник сообщений, а у него есть множество подписчиков.
        // Количество последних при этом заранее неизвестно и может меняться в процессе работы программы.
    }

    // Нашему объекту-источнику событий Publisher не надо ничего знать о наблюдателях-подписчиках Subscriber кроме того, что там реализован метод Update().
    // Эти объекты являются слабо связанными, изменения в одном не влияют на изменения в другом.

    /// <summary>
    /// Представляет объект - источник событий
    /// ( Иначе говоря, наблюдаемый объект )
    /// </summary>
    interface IPublisher
    {
        void AddSubscriber(ISubscriber sub);
        void RemoveSubscriber(ISubscriber o);
        void Publish();
    }

    /// <summary>
    /// Конкретная реализация источника событий
    /// ( наблюдаемого объекта )
    /// </summary>
    class ConcretePublisher : IPublisher
    {
        private List<ISubscriber> subscribers;

        public ConcretePublisher()
        {
            subscribers = new List<ISubscriber>();
        }
        public void AddSubscriber(ISubscriber sub)
        {
            subscribers.Add(sub);
        }
        public void RemoveSubscriber(ISubscriber o)
        {
            subscribers.Remove(o);
        }
        public void Publish()
        {
            foreach (ISubscriber subscriber in subscribers)
                subscriber.Update();
        }
    }

    /// <summary>
    /// Тот, кто подписан на события, наблюдаемого объекта
    /// ( иначе говоря, наблюдатель )
    /// </summary>
    interface ISubscriber
    {
        void Update();
    }

    /// <summary>
    /// Конкретная реализация наблюдателя
    /// </summary>
    class ConcreteSubscriber : ISubscriber
    {
        public void Update()
        {
        }
    }
}
