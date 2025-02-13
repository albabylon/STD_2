using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_3_BehavioralP.Observer.ObserverRealExample.Observers
{
    /// <summary>
    /// Интерфейс наблюдаемого объекта (источника информации, на который подписаны наблюдатели)
    /// </summary>
    interface IObservable
    {
        // добавить наблюдателя
        void RegisterObserver(IObserver o);

        // удалить наблюдателя
        void RemoveObserver(IObserver o);

        // уведомление наблюдателей
        void NotifyObservers();
    }
}
