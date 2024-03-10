using System;
using System.Collections.Generic;

namespace Assignement_Repo.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal ProductPrice { get; set; }

    public bool? Status { get; set; }

    public int? CategoryId { get; set; }

    public int? SizeId { get; set; }

    public virtual Categorie? Category { get; set; }

    public virtual ICollection<Orderdetail> Orderdetails { get; set; } = new List<Orderdetail>();

    public virtual Size? Size { get; set; }
}
