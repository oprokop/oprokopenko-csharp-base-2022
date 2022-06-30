using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponApp
{
    public abstract class Weapon
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public virtual void Repair()
        {
            Console.WriteLine("Repairing");
        }
    }
}
