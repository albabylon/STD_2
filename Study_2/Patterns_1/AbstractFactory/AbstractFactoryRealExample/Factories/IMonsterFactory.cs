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
    ///  Интерфейс абстрактной фабрики
    /// </summary>
    interface IMonsterFactory
    {
        IMovement CreateMovement();
        IWeapon CreateWeapon();
    }
}
