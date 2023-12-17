using System;
using System.Collections.Generic;

namespace Library.Domain.Models;

public partial class TblPenalty
{
    public int PenaltyId { get; set; }

    public int? StudentId { get; set; }

    public string? BookName { get; set; }

    public double? Price { get; set; }

    public double? Penalty { get; set; }

    public string? Detail { get; set; }

    public DateTime? CreatedDate { get; set; }
}
