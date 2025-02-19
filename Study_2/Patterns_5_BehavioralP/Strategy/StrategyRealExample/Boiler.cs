using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_5_BehavioralP.Strategy.StrategyRealExample
{
    class Boiler
    {
        //  Мощность
        protected int Power;

        // Модель
        protected string Model;
        public Boiler(int power, string model, IHeater heater)
        {
            Power = power;
            Model = model;
            Heater = heater;
        }

        /// <summary>
        /// Интерфейс подключения отопителя
        /// </summary>
        public IHeater Heater { private get; set; }

        /// <summary>
        /// Запуск отопителя
        /// </summary>
        public void Start()
        {
            Heater.Heat();
        }
    }
}
