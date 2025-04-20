namespace wk1ex2_review;
class Program
{
    static void Main(string[] args)
    {
        // display welcome text for the input process
        Console.WriteLine("INFORMATION INPUT");
        // ask the user for their first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        // ask the user for their last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        // ask for age and convert from string to integer
        Console.Write("What is your age? ");
        int age = Convert.ToInt32(Console.ReadLine());
        // ask the user for their favorite color
        Console.Write("What is your favorite color? ");
        string color = Console.ReadLine();
        // create a new Person object using the info provided
        Person Person1 = new Person(firstName, lastName, age, color);
        // call method to print the message to the user
        Person1.DisplayResults();
        // pause the console so it doesn't close right away
        Console.Read();
    }
    // this class stores the personal info of one user
    public class Person
    {
        // define variables to store name, age, color
        public string firstName, lastName, color;
        public int age;
        // constructor for person object, receives 4 values
        public Person(string firstName, string lastName, int age, string color)
        {
            // assign the values to the class fields
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.color = color;
        }
        // method to show results
        public void DisplayResults()
        {
            // print a friendly message with all the info
            Console.WriteLine("Hello, " + firstName + " " + lastName + " You are " + age + " Years old and your favorite color is " + color + ".");
        }
    }
}
