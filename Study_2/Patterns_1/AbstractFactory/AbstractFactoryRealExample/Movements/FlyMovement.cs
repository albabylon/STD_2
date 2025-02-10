using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1.AbstractFactory.Movements
{
    /// <summary>
    /// Летающим монстрам доступно движение полета
    /// </summary>
    class FlyMovement : IMovement
    {
        public void Start()
        {
            Console.WriteLine("Летим");
        }
    }
}
