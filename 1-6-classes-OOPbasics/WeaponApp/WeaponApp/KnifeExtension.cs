using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponApp
{
    public static class KnifeExtension
    {
        public static void Copy (this Knife knife1)
        {
            var knife2 = new Knife();
            knife2.Name = knife1.Name;
            knife2.BladeLength = knife1.BladeLength;
            knife2.Weight = knife1.Weight;
            knife2.GripType = knife1.GripType;
            Console.WriteLine("Name is " + knife2.Name + ";");
            Console.WriteLine("Blade length : " + knife2.BladeLength + ";");
            Console.WriteLine("Weight : " + knife2.Weight + ";");
            Console.WriteLine("Grip type : " + knife2.GripType + ";");
        }
    }
}
