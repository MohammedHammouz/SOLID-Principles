using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehichle
{
    public class Vehichle
    {
        public virtual void Drive()
        {
            Console.WriteLine("Vehicle is Driving");
        }
    }
    public class MotorVehichle:Vehichle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("Vehicle is Starting Engine");
        }
    } 
    public class Bycycle : Vehichle
    {
        public override void Drive()
        {
            Console.WriteLine("Bycycle is Driving");
        }
    }
    public class Car : MotorVehichle
    {
        public override void Drive()
        {
            Console.WriteLine("Car is Driving");
        }
        public override void StartEngine()
        {
            Console.WriteLine("Car is Starting Engine");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bycycle vehchle1 = new Bycycle();
            vehchle1.Drive();
            Car vehichle2 = new Car();
            vehichle2.Drive();
            vehichle2.StartEngine();
        }
    }
}
