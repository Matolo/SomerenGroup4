using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Drink
    {
        public Drink() { }
        public Drink(int DrinkId, string DrinkName, float Price, bool IsAlcoholic, int Stock) 
        {
            this.DrinkId = DrinkId;
            this.DrinkName = DrinkName;
            this.Price = Price;
            this.IsAlcoholic = IsAlcoholic;
            this.Stock = Stock;
            this.TimesSold = 0;
        }
        public int DrinkId { get; set; }
        public string DrinkName { get; set; }
        public double Price { get; set; }
        public bool IsAlcoholic { get; set; }
        public int Stock { get; set; }
        public int TimesSold { get; set; }
    }
}
