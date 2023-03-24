using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
using System;

namespace SomerenDAL
{
    public class CashRegisterDao : BaseDao
    {
        public void RegisterCheckOut(Student student, Drink drink, string time)
        {

            string query = $"INSERT INTO CashRegister1 (DrinkId, StudentId, Date) " +
                 $"VALUES ({drink.DrinkId}, {student.StudentId}, '{time:yyyy-MM-dd HH':'mm':'ss}')" +
                 $"SELECT * FROM CashRegister1"; //FOR SOME REASON IT COMPLAINS IF I DON'T USE THE TABLE AFTERWARDS SO I CHEAPLY USE IT HERE SO I DON'T GET ERRORS I WILL FIX THIS LATER ON 
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteSelectQuery(query, sqlParameters);
            string query2 =  $"UPDATE Drink SET TimesSold = {drink.TimesSold + 1} WHERE DrinkId = {drink.DrinkId}" +
                $"SELECT * FROM CashRegister1";
            SqlParameter[] sqlParameters2 = new SqlParameter[0];
            ExecuteSelectQuery(query2, sqlParameters2);
        }  
    }
}