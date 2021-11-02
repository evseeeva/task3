using System;
using System.Collections.Generic;

namespace task3
{
    class TaxInspection
    {
        static List<Citizen> citizens;
        Dictionary<int, List<Tax>> taxes;
        public TaxInspection(int numberOfCitizens )
        {
            citizens = new List<Citizen>();
            taxes = new Dictionary<int, List<Tax>>();
            for (int i = 0; i < numberOfCitizens; i++)
            {
                Citizen c = generateCitizen(i);
                citizens.Add(c);
            }
        }
        static void Main(string[] args)
        {
            TaxInspection taxInspection = new TaxInspection(4);
            taxInspection.setTaxes();
           
            for (int i = 0; i < citizens.Count; i++)
            {
                taxInspection.printCitizenInfo(i);
                taxInspection.printCitizenTaxes(i);
                taxInspection.sortTaxesBySum(i);
                taxInspection.printCitizenTaxes(i);

            }



        }

        private void setTaxes()
        {
            
            foreach (Citizen citizen in citizens)
            {
                List<Tax> taxesOfCitizen = new List<Tax>();
                taxesOfCitizen.Add(new BasicIncomeTax(citizen));
                taxesOfCitizen.Add(new AdditionalIncomeTax(citizen));
                taxesOfCitizen.Add(new CopyrightAwardTax(citizen));
                taxesOfCitizen.Add(new PropertySaleTax(citizen));
                taxesOfCitizen.Add(new GiftMoneyTax(citizen));
                taxesOfCitizen.Add(new AbroadTranserfsTax(citizen));
                taxesOfCitizen.Add(new MaterialHelp(citizen));
                List<Tax> realTaxesOfCitizen = new List<Tax>();
                foreach (Tax tax in taxesOfCitizen)
                {
                  if (tax.TaxAmount != 0) realTaxesOfCitizen.Add(tax);
                }
                taxesOfCitizen = realTaxesOfCitizen;
                taxes.Add(citizen.ID, taxesOfCitizen);
            }
        }
        private void sortTaxesBySum(int id) {
            List<Tax> taxesOfCitizen = taxes[id];
            taxesOfCitizen.Sort((a, b) => Math.Abs(b.TaxAmount).CompareTo(Math.Abs(a.TaxAmount)));
        }
        private void printCitizenInfo(int id)
        {
             citizens.Find(x => x.ID==id).getInfo();
             Console.WriteLine();
            
        }
        private void printCitizenTaxes(int id)
        {
            List<Tax> taxesOfCitizen = taxes[id];
            foreach (Tax tax in taxesOfCitizen)
            {   
                Console.WriteLine(tax.ToString());
            }
            Console.WriteLine($"Общая сумма налогов: {sumTaxes(id)}");
            Console.WriteLine();

        }
        private double sumTaxes(int id)
        {
            List<Tax> taxesOfCitizen = taxes[id];
            double sum = 0;
            foreach (Tax tax in taxesOfCitizen)
            {
                sum += tax.TaxAmount;
            }
            return sum;
        }
        private static String[] names = new String[] {"Василий", "Елена", "Петр", "Евгений", "Вячеслав", "Николай", "Анна", "Ольга", "Дмитрий", "София"};
        static Random rnd = new Random();
        private static Citizen generateCitizen(int id)
        {
            
            String name = names[rnd.Next(0, names.Length)];
            int age = rnd.Next(20,80);
            int basicIncome = (rnd.Next(0, 2) == 1) ? rnd.Next(100)*1000:0;
            int additionalIncome = (rnd.Next(0, 2) == 1) ? rnd.Next(40) * 1000 : 0;
            int copyrightAward = (rnd.Next(0, 2) == 1) ? rnd.Next(0, 100) * 1000 : 0;
            int propertySale = (rnd.Next(0, 2) == 1) ? rnd.Next(0, 1000) * 1000 : 0;
            int giftMoney = (rnd.Next(0, 2) == 1) ? rnd.Next(0, 10) * 1000 : 0;
            int abroadMoneyTransfers = (rnd.Next(0, 2) == 1) ? rnd.Next(0, 100) * 1000 : 0;
            bool haveChildren = (rnd.Next(0, 2)==1)? true: false;

            List<Child> children = new List<Child>();
            if (haveChildren) children = generateChildren();
            

            Citizen citizen = new Citizen(id, name, age, children, basicIncome, additionalIncome, copyrightAward, propertySale, 
                giftMoney, abroadMoneyTransfers);
            return citizen;
        }
        private static List<Child> generateChildren()
        {
            List<Child> childrenList = new List<Child>();

            int childNumber = rnd.Next(1, 6);

            for (int i = 0; i < childNumber; i++)
            {
                String name = names[rnd.Next(0, names.Length)];
                int age = rnd.Next(0, 40);
                bool haveTaxIncentives = (rnd.Next(0, 2) == 1) ? true : false;
                childrenList.Add(new Child(name, age, haveTaxIncentives));
            }
            return childrenList;
        }
    }
}
