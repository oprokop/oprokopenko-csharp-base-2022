using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileApp
{
    public class Deposit
    {
        public string Name { get; set; }

        public int Duration { get; set; }

        public double PercentProfit { get; set; }

        public bool IsMonthlyCapitalized { get; set; }

        public Deposit()
        {
            IsMonthlyCapitalized = false;
        }

        public override string ToString()
        {
            return $"{Name};{Duration};{PercentProfit};{IsMonthlyCapitalized}";
        }

        public static Deposit FromString(string line)
        {
            var props = line.Split(';');

            var deposit = new Deposit
            {
                Name = props[0],
                Duration = int.Parse(props[1]),
                PercentProfit = double.Parse(props[2]),
                IsMonthlyCapitalized = bool.Parse(props[3])
            };
            return deposit;
        }
    }
}
