using Patterns_3_BehavioralP.Observer.ObserverRealExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_3_BehavioralP.Observer.ObserverRealExample.Observers
{
    /// <summary>
    /// Реализация брокера в качестве наблюдателя
    /// </summary>
    class Broker : IObserver
    {
        IObservable stock;

        public Broker(IObservable obs)
        {
            stock = obs;
            stock.RegisterObserver(this);
        }

        public void Update(object o)
        {
            StockData sData = (StockData)o;

            if (sData.USD > 85)
                Console.WriteLine($"Брокер продает доллары  по курсу {sData.USD}");
            else
                Console.WriteLine($"Брокер покупает доллары  по курсу {sData.USD}");
        }

        public void StopTrade()
        {
            stock.RemoveObserver(this);
            stock = null;
        }
    }
}
