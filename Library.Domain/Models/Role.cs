using System;
using System.Collections.Generic;

namespace Library.Domain.Models;

public partial class Role
{
    public short RoleId { get; set; }

    public string Name { get; set; } = null!;

    public int UpdatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }

    public virtual ICollection<User> Users { get; } = new List<User>();
}
