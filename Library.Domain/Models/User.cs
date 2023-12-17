using System;
using System.Collections.Generic;

namespace Library.Domain.Models;

public partial class User
{
    public int UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public short RoleId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public byte StatusTypeId { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public string? Email { get; set; }

    public virtual Role Role { get; set; } = null!;

    public virtual StatusType StatusType { get; set; } = null!;

    public virtual UserCred? UserCred { get; set; }
}
