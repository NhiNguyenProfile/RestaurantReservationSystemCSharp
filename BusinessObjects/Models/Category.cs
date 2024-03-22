using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public bool Status { get; set; }

    public virtual ICollection<Food> Foods { get; set; } = new List<Food>();
}
