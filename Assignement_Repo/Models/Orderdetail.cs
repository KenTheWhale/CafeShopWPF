using System;
using System.Collections.Generic;

namespace Assignement_Repo.Models;

public partial class Orderdetail
{
    public int OrderdetailId { get; set; }

    public int Quantity { get; set; }

    public decimal? ProductPrice { get; set; }

    public int? ProductId { get; set; }

    public int? OrdersId { get; set; }

    public virtual Order? Orders { get; set; }

    public virtual Product? Product { get; set; }
}
