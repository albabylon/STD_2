using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_5_BehavioralP.Strategy.StrategyRealExample
{
    /// <summary>
    ///  Реализация газового отопления
    /// </summary>
    class GasHeater : IHeater
    {
        public void Heat()
        {
            Console.WriteLine("Нагрев газом");
        }
    }
}
