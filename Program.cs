using practicequestions2;
using Practicequestions2;
using System;

namespace practicequestions
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\n=== Vehicle Information ===");

            // Creating a Car object
            Car myCar = new Car("Toyota", 180);
            myCar.DisplayInfo();

            // Creating a Bike object
            Bike myBike = new Bike("Yamaha", 120);
            myBike.DisplayInfo();

            Console.WriteLine("\n=== Vehicle Information ===");

            // Creating a Car2 object
            Car2 myCar2 = new Car2("Toyota", 180, 4);
            myCar2.DisplayInfo();

            // Creating a Bike2 object
            Bike2 myBike2 = new Bike2("Yamaha", 120, true);
            myBike2.DisplayInfo();

            Console.WriteLine("\n=== Employee and Manager Details ===");

            // Creating an Employee object
            ConstructorChanging employee = new ConstructorChanging("John Doe", 50000);
            employee.DisplayInfo();

            Console.WriteLine();

            // Creating a Manager object
            Manager manager = new Manager("Alice Smith", 70000, 10000);
            manager.DisplayInfo();

            Console.WriteLine("\n=== Animal Sounds ===");

            // Creating Dog object
            AbstractClassAndPoly dog = new Dog("Buddy");
            dog.MakeSound();

            // Creating Cat object
            AbstractClassAndPoly cat = new Cat("Whiskers");
            cat.MakeSound();

            Console.WriteLine("\n=== Interface vs Inheritance in C# ===");
            // Creating a Robot object
            Robot myRobot = new Robot();
            // Calling Start() from Machine (base class)
            myRobot.Start();
            // Calling Move() from IMovable (interface)
            myRobot.Move();

            Console.WriteLine("\n=== Sealed Class and Methods ===");

            // Creating a SavingsAccount object
            SavingsAccount myAccount = new SavingsAccount();

            // Calling CalculateInterest()
            myAccount.CalculateInterest();

            Console.WriteLine("\n=== Multiple Inheritance Using Interfaces ===");

            // Creating a Duck object
            Duck myDuck = new Duck();

            // Calling methods from both interfaces
            myDuck.Fly();
            myDuck.Swim();

            Console.WriteLine("\n=== Upcasting and Downcasting ===");

            // Creating a Student object
            Student student = new Student("Alice", 101);

            // Upcasting: Student to Casting (Base Class)
            Casting person = student;
            person.ShowInfo();

            // Downcasting: Casting back to Student
            if (person is Student downcastedStudent)
            {
                downcastedStudent.ShowStudentInfo();
            }
            else
            {
                Console.WriteLine("Downcasting failed!");
            }
            Console.WriteLine("\n=== E-Commerce System ===");

            // Creating an Electronic Product
            Ecommerce laptop = new ElectronicProduct("Laptop", 1000);
            laptop.DisplayInfo();

            // Creating a Clothing Product
            Ecommerce tshirt = new ClothingProduct("T-Shirt", 50);
            tshirt.DisplayInfo();

            Console.WriteLine("\n=== Security System ===");
            SecuritySystem system = new SecuritySystem();
            system.AuthenticateUser("admin", "password123");
        }
    }
}
