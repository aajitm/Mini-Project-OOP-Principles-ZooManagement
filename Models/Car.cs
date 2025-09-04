namespace ZooManagement.Models
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public void Honk()
        {
            System.Console.WriteLine("Car is honking!");
        }
    }
}
