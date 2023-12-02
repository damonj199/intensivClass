using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intensivClass
{
    public class DrinksRecept
    {
        public string Name { get; private set; }
        public int WaterConsum { get; private set; }
        public int MilkConsum { get; private set; }
        public int CoffeeConsum { get; private set; }
        public int Price { get; private set; }

        public DrinksRecept(string name, int price, int coffeeConcum, int milkConsum, int waterConsum) 
        {
            Name = name;
            Price = price;
            WaterConsum = waterConsum;
            MilkConsum = milkConsum;
            CoffeeConsum = waterConsum;
        }
    }
}
