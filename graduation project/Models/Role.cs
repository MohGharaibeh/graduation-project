using System;
using System.Collections.Generic;

namespace graduation_project.Models;

public partial class Role
{
    public int Id { get; set; }

    public string? Rolename { get; set; }

    public virtual ICollection<Useraccount> Useraccounts { get; set; } = new List<Useraccount>();
}
