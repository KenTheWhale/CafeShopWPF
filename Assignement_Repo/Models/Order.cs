using System;
using System.Collections.Generic;

namespace Assignement_Repo.Models;

public partial class Order
{
    public int OrdersId { get; set; }

    public DateTime OrdersDate { get; set; }

    public decimal? OrderPrice { get; set; }

    public int? CustomerId { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<Orderdetail> Orderdetails { get; set; } = new List<Orderdetail>();
}
