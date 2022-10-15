using System;
using System.Collections.Generic;

<<<<<<< HEAD
namespace VuePlanner.Models;
=======
namespace NorthwindData;
>>>>>>> dev

public partial class Shipper
{
    public int ShipperId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? Phone { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
