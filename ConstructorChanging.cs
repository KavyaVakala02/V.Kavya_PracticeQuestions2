using System;

namespace practicequestions2
{
    // Base class ConstructorChanging
    class ConstructorChanging
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public ConstructorChanging(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Salary: {Salary}");
        }
    }
    // Derived class Manager
    class Manager : ConstructorChanging
    {
        public double Bonus { get; set; }
        public Manager(string name, double salary, double bonus) : base(name, salary)
        {
            Bonus = bonus;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Bonus: {Bonus}");
        }
    }
}
