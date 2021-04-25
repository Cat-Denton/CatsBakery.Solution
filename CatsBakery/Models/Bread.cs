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
      return 0;
    }
  }
}