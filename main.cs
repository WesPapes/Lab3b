using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter salesperson name");
    string salespersonName = Console.ReadLine();
    Console.WriteLine(salespersonName);
    Console.WriteLine ("Enter sales amount");
    int amount = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(amount);
    
    if (amount >= 0 && amount <= 2999)
    {
      Console.WriteLine("Performance is poor");
    }
    else if (amount >= 3000 && amount <= 4999)
    {
      Console.WriteLine("Performance is average");
    }
    else if (amount >= 5000 && amount <= 9999)
    {
      Console.WriteLine("Performance is good");
    }
    else if (amount >= 10000 && amount <= 14999)
    {
      Console.WriteLine("Performance is excellent");
    }
    else if (amount >= 15000)
    {
      Console.WriteLine("Performane is outstanding");
    }
  }
}