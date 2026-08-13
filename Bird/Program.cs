using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bird
{
    public class Bird
    {
        public virtual void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    public class FlyingBirds:Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("Flying...");
        }
    }
    public class Ostrich : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Ostrich Eating...");
        }
    }
    public class Eagle : FlyingBirds
    {
        public override void Eat()
        {
            Console.WriteLine("Eagle Eating...");
        }

        public override void Fly()
        {
            Console.WriteLine("Eagle flying...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Eagle eagle = new Eagle();
            eagle.Eat();
            eagle.Fly();
            Ostrich ostrich = new Ostrich();
            ostrich.Eat();
        }
    }
}
