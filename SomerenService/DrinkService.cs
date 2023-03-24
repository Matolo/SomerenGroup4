using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class DrinkService
    {
        private DrinkDao drinkdb;

        public DrinkService()
        {
            drinkdb = new DrinkDao();
        }

        public List<Drink> GetDrinks()
        {
            List<Drink> drinks = drinkdb.GetAllDrinks();
            return drinks;
        }
        public void DeleteDrink(int DrinkId)
        {
            drinkdb.DeleteDrink(DrinkId);
        }
        public void AddDrink(Drink drink)
        {
            drinkdb.AddDrink(drink);
        }
        public void UpdateDrink(Drink drink)
        {
            drinkdb.UpdateDrink(drink);
        }
        public List<Drink> GetSoldDrinks(DateTime start, DateTime end)
        {
            List<Drink> drinks = drinkdb.GetSoldDrinks(start, end);
            return drinks;
        }
    }
}