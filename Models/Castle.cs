


using System;
using System.Collections.Generic;

namespace KnightCastle.Models
{
  public class Castle
  {
    public string Name { get; set; }
    public bool Destroyed { get; set; }
    public int Id { get; set; }

    internal List<Castle> ToList()
    {
      throw new NotImplementedException();
    }
  }
}