using intensivClass;
using System.Reflection.Metadata.Ecma335;

DrinksRecept[] drinks = Array.Empty<DrinksRecept>();

CoffeeAvtomat vending = new CoffeeAvtomat("Центр", drinks);
vending.RemainingCoffee = 2000;
vending.RemainingMilk = 1000;
vending.RemainingSugar = 1000;
vending.Balance = 5000;

vending.PrintMenu();
Console.WriteLine();

vending.AddBalanceCash(250);
Console.WriteLine();

vending.ByDrink(2);
vending.ByDrink(1);
Console.WriteLine();

vending.GetChange();
Console.WriteLine();
