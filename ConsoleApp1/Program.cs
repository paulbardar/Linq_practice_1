namespace ConsoleApp1
{

    // Для масиву рядків, що містять назву міст, реалізуйте такі запити:
    // Отримати весь масив міст;
    // Отримати міста з довжиною назви, що дорівнює заданій;
    // Отримати міста, назви яких починаються з літери A;
    //Отримати міста, назви яких закінчуються літерою M;
    // Отримати міста, назви яких починаються з літери N і закінчуються літерою K;
    // Отримати міста назви яких починаються на Ne.Результат відсортувати за спаданням.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string[] cities = { "New York City", "London", "Paris", "Tokyo","Sydney", "Dubai", 
                "Mumbai", "Delhi", "Toronto", "Cape Town",
                "Singapore", "Rio de Janeiro", "Rome", "Bangkok", "Berlin" };

            var cityChoices = from city in cities
                              select city;

            cityChoices = cities.Select(c => c);

            foreach (var c in cityChoices)
            {
                Console.Write($"{c} ");
            }

            Console.WriteLine("\n___________________________________\n");

            var CityLength = from city in cities
                             where city.Length > 5
                             select city;

            CityLength = cities.Where(c => c.Length > 5);
            foreach (var c in CityLength)
            {
                Console.Write($"{c} ");
            }

            Console.WriteLine("\n___________________________________\n");

            var CityName = cities.Where(c => c.StartsWith("D") 
            && c.EndsWith("i")).OrderByDescending(c => c);
            foreach (var c in CityName)
            {
                Console.Write($"{c} ");
            }

            Console.WriteLine("\n___________________________________\n");
        }
    }
}
