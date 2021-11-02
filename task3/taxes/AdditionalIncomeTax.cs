using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class AdditionalIncomeTax : Tax
    {
        public AdditionalIncomeTax(Citizen citizen) : base(citizen, 13, "Налог на дополнительный доход")
        {

        }
        public override double calculateTax()
        {
            return (double)this.Citizen.AdditionalIncome / 100 * this.Rate;
        }
    }
}
