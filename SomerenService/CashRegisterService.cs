using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;

namespace SomerenService
{
    public class CashRegisterService
    {
        private CashRegisterDao cashRegisterdb;

        public CashRegisterService()
        {
            cashRegisterdb = new CashRegisterDao();
        }
        public void RegisterCheckOut(Student student, Drink drink, DateTime time) 
        { 
            cashRegisterdb.RegisterCheckOut(student, drink, time);
        }
        public List<int> GetYears()
        {
            return cashRegisterdb.GetYears();
        }
    }
}