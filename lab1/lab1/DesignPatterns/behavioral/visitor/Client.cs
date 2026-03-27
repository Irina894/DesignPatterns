using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.visitor
{

    public class Client
    {
        private readonly List<IPart> _carParts;

        public Client()
        {
            _carParts = new List<IPart>
        {
            new Engine(),
            new Brakes(),
            new Electronics()
        };
        }

           public static void Run()
        {
            var parts = new List<IPart> { new Engine(), new Brakes(), new Electronics() };

            Console.WriteLine("--- Diagnostics ---");
            Execute(parts, new StatusCheckVisitor());

            Console.WriteLine("\n--- Estimation ---");
            var cost = new PriceEstimateVisitor();
            Execute(parts, cost);
            Console.WriteLine($"Total Cost: ${cost.Total}");

            Console.WriteLine("\n--- Repairing ---");
            Execute(parts, new RepairVisitor());
        }

        private static void Execute(List<IPart> parts, IVisitor visitor)
        {
            foreach (var part in parts) part.Accept(visitor);
        }
        

        private void Execute(IVisitor visitor)
        {
            foreach (var part in _carParts)
            {
                part.Accept(visitor);
            }
        }
    }
}
