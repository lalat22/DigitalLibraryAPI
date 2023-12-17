using System;
using System.Collections.Generic;

namespace Library.Domain.Models;

public partial class TblBranch
{
    public int BranchId { get; set; }

    public string? BranchName { get; set; }

    public DateTime? CreatedDate { get; set; }
}
