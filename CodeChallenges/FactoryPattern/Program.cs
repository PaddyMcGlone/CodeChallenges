using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    abstract class Position
    {
        public abstract string Title { get; }
    }

    class Manager : Position
    {
        public override string Title => "Manager";
    }

    class Clerk : Position
    {
        public override string Title => "Clerk";
    }

    class Programmer : Position
    {
        public override string Title => "Programmer";
    }

    // The factory class decides which class to initiate
    // the factory recieves an input and then decides what to return from there.
    static class Factory
    {
        public static Position Get(int id)
        {
            switch (id)
            {
                case 1:
                    return new Manager();
                case 2:
                    return new Clerk();
                default:
                    return new Programmer();
            }
        }
    }

    internal class Program
    {
        static void Main()
        {
            for (int i = 0; i < 3; i++)                            
                Console.WriteLine($"Position: {Factory.Get(i).Title}");

            Console.ReadKey();
        }
    }
}
