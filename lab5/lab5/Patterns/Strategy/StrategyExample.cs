using System;
using lab5.Models;

namespace lab5.Patterns.Strategy;

public static class StrategyExample
{
    public static void Run()
    {
        var team = new List<Person>
        {
            new Person("Олексій", "Developer"),
            new Person("Марія", "Designer"),
            new Person("Іван", "Developer")
        };

        // Стратегії — це просто умови (Predicate)
        Predicate<Person> isDev = p => p.Role == "Developer";
        Predicate<Person> isDesigner = p => p.Role == "Designer";

        void Show(string title, Predicate<Person> filter)
        {
            Console.WriteLine($"--- {title} ---");
            var filtered = team.FindAll(filter);
            filtered.ForEach(p => Console.WriteLine(p.Name));
        }

        Show("Розробники", isDev);
        Show("Дизайнери", isDesigner);
    }
}