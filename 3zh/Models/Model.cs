using System;
using System.Collections.Generic;

namespace _3zh.Models;

public partial class Model
{
    public int Id { get; set; }

    public int? BrandId { get; set; }

    public string? Name { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual ICollection<UpForSale> UpForSales { get; set; } = new List<UpForSale>();
}
