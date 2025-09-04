namespace ZooManagement.Models
{
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            System.Console.WriteLine("Meow");
        }
    }
}
