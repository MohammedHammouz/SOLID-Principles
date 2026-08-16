using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment
{
    public interface IPayment
    {
        void PayWithCreditCard();
        void PayWithPayPal();
        void PayWithBitcoin();
    }
    public interface ICreditCardPayment
    {
        void PayWithCreditCard();
    }
    public interface IPayPalPayment
    {
        void PayWithPayPal();
    }
    public interface IBitcoinPayment
    {
        void PayWithBitcoin();
    }
    public class CreditCardPayment : ICreditCardPayment
    {
        public void PayWithCreditCard()
        {
            Console.WriteLine("Payment with credit card.");
        }
    }

    public class PayPalPayment : IPayPalPayment
    {
        public void PayWithPayPal()
        {
            Console.WriteLine("Payment with PayPal.");
        }

    }
    public class BitcoinPayment :IBitcoinPayment
    {
        public void PayWithBitcoin()
        {
            Console.WriteLine("Payment with Bitcoin.");
        }

    }
    public class AllPayments : IBitcoinPayment, IPayPalPayment, ICreditCardPayment
    {
        public void PayWithCreditCard()
        {
            Console.WriteLine("Payment with credit card.");
        }
        public void PayWithPayPal()
        {
            Console.WriteLine("Payment with PayPal.");
        }
        public void PayWithBitcoin()
        {
            Console.WriteLine("Payment with Bitcoin.");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ICreditCardPayment creditCardPayment = new CreditCardPayment();
            creditCardPayment.PayWithCreditCard();
            

            IPayPalPayment payPalPayment = new PayPalPayment();
            payPalPayment.PayWithPayPal();

            IBitcoinPayment bitcoinPayment = new BitcoinPayment();
            bitcoinPayment.PayWithBitcoin();

            AllPayments allPayments = new AllPayments();
            allPayments.PayWithBitcoin();
            allPayments.PayWithCreditCard();
            allPayments.PayWithPayPal();

            Console.ReadKey();
        }
    }
}
