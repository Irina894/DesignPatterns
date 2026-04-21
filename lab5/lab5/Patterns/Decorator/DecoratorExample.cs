using lab5.Models;
// Видаліть або закоментуйте using System.Drawing; якщо він там є

namespace lab5.Patterns.Decorator;

// Створюємо чіткий псевдонім, щоб компілятор не плутався
using MyColor = lab5.Models.Color;

public static class DecoratorExample
{
    public static void Run()
    {
        MyColor baseColor = new MyColor(100, 100, 100);

        Func<MyColor, MyColor> identity = c => c;

        Func<Func<MyColor, MyColor>, Func<MyColor, MyColor>> brighter =
            next => c => next(new MyColor(
                Math.Min(c.R + 50, 255),
                Math.Min(c.G + 50, 255),
                Math.Min(c.B + 50, 255)
            ));

        var cameraEffect = brighter(identity);

        var result = cameraEffect(baseColor);

        Console.WriteLine($"Початковий колір: R={baseColor.R}, G={baseColor.G}, B={baseColor.B}");
        Console.WriteLine($"Після фільтра:    R={result.R}, G={result.G}, B={result.B}");
    }
}