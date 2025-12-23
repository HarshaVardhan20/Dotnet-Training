namespace PaymentNamespace
{
    public class Program
    {
        public static void Main()
        {
            UpiPayment upipayment = new UpiPayment(2828,38838933);

            upipayment.Pay();

            upipayment.printReceipt();

        }
    }
}
