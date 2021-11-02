using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
   abstract class Tax

    {
        public double Rate { get; private set; }
        public double TaxAmount { get; private set; }
        public Citizen Citizen{ get; private set; }
        public string Name { get; private set; }
        public Tax(Citizen citizen, double rate, String name)
        {
            Citizen = citizen;
            Rate = rate;
            Name = name;
            TaxAmount = calculateTax();
        }
        public abstract double calculateTax();
        public override string ToString()
        {
            return string.Format("{0}: ставка {1}, размер {2}  ", Name, Rate, TaxAmount);
        }

    }
}
