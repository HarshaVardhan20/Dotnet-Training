using System;
using OopsSession.ConstructorEx;

namespace OopsSession
{

    public class Program
    {
        public static void Main(string[] args) {
            //try
            //{
            //    Employee emp = new Employee(1, "", 2);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //try
            //{
            //    Employee emp = new Employee(1, "Harsha", 200);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //try
            //{
            //    Employee emp = new Employee(-1, "Vishnu", 2);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Account acc = new Account { AccountId = 1, AccountName = "Person 1"};
            //Console.WriteLine(acc.getAccountDetials());

            //SalesAccount acc2 = new SalesAccount { AccountId = 2, AccountName = "Person 2" };
            //Console.WriteLine(acc2.GetSalesAccountDetails());


            //PurchaseAccount acc3 = new PurchaseAccount { AccountId = 3, AccountName = "Person 3" };
            //Console.WriteLine(acc3.GetPurchaseAccountDetails());

            Child child = new Child();

            Console.WriteLine(child.InterestedOn());
        }
    }
}