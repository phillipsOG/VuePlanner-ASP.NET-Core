using System;
using System.Collections.Generic;

namespace VuePlanner.Models;

public partial class Spartan
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Title { get; set; }

    public string? University { get; set; }

    public string? CourseTaken { get; set; }

    public string? MarkAchieved { get; set; }
}
