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

        public void Greet()
        {
            System.Console.WriteLine($"Hello, my name is {name}");
        }
    }
}
