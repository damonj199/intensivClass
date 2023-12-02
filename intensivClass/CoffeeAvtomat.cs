using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace intensivClass
{
    public class CoffeeAvtomat
    {
        public string Name { get; set; } 
        public int Balance { get; private set; }
        public DrinksRecept[] Drinks { get; set; }
        public int RemainingWater { get; private set; }
        public int RemainingMilk { get; private set; }
        public int RemainingCoffee { get; private set; }
        public int RemainingSugar { get; private set; }
        public int Profit { get; private set; }
        public int UserBalance { get; private set; }

        public CoffeeAvtomat(string name, DrinksRecept[] drinks)
        {
            Name = name;
            Drinks = drinks;

            Balance = 0;
            RemainingMilk = 0;
            RemainingCoffee = 0;
            RemainingSugar = 0;
        }

        public void PrintMenu()
        {
            Console.WriteLine($"Меню автомата {Name}");
            for(int i = 0; i < Drinks.Length; i++)
            {
                DrinksRecept drink = Drinks[i];
                Console.WriteLine($"{i + 1} - {drink.Price}рублей."); 
            }
        }

        public void AddBalanceCash(int money)
        {
            UserBalance += money;
        }

        public void AddBalanceCard(int priceDrink)
        {
            Profit += priceDrink;
        }

        public void ByDrink(int number)
        {
            number--;
            DrinksRecept selectedDrink = Drinks[number];

            if(selectedDrink.CoffeeConsum > RemainingCoffee || selectedDrink.MilkConsum > RemainingMilk || selectedDrink.WaterConsum > RemainingWater)
            {
                Console.WriteLine($"Не достаточно молока / воды / зерна! Выберите другой напиток!");
            }
            else if(selectedDrink.Price > UserBalance)
            {
                Console.WriteLine($"Недостаточно денег! Добавьте или выберите другой напиток!");
            }
            else
            {
                Console.WriteLine($"Готово! Вот ваш {selectedDrink.Name}");

                UserBalance -= selectedDrink.Price;
                RemainingWater -= selectedDrink.WaterConsum;
                RemainingMilk -= selectedDrink.MilkConsum;
                RemainingCoffee -= selectedDrink.CoffeeConsum;
            }
        }

        public void GetChange()
        {
            Console.WriteLine($"Вот Ваша сдача {UserBalance}рублей.");

        }
    }

}
