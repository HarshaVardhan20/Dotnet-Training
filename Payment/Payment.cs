using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentNamespace
{
    public abstract class Payment
    {
        public decimal Amount { get; }

        protected Payment(decimal amount) => Amount = amount;

        public abstract void Pay();

        public void printReceipt()
        {
            Console.WriteLine($"Receipt: Amount = {Amount}");
        }

    }

    public class UpiPayment: Payment{
        public int UpiId { get; }
        public UpiPayment(int amount, int upiId) : base(amount) => UpiId = upiId;

        public override void Pay()
        {
            Console.WriteLine($"Amount paid through upi is {Amount} from upiId {UpiId}");
        }
    }
}

