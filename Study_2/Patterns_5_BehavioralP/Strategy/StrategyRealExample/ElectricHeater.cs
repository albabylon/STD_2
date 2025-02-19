using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_5_BehavioralP.Strategy.StrategyRealExample
{
    /// <summary>
    /// Реализация электрического отопления
    /// </summary>
    class ElectricHeater : IHeater
    {
        public void Heat()
        {
            Console.WriteLine("Нагрев электричеством");
        }
    }
}
