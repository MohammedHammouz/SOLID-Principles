using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService
{
    public class PaymentService
    {
        private IPayment _payment;
        public PaymentService(IPayment payment)
        {
            _payment = payment;
        }
        public void Payment(string message)
        {
            _payment.Payment(message);
        }
    }
    public interface IPayment
    {
        void Payment(string message);
    }
    public class PayPal:IPayment
    {
        public void Payment(string message)
        {
            Console.WriteLine($"The payment method is:{message}");
        }
    }
    public class CreditCard : IPayment
    {
        public void Payment(string message)
        {
            Console.WriteLine($"The payment method is:{message}");
        }
    }
    public class BankTransfer : IPayment
    {
        public void Payment(string message)
        {
            Console.WriteLine($"The payment method is:{message}");
        }
    }
    public class Bitcoin : IPayment
    {
        public void Payment(string message)
        {
            Console.WriteLine($"The payment method is:{message}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentService paymentService = new PaymentService(new PayPal());
            paymentService.Payment("Pay Pal");
            paymentService = new PaymentService(new BankTransfer());
            paymentService.Payment("Bank Transfer");
            paymentService = new PaymentService(new CreditCard());
            paymentService.Payment("Credit Card");
            paymentService = new PaymentService(new Bitcoin());
            paymentService.Payment("Bitcoin");
        }
    }
}
