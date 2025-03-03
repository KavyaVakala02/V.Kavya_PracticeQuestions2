using System;

namespace practicequestions2
{
    // Base class MethodOverride
    class MethodOverride
    {
        public string Brand { get; set; }
        public int Speed { get; set; }
        public MethodOverride(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
        }
    }
    // Derived class Car2
    class Car2 : MethodOverride
    {
        public int NumberOfDoors { get; set; }

        public Car2(string brand, int speed, int numberOfDoors) : base(brand, speed)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
        }
    }
    // Derived class Bike2
    class Bike2 : MethodOverride
    {
        public bool HasCarrier { get; set; }
        public Bike2(string brand, int speed, bool hasCarrier) : base(brand, speed)
        {
            HasCarrier = hasCarrier;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Has Carrier: {HasCarrier}");
        }
    }
}
