using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingApp
{
    public class Converters
    {
        public static void ToBinary(int number)
        {
            int n = 0;
            int rest;
            for (int number1 = number; number1 >= 2;)
            {
                number1 /= 2;
                n++;
                if (number1 == 2)
                {
                    n++;
                }
            }
            int[] mas = new int[n];
            for (int j = n - 1; j >= 0; j--)
            {

                if (j == 0)
                {
                    mas[0] = 1;
                }
                else
                {
                    rest = number % 2;
                    mas[j] = rest;
                    number /= 2;
                }
            }
            for (int j = 0; j < n; j++)
            {
                Console.Write(mas[j]);
            }
            Console.WriteLine();
        }
        public static string ToHex(int number)
        {

            return Convert.ToString(number);
        }
        public static string ToOct(int number)
        {

            return Convert.ToString(number);
        }
        public static void Dividing()
        {

        }
    }
}
