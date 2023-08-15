using System;
using System.Collections.Generic;

namespace coreEFCDBFirst.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public double? CustomerAmount { get; set; }
}
