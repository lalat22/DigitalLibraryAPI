using System;
using System.Collections.Generic;

namespace Library.Domain.Models;

public partial class TblBook
{
    public int BookId { get; set; }

    public string BookName { get; set; } = null!;

    public string Author { get; set; } = null!;

    public string? Detail { get; set; }

    public decimal Price { get; set; }

    public string? Publication { get; set; }

    public string? Branch { get; set; }

    public int? Quantities { get; set; }

    public int? AvlQuantity { get; set; }

    public int? RentQuantity { get; set; }

    public string? Images { get; set; }

    public string? Pdf { get; set; }

    public DateTime? CreatedBy { get; set; }
}
