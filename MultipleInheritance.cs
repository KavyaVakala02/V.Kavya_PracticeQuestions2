using System;

namespace practicequestions
{
    // Interface MultipleInheritance
    interface MultipleInheritance
    {
        void Fly();
    }

    // Interface ISwimmable
    interface ISwimmable
    {
        void Swim();
    }

    // Class Duck implementing both interfaces
    class Duck : MultipleInheritance, ISwimmable
    {
        public void Fly()
        {
            Console.WriteLine("The duck is flying...");
        }
        public void Swim()
        {
            Console.WriteLine("The duck is swimming...");
        }
    }
}
