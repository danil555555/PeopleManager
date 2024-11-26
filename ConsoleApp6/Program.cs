class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Status { get; set; }
    public decimal Balance { get; set; }
    public Guid Id { get; set; }
    public int Rating { get; set; }

    public Person(string name, int age, string status, decimal balance, Guid id, int rating)
    {
        Name = name;
        Age = age;
        Status = status;
        Balance = balance;
        Id = id;
        Rating = rating;
    }
}

class Programm
{
    static List<Person> people = new List<Person>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("==== Person manager ====");
            Console.WriteLine("1. View person");
            Console.WriteLine("2. Add person");
            Console.WriteLine("3. Update person");
            Console.WriteLine("4. Delet person");
            Console.WriteLine("5. Sort status");
            Console.WriteLine("6. Sort reting");
            Console.WriteLine("7. Read data base");
            Console.WriteLine("8. Write data base");
            Console.WriteLine("9. Exit");
            Console.Write("Choise number from 1-9: ");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ViewPerson();
                    break;
                case "2":
                    AddPerson();
                    break;
                case "3":
                    UpdatePerson();
                    break;
                case "4":
                    DeletePerson();
                    break;
                case "5":
                    SortStatus();
                    break;
                case "6":
                    SortReting();
                    break;
                case "7":
                    ReadDB();
                    break;
                case "8":
                    WrireDB();
                    break;
                case "9":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("\nPress any to continue...");
            Console.ReadKey();
        }
    }

    static void ViewPerson()
    {
        Console.Clear();
        Console.WriteLine("==== View person ====");
        for (int i = 0; i < people.Count; i++)
        {
            Console.WriteLine($"{i + 1}. Name: {people[i].Name}");
            Console.WriteLine($"   Age: {people[i].Age}");
            Console.WriteLine($"   Status: {people[i].Status}");
            Console.WriteLine($"   Balance: {people[i].Balance}");
            Console.WriteLine($"   Id: {people[i].Id}");
            Console.WriteLine($"   Reting: {people[i].Rating}");
            Console.WriteLine();
        }
        Console.WriteLine("Sucsseccfully.");
    }

    static void AddPerson()
        {
            Console.Clear();
            Console.WriteLine("Write name new person: ");
            string name = Console.ReadLine();
            if (name != null)
            {
                Console.WriteLine("Invalid name");
                return;
            }
            Console.WriteLine("Write age new person: ");
            int age = int.Parse(Console.ReadLine());
            if (age < 0)
            {
                Console.WriteLine("Invalid age");
                return;
            }
            Console.WriteLine("Write status new person: junior/middle/senior/lead/CEO");
            string status = Console.ReadLine();
            var balance = 0m;
            Console.WriteLine("Write reting new person: ");
            int reting = int.Parse(Console.ReadLine());
            Person person = new Person(name, age, status, balance, Guid.NewGuid(), reting);
            people.Add(person);
            Console.WriteLine("Person added successfully.");
        }

        static void UpdatePerson()
        {
            Console.Clear();
            Console.WriteLine("==== Update Person ====");
            Console.Write("Write number persone: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 0 || number > people.Count)
            {
                Console.WriteLine("Invalid number");
                return;
            }
            var person = people[number - 1];
            Console.Write("New Status: ");
            string consoleStatus = Console.ReadLine();
            if (consoleStatus != "")
                person.Status = consoleStatus;
            Console.Write("New Balance: ");
            var consoleBalance = Console.ReadLine();
            if (consoleBalance != "")
                person.Balance = int.Parse(consoleBalance);
            Console.WriteLine("Write reting new person:");
            var consoleReting = Console.ReadLine();
            if (consoleReting != "")
                person.Rating = int.Parse(consoleReting);
            Console.Write("Update successfully.");
        }
        static void DeletePerson()
        {
            Console.Clear();
            Console.WriteLine("==== Delet Person ====");
            Console.Write("Write number persone: ");
            int numberPerson = int.Parse(Console.ReadLine());
            
            if (numberPerson < 1 || numberPerson > people.Count)
            {
                Console.WriteLine("Invalid number");
                return;
            }

            people.RemoveAt(numberPerson - 1);
            Console.WriteLine("Person deleted successfully.");
        }

        static void SortStatus()
        {

        }

        static void SortReting()
        {

        }

        static void ReadDB()
        {
            
        }

        static void WrireDB()
        {

        }
    }
