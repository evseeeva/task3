using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Child
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public bool HaveTaxIncentives { get; private set; }
        public Child(string name, int age, bool haveTaxIncentives)
        {
            Name = name;
            Age = age;
            HaveTaxIncentives = haveTaxIncentives;
        }
        
    }
}
