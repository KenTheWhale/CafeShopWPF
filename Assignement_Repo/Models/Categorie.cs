using System;
using System.Collections.Generic;

namespace Assignement_Repo.Models;

public partial class Categorie
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
