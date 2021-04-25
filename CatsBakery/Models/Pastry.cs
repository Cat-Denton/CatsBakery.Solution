using System.Collections.Generic;
using System;

namespace CatsBakery.Models
{
  public class Pastry
  {
    public int PastryOrderSize { get; set; }

    public Pastry(int pastryOrderSize)
    {
      PastryOrderSize = pastryOrderSize;
    }

    public int GetPastryDiscount()
    {
      int discountCount = 0;
      int discountAmount = 1;
      int pastryDiscount = discountAmount*discountCount;
      return pastryDiscount; 
    }
  }
}