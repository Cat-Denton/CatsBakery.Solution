using System.Collections.Generic;
using System;

namespace CatsBakery.Models
{
  public class Bread
  {
    public int BreadOrderSize { get; set; }

    public Bread(int breadOrderSize)
    {
      BreadOrderSize = breadOrderSize;
    }

    public int GetBreadDiscount()
    {
      int discountCount = 0;
      int discountAmount = 5;
      int discountRatio = 3;
      if (BreadOrderSize % discountRatio == 0)
      {
        discountCount++;
      }
      int breadDiscount = discountCount*discountAmount;
      return breadDiscount;
    }
  }
}