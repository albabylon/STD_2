using Patterns_1.AbstractFactory.Movements;
using Patterns_1.AbstractFactory.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1.AbstractFactory.Factories
{
    /// <summary>
    /// У нас есть фабрика по производству орков!
    /// Саурон нервно курит в сторонке.
    /// </summary>
    class OrcFactory : IMonsterFactory
    {
        public IMovement CreateMovement()
        {
            return new RunMovement();
        }
        public IWeapon CreateWeapon()
        {
            return new Axe();
        }
    }
}
