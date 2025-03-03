using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicequestions2
{
    class Account
    {
        public virtual void CalculateInterest()
        {
            Console.WriteLine("Calculating interest in Account...");
        }
    }
    // Derived class
    class SavingsAccount : Account
    {
        // Prevent further overriding by marking it as sealed
        public sealed override void CalculateInterest()
        {
            Console.WriteLine("Calculating interest for Savings Account...");
        }
    }
}
