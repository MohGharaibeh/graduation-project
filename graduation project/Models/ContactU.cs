﻿using System;
using System.Collections.Generic;

namespace graduation_project.Models;

public partial class ContactU
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public string? Message { get; set; }

    public string? Email { get; set; }
}
