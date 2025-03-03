using System;

namespace practicequestions
{
    // Base class Vehicle
    class Vehicle
    {
        public string Brand { get; set; }
        public int Speed { get; set; }
        public Vehicle(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
        }
    }
    // Derived class Car
    class Car : Vehicle
    {
        public Car(string brand, int speed) : base(brand, speed) { }
    }
    // Derived class Bike
    class Bike : Vehicle
    {
        public Bike(string brand, int speed) : base(brand, speed) { }
    }
}