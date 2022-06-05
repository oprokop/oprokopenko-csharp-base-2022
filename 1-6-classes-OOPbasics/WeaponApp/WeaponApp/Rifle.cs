using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponApp
{
    internal class Rifle : LongRangedWeapon, IReload
    {
        public string Type { get; set; } // firearm or air gun
        public override void Shoot()
        {
            Console.WriteLine("1 shoot");
        }
        public void Reload()
        {
            Console.WriteLine("Reloaded");
        }
    }
}
