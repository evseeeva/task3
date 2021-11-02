using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class BasicIncomeTax : Tax
    {
        public BasicIncomeTax(Citizen citizen) : base(citizen, 13, "Налог на основной доход")
        {

        }
        public override double calculateTax()
        {
            return (double)this.Citizen.BasicIncome / 100 * this.Rate;

        }
        


    }
}
