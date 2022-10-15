using System;
using System.Collections.Generic;

<<<<<<< HEAD
namespace VuePlanner.Models;
=======
namespace NorthwindData;
>>>>>>> dev

public partial class SummaryOfSalesByYear
{
    public DateTime? ShippedDate { get; set; }

    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
