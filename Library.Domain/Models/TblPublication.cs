using System;
using System.Collections.Generic;

namespace Library.Domain.Models;

public partial class TblPublication
{
    public int PublicationId { get; set; }

    public string? PublicationName { get; set; }

    public DateTime? CreatedDate { get; set; }
}
