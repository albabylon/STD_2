using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_4_GenerativeP.Prototype.PrototypeRealExample
{
    /// <summary>
    /// Известное место на карте
    /// </summary>
    class Place : ILocation
    {
        string Address;

        public Place(string address)
        {
            Address = address;
        }

        /// Метод для клонирования
        public ILocation Clone()
        {
            return new Place(Address);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Новый объект по адресу {Address}. ");
        }
    }
}
