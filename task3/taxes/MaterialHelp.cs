using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class MaterialHelp : Tax
    {
        public MaterialHelp(Citizen citizen) : base(citizen, 0, "Материальная помощь")
        {

        }
        public override double calculateTax()

        {
            int minorChildren = 0;
            int withIncentivesChildren = 0;
            foreach (Child child in Citizen.Children)
            {   if (child.Age<=18)
                    minorChildren += 1;

                if (child.HaveTaxIncentives == true)
                    withIncentivesChildren += 1;
            }
            return -(5000 * minorChildren + 10000* withIncentivesChildren);
        }
        public override string ToString()
        {
            return string.Format("{0}:  размер {1}  ", Name, -TaxAmount);
        }
       
    }
}
