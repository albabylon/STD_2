using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1.AbstractFactory.Movements
{
    /// <summary>
    /// Большинству наземных монстров доступен бег
    /// </summary>
    class RunMovement : IMovement
    {
        public void Start()
        {
            Console.WriteLine("Бежим");
        }
    }
}
