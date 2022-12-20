using System;

namespace ProductApi.Models {

  public class Product {
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public uint Price { get; set; }
  }
}

