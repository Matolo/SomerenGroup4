﻿using System.Collections.Generic;
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
                 $"VALUES ({drink.DrinkId}, {student.StudentId}, '{time:yyyy-MM-dd HH':'mm':'ss}')";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteSelectQuery(query, sqlParameters);
        }
        
    }
}