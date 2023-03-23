using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class DrinkDao : BaseDao
    {
        public List<Drink> GetAllDrinks()
        {
            string query = "SELECT DrinkID, DrinkName, Price, Is_Alchol ,Stock FROM Drink";
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
                    Price = (int)dr["Price"],
                    Is_Alchol = (bool)dr["Is_Alchol"],
                    Stock = (int)dr["Stock"],
                };
                drinks.Add(drink);
            }
            return drinks;
        }
    }
}
