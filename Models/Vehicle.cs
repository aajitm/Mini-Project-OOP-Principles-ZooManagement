namespace ZooManagement.Models
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public void Start()
        {
            System.Console.WriteLine("Vehicle is starting...");
        }
    }
}
