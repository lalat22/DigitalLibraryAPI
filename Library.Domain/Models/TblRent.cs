using System;
using System.Collections.Generic;

namespace Library.Domain.Models;

public partial class TblRent
{
    public int RentId { get; set; }

    public int? StudentId { get; set; }

    public string? BookName { get; set; }

    public int? Days { get; set; }

    public DateTime? IssueDate { get; set; }

    public DateTime? ReturnDate { get; set; }

    public string? Stats { get; set; }
}
