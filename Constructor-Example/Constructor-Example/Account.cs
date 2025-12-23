using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSession
{
    public class Account
    {

        public int AccountId { get; set; }
        public string AccountName { get; set; }


        public string getAccountDetials()
        {
            return $"I am from base class. Account Id is {AccountId}";
        }
    }
    public class SalesAccount: Account {
        public string GetSalesAccountDetails()
        {
            string info = string.Empty;
            info += base.getAccountDetials();
            info += " I am from sales Derived Class";
            return info;
        }
    }

    public class PurchaseAccount : Account
    {
        public string GetPurchaseAccountDetails()
        {
            string info = string.Empty;
            info += base.getAccountDetials();
            info += " I am from purchase Derived Class";
            return info;
        }
    }
}
