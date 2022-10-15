using System;
using System.Collections.Generic;

<<<<<<< HEAD
namespace VuePlanner.Models;
=======
namespace NorthwindData;
>>>>>>> dev

public partial class Region
{
    public int RegionId { get; set; }

    public string RegionDescription { get; set; } = null!;

    public virtual ICollection<Territory> Territories { get; } = new List<Territory>();
}
