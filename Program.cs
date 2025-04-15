namespace wk1ex2_review;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("INFORMATION INPUT");
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        Console.Write("What is your age? ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("What is your favorite color? ");
        string color = Console.ReadLine();



        Person Person1 = new Person(firstName, lastName, age, color);

        Person1.DisplayResults();

        Console.Read();
    }
    public class Person
    {
        public string firstName, lastName, color;
        public int age;

        public Person(string firstName, string lastName, int age, string color)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.color = color;

        }

        public void DisplayResults()
        {
            Console.WriteLine("Hello, " + firstName + " " + lastName + " You are " + age + " Years old and your favorite color is " + color + ".");
        }
    }
}

