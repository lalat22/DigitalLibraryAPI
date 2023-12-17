using System;
using System.Collections.Generic;

namespace Library.Domain.Models;

public partial class UserCred
{
    public int UserId { get; set; }

    public string UserPwd { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
