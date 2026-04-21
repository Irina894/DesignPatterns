using lab5.Patterns.Strategy;
using lab5.Patterns.FactoryMethod;
using lab5.Patterns.Decorator;
using lab5.Patterns.ExecuteAround;

Console.WriteLine("===Lab №5: Функціональні патерни ===");

Console.WriteLine("\n1. Strategy (Стратегія):");
StrategyExample.Run();

Console.WriteLine("\n2. Factory Method (Фабричний метод):");
FactoryExample.Run();

Console.WriteLine("\n3. Decorator (Декоратор):");
DecoratorExample.Run();

Console.WriteLine("\n4. Execute Around (Навколишнє виконання):");
ExecuteAroundExample.Run();