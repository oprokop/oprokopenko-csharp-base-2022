﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponApp
{
    internal class LongRangedWeapon : Weapon
    {
        public int Range { get; set; }
        public void Shoot()
        {
            Console.WriteLine("1 shoot");
        }
    }
}
