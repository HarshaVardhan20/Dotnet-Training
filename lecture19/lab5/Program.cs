using System.Diagnostics.Tracing;

public class Program
{
    public class EcommerceShop
    {
        public string UserName {get;set;}
        public double WalletBalance {get;set;}
        public double TotalPurchaseAmount {get;set;}
    }
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException() : base("Insufficient balance in your digital wallet"){}
    }
    public EcommerceShop MakePayment(string name, double balance, double amount)
    {
        if (balance >= amount)
        {
            return new EcommerceShop{UserName = name, WalletBalance = balance, TotalPurchaseAmount = amount};
        }   
        throw new InsufficientBalanceException();     
    }
    public static void Main()
    {
        try
        {
            Program p = new Program();
            EcommerceShop e = p.MakePayment("Harhsa",4949,3993);
            Console.WriteLine("Payment successfull");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}