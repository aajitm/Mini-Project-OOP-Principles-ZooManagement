# 🐾 Zoo Management System (OOP Demo in C#)

This is a simple **C# console application** built in **Visual Studio** to demonstrate the **four main OOP principles**:

Object-Oriented Programming (OOP) is a paradigm that uses objects and classes to organize and structure code.  
In OOP, everything is an object, and these objects interact with each other through methods and properties.  

OOP in C# revolves around four main principles:
1. **Encapsulation**
2. **Abstraction**
3. **Inheritance**
4. **Polymorphism**

---

## 1️⃣ Encapsulation → `Person.cs`

Encapsulation is the process of hiding the internal state of an object and restricting access to it.  
It ensures integrity by preventing outsiders from directly modifying an object’s state, allowing controlled access through **properties** or **methods**.

### Example:
```csharp
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
        person.Greet();        // Calling the method to greet
    }
}
````

**Explanation:**

* `name` → private field (cannot be accessed directly outside the class).
* `Name` → public property (controlled access).
* `Greet()` → public method to interact with the object.

---

## 2️⃣ Abstraction → `Animal.cs`, `Dog.cs`, `Cat.cs`

Abstraction hides system complexity and exposes only the **essential features**.
It allows you to focus on **what** an object does, rather than **how** it does it.

### Example:

```csharp
public abstract class Animal
{
    public abstract void MakeSound(); // Abstract method
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
```

**Explanation:**

* `Animal` → abstract class with `MakeSound()` method.
* `Dog` & `Cat` → implement their own versions of `MakeSound()`.
* Abstraction allows treating both `Dog` and `Cat` as `Animal`.

---

## 3️⃣ Inheritance → `Vehicle.cs`, `Car.cs`

Inheritance enables **code reuse** by allowing one class to derive properties and methods from another.

### Example:

```csharp
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

        myCar.Start(); // Inherited from Vehicle
        myCar.Honk();  // Specific to Car
    }
}
```

**Explanation:**

* `Car` inherits from `Vehicle`.
* It reuses `Make`, `Model`, and `Start()`.
* Adds its own property `NumberOfDoors` and method `Honk()`.

---

## 4️⃣ Polymorphism → `Shape.cs`, `Circle.cs`, `Rectangle.cs`

Polymorphism allows different classes to be treated as a **common base type**.
It supports:

* **Compile-time Polymorphism** (method overloading).
* **Run-time Polymorphism** (method overriding).

### Example (Run-time Polymorphism):

```csharp
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
```

**Explanation:**

* `Draw()` is overridden in `Circle` and `Rectangle`.
* At runtime, the correct method executes depending on object type.

---

## 📌 Summary of OOP Concepts in C\#

1. **Encapsulation** → Hides internal state, controlled access via methods/properties.
2. **Abstraction** → Hides complexity, shows only essentials.
3. **Inheritance** → Reuse code, hierarchical relationship.
4. **Polymorphism** → Different behaviors for a common base type.

✅ Together, these make code **flexible, reusable, and maintainable**.

---

## 🚀 How to Run

1. Clone this repository:

   ```bash
   git clone https://github.com/your-username/ZooManagement.git
   ```
2. Open `ZooManagement.sln` in **Visual Studio**.
3. Run the project (`F5`).

---

## 📊 Output Example

```
=== ZOO MANAGEMENT SYSTEM (OOP DEMO) ===

Hello, my name is Ajit

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

* C#
* .NET 6 / .NET Framework
* Visual Studio 2022
