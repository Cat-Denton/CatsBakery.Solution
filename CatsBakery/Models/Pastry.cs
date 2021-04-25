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
  }
}