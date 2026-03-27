using FactoryClient = DesignPatterns.creational.factory_method.Client;
using AbstractFactoryClient = DesignPatterns.creational.abstract_factory.Client;
using BuilderClient = DesignPatterns.creational.builder.Client;
using PrototypeClient = DesignPatterns.creational.prototype.Client;
using SingletonClient = DesignPatterns.creational.singleton.Client;
using AdapterClient = DesignPatterns.structural.adapter.Client;
using BridgeClient = DesignPatterns.structural.bridge.Client;
using CompositeClient = DesignPatterns.structural.composite.Client;
using ObjectPoolClient = DesignPatterns.creational.object_pool.Client;
using DecoratorClient = DesignPatterns.structural.decorator.Client;
using FacadeClient = DesignPatterns.structural.facade.Client;
using FlyweightClient = DesignPatterns.structural.flyweight.Client;
using ProxyClient = DesignPatterns.structural.proxy.Client;
using Chainofresponsibilty = DesignPatterns.behavioral.chainofresponsibility.Client;
using Command = DesignPatterns.behavioral.command.Client;
using Iterator = DesignPatterns.behavioral.iterator.Client;
using Mediator = DesignPatterns.behavioral.mediator.Client;
using Memento = DesignPatterns.behavioral.memento.Client;
using Observer = DesignPatterns.behavioral.observer.Client;
using State = DesignPatterns.behavioral.state.Client;
using Strategy = DesignPatterns.behavioral.strategy.Client;
using TemplateMethod = DesignPatterns.behavioral.templatemethod.Client;
using Visitor = DesignPatterns.behavioral.visitor.Client;
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

                Console.WriteLine();

                Console.WriteLine("===== OBJECT POOL =====");
                ObjectPoolClient.Run();

                Console.WriteLine();
                Console.WriteLine("===== STRUCTURAL  =====");
                Console.WriteLine();

                Console.WriteLine();
                Console.WriteLine("===== ADAPTER =====");
                AdapterClient.Run();

                Console.WriteLine();
                Console.WriteLine("===== BRIDGE =====");
                BridgeClient.Run();

                Console.WriteLine();
                Console.WriteLine("===== COMPOSITE =====");
                CompositeClient.Run();

                Console.WriteLine();
                Console.WriteLine("===== DECORATOR =====");
                DecoratorClient.Run();

                Console.WriteLine();
                Console.WriteLine("===== FACADE =====");
                FacadeClient.Run();

                Console.WriteLine();
                Console.WriteLine("===== FLYWEIGHT =====");
                FlyweightClient.Run();

                Console.WriteLine();
                Console.WriteLine("===== PROXY =====");
                ProxyClient.Run();

                Console.WriteLine();
                Console.WriteLine("===== CHAIN OF RESPONSIBILITY =====");
                Chainofresponsibilty.Run();

                Console.WriteLine();
                Console.WriteLine("===== COMMAND =====");
                Command.Run();

                Console.WriteLine();
                Console.WriteLine("===== ITERATOR =====");
                Iterator.Run();

                    Console.WriteLine();
                    Console.WriteLine("===== MEDIATOR =====");
                    Mediator.Run();

                    Console.WriteLine();
                    Console.WriteLine("===== MEMENTO =====");
                    Memento.Run();

                    Console.WriteLine();
                    Console.WriteLine("===== OBSERVER =====");
                    Observer.Run();

                    Console.WriteLine();
                    Console.WriteLine("===== STATE =====");
                    State.Run();


                Console.WriteLine();
                Console.WriteLine("===== STRATEGY =====");
                Strategy.Run();

                Console.WriteLine();
                Console.WriteLine("===== TEMPLATE METHOD =====");
                TemplateMethod.Run();

                Console.WriteLine();
                Console.WriteLine("===== VISITOR =====");
                Visitor.Run();

                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();



            }
        }
    }
}
