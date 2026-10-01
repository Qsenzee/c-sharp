using System;

namespace KT1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Delivery d1 = new StandardDelivery("Standard");
            d1.CalculatePrice(20m);
            Delivery d2 = new ExpressDelivery("Express");
            d2.CalculatePrice(20m);
            Delivery d3 = new InternationalDelivery("International");
            d3.CalculatePrice(20m);

            Console.WriteLine(d1.ToString());
            Console.WriteLine(d2.ToString());
            Console.WriteLine(d3.ToString());
        }
    }

    abstract class Delivery
    {
        protected string name;
        protected decimal price;

        public abstract void CalculatePrice(decimal basePrice);

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length != 0 && value.Length <= 20) name = value;
            }
        }

        public decimal Price
        {
            get { return price; }
        }

        public override string ToString()
        {
            return $"Name: {Name} Price: {Price:c}";
        }
    }

    class StandardDelivery : Delivery
    {
        public StandardDelivery(string name)
        {
            Name = name;
        }

        public override void CalculatePrice(decimal basePrice)
        {
            price = basePrice * 1.0m;
        }
    }

    class ExpressDelivery : Delivery
    {
        public ExpressDelivery(string name)
        {
            Name = name;
        }

        public override void CalculatePrice(decimal basePrice)
        {
            price = basePrice * 2.5m;
        }
    }

    class InternationalDelivery : Delivery
    {
        public InternationalDelivery(string name)
        {
            Name = name;
        }

        public override void CalculatePrice(decimal basePrice)
        {
            price = basePrice * 4.0m;
        }
    }
}