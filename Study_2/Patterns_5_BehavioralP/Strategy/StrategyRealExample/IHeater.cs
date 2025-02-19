using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_5_BehavioralP.Strategy.StrategyRealExample
{
    /// <summary>
    /// Общий интерфейс отопительных котлов
    /// </summary>
    interface IHeater
    {
        //  Нагрев
        void Heat();
    }
}
