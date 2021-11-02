using System;
using System.Collections.Generic;
using System.Linq;


namespace task3
{
    class Citizen
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public List<Child> Children { get; private set; }
        public int BasicIncome { get; private set; }
        public int AdditionalIncome { get; private set; }
        public int CopyrightAward { get; private set; }
        public int PropertySale { get; private set; }
        public int GiftMoney { get; private set; }
        public int AbroadMoneyTransfers { get; private set; }

        public Citizen(int id, string name, int age, List<Child> children, int basicIncome, int additionalIncome, int copyrightAward, int propertySale,
           int giftMoney, int abroadMoneyTransfers)
        {
            ID = id;
            Name = name;
            Age = age;
            Children = children;
            BasicIncome = basicIncome;
            AdditionalIncome = additionalIncome;
            CopyrightAward = copyrightAward;
            PropertySale = propertySale;
            GiftMoney = giftMoney;
            AbroadMoneyTransfers = abroadMoneyTransfers;

        }
       
        public int getChildrenCount()
        {
           return Children.Count();
        }
        public void getInfo()
        {
            Console.WriteLine("Сведения о гражданине(на текущий месяц):");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Возраст: {Age}");
            Console.WriteLine($"Кол-во детей: { getChildrenCount()}");
            Console.WriteLine($"Доход с основного места работы: {BasicIncome}");
            Console.WriteLine($"Доход с дополнительного места работы: {AdditionalIncome}");
            Console.WriteLine($"Авторские вознаграждения: {CopyrightAward}");
            Console.WriteLine($"Продажа имущества: {PropertySale}");
            Console.WriteLine($"Получение денег в подарок: {GiftMoney}");
            Console.WriteLine($"Переводы из-за границы: {AbroadMoneyTransfers}");
        }
    }
}

