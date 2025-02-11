using Study_2.Adapter.AdapterRealExample.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_2.Adapter.AdapterRealExample
{
    /// <summary>
    /// Адаптер от CanvasPainter к IPrinter
    /// </summary>
    class CanvasPainterToPrinterAdapter : IPrinter
    {
        private CanvasPainter _canvasPainter;
        public CanvasPainterToPrinterAdapter(CanvasPainter canvasPainter)
        {
            _canvasPainter = canvasPainter;
        }

        public void Print()
        {
            _canvasPainter.Paint();
        }
    }
}
