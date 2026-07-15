namespace Phone_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Phones Array!");

            List<Phone> phones = new List<Phone>
            {
                new Phone("iPhone 15", "Apple", 35000.00m, new DateTime(2023, 9, 22)),
                new Phone("iPhone 16 Pro", "Apple", 52000.00m, new DateTime(2024, 9, 20)),
                new Phone("Galaxy S24 Ultra", "Samsung", 48000.00m, new DateTime(2024, 1, 31)),
                new Phone("Galaxy A55", "Samsung", 16500.00m, new DateTime(2024, 3, 15)),
                new Phone("Pixel 8 Pro", "Google", 38000.00m, new DateTime(2023, 10, 12)),
                new Phone("Pixel 9", "Google", 41000.00m, new DateTime(2024, 8, 22)),
                new Phone("Redmi Note 13 Pro", "Xiaomi", 12000.00m, new DateTime(2024, 1, 15)),
                new Phone("Xiaomi 14 Ultra", "Xiaomi", 55000.00m, new DateTime(2024, 2, 25)),
                new Phone("Edge 50 Pro", "Motorola", 22000.00m, new DateTime(2024, 4, 16)),
                new Phone("Xperia 1 VI", "Sony", 49000.00m, new DateTime(2024, 6, 1))
            };
            // Task 3
            // Порахуйте кількість телефонів;
            int totalPhones = phones.Count();
            Console.WriteLine($"Total count Phones in List: {totalPhones}");

            // Загальна кылькысть телефоныв Apple)
            int appleCount = phones.Count(p => p.Company == "Apple");
            Console.WriteLine($"Count of phones Apple: {appleCount}");

            // Порахуйте кількість телефонів із ціною більше 35000
            int expensivePhonesCount = phones.Count(p => p.Price > 35000m);
            Console.WriteLine($"Number of phones more expensive than 35 000 uah: {expensivePhonesCount}");

            // Порахуйте кількість телефонів із ціною в діапазоні від 22 000 до 40 000;
            int phonesInRangeCount = phones.Count(p => p.Price >= 22000m && p.Price <= 40000m);

            Console.WriteLine($"Number of phones more expensive thanNumber " +
                $"of phones with a price from 22,000 to 40,000 UAH: {phonesInRangeCount}");

            // Порахуйте кількість телефонів конкретного виробника
            string targetCompany = "Samsung";
            int companyPhonesCount = phones.Count(p => p.Company.Equals(targetCompany, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine($"Number of manufacturer phones {targetCompany}: {companyPhonesCount}");


            // Знайдіть телефон із мінімальною ціною;
            Phone cheapestPhone = phones.MinBy(p => p.Price);

            if (cheapestPhone != null)
            {
                Console.WriteLine($"Cheapest phone: {cheapestPhone}");
            }

            // Знайдіть телефон із максимальною ціною;
            Phone mostExpensivePhone = phones.MaxBy(p => p.Price);

            if (mostExpensivePhone != null)
            {
                Console.WriteLine($"Most Expensive phone: {mostExpensivePhone}");
            }

            // Відобразіть інформацію про найстаріший телефон 
            Phone oldestPhone = phones.MinBy(p => p.ReleaseDate);
            if (oldestPhone != null)
            {
                Console.WriteLine("--- Most Oldest Phone ---");
                Console.WriteLine(oldestPhone);
            }
            // Відобразіть інформацію про найсвіжіший телефон
            Phone newestPhone = phones.MaxBy(p => p.ReleaseDate);
            if (newestPhone != null)
            {
                Console.WriteLine("--- NewestPhone in List ---");
               
                Console.WriteLine(newestPhone);
            }

            // Знайдіть середню ціну телефону.
            decimal averagePrice = phones.Average(p => p.Price);
            Console.WriteLine($"Average price of Phone in List: {Math.Round(averagePrice, 2)} UAH");

            // Task 4
            // Відобразіть п'ять найдорожчих телефонів;
            var top5ExpensivePhones = phones.OrderByDescending(p => p.Price).Take(5);

            Console.WriteLine("--- ТОП-5 Most Expensive phones ---");
            foreach (var phone in top5ExpensivePhones)
            {
                
                Console.WriteLine(phone);
            }

            // Відобразіть п'ять найдешевших телефонів
            var top5CheapestPhones = phones.OrderBy(p => p.Price).Take(5);
            Console.WriteLine("--- ТОП-5 CHEAPEST PHONES ---");
            foreach (var phone in top5CheapestPhones)
            {
                
                Console.WriteLine(phone);
            }

            // Відобразіть три найстаріші телефони
            var top3OldestPhones = phones.OrderBy(p => p.ReleaseDate).Take(3);
            Console.WriteLine("--- ТОП-3 OLDEST PHONES ---");
            foreach (var phone in top3OldestPhones)
            {
                Console.WriteLine(phone);
            }
            Console.WriteLine();

            // Відобразіть три найновіші телефони.
            var top3NewestWithSkip = phones.OrderBy(p => p.ReleaseDate).Skip(phones.Count - 3);
            Console.WriteLine("--- 3 NEWEST PHONES (SKIP) ---");
            foreach (var phone in top3NewestWithSkip)
            {
                Console.WriteLine(phone);
            }
        }
    }

    class Phone
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }

        public Phone(string name, string company, decimal price, DateTime releaseDate)
        {
            Name = name;
            Company = company;
            Price = price;
            ReleaseDate = releaseDate;
        }

        public override string ToString()
        {
            return $"{Name} {Company} {Price} UAH {ReleaseDate:d}";
        }
    }

}
