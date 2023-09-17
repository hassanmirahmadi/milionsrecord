using System;
using System.Collections.Generic;

namespace milyon.models;

public partial class Mobile
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string BrandName { get; set; } = null!;

    public string CreatedAt { get; set; } = null!;
}
