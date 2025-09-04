using System;
using ZooManagement.Models;

namespace ZooManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ZOO MANAGEMENT SYSTEM (OOP DEMO) ===\n");

            // 1. Encapsulation
            Person person = new Person();
            person.Name = "Ajit"; // Encapsulated property
            person.Greet();

            Console.WriteLine("\n--- Abstraction Example ---");
            // 2. Abstraction
            Animal dog = new Dog();
            Animal cat = new Cat();
            dog.MakeSound();
            cat.MakeSound();

            Console.WriteLine("\n--- Inheritance Example ---");
            // 3. Inheritance
            Car car = new Car
            {
                Make = "Toyota",
                Model = "Corolla",
                NumberOfDoors = 4
            };
            car.Start();
            car.Honk();

            Console.WriteLine("\n--- Polymorphism Example ---");
            // 4. Polymorphism
            Console.WriteLine("\nExample(Method Overriding - Run - time Polymorphism):");
            Shape shape = new Shape();
            Shape circle = new Circle();
            Shape rectangle = new Rectangle();

            shape.Draw();
            circle.Draw();
            rectangle.Draw();

            Console.WriteLine("\nExample(Method Overloading - Compile - time Polymorphism):");
            person.Greet(); // Hello, my name is Ajit
            person.Greet("Welcome"); // Welcome, my name is Ajit
            person.Greet(35); // Hello, my name is Ajit and I am 35 years old.

            Console.WriteLine("\n=== END OF DEMO ===");
        }
    }
}
