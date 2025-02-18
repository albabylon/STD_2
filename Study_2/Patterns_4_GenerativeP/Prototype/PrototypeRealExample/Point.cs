using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_4_GenerativeP.Prototype.PrototypeRealExample
{
    /// <summary>
    /// Обычная точка на карте
    /// </summary>
    class Point : ILocation
    {
        double Latitude;
        double Longitude;

        public Point(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        /// Метод для клонирования
        public ILocation Clone()
        {
            return new Point(Latitude, Longitude);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Новая точка на карте с координатами {Longitude}, {Latitude}");
        }
    }
}
