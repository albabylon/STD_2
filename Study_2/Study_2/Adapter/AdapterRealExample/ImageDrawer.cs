using Study_2.Adapter.AdapterRealExample.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_2.Adapter.AdapterRealExample
{
    /// <summary>
    /// Класс для отрисовки изображений. Наш класс, с помощью которого мы печатаем (который поддерживает печать на бумаге, но не поддерживает печать на холсте)
    /// </summary>
    class ImageDrawer
    {
        // Метод, запускающий печать с помощью внешнего устройства
        public void DrawWith(IPrinter printer)
        {
            printer.Print();
        }
    }
}
