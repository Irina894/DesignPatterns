namespace lab5.Patterns.ExecuteAround;

public static class ExecuteAroundExample
{
    public static void DoWorkInSafeContext(Action work)
    {
        Console.WriteLine("[Логування] Початок операції...");
        try
        {
            work();
        }
        finally
        {
            Console.WriteLine("[Логування] Операцію завершено успішно.");
        }
    }

    public static void Run()
    {
        DoWorkInSafeContext(() => {
            Console.WriteLine("Виконується основна робота всередині безпечного контексту.");
        });
    }
}