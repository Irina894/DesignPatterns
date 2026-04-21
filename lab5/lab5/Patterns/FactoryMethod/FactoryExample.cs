namespace lab5.Patterns.FactoryMethod;

public static class FactoryExample
{
    public static void Run()
    {
        var getNotification = (string type) => type.ToLower() switch
        {
            "sms" => (Action<string>)((msg) => Console.WriteLine($"Відправлено SMS: {msg}")),
            "email" => (msg) => Console.WriteLine($"Відправлено Email: {msg}"),
            _ => (msg) => Console.WriteLine($"Стандартне сповіщення: {msg}")
        };

        var notifier = getNotification("sms");
        notifier("Код працює.");
    }
}