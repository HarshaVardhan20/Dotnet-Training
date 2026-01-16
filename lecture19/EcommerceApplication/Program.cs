using System.Diagnostics.Tracing;

/// <summary>
/// Program class for processing e-commerce payments.
/// Validates that the user has sufficient wallet balance before processing payments.
/// Throws an exception if balance is insufficient.
/// </summary>
public class Program
{
    #region Inner Classes
    /// <summary>
    /// Data class to store e-commerce shop user information including wallet balance and purchase amount.
    /// </summary>
    public class EcommerceShop
    {
        public string UserName {get;set;}
        public double WalletBalance {get;set;}
        public double TotalPurchaseAmount {get;set;}
    }
    /// <summary>
    /// Custom exception thrown when a user attempts to make a payment without sufficient wallet balance.
    /// </summary>
    public class InsufficientBalanceException : Exception
    {
        /// <summary>
        /// Initializes a new instance of InsufficientBalanceException with a predefined message.
        /// </summary>
        public InsufficientBalanceException() : base("Insufficient balance in your digital wallet"){}
    }
    #endregion

    #region Methods
    /// <summary>
    /// Processes a payment transaction if the user has sufficient balance.
    /// Creates and returns an EcommerceShop object with transaction details if successful.
    /// Throws InsufficientBalanceException if balance is less than the payment amount.
    /// </summary>
    /// <param name="name">The name of the user making the payment.</param>
    /// <param name="balance">The current wallet balance.</param>
    /// <param name="amount">The amount to be charged.</param>
    /// <returns>EcommerceShop object containing the transaction details.</returns>
    public EcommerceShop MakePayment(string name, double balance, double amount)
    {
        if (balance >= amount)
        {
            return new EcommerceShop{UserName = name, WalletBalance = balance, TotalPurchaseAmount = amount};
        }   
        throw new InsufficientBalanceException();     
    }
    #endregion

    #region Main
    /// <summary>
    /// Main entry point. Demonstrates payment processing with a test case.
    /// Handles InsufficientBalanceException if the payment cannot be processed.
    /// </summary>
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
    #endregion
}