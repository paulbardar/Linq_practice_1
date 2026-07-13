using System.Runtime.ConstrainedExecution;

namespace Array_Cars
{

    /*
 Створіть користувацький тип "Автомобіль". Потрібно зберігати такі характеристики:
Назва;
Виробник;
Рік випуску.
Для двох масивів автомобілів реалізуйте операції:
Різниця масивів;
Перетин масивів;
Об'єднання масивів.
Критерій для проведення операцій — виробник.
 */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Car!");

            //Auto car1 = new Auto("Model S", "Tesla", 2023);
            //Auto car2 = new Auto("Mustang", "Ford", 2021);
            //Auto car3 = new Auto("Camry", "Toyota", 2025);
            //Auto car4 = new Auto("X5", "BMW", 2024);

            // 3. Створення двох масивів, що мають спільні елементи (car1 та car2)
            //Auto[] array1 = { car1, car2, car3 };
            //Auto[] array2 = { car1, car2, car4 };

            List<Auto> auto1 = new List<Auto>
            {
                new Auto("Model S", "Tesla", 2023),
                new Auto("Mustang", "Ford", 2021),
                new Auto("Camry", "Toyota", 2025),
                new Auto("X5", "BMW", 2024),
                new Auto("Civic", "Honda", 2019)
            };

            List<Auto>auto2 = new List<Auto>
            {
                new Auto("Model S", "Tesla", 2023),
                new Auto("Mustang", "Ford", 2021),
                new Auto("X5", "BMW", 2024),
                new Auto("Renault", "Duster", 2023)
            };

            var result = auto1.Except(auto2);
            Console.WriteLine("\n\nPазность множеств");
            foreach (var s in result)
                Console.Write(s.Name + " " + s.Manufacturer + " ");

            Console.WriteLine( "\n");
            Console.WriteLine("-----------------Intersect--------------------");
            var result5 = auto2.Intersect(auto1);
            foreach (var item in result5)
            {
                Console.WriteLine(item.Name + "  " + item.Manufacturer);
            }

            Console.WriteLine("\n-----------------Union--------------------");
            result5 = auto2.Union(auto1);
            foreach (var item in result5)
            {
                Console.WriteLine(item.Name + "  " + item.Manufacturer + "  " + item.Year);
            }
        }

    }
    public class Auto : IEquatable<Auto>
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }

        public Auto(string name, string manufacturer, int year)
        {
            Name = name;
            Manufacturer = manufacturer;
            Year = year;
        }

        public bool Equals(Auto? other)
        {
            if (other == null)
                return false;

            if (this.Name == other.Name)
                return true;
            else
                return false;
        }

        public override bool Equals(object? obj) => Equals(obj as Auto);

        public override int GetHashCode() => Name!.GetHashCode();
    }

}

