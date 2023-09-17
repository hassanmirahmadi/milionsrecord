using System;
using System.Collections.Generic;

namespace milyon.models;

public partial class Mobile
{
    public int Id { get; set; }
    
    public string Name { get; set; }=string.Empty;

    public string BrandName { get; set; } = string.Empty;

    public string? CreatedAt { get; set; } 
}
