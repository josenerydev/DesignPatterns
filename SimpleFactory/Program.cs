using SimpleFactoryPattern.DesignPatternsInCSharp;

using System;

namespace SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Simple Factory Pattern Demo ***\n");
            IAnimal preferredType = null;
            SimpleFactory simpleFactory = new SimpleConcreteFactory();
            preferredType = simpleFactory.CreateAnimal();
            preferredType.Speak();
            preferredType.Action();

            Console.ReadKey();
        }
    }
}
