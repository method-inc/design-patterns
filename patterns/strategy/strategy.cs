using System;

namespace StrategyPattern
{
    //context
    public abstract class Company
    {
        public abstract double Calculate(Package package);
    }

    //context
    public class Shipping
    {
        private Company company;

        public void SetStrategy(Company company)
        {
            this.company = company;
        }

        public double Calculate(Package package)
        {
            return company.Calculate(package);
        }
    }

    //dependent 
    public class Package
    {
        public int From { get; set; }
        public int To { get; set; }
        public string Weight { get; set; }
    }

    //concreteStrategy
    public class UPS : Company
    {
        public override double Calculate(Package package)
        {
            // calculations...
            return 45.95;
        }
    }

    //concreteStrategy
    public class USPS : Company
    {
        public override double Calculate(Package package)
        {
            // calculations...
            return 39.40;
        }
    }

    //concreteStrategy
    public class Fedex : Company
    {
        public override double Calculate(Package package)
        {
            // calculations...
            return 43.20;
        }
    }

    //client Participant
    internal class Program
    {
        static void Main(string[] args)
        {
            Package package = new Package() 
                            { From  = 76712, To = 10012, Weight = "1kg"};

            // the 3 strategies
            UPS ups = new UPS();
            USPS usps = new USPS();
            Fedex fedex = new Fedex();

            Shipping shipping = new Shipping();
            shipping.SetStrategy(ups);
            Console.WriteLine("UPS Strategy: " + shipping.Calculate(package));

            shipping.SetStrategy(usps);
            Console.WriteLine("USPS Strategy: " + shipping.Calculate(package));

            shipping.SetStrategy(fedex);
            Console.WriteLine("Fedex Strategy: " + shipping.Calculate(package));
            
        }
    }
}
