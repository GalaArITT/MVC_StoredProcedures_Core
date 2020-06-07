using System;
using System.Collections.Generic;

namespace MVC_StoredProcedures_CORE.Models
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
