using System;
using System.Collections.Generic;

namespace Library.Domain.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string StudentName { get; set; } = null!;

    public string? BranchName { get; set; }

    public string Mobile { get; set; } = null!;

    public string? Address { get; set; }

    public string? PinCode { get; set; }

    public DateTime? Dob { get; set; }

    public string? Gender { get; set; }

    public string Email { get; set; } = null!;

    public string Images { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }
}
