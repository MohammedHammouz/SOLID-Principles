using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    public interface IPrint
    {
        void Print(string content);

    }
    public interface IScan
    {
        void Scan();

    }
    public interface IFax
    {
        void Fax();

    }
  
    public class BasicPrinter : IPrint
    {
        public void Print(string content)
        {
            Console.WriteLine($"The message:{content}");
        }
    }
    public class AdvancePrinter : IPrint,IFax,IScan
    {
        public void Print(string content)
        {
            Console.WriteLine($"The message:{content}");
        }
        public void Scan()
        {
            Console.WriteLine("Scanning...");
        }
        public void Fax()
        {
            Console.WriteLine("Faxing...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicPrinter basicPrinter = new BasicPrinter();
            basicPrinter.Print("Hi My name's Mohammed");
            AdvancePrinter advancePrinter = new AdvancePrinter();
            advancePrinter.Print("Hi My name's Mohammed");
            advancePrinter.Fax();
            advancePrinter.Scan();
            Console.ReadKey();
        }
    }
}
