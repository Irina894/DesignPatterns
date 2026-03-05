using FactoryClient = DesignPatterns.creational.factory_method.Client;
using AbstractFactoryClient = DesignPatterns.creational.abstract_factory.Client;
using BuilderClient = DesignPatterns.creational.builder.Client;
using PrototypeClient = DesignPatterns.creational.prototype.Client;
using SingletonClient = DesignPatterns.creational.singleton.Client;

using DesignPatterns.creational.abstract_factory;


namespace lab1
{

    namespace lab1
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("===== FACTORY METHOD =====");
                FactoryClient.Run();

                Console.WriteLine();

                Console.WriteLine("===== ABSTRACT FACTORY =====");

                AbstractFactoryClient.Run(new WindowsFactory());
                AbstractFactoryClient.Run(new MacFactory());
                AbstractFactoryClient.Run(new WebFactory());

                Console.WriteLine();

                Console.WriteLine("===== BUILDER =====");
                BuilderClient.Run();

                Console.WriteLine();

                Console.WriteLine("===== PROTOTYPE =====");
                PrototypeClient.Run();

                Console.WriteLine();

                Console.WriteLine("===== SINGLETON =====");
                SingletonClient.Run();
            }
        }
    }
}
