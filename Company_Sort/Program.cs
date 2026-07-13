namespace Company_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            DateTime currentDate = new DateTime(2026, 7, 6);

            // Створення 20 об'єктів фірм
            List<Firm> firms = new List<Firm>
            {
                new Firm { Name = "Food Corp", FoundationDate = new DateTime(2020, 5, 12), BusinessProfile = "Food", DirectorFullName = "John White", EmployeeCount = 150, Address = "London, Baker St" },
                new Firm { Name = "IT Solutions", FoundationDate = new DateTime(2023, 1, 10), BusinessProfile = "IT", DirectorFullName = "Alice Black", EmployeeCount = 80, Address = "London, Oxford St" },
                new Firm { Name = "Global Marketing", FoundationDate = new DateTime(2018, 11, 25), BusinessProfile = "Marketing", DirectorFullName = "Robert Ford", EmployeeCount = 120, Address = "New York, Wall St" },
                new Firm { Name = "White Food", FoundationDate = new DateTime(2024, 3, 5), BusinessProfile = "Food", DirectorFullName = "Michael Black", EmployeeCount = 250, Address = "London, Regent St" },
                new Firm { Name = "Tech Pro", FoundationDate = new DateTime(2021, 6, 15), BusinessProfile = "IT", DirectorFullName = "Emma Watson", EmployeeCount = 300, Address = "Kyiv, Khreshchatyk" },
                new Firm { Name = "Fast Food UA", FoundationDate = new DateTime(2025, 3, 5), BusinessProfile = "Food", DirectorFullName = "Sarah White", EmployeeCount = 50, Address = "Lviv, Rynok sq" },
                new Firm { Name = "Ad Agency", FoundationDate = new DateTime(2015, 9, 1), BusinessProfile = "Marketing", DirectorFullName = "David Black", EmployeeCount = 110, Address = "London, Piccadilly" },
                new Firm { Name = "Soft Dev", FoundationDate = new DateTime(2022, 7, 20), BusinessProfile = "IT", DirectorFullName = "Peter Parker", EmployeeCount = 45, Address = "London, King St" },
                new Firm { Name = "Tasty Meal", FoundationDate = new DateTime(2026, 3, 5), BusinessProfile = "Food", DirectorFullName = "John Black", EmployeeCount = 350, Address = "Berlin, Main St" },
                new Firm { Name = "Creative Minds", FoundationDate = new DateTime(2019, 4, 18), BusinessProfile = "Marketing", DirectorFullName = "Laura White", EmployeeCount = 95, Address = "London, Bond St" },
                new Firm { Name = "Code Base", FoundationDate = new DateTime(2024, 1, 1), BusinessProfile = "IT", DirectorFullName = "Chris White", EmployeeCount = 210, Address = "Paris, Champs-Elysees" },
                new Firm { Name = "Organic Food", FoundationDate = new DateTime(2023, 3, 5), BusinessProfile = "Food", DirectorFullName = "Anna Black", EmployeeCount = 180, Address = "London, Oxford St" },
                new Firm { Name = "Pro Marketer", FoundationDate = new DateTime(2020, 8, 30), BusinessProfile = "Marketing", DirectorFullName = "Tom White", EmployeeCount = 135, Address = "London, Regent St" },
                new Firm { Name = "AI Lab", FoundationDate = new DateTime(2025, 3, 5), BusinessProfile = "IT", DirectorFullName = "George Black", EmployeeCount = 75, Address = "Warsaw, Marszalkowska" },
                new Firm { Name = "Daily Food", FoundationDate = new DateTime(2017, 12, 12), BusinessProfile = "Food", DirectorFullName = "Oliver White", EmployeeCount = 280, Address = "London, Fleet St" },
                new Firm { Name = "Innovatech", FoundationDate = new DateTime(2026, 1, 1), BusinessProfile = "IT", DirectorFullName = "Sophie White", EmployeeCount = 160, Address = "London, Strand" },
                new Firm { Name = "Market Masters", FoundationDate = new DateTime(2026, 3, 5), BusinessProfile = "Marketing", DirectorFullName = "Harry Black", EmployeeCount = 90, Address = "London, Victoria St" },
                new Firm { Name = "Mega Bite", FoundationDate = new DateTime(2014, 4, 14), BusinessProfile = "Food", DirectorFullName = "James White", EmployeeCount = 500, Address = "Chicago, Michigan Ave" },
                new Firm { Name = "Digital One", FoundationDate = new DateTime(2021, 10, 5), BusinessProfile = "Marketing", DirectorFullName = "Jack Black", EmployeeCount = 105, Address = "London, Oxford St" },
                new Firm { Name = "NextGen IT", FoundationDate = new DateTime(2016, 2, 28), BusinessProfile = "IT", DirectorFullName = "Mia White", EmployeeCount = 220, Address = "London, High St" }
            };

            // 1. Отримати інформацію про всі фірми;
            var AllFirms = from f in firms
                           select f;

            foreach (var f in AllFirms)
                Console.WriteLine(f.ToString());
            Console.WriteLine('\n');

            // 1_2. Метод розширень
            var allFirms = firms.Select(f => f);
            Console.WriteLine("=== Результат запиту ===");
            allFirms.ToList().ForEach(f => Console.WriteLine(f));

            // 2. Отримати фірми, у яких у назві є слово Food;

            var Firms_byName = from f in firms
                               where f.Name.Contains("Food")
                               select f;

            foreach (var f in Firms_byName)
                Console.WriteLine(f.ToString());
            Console.WriteLine('\n');

            // 2_1 . Метод розширень
            var foodFirms = firms.Where(f => f.Name.Contains("Food"));
            Console.WriteLine("=== Результат запиту Food ===");
            foodFirms.ToList().ForEach(f => Console.WriteLine(f));


            // Отримати фірми, які працюють у галузі маркетингу;

            var Firms_Profile = from f in firms
                               where f.BusinessProfile == "Marketing"
                                select f;

            foreach (var f in Firms_Profile)
                Console.WriteLine(f.ToString());
            Console.WriteLine('\n');

            // 2_3. Метод розширень
            var marketingFirms = firms.Where(f => f.BusinessProfile == "Marketing");
            Console.WriteLine("=== Результат запиту Marketing ===");
            marketingFirms.ToList().ForEach(f => Console.WriteLine(f));

            // Отримати фірми, які працюють у галузі маркетингу або IT;

            var Firms_Profiles = from f in firms
                                where f.BusinessProfile == "Marketing" || f.BusinessProfile == "IT"
                                 select f;

            foreach (var f in Firms_Profiles)
                Console.WriteLine(f.ToString());
            Console.WriteLine('\n');


            // 2_4. Метод розширень
            var marketingOrItFirms = firms.Where(f => f.BusinessProfile == "Marketing" || f.BusinessProfile == "IT");
            Console.WriteLine("=== Результат запиту Marketing IT ===");
            marketingOrItFirms.ToList().ForEach(f => Console.WriteLine(f));

            // Отримати фірми з кількістю співробітників, більшою за 100;
            Console.WriteLine("================================================");
            var firms_more100 = firms.Where(p => p.EmployeeCount > 100);

            foreach (var f in firms_more100)
                Console.WriteLine(f.ToString());
            Console.WriteLine('\n');

            // 2_5. Метод розширень
            var largeFirms = firms.Where(f => f.EmployeeCount > 100);
            Console.WriteLine("=== Результат запиту з кількістю співробітників, більшою за 100 ===");
            marketingOrItFirms.ToList().ForEach(f => Console.WriteLine(f));

            // Отримати фірми з кількістю співробітників у діапазоні від 100 до 300;
            Console.WriteLine("================================================");
            var firms_more101 = firms.Where(p => p.EmployeeCount > 100 && p.EmployeeCount <= 200);

            foreach (var f in firms_more101)
                Console.WriteLine(f.ToString());
            Console.WriteLine('\n');

            // 2_6 . Метод розширень
            var midSizeFirms = firms.Where(f => f.EmployeeCount >= 100 && f.EmployeeCount <= 200);
            Console.WriteLine("=== Результат запиту з кількістю співробітників, більшою за 100 і менше 200 ===");
            midSizeFirms.ToList().ForEach(f => Console.WriteLine(f));

            // Отримати фірми, які знаходяться в Лондоні;
            Console.WriteLine("================================================");
            var firm_London = firms.Where(p => p.Address.Contains("London"));

            foreach (var f in firm_London)
                Console.WriteLine(f.ToString());
            Console.WriteLine('\n');

            // 2_7 . Метод розширень
            var londonFirms = firms.Where(f => f.Address.Contains("London"));
            Console.WriteLine("=== Результат запиту фірми з Лондону ===");
            midSizeFirms.ToList().ForEach(f => Console.WriteLine(f));

            // Отримати фірми з дня заснування, яких минуло 1230 дні;
            Console.WriteLine("================================================");
            var Firm_more123 = firms.Where(d => (DateTime.Now - d.FoundationDate).Days > 1230);

            foreach (var f in Firm_more123)
                Console.WriteLine(f.ToString());
            Console.WriteLine('\n');

            // 2_9 Метод розширень
            var olderThanTwoYears = firms.Where(f => f.FoundationDate < currentDate.AddYears(-2));
            Console.WriteLine("=== Результат запиту фірми більше 2 років ===");
            midSizeFirms.ToList().ForEach(f => Console.WriteLine(f));


            //Отримати фірми, у яких прізвище директора White;
            Console.WriteLine("================================================");
            var Firm_White = firms.Where(p => p.DirectorFullName.Contains("White"));

            foreach (var f in Firm_White)
                Console.WriteLine(f.ToString());
            Console.WriteLine('\n');

            // 2_8 . Метод розширень
            var whiteDirectors = firms.Where(f => f.DirectorFullName.EndsWith("White"));
            Console.WriteLine("=== Результат запиту діректор White  ===");
            midSizeFirms.ToList().ForEach(f => Console.WriteLine(f));

            // Отримати фірми, у яких прізвище директора Black і назва фірми містить слово White.
            Console.WriteLine("White Black ================================================");
            var Firm_Blank_White = firms.Where(p => p.DirectorFullName.EndsWith("Black") && p.Name.Contains("White"));
            foreach (var f in Firm_Blank_White)
                Console.WriteLine(f.ToString());
            Console.WriteLine('\n');

            Console.WriteLine("=== Результат запиту діректор Black Фірма White  ===");
            Firm_Blank_White.ToList().ForEach(f => Console.WriteLine(f));

        }
    }

    public class Firm
    {
        public string Name { get; set; }
        public DateTime FoundationDate { get; set; }
        public string BusinessProfile { get; set; }
        public string DirectorFullName { get; set; }
        public int EmployeeCount { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"{Name} | {BusinessProfile} | Директор: {DirectorFullName} | {EmployeeCount} співр. | {Address} | Засновано: {FoundationDate:dd.MM.yyyy}";
        }
    }
}
