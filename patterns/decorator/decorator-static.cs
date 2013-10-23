using System;
using System.Collections.Generic;

// Component
public abstract class Coffee 
{
  public abstract double getCost(); // returns the cost of the coffee
}
 
// ConcreteComponent
public class SimpleCoffee : Coffee {
  public override double getCost() 
  {
    return 2;
  }
}

// Decorator 
public abstract class CoffeeDecorator : Coffee 
{
  Coffee decoratedCoffee;

  public CoffeeDecorator (Coffee decoratedCoffee) 
  {
    this.decoratedCoffee = decoratedCoffee;
  }

  public override double getCost() 
  {
    return decoratedCoffee.getCost();
  }
}

// ConcreteDecorator 
class Milk : CoffeeDecorator 
{
  public Milk (Coffee decoratedCoffee) 
    : base(decoratedCoffee)
  {
  }

  public override double getCost() 
  {
    return base.getCost() + 0.4;
  }
}

// ConcreteDecorator 
class Sugar : CoffeeDecorator 
{
  public Sugar (Coffee decoratedCoffee) 
    : base(decoratedCoffee)
  {
  }

  public override double getCost() 
  {
    return base.getCost() + 0.2;
  }
}

// Client
internal class Program
{
    public static void Main(string[] args)
    {
      Coffee c = new SimpleCoffee();
      Console.WriteLine("Cost: " + c.getCost() + ";");

      c = new Milk(c);
      Console.WriteLine("Cost: " + c.getCost() + ";");

      c = new Sugar(c);
      Console.WriteLine("Cost: " + c.getCost() + ";");

      c = new SimpleCoffee();
      c = new Milk(new Sugar(c)); //shows the actual decoration
      Console.WriteLine("Cost: " + c.getCost() + ";");
    }
}
