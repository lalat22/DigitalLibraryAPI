using System;
using System.Collections.Generic;

namespace Library.Domain.Models;

public partial class StatusType
{
    public byte StatusTypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<User> Users { get; } = new List<User>();
}
