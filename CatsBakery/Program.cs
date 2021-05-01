using System;
using CatsBakery.Models;

namespace CatsBakery
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Cat's Bakery, where the bread is very-well-kneaded!");
      Console.WriteLine("How many loaves of bread would you like? $5 each, buy two get the third free! Enter Number: ");
      int numberBread = int.Parse(Console.ReadLine());
      Console.WriteLine("How many pastries would you like? $2 each or 3 for $5! Enter Number: ");
      int numberPastry = int.Parse(Console.ReadLine());
      Bread breadOrder = new Bread(numberBread);
      Pastry pastryOrder = new Pastry(numberPastry);
      int discountTotal = breadOrder.GetBreadDiscount() + pastryOrder.GetPastryDiscount();
      int orderTotal = breadOrder.GetBreadPrice() + pastryOrder.GetPastryPrice() - discountTotal;
      Console.WriteLine("Your order of {0} loaves of bread and {1} pastries comes to a total of ${2}.", numberBread, numberPastry, orderTotal);
    }
  }
}
