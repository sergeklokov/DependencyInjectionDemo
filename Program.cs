using System;

/// <summary>
/// This example based on article 
/// https://stackoverflow.com/questions/14301389/why-does-one-use-dependency-injection
/// coded by serge klokov 2018
/// </summary>
namespace DependencyInjectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new TightlyCoupled();
            t.DoJob();

            var d = new Decoupled(new B());
            d.DoJob();

            Console.WriteLine("Press any key..");
            Console.ReadKey();
        }
    }

    class B {
        public void DoJob()
        {
            Console.WriteLine("Working..");
        }
    }

    class TightlyCoupled
    {
        private B b;

        public TightlyCoupled()
        {
            b = new B();
        }

        public void DoJob()
        {
            b.DoJob();
        }
    }

    class Decoupled
    {
        private B b;

        public Decoupled(B b)
        {
            this.b = b;
        }

        public void DoJob()
        {
            b.DoJob();
        }
    }
}
