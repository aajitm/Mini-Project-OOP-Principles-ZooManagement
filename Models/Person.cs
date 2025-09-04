namespace ZooManagement.Models
{
    public class Person
    {
        private string name; // Encapsulated field

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Original greet method
        public void Greet()
        {
            System.Console.WriteLine($"Hello, my name is {name}");
        }

        // Overloaded greet method with a custom greeting
        public void Greet(string customGreeting)
        {
            System.Console.WriteLine($"{customGreeting}, my name is {name}");
        }

        // Overloaded greet method with age
        public void Greet(int age)
        {
            System.Console.WriteLine($"Hello, my name is {name} and I am {age} years old.");
        }
    }
}
