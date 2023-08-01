using System;
using System.Collections.Generic;

namespace graduation_project.Models;

public partial class Invoive
{
    public int Id { get; set; }

    public int? UserAccountId { get; set; }

    public int? RequestRecipeId { get; set; }

    public virtual RequestRecipe? RequestRecipe { get; set; }

    public virtual Useraccount? UserAccount { get; set; }
}
