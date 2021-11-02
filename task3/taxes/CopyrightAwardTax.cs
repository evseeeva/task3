using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class CopyrightAwardTax : Tax
    {

             
        public CopyrightAwardTax(Citizen citizen) : base(citizen, 10, "Налог на авторские вознаграждения")
        {
        
        }
        public override double calculateTax()
        {
            return (double)this.Citizen.CopyrightAward / 100 * this.Rate;
        }
    }
}
