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
                new Firm { Name = "Food Corp", FoundationDate = new DateTime(2020, 5, 12), 
                    BusinessProfile = "Food", DirectorFullName = "John White",
                    Address = "London, Baker St",
                Employees = new List<Employee>
                {
                    new Employee { FullName = "Jack Higgins", Position = "Manager", Phone = "+44-20-7946-0958", Email = "higgins@foodcorp.com", Salary = 4500.00m },
                    new Employee { FullName = "Mary Berry", Position = "Chef", Phone = "+44-20-7946-0112", Email = "berry@foodcorp.com", Salary = 5200.00m }
                }},
                new Firm { Name = "IT Solutions", FoundationDate = new DateTime(2023, 1, 10), BusinessProfile = "IT", DirectorFullName = "Alice Black", Address = "London, Oxford St",
                    Employees = new List<Employee>
                    {
                        new Employee { FullName = "Alan Turing", Position = "Senior Developer", Phone = "+44-20-7946-0443", Email = "turing@itsolutions.com", Salary = 7500.00m },
                        new Employee { FullName = "Linus Torvalds", Position = "DevOps", Phone = "+44-20-7946-0889", Email = "linus@itsolutions.com", Salary = 6800.00m }
                    }
                },
                new Firm { Name = "Global Marketing", FoundationDate = new DateTime(2018, 11, 25), BusinessProfile = "Marketing", DirectorFullName = "Robert Ford", Address = "New York, Wall St",
                    Employees = new List<Employee>
                    {
                        new Employee { FullName = "Don Draper", Position = "Creative Director", Phone = "+1-555-0199", Email = "draper@globalmark.com", Salary = 9000.00m },
                        new Employee { FullName = "Peggy Olson", Position = "Copywriter", Phone = "+1-555-0144", Email = "olson@globalmark.com", Salary = 4800.00m }
                    }
                },
                new Firm { Name = "White Food", FoundationDate = new DateTime(2024, 3, 5), BusinessProfile = "Food", DirectorFullName = "Michael Black", Address = "London, Regent St",
                    Employees = new List<Employee>
                    {
                        new Employee { FullName = "Gordon Ramsay", Position = "Brand Chef", Phone = "+44-20-7946-0331", Email = "ramsay@whitefood.com", Salary = 8500.00m },
                        new Employee { FullName = "David Chang", Position = "Sous Chef", Phone = "+44-20-7946-0772", Email = "chang@whitefood.com", Salary = 5000.00m }
                    }
                },
                new Firm { Name = "Tech Pro", FoundationDate = new DateTime(2021, 6, 15), BusinessProfile = "IT", DirectorFullName = "Emma Watson", Address = "Kyiv, Khreshchatyk",
                    Employees = new List<Employee>
                    {
                        new Employee { FullName = "Олександр Коваленко", Position = "Team Lead", Phone = "+380441234567", Email = "kovalenko@techpro.ua", Salary = 120000.00m },
                        new Employee { FullName = "Марія Бондар", Position = "QA Engineer", Phone = "+380447654321", Email = "bondar@techpro.ua", Salary = 45000.00m }
                    }
                },
                new Firm { Name = "Fast Food UA", FoundationDate = new DateTime(2025, 3, 5), BusinessProfile = "Food", DirectorFullName = "Sarah White", Address = "Lviv, Rynok sq",
                    Employees = new List<Employee>
                    {
                        new Employee { FullName = "Ігор Шевченко", Position = "Courier", Phone = "+380671112233", Email = "sheva@fastfood.lviv.ua", Salary = 20000.00m },
                        new Employee { FullName = "Олена Петрів", Position = "Cashier", Phone = "+380634445566", Email = "petriv@fastfood.lviv.ua", Salary = 18000.00m }
                    }
                },
                new Firm { Name = "Ad Agency", FoundationDate = new DateTime(2015, 9, 1), BusinessProfile = "Marketing", DirectorFullName = "David Black", Address = "London, Piccadilly",
                    Employees = new List<Employee>
                    {
                        new Employee { FullName = "Sam Phillips", Position = "PR Specialist", Phone = "+44-20-7946-0511", Email = "sam@adagency.co.uk", Salary = 4200.00m },
                        new Employee { FullName = "Jane Doe", Position = "Designer", Phone = "+44-20-7946-0222", Email = "jane@adagency.co.uk", Salary = 4600.00m }
                    }
                },
                new Firm { Name = "Soft Dev", FoundationDate = new DateTime(2022, 7, 20), BusinessProfile = "IT", DirectorFullName = "Peter Parker", Address = "London, King St",
                    Employees = new List<Employee>
                    {
                        new Employee { FullName = "Ned Leeds", Position = "System Administrator", Phone = "+44-20-7946-0109", Email = "ned@softdev.com", Salary = 3800.00m },
                        new Employee { FullName = "Gwen Stacy", Position = "Data Analyst", Phone = "+44-20-7946-0188", Email = "gwen@softdev.com", Salary = 5100.00m }
                    }
                },
                new Firm { Name = "Tasty Meal", FoundationDate = new DateTime(2026, 3, 5), BusinessProfile = "Food", DirectorFullName = "John Black", Address = "Berlin, Main St",
                    Employees = new List<Employee>
                    {
                        new Employee { FullName = "Hans Müller", Position = "Logistics Manager", Phone = "+49-30-123456", Email = "muller@tastymeal.de", Salary = 3900.00m },
                        new Employee { FullName = "Anna Schmidt", Position = "Technologist", Phone = "+49-30-654321", Email = "schmidt@tastymeal.de", Salary = 4400.00m }
                    }
                },
                new Firm { Name = "Creative Minds", FoundationDate = new DateTime(2019, 4, 18), BusinessProfile = "Marketing", DirectorFullName = "Laura White", Address = "London, Bond St",
                    Employees = new List<Employee>
                    {
                        new Employee { FullName = "Leo Burnett", Position = "Strategist", Phone = "+44-20-7946-1357", Email = "burnett@creativeminds.com", Salary = 5500.00m },
                        new Employee { FullName = "David Ogilvy", Position = "Copywriter", Phone = "+44-20-7946-2468", Email = "ogilvy@creativeminds.com", Salary = 6000.00m }
                    }
                },
                new Firm { Name = "Code Base", FoundationDate = new DateTime(2024, 1, 1), BusinessProfile = "IT", DirectorFullName = "Chris White", Address = "Paris, Champs-Elysees",
                    Employees = new List<Employee>
                    {
                        new Employee { FullName = "Jean Dupont", Position = "Frontend Developer", Phone = "+33-1-422778", Email = "dupont@codebase.fr", Salary = 4800.00m },
                        new Employee { FullName = "Marie Curie", Position = "Backend Developer", Phone = "+33-1-987654", Email = "curie@codebase.fr", Salary = 5300.00m }
                    }
                },
                new Firm { Name = "Organic Food", FoundationDate = new DateTime(2023, 3, 5), BusinessProfile = "Food", DirectorFullName = "Anna Black", Address = "London, Oxford St",
                    Employees = new List<Employee>
                    {
                        new Employee { FullName = "Tom Marvolo", Position = "Quality Inspector", Phone = "+44-20-7946-9900", Email = "riddle@organicfood.co.uk", Salary = 4100.00m },
                        new Employee { FullName = "Jamie Oliver", Position = "Nutritionist", Phone = "+44-20-7946-9911", Email = "jamie@organicfood.co.uk", Salary = 5800.00m }
                    }
                },
                new Firm { Name = "Pro Marketer", FoundationDate = new DateTime(2020, 8, 30), BusinessProfile = "Marketing", DirectorFullName = "Tom White", Address = "London, Regent St",
                    Employees = new List<Employee> 
                    {
                        new Employee { FullName = "Gary Vaynerchuk", Position = "SMM Head", Phone = "+44-20-7946-4455", Email = "gary@promarketer.com", Salary = 6200.00m },
                        new Employee { FullName = "Neil Patel", Position = "SEO Expert", Phone = "+44-20-7946-5566", Email = "neil@promarketer.com", Salary = 5900.00m }
                    }
                },
                new Firm { Name = "AI Lab", FoundationDate = new DateTime(2025, 3, 5), BusinessProfile = "IT", DirectorFullName = "George Black", Address = "Warsaw, Marszalkowska",
                    Employees = new List<Employee>
                    {
                        new Employee { FullName = "Jan Kowalski", Position = "AI Engineer", Phone = "+48-22-123456", Email = "kowalski@ailab.pl", Salary = 6500.00m },
                        new Employee { FullName = "Anna Nowak", Position = "Data Scientist", Phone = "+48-22-654321", Email = "nowak@ailab.pl", Salary = 6200.00m }
                    }
                },
                new Firm { Name = "Daily Food", FoundationDate = new DateTime(2017, 12, 12), BusinessProfile = "Food", DirectorFullName = "Oliver White", Address = "London, Fleet St",
                    Employees = new List<Employee>
                    {
                        new Employee { FullName = "Arthur Dent", Position = "Supplier", Phone = "+44-20-7946-8822", Email = "dent@dailyfood.com", Salary = 3500.00m },
                        new Employee { FullName = "Ford Prefect", Position = "Controller", Phone = "+44-20-7946-8833", Email = "prefect@dailyfood.com", Salary = 3900.00m }
                    }
                },
                new Firm { Name = "Innovatech", FoundationDate = new DateTime(2026, 1, 1), BusinessProfile = "IT", DirectorFullName = "Sophie White", Address = "London, Strand",
                    Employees = new List<Employee>
                    {
                        new Employee { FullName = "Ada Lovelace", Position = "Architect", Phone = "+44-20-7946-7711", Email = "ada@innovatech.com", Salary = 8000.00m },
                        new Employee { FullName = "Charles Babbage", Position = "Hardware Specialist", Phone = "+44-20-7946-7722", Email = "charles@innovatech.com", Salary = 7100.00m }
                    }
                },
                new Firm { Name = "Market Masters", FoundationDate = new DateTime(2026, 3, 5), BusinessProfile = "Marketing", DirectorFullName = "Harry Black", Address = "London, Victoria St",
                    Employees = new List<Employee>
                    {
                        new Employee { FullName = "Philip Kotler", Position = "Consultant", Phone = "+44-20-7946-1212", Email = "kotler@mmasters.co.uk", Salary = 7000.00m },
                        new Employee { FullName = "Seth Godin", Position = "Analyst", Phone = "+44-20-7946-1313", Email = "seth@mmasters.co.uk", Salary = 5400.00m }
                    }
                },
                new Firm { Name = "Mega Bite", FoundationDate = new DateTime(2014, 4, 14), BusinessProfile = "Food", DirectorFullName = "James White", Address = "Chicago, Michigan Ave",
                    Employees = new List<Employee>
                    {
                        new Employee { FullName = "Ray Kroc", Position = "Regional Director", Phone = "+1-312-555-0100", Email = "kroc@megabite.com", Salary = 9500.00m },
                        new Employee { FullName = "Colonel Sanders", Position = "Food Franchise Manager", Phone = "+1-312-555-0177", Email = "sanders@megabite.com", Salary = 7800.00m }
                    }
                },
                new Firm { Name = "Digital One", FoundationDate = new DateTime(2021, 10, 5), BusinessProfile = "Marketing", DirectorFullName = "Jack Black", Address = "London, Oxford St",
                    Employees = new List<Employee>
                    {
                        new Employee { FullName = "Steve Jobs", Position = "Product Marketing Leader", Phone = "+44-20-7946-3696", Email = "jobs@digitalone.com", Salary = 8800.00m },
                        new Employee { FullName = "Tim Cook", Position = "Operations Executive", Phone = "+44-20-7946-3697", Email = "cook@digitalone.com", Salary = 7400.00m }
                    }


                },
                new Firm { Name = "NextGen IT", FoundationDate = new DateTime(2016, 2, 28), BusinessProfile = "IT", DirectorFullName = "Mia White", Address = "London, High St",
                    Employees = new List<Employee>
                    {
                        new Employee { FullName = "Bill Gates", Position = "Lead Developer", Phone = "+44-20-7946-5544", Email = "gates@nextgenit.co.uk", Salary = 8200.00m },
                        new Employee { FullName = "Paul Allen", Position = "Security Researcher", Phone = "+44-20-7946-5545", Email = "allen@nextgenit.co.uk", Salary = 7300.00m }
                    }
                }
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
            Console.WriteLine('\n');

            // TASK 3 Employee
            // 1. Отримати всіх співробітників конкретної фірми (наприклад, першої у списку)
            var employeesOfFirm = firms.First(f => f.Name == "Food Corp").Employees;
            Console.WriteLine("=== Співробітники фірми Food Corp ===");
            employeesOfFirm.ToList().ForEach(e => Console.WriteLine(e));
            Console.WriteLine('\n');

            // 2. Отримати всіх співробітників конкретної фірми, у яких заробітні плати більші за задану (наприклад, > 5000)
            decimal targetSalary = 5000.00m;
            var employeesOfFirm5000 = firms.First(f => f.Name == "White Food").Employees;
            var highPaidEmployeesOfFirm = employeesOfFirm5000
                .Where(e => e.Salary > targetSalary);
            Console.WriteLine("=== Співробітники фірми Food Corp з ЗП більше 5000 ===");
            highPaidEmployeesOfFirm.ToList().ForEach(e => Console.WriteLine(e));
            Console.WriteLine('\n');

            // 3. Отримати співробітників усіх фірм, у яких посада менеджер
            var allManagers = firms
                .SelectMany(f => f.Employees)
                .Where(e => e.Position.Contains("Manager", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("=== Співробітники Manager всіх фірм ===");
            allManagers.ToList().ForEach(e => Console.WriteLine(e));
            Console.WriteLine('\n');

            // 4. Отримати співробітників, у яких телефон починається з 23
         
            var phone23Employees = firms
                .SelectMany(f => f.Employees)
                .Where(e => e.Phone.Contains("23"));
            Console.WriteLine("=== Співробітники з телефоном на 23 ===");
            phone23Employees.ToList().ForEach(e => Console.WriteLine(e));
            Console.WriteLine('\n');

            // 5. Отримати співробітників, у яких Email починається з di
            var emailDiEmployees = firms
                .SelectMany(f => f.Employees)
                .Where(e => e.Email.StartsWith("ko", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("=== Співробітники у яких Email починається з ko ===");
            phone23Employees.ToList().ForEach(e => Console.WriteLine(e));
            Console.WriteLine('\n');

            // 6. Отримати співробітників, у яких ім'я Jack
            var jackEmployees = firms
                .SelectMany(f => f.Employees)
                .Where(e => e.FullName.StartsWith("Jack", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("=== Співробітники у яких ім'я Jack ===");
            jackEmployees.ToList().ForEach(e => Console.WriteLine(e));
            Console.WriteLine('\n');
        }
    }

    public class Firm
    {
        public string Name { get; set; }
        public DateTime FoundationDate { get; set; }
        public string BusinessProfile { get; set; }
        public string DirectorFullName { get; set; }
        public int EmployeeCount => Employees?.Count ?? 0;
        public string Address { get; set; }

        public List<Employee> Employees { get; set; } = new List<Employee>();

        public override string ToString()
        {
            return $"{Name} | {BusinessProfile} | Директор: {DirectorFullName} " +
                $"| {EmployeeCount} співр. | {Address} | Засновано: {FoundationDate:dd.MM.yyyy}";
        }
    }

    public class Employee
    {
        public string FullName { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"   - {FullName} | {Position} | Тел: {Phone} | Email: {Email} | ЗП: {Salary:F2} грн";
        }
    }
}
