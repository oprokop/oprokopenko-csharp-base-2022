using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponApp
{
    internal class Bows : LongRangedWeapon
    {
        public void PutArrow()
        {
            Console.WriteLine("Put an arrow in a bow");
        }
    }
}
