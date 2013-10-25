using System;

// Specification
public interface ISpecification<T>
{
  bool Satisfies(T candidate);
}

// Object
public class Tshirt
{
  public string Name { get; set; }
}

// ConcreteSpecification
public class TshirtSpecification : ISpecification<Tshirt>
{
  public bool Satisfies(Tshirt shirt)
  {
    return shirt.Name == "Awesome";
  }
}

internal class Program
{
  public static void Main(string[] args)
  {
    Tshirt ats = new Tshirt();
    ats.Name = "Awesome";
    Tshirt nts = new Tshirt();
    nts.Name = "Not Awesome";
    TshirtSpecification criteria = new TshirtSpecification();
    Console.WriteLine("Is the shirt awesome? " + criteria.Satisfies(ats));
    Console.WriteLine("Is the shirt awesome? " + criteria.Satisfies(nts));
  }
}

