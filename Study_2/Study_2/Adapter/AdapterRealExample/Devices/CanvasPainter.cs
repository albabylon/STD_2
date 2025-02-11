using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_2.Adapter.AdapterRealExample.Devices
{
    /// <summary>
    /// Класс для работы с устройством,
    /// печатающим на холсте
    /// </summary>
    class CanvasPainter : IPainter
    {
        public void Paint()
        {
            Console.WriteLine("Рисуем на холсте");
        }
    }
}
