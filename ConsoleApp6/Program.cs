class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Status { get; set; }
    public decimal Balance { get; set; }
    public Person(string name, int age, string status, decimal balance)
    {
        Name = name;
        Age = age;
        Status = status;
        Balance = balance;
    }
}

class Programm
{
    static List<Person> people = new List<Person>();
    static void Main(string[] args)
    {
        while(true)
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
        // i am gay
    }

    static void AddPerson()
    {
        Console.Clear();
        Console.WriteLine("Write name new person: ");
        string name = Console.ReadLine();
        Console.WriteLine("Write age new person: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Write status new person: ");
        string status = Console.ReadLine();
        var balance = 0m;
        Person person = new Person(name,age,status,balance);
        people.Add(person);
        Console.WriteLine("Person added successfully.");
    }

    static void UpdatePerson()
    {

    }

    static void DeletePerson()
    {

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