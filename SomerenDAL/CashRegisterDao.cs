using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
using System;
using System.Linq;

namespace SomerenDAL
{
    public class CashRegisterDao : BaseDao
    {
        public void RegisterCheckOut(Student student, Drink drink, DateTime time)
        {

            string query = $"INSERT INTO CashRegister1 (DrinkId, StudentId, Date) " +
                 $"VALUES ({drink.DrinkId}, {student.StudentId}, '{time:yyyy-MM-dd HH:mm:ss}')" +
                 $"SELECT * FROM CashRegister1"; //FOR SOME REASON IT COMPLAINS IF I DON'T USE THE TABLE AFTERWARDS SO I CHEAPLY USE IT HERE SO I DON'T GET ERRORS I WILL FIX THIS LATER ON 
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteSelectQuery(query, sqlParameters);
            string query2 =  $"UPDATE Drink SET TimesSold = {drink.TimesSold + 1} WHERE DrinkId = {drink.DrinkId}" +
                $"SELECT * FROM CashRegister1";
            SqlParameter[] sqlParameters2 = new SqlParameter[0];
            ExecuteSelectQuery(query2, sqlParameters2);
        }
        public List<int> GetYears()
        {
            string query = "SELECT Date FROM CashRegister1";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ReadYears(ExecuteSelectQuery(query, sqlParameters));
            List<DateTime> years = ReadYears(ExecuteSelectQuery(query, sqlParameters));
            List<int> convertedYears = new List<int>();


            foreach (DateTime year in years)
            {
                convertedYears.Add(Convert.ToDateTime(year).Year);
            }
            convertedYears = convertedYears.Distinct().ToList();
            return convertedYears;
        }
        private List<DateTime> ReadYears(DataTable dataTable)
        {
            List<DateTime> years = new List<DateTime>();

            foreach (DataRow dr in dataTable.Rows)
            {
                years.Add((DateTime)dr["Date"]);
            }
            return years;
        }
    }
}