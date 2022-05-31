using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponApp
{
    internal class Gun : LongRangedWeapon, IReload
    {
        public string Type { get; set; } // firearm or air gun
        public void Reload ()
        {
            Console.WriteLine("Reloaded");
        }
    }
}
