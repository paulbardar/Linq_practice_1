using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Grouped
{

    /*
Завдання 3
Для масиву цілих виконайте такі завдання, використовуючи агрегатні операції з LINQ:
Порахуйте добуток елементів масиву;
Порахуйте кількість елементів масиву;
Порахуйте кількість елементів масиву, кратних 9;
Порахуйте кількість елементів масиву, кратних 7 і більших, ніж 945;
Порахуйте суму елементів масиву;
Порахуйте суму парних елементів масиву;
Знайдіть мінімум у масиві;
Знайдіть максимум у масиві;
Знайдіть середнє значення в масиві.

Завдання 4
Додайте до третього завдання нову функціональність:
Відобразіть три перші максимальні елементи;
Відобразіть три перші мінімальні елементи.
Для реалізації завдання використовуйте сімейство методів Skip, Take.

Завдання 5
Додайте до третього завдання нову функціональність:
Відобразіть статистику входження кожного числа в масив. Наприклад: 7 — 3 рази, 5 — 2 рази, 8 — 4 рази тощо.
Відобразіть статистику входження парних чисел у масив. Наприклад: 2 — 4 рази, 6 — 2 рази тощо.
Відобразіть статистику входження парних і непарних чисел у масив. Наприклад: парні — 3 рази, непарні — 2 рази.
*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Group task!");

            long[] numbers = { 7, 5, 8, 7, 2, 6, 9, 3, 4, 5, 8, 2, 1, 7, 6 };

            long query = numbers.Aggregate((x, y) => x * y);
            Console.WriteLine("Res of Aggregate((x, y) => x * y): " + query);
            Console.WriteLine();


            long size = numbers.Count();
            Console.WriteLine("Число элементов в выборке: " + size);
            Console.WriteLine();

            int size1 = numbers.Count(i => i % 7 == 0); 
            Console.WriteLine("Число элементов в выборке: " + size1);
            Console.WriteLine();

            Console.WriteLine("\nПорахуйте суму парних елементів масиву");
            var sum = numbers.Where(i => i % 2 == 0).Sum();
            Console.WriteLine("Сумма элементов массива: " + sum);
            Console.WriteLine();

            Console.WriteLine("\nЗнайдіть мінімум у масиві");
            long min1 = numbers.Min();
            Console.WriteLine("Минимальный элемент массива: " + min1);
            Console.WriteLine();

            Console.WriteLine("\nЗнайдіть мінімум у масиві");
            double avr = numbers.Average();
            Console.WriteLine("Минимальный элемент массива: " + avr);
            Console.WriteLine();

            Console.WriteLine("Відобразіть три перші максимальні елементи;");
            var result1 = numbers.OrderByDescending(n => n).Take(3);
            foreach(long t in result1)
            {
                Console.Write( t + " ");
            }

            Console.WriteLine("Відобразіть три перші мінімальні елементи;");
            var result2 = numbers.OrderBy(n => n).Take(3);
            foreach (long t in result2)
            {
                Console.Write(t + " ");
            }

            Console.WriteLine("Відобразіть статистику входження кожного числа в масив. Наприклад: 7 — 3 рази, 5 — 2 рази, 8 — 4 рази тощо.");
            var result3 = numbers.GroupBy(n => n).Select(g => new { num = g.Key, Count = g.Count() });
            foreach (var group in result3)
                Console.WriteLine("{0} : {1}", group.num, group.Count);
            Console.WriteLine('\n');

            Console.WriteLine("Відобразіть статистику входження парних чисел у масив. " +
                "Наприклад: 2 — 4 рази, 6 — 2 рази тощо.");
            var result4 = numbers.Where(n => n % 2 == 0).GroupBy(n => n).Select(g => new { num = g.Key, Count = g.Count() });
            foreach (var group in result4)
                Console.WriteLine("{0} : {1}", group.num, group.Count);
            Console.WriteLine('\n');

            Console.WriteLine("Відобразіть статистику входження парних і непарних чисел у масив. " +
                "Наприклад: парні — 3 рази, непарні — 2 рази.");
            var result5 = numbers.GroupBy(n => n % 2 == 0 ? "Even" : "Odd").Select(g => new { num = g.Key, Count = g.Count() });
            foreach (var group in result5)
                Console.WriteLine("{0} : {1}", group.num, group.Count);
            Console.WriteLine('\n');
        }
    }
}
