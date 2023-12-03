using System;
using System.Collections.Generic;

namespace _3zh.Models;

public partial class Brand
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Country { get; set; }

    public virtual ICollection<Model> Models { get; set; } = new List<Model>();

    public virtual ICollection<UpForSale> UpForSales { get; set; } = new List<UpForSale>();
}
