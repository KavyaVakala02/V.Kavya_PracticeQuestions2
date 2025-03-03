using System;

namespace practicequestions
{
    // Base class Ecommerce
    class Ecommerce
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Ecommerce(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public virtual double GetDiscountedPrice()
        {
            return Price; // No discount by default
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Ecommerce: {Name}, Price: ${Price}, Discounted Price: ${GetDiscountedPrice()}");
        }
    }
    // Derived class ElectronicProduct
    class ElectronicProduct : Ecommerce
    {
        public ElectronicProduct(string name, double price) : base(name, price) { }

        public override double GetDiscountedPrice()
        {
            return Price * 0.9; // 10% discount for electronics
        }
    }
    // Derived class ClothingProduct
    class ClothingProduct : Ecommerce
    {
        public ClothingProduct(string name, double price) : base(name, price) { }

        public override double GetDiscountedPrice()
        {
            return Price * 0.8; // 20% discount for clothing
        }
    }
}
