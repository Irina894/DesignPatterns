using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<double> realNumbers = new List<double> { 2.5, 3.7, 4.1, 5.9, 6.3 };
            List<string> words = new List<string> { "banana", "apple", "kiwi", "orange", "", "grape" };
            List<string> capitalWords = new List<string> { "Київ", "Львів", "Одеса" };
            string sentence = "Це приклад речення для підрахунку слів";
            int factorialNumber = 5;

            Console.WriteLine("1. Непарні числа:");
            PrintCollection(FilterOddNumbers(numbers));

            Console.WriteLine("\n2. Середнє значення:");
            Console.WriteLine(CalculateAverage(realNumbers));

            Console.WriteLine("\n3. Сортування рядків (алфавіт):");
            PrintCollection(SortStringsAlphabetically(words));

            Console.WriteLine("\n4. Сума парних чисел:");
            Console.WriteLine(SumEvenNumbers(numbers));

            Console.WriteLine("\n5. Факторіал числа:");
            Console.WriteLine(CalculateFactorial(factorialNumber));

            Console.WriteLine("\n6. Сума і добуток:");
            var result = CalculateSumAndProduct(numbers);
            Console.WriteLine($"Сума = {result.sum}, Добуток = {result.product}");

            Console.WriteLine("\n7. Квадрати чисел:");
            PrintCollection(GetSquares(numbers));

            Console.WriteLine("\n8. Сортування за довжиною:");
            PrintCollection(SortStringsByLength(words));

            Console.WriteLine("\n9. Кількість слів:");
            Console.WriteLine(CountWords(sentence));

            Console.WriteLine("\n10. Перший непорожній рядок:");
            Console.WriteLine(FindFirstNonEmptyString(words));

            Console.WriteLine("\n11. Чи всі з великої літери:");
            Console.WriteLine(AllStartWithUpper(capitalWords));

            Console.WriteLine("\n12. Друге за величиною число:");
            Console.WriteLine(FindSecondLargest(numbers));

            Console.WriteLine("\n13. Найбільше парне число:");
            Console.WriteLine(FindLargestEven(numbers));
        }

        // ===== 1. Непарні числа =====
        static List<int> FilterOddNumbers(List<int> numbers)
        {
            return numbers.Where(x => x % 2 != 0).ToList();
        }

        // ===== 2. Середнє значення =====
        static double CalculateAverage(List<double> numbers)
        {
            return numbers.Average(x => x);
        }

        // ===== 3. Сортування за алфавітом =====
        static List<string> SortStringsAlphabetically(List<string> strings)
        {
            return strings.OrderBy(x => x).ToList();
        }

        // ===== 4. Сума парних чисел =====
        static int SumEvenNumbers(List<int> numbers)
        {
            return numbers.Where(x => x % 2 == 0).Sum();
        }

        // ===== 5. Факторіал =====
        static long CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;

            return Enumerable.Range(1, n)
                             .Aggregate(1L, (acc, x) => acc * x);
        }

        // ===== 6. Сума і добуток =====
        static (int sum, long product) CalculateSumAndProduct(List<int> numbers)
        {
            int sum = numbers.Sum(x => x);
            long product = numbers.Aggregate(1L, (acc, x) => acc * x);

            return (sum, product);
        }

        // ===== 7. Квадрати чисел =====
        static List<int> GetSquares(List<int> numbers)
        {
            return numbers.Select(x => x * x).ToList();
        }

        // ===== 8. Сортування за довжиною =====
        static List<string> SortStringsByLength(List<string> strings)
        {
            return strings.OrderBy(x => x.Length).ToList();
        }

        // ===== 9. Підрахунок слів =====
        static int CountWords(string sentence)
        {
            return sentence
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Count();
        }

        // ===== 10. Перший непорожній рядок =====
        static string FindFirstNonEmptyString(List<string> strings)
        {
            return strings
                .FirstOrDefault(x => !string.IsNullOrWhiteSpace(x))
                ?? "Немає значення";
        }

        // ===== 11. Перевірка великої літери =====
        static bool AllStartWithUpper(List<string> strings)
        {
            return strings.All(x => !string.IsNullOrEmpty(x) && char.IsUpper(x[0]));
        }

        // ===== 12. Друге за величиною число =====
        static int FindSecondLargest(List<int> numbers)
        {
            return numbers
                .Distinct()
                .OrderByDescending(x => x)
                .Skip(1)
                .First();
        }

        // ===== 13. Найбільше парне число =====
        static int FindLargestEven(List<int> numbers)
        {
            return numbers.Where(x => x % 2 == 0).Max();
        }

        // ===== Допоміжний метод =====
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            Console.WriteLine(string.Join(", ", collection));
        }
    }
}