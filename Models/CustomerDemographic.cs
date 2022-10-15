using System;
using System.Collections.Generic;
using NorthwindData.Models;

<<<<<<< HEAD
namespace VuePlanner.Models;
=======
namespace NorthwindData;
>>>>>>> dev

public partial class CustomerDemographic
{
    public string CustomerTypeId { get; set; } = null!;

    public string? CustomerDesc { get; set; }

    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();
}
