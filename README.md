# Zoo Management System (OOP Demo in C#)

This is a simple C# console application built in **Visual Studio** to demonstrate the **four main OOP principles**:

Object-Oriented Programming (OOP) is a programming paradigm that uses objects and classes to organize and structure code. In OOP, everything is an object, and these objects interact with each other through methods and properties. OOP in C# revolves around four main principles:

1.Encapsulation
2.Abstraction
3.Inheritance
4.Polymorphism

Let's go through each principle and illustrate them with an example in C#.

1. **Encapsulation** → `Person.cs`
Encapsulation is the process of hiding the internal state of an object and restricting access to it. This helps to protect the object's integrity by preventing outsiders from directly modifying its state. Instead, access is provided through public methods or properties.

Example:
public class Person
{
    private string name; // Private field

    // Public property to get and set the name
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Public method to display the name
    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {name}");
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person();
        person.Name = "Alice"; // Setting the name using the property
        person.Greet(); // Calling the method to greet
    }
}
In this example:
=> name is a private field, meaning it cannot be accessed directly from outside the Person class.
=> Name is a public property that allows controlled access to the name field.
=> Greet() is a public method to interact with the object.

2. **Abstraction** → `Animal.cs`, `Dog.cs`, `Cat.cs`
Abstraction is the concept of hiding the complexity of the system and exposing only the essential parts. It allows you to focus on what an object does rather than how it does it.

Example:
public abstract class Animal
{
    public abstract void MakeSound(); // Abstract method (no implementation)
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

class Program
{
    static void Main()
    {
        Animal myDog = new Dog();
        myDog.MakeSound(); // Outputs: Bark

        Animal myCat = new Cat();
        myCat.MakeSound(); // Outputs: Meow
    }
}
In this example:
=> Animal is an abstract class with an abstract method MakeSound() that must be implemented by any derived class.
=> Dog and Cat are concrete classes that implement the MakeSound method.
=> The abstraction allows us to treat Dog and Cat as Animal objects, hiding the specific details of their implementation.

3. **Inheritance** → `Vehicle.cs`, `Car.cs`
Inheritance allows a class to inherit properties and methods from another class. This helps in code reusability and establishes a hierarchical relationship between classes.

Example:
public class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }

    public void Start()
    {
        Console.WriteLine("Vehicle is starting...");
    }
}

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public void Honk()
    {
        Console.WriteLine("Car is honking!");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.Make = "Toyota";
        myCar.Model = "Corolla";
        myCar.NumberOfDoors = 4;

        myCar.Start(); // Inherited method from Vehicle
        myCar.Honk();  // Method specific to Car
    }
}
In this example:
=> Car inherits from Vehicle, so it has access to Make, Model, and Start().
=> Car also adds its own property NumberOfDoors and method Honk().

4. **Polymorphism** → `Shape.cs`, `Circle.cs`, `Rectangle.cs`
Polymorphism allows objects of different types to be treated as objects of a common base type. The two types of polymorphism are compile-time (method overloading) and run-time (method overriding).

Example (Method Overriding - Run-time Polymorphism):
public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}

class Program
{
    static void Main()
    {
        Shape myShape = new Shape();
        myShape.Draw(); // Outputs: Drawing a shape

        Shape myCircle = new Circle();
        myCircle.Draw(); // Outputs: Drawing a circle

        Shape myRectangle = new Rectangle();
        myRectangle.Draw(); // Outputs: Drawing a rectangle
    }
}
In this example:
=> The Draw() method is overridden in both Circle and Rectangle classes.
=> At runtime, the appropriate Draw() method is called based on the object type, demonstrating polymorphism.

Summary of OOP Concepts in C#:
1. Encapsulation: Hides the internal state and provides controlled access through methods/properties.
2. Abstraction: Hides complexity and shows only essential features.
3. Inheritance: Enables code reuse by allowing a class to inherit properties and behaviors from another class.
4. Polymorphism: Allows objects of different types to be treated as objects of a common base type and behave differently based on the actual type.

These four principles together allow you to write flexible, reusable, and maintainable code in C#.
---

## 🚀 How to Run
1. Clone this repository:
   ```bash
   git clone https://github.com/your-username/ZooManagement.git
   ```
2. Open `ZooManagement.sln` in **Visual Studio**.
3. Run the project (F5).

---

## 📌 Output Example
```
=== ZOO MANAGEMENT SYSTEM (OOP DEMO) ===

Hello, my name is Alice

--- Abstraction Example ---
Bark
Meow

--- Inheritance Example ---
Vehicle is starting...
Car is honking!

--- Polymorphism Example ---
Drawing a shape
Drawing a circle
Drawing a rectangle

=== END OF DEMO ===
```

---

## 🛠 Tech Stack
- C#
- .NET 6 / .NET Framework
- Visual Studio 2022
