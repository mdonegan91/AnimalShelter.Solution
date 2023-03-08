using System.Collections.Generic;
using System;

namespace AnimalShelter.Models
{
  public class Types
  {
    public int TypeId { get; set; }
    public string Description { get; set; }
    public int AnimalId { get; set; }
    public string Name { get; set;}
    public string Breed { get; set; }
    public string Date { get; set; }

  }
}