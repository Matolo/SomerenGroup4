using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Globalization;

namespace SomerenDAL
{
    public class DrinkDao : BaseDao
    {
        public List<Drink> GetAllDrinks()
        {
            string query = "SELECT * FROM Drink ORDER BY DrinkName";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Drink> ReadTables(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                 Drink drink = new Drink()
                {
                    DrinkId = (int)dr["DrinkId"],
                    DrinkName = dr["DrinkName"].ToString(),
                    Price = (decimal)dr["Price"],
                    IsAlcoholic = (bool)dr["Is_Alcohol"],
                    Stock = (int)dr["Stock"],
                    TimesSold = (int)dr["TimesSold"]
                };
                drinks.Add(drink);
            }
            return drinks;
        }
        public void DeleteDrink(int DrinkId)
        {
            string query = $"DELETE FROM Drink WHERE DrinkId = {DrinkId}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void AddDrink(Drink drink)
        {
            string query = $"INSERT INTO Drink (DrinkId, DrinkName, Price, Is_Alcohol, Stock, TimesSold)" +
                $"VALUES ({drink.DrinkId}, '{drink.DrinkName}', {drink.Price}, '{drink.IsAlcoholic}', {drink.Stock}, {drink.TimesSold})";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void UpdateDrink(Drink drink)
        {
            string query = $"UPDATE Drink SET DrinkName = '{drink.DrinkName}', Price = {drink.Price}, Is_Alcohol = '{drink.IsAlcoholic}', Stock = {drink.Stock} WHERE DrinkId = {drink.DrinkId}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
