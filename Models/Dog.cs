namespace ZooManagement.Models
{
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            System.Console.WriteLine("Bark");
        }
    }
}
