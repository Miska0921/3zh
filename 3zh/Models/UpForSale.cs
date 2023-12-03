using System;
using System.Collections.Generic;

namespace _3zh.Models;

public partial class UpForSale
{
    public int Id { get; set; }

    public int? BrandId { get; set; }

    public int? ModelId { get; set; }

    public int? Price { get; set; }

    public int? Horsepower { get; set; }

    public string? Fuel { get; set; }

    public string? Seller { get; set; }

    public int? Mileage { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual Model? Model { get; set; }
}
