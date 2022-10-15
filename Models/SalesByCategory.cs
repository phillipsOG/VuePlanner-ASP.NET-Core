using System;
using System.Collections.Generic;

<<<<<<< HEAD
namespace VuePlanner.Models;
=======
namespace NorthwindData;
>>>>>>> dev

public partial class SalesByCategory
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public decimal? ProductSales { get; set; }
}
