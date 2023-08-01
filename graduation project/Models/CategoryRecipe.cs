using System;
using System.Collections.Generic;

namespace graduation_project.Models;

public partial class CategoryRecipe
{
    public int Id { get; set; }

    public string? ImagePath { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
}
