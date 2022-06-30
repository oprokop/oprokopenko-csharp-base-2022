using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponApp
{
    internal abstract class LongRangedWeapon : Weapon
    {
        public int Range { get; set; }
        public abstract void Shoot();
    }
}
