using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponApp
{
    internal class Pike : MeleeWeapon, IStab, ISharpen
    {
        public readonly string Material = "wood";
        public int Length { get; set; }
        public void Stab()
        {
            Console.WriteLine("1 stab");
        }
        public void Sharpen()
        {
            Console.WriteLine("To sharpen");
        }
    }
}
