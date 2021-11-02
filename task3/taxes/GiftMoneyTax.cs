using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class GiftMoneyTax : Tax
    {
        public GiftMoneyTax(Citizen citizen) : base(citizen, 13.5, "Налог на подаренное имущество")
        {

        }
        public override double calculateTax()
        {
            return (double)this.Citizen.GiftMoney / 100 * this.Rate;
        }
    }
}
