using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class AbroadTranserfsTax : Tax
    {


        public AbroadTranserfsTax(Citizen citizen) : base(citizen, 15, "Налог на переводы из-за границы")
        {

        }
        public override double calculateTax()
        {
            return (double)this.Citizen.AbroadMoneyTransfers / 100 * this.Rate;
        }
    }
}
