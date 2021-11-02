using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class PropertySaleTax : Tax
    {
        public PropertySaleTax(Citizen citizen) : base(citizen, 16, "Налог на продажу имущества")
        {

        }
        public override double calculateTax()
        {
            return (double)this.Citizen.PropertySale / 100 * this.Rate;
        }
    }
}
