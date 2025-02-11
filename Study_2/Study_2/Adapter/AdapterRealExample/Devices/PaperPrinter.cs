using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_2.Adapter.AdapterRealExample.Devices
{
    /// <summary>
    /// Класс для работы с принтером
    /// </summary>
    class PaperPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Печатаем на бумаге");
        }
    }
}
