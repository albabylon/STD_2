using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1.AbstractFactory.Weapons
{
    /// <summary>
    /// Оружие драконов - огненное дыхание
    /// </summary>
    class FireBreath : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Дышим огнем");
        }
    }
}
