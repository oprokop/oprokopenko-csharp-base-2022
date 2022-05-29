using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponApp
{
    internal class Guns : LongRangedWeapon, IReload
    {
        public void Reload ()
        {
            Console.WriteLine("Reloaded");
        }
    }
}
