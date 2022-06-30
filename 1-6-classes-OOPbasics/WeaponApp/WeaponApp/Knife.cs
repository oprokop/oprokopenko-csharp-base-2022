using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponApp
{
    public class Knife : MeleeWeapon, IStab, ISharpen
    {
        public const string Material = "steel";
        public int BladeLength { get; set; }
        public void Stab()
        {
            Console.WriteLine("1 stab");
        }
        public void Sharpen()
        {
            Console.WriteLine("To sharpen");
        }
        //public Knife(Knife MeleeWeapon)
        //{
        //    GripType = MeleeWeapon.GripType;
        //}
    }
}
