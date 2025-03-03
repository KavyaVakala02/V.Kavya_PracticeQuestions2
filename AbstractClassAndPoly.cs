using System;

namespace practicequestions
{
    abstract class AbstractClassAndPoly
    {
        public string Name { get; set; }
        public AbstractClassAndPoly(string name)
        {
            Name = name;
        }
        public abstract void MakeSound();
    }
    class Dog : AbstractClassAndPoly
    {
        public Dog(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Woof! Woof!");
        }
    }
    // Derived class Cat
    class Cat : AbstractClassAndPoly
    {
        public Cat(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Meow! Meow!");
        }
    }
}
